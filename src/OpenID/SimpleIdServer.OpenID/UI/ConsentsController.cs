﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;
using SimpleIdServer.OAuth.Api.Authorization;
using SimpleIdServer.OAuth.DTOs;
using SimpleIdServer.OAuth.Extensions;
using SimpleIdServer.OAuth.Options;
using SimpleIdServer.OAuth.Persistence;
using SimpleIdServer.OAuth.Persistence.Users;
using SimpleIdServer.OpenID.Extensions;
using SimpleIdServer.OpenID.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace SimpleIdServer.OpenID.UI
{
    [Authorize("IsConnected")]
    public class ConsentsController : Controller
    {
        private readonly IOAuthUserQueryRepository _oauthUserRepository;
        private readonly IOAuthUserCommandRepository _oAuthUserCommandRepository;
        private readonly IOAuthClientQueryRepository _oauthClientRepository;
        private readonly IUserConsentFetcher _userConsentFetcher;
        private readonly IDataProtector _dataProtector;
        private readonly OAuthHostOptions _oauthHostOptions;

        public ConsentsController(IOAuthUserQueryRepository oauthUserRepository, IOAuthUserCommandRepository oauthUserCommandRepository, IOAuthClientQueryRepository oauthClientRepository, IUserConsentFetcher userConsentFetcher, IDataProtectionProvider dataProtectionProvider, IOptions<OAuthHostOptions> opts)
        {
            _oauthUserRepository = oauthUserRepository;
            _oAuthUserCommandRepository = oauthUserCommandRepository;
            _oauthClientRepository = oauthClientRepository;
            _userConsentFetcher = userConsentFetcher;
            _dataProtector = dataProtectionProvider.CreateProtector("Authorization");
            _oauthHostOptions = opts.Value;
        }

        public async Task<IActionResult> Index(string returnUrl)
        {
            if (string.IsNullOrWhiteSpace(returnUrl))
            {
                return RedirectToAction("Index", "Errors", new { code = "invalid_request", ReturnUrl = $"{Request.Path}{Request.QueryString}" });
            }

            try
            {
                var unprotectedUrl = _dataProtector.Unprotect(returnUrl);
                var query = unprotectedUrl.GetQueries().ToJObj();
                var uiLocales = query.GetUILocalesFromAuthorizationRequest();
                var cancellationUrl = query.GetRedirectUriFromAuthorizationRequest();
                if (!string.IsNullOrWhiteSpace(cancellationUrl))
                {
                    var state = query.GetStateFromAuthorizationRequest();
                    if (!string.IsNullOrWhiteSpace(state))
                    {
                        cancellationUrl = QueryHelpers.AddQueryString(cancellationUrl, AuthorizationRequestParameters.State, state);
                    }
                }

                var scopes = query.GetScopesFromAuthorizationRequest();
                var claims = query.GetClaimsFromAuthorizationRequest();
                var clientId = query.GetClientIdFromAuthorizationRequest();
                var oauthClient = await _oauthClientRepository.FindOAuthClientById(clientId);
                var defaultLanguage = TranslationHelper.SwitchCulture(uiLocales, _oauthHostOptions.DefaultCulture);
                var consent = _userConsentFetcher.BuildFromAuthorizationRequest(query);
                var claimDescriptions = new List<string>();
                if (claims != null && claims.Any())
                {
                    claimDescriptions = claims.Select(c => c.Name).ToList();
                }

                return View(new ConsentsIndexViewModel(
                    oauthClient.ClientNames.GetTranslation(defaultLanguage, oauthClient.ClientId),
                    returnUrl,
                    oauthClient.AllowedScopes.Where(c => scopes.Contains(c.Name)).Select(s => s.Name),
                    claimDescriptions,
                    cancellationUrl));
            }
            catch(CryptographicException)
            {
                return RedirectToAction("Index", "Errors", new { code = "invalid_request", ReturnUrl = $"{Request.Path}{Request.QueryString}" });
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(ConfirmConsentsViewModel confirmConsentsViewModel)
        { 
            try
            {
                var unprotectedUrl = _dataProtector.Unprotect(confirmConsentsViewModel.ReturnUrl);
                var query = unprotectedUrl.GetQueries().ToJObj();
                var claimName = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);
                var user = await _oauthUserRepository.FindOAuthUserByLogin(claimName.Value);
                var consent = _userConsentFetcher.FetchFromAuthorizationRequest(user, query);
                if (consent == null)
                {
                    consent = _userConsentFetcher.BuildFromAuthorizationRequest(query);
                    user.Consents.Add(consent);
                    _oAuthUserCommandRepository.Update(user);
                    await _oAuthUserCommandRepository.SaveChanges();
                }

                return Redirect(unprotectedUrl);
            }
            catch(CryptographicException)
            {
                ModelState.AddModelError("invalid_request", "invalid_request");
                return View(confirmConsentsViewModel);
            }
        }
    }
}