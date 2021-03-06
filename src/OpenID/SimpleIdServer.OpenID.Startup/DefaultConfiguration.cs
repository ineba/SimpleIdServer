﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using SimpleIdServer.OAuth.Domains;
using SimpleIdServer.OAuth.Helpers;
using SimpleIdServer.OpenID.Domains;
using System;
using System.Collections.Generic;

namespace SimpleIdServer.OpenID.Startup
{
    public class DefaultConfiguration
    {
        public static List<OpenIdScope> Scopes = new List<OpenIdScope>
        {
            new OpenIdScope
            {
                Name = "scim",
                Claims = new List<string>
                {
                    "scim_id"
                }
            },
            new OpenIdScope
            {
                Name = "role",
                Claims = new List<string>
                {
                    "role"
                }
            }
        };

        public static List<AuthenticationContextClassReference> AcrLst => new List<AuthenticationContextClassReference>
        {
            new AuthenticationContextClassReference
            {
                DisplayName = "First level of assurance",
                Name = "sid-load-01",
                AuthenticationMethodReferences = new List<string>
                {
                    "pwd"
                }
            },
            new AuthenticationContextClassReference
            {
                DisplayName = "Second level of assurance",
                Name = "sid-load-02",
                AuthenticationMethodReferences = new List<string>
                {
                    "pwd",
                    "sms"
                }
            }
        };

        public static List<OAuthUser> Users => new List<OAuthUser>
        {
            new OAuthUser
            {
                Id = "administrator",
                Credentials = new List<OAuthUserCredential>
                {
                    new OAuthUserCredential
                    {
                        CredentialType = "pwd",
                        Value = PasswordHelper.ComputeHash("password")
                    }
                },
                Claims = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>(SimpleIdServer.Jwt.Constants.UserClaims.Subject, "administrator"),
                    new KeyValuePair<string, string>(SimpleIdServer.Jwt.Constants.UserClaims.GivenName, "administrator"),
                    new KeyValuePair<string, string>(SimpleIdServer.Jwt.Constants.UserClaims.Role, "admin")
                }
            },
            new OAuthUser
            {
                Id = "businessanalyst",
                Credentials = new List<OAuthUserCredential>
                {
                    new OAuthUserCredential
                    {
                        CredentialType = "pwd",
                        Value = PasswordHelper.ComputeHash("password")
                    }
                },
                Claims = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>(SimpleIdServer.Jwt.Constants.UserClaims.Subject, "businessanalyst"),
                    new KeyValuePair<string, string>(SimpleIdServer.Jwt.Constants.UserClaims.GivenName, "businessanalyst"),
                    new KeyValuePair<string, string>(SimpleIdServer.Jwt.Constants.UserClaims.Role, "businessanalyst")
                }
            },
            new OAuthUser
            {
                Id = "caseworker",
                Credentials = new List<OAuthUserCredential>
                {
                    new OAuthUserCredential
                    {
                        CredentialType = "pwd",
                        Value = PasswordHelper.ComputeHash("password")
                    }
                },
                Claims = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>(SimpleIdServer.Jwt.Constants.UserClaims.Subject, "caseworker"),
                    new KeyValuePair<string, string>(SimpleIdServer.Jwt.Constants.UserClaims.GivenName, "caseworker"),
                    new KeyValuePair<string, string>(SimpleIdServer.Jwt.Constants.UserClaims.Role, "caseworker")
                }
            },
            new OAuthUser
            {
                Id = "scimUser",
                Credentials = new List<OAuthUserCredential>
                {
                    new OAuthUserCredential
                    {
                        CredentialType = "pwd",
                        Value = PasswordHelper.ComputeHash("password")
                    }
                },
                Claims = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>(SimpleIdServer.Jwt.Constants.UserClaims.Subject, "scimUser"),
                    new KeyValuePair<string, string>("scim_id", "1")
                }
            },
            new OAuthUser
            {
                Id = "umaUser",
                Credentials = new List<OAuthUserCredential>
                {
                    new OAuthUserCredential
                    {
                        CredentialType = "pwd",
                        Value = PasswordHelper.ComputeHash("password")
                    }
                },
                Claims = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>(Jwt.Constants.UserClaims.Subject, "umaUser"),
                    new KeyValuePair<string, string>(Jwt.Constants.UserClaims.Name, "User"),
                    new KeyValuePair<string, string>(Jwt.Constants.UserClaims.UniqueName, "User")
                }
            },
            new OAuthUser
            {
                Id = "doctor",
                Credentials = new List<OAuthUserCredential>
                {
                    new OAuthUserCredential
                    {
                        CredentialType = "pwd",
                        Value = PasswordHelper.ComputeHash("password")
                    }
                },
                Claims = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>(Jwt.Constants.UserClaims.Subject, "doctor"),
                    new KeyValuePair<string, string>(Jwt.Constants.UserClaims.Name, "Doctor"),
                    new KeyValuePair<string, string>(Jwt.Constants.UserClaims.GivenName, "Doctor"),
                    new KeyValuePair<string, string>(Jwt.Constants.UserClaims.UniqueName, "Doctor")
                }
            }
        };

        public static List<OpenIdClient> Clients => new List<OpenIdClient>
        {
            new OpenIdClient
            {
                ClientId = "scimClient",
                Secrets = new List<ClientSecret>
                {
                    new ClientSecret(ClientSecretTypes.SharedSecret, PasswordHelper.ComputeHash("scimClientSecret"))
                },
                TokenEndPointAuthMethod = "client_secret_post",
                ApplicationType = "web",
                UpdateDateTime = DateTime.UtcNow,
                CreateDateTime = DateTime.UtcNow,
                TokenExpirationTimeInSeconds = 60 * 30,
                RefreshTokenExpirationTimeInSeconds = 60 * 30,
                TokenSignedResponseAlg = "RS256",
                IdTokenSignedResponseAlg = "RS256",
                AllowedScopes = new List<OpenIdScope>
                {
                    new OpenIdScope
                    {
                        Name = "scim",
                        Claims = new List<string>
                        {
                            "scim_id"
                        }
                    }
                },
                GrantTypes = new List<string>
                {
                    "implicit",
                },
                RedirectionUrls = new List<string>
                {
                    "http://localhost:8080",
                    "http://localhost:1700"
                },
                PreferredTokenProfile = "Bearer",
                ResponseTypes = new List<string>
                {
                    "token",
                    "id_token"
                }
            },
            new OpenIdClient
            {
                ClientId = "umaClient",
                Secrets = new List<ClientSecret>
                {
                    new ClientSecret(ClientSecretTypes.SharedSecret, PasswordHelper.ComputeHash("umaClientSecret"))
                },
                TokenEndPointAuthMethod = "client_secret_post",
                ApplicationType = "web",
                UpdateDateTime = DateTime.UtcNow,
                CreateDateTime = DateTime.UtcNow,
                TokenExpirationTimeInSeconds = 60 * 30,
                RefreshTokenExpirationTimeInSeconds = 60 * 30,
                TokenSignedResponseAlg = "RS256",
                IdTokenSignedResponseAlg = "RS256",
                AllowedScopes = new List<OpenIdScope>
                {
                    SIDOpenIdConstants.StandardScopes.Profile,
                    SIDOpenIdConstants.StandardScopes.Email
                },
                GrantTypes = new List<string>
                {
                    "implicit",
                    "authorization_code"
                },
                RedirectionUrls = new List<string>
                {
                    "https://localhost:60001/signin-oidc"
                },
                PreferredTokenProfile = "Bearer",
                ResponseTypes = new List<string>
                {
                    "token",
                    "id_token",
                    "code"
                }
            },
            new OpenIdClient
            {
                ClientId = "simpleIdServerWebsite",
                Secrets = new List<ClientSecret>
                {
                    new ClientSecret(ClientSecretTypes.SharedSecret, PasswordHelper.ComputeHash("simpleIdServerWebsiteSecret"))
                },
                TokenEndPointAuthMethod = "client_secret_post",
                ApplicationType = "web",
                UpdateDateTime = DateTime.UtcNow,
                CreateDateTime = DateTime.UtcNow,
                TokenExpirationTimeInSeconds = 60 * 30,
                RefreshTokenExpirationTimeInSeconds = 60 * 30,
                TokenSignedResponseAlg = "RS256",
                IdTokenSignedResponseAlg = "RS256",
                AllowedScopes = new List<OpenIdScope>
                {
                    SIDOpenIdConstants.StandardScopes.OpenIdScope,
                    SIDOpenIdConstants.StandardScopes.Profile,
                    SIDOpenIdConstants.StandardScopes.Email,
                    SIDOpenIdConstants.StandardScopes.Role
                },
                GrantTypes = new List<string>
                {
                    "implicit"
                },
                RedirectionUrls = new List<string>
                {
                    "http://localhost:4200",
					"http://simpleidserver.northeurope.cloudapp.azure.com/simpleidserver"
                },
                PreferredTokenProfile = "Bearer",
                ResponseTypes = new List<string>
                {
                    "token",
                    "id_token"
                }
            },
            new OpenIdClient
            {
                ClientId = "tradWebsite",
                Secrets = new List<ClientSecret>
                {
                    new ClientSecret(ClientSecretTypes.SharedSecret, PasswordHelper.ComputeHash("tradWebsiteSecret"))
                },
                TokenEndPointAuthMethod = "client_secret_post",
                ApplicationType = "web",
                UpdateDateTime = DateTime.UtcNow,
                CreateDateTime = DateTime.UtcNow,
                TokenExpirationTimeInSeconds = 60 * 30,
                RefreshTokenExpirationTimeInSeconds = 60 * 30,
                TokenSignedResponseAlg = "RS256",
                IdTokenSignedResponseAlg = "RS256",
                AllowedScopes = new List<OpenIdScope>
                {
                    SIDOpenIdConstants.StandardScopes.OpenIdScope,
                    SIDOpenIdConstants.StandardScopes.Profile
                },
                GrantTypes = new List<string>
                {
                    "authorization_code",
                    "password"
                },
                RedirectionUrls = new List<string>
                {
                    "https://localhost:5001/signin-oidc"
                },
                PreferredTokenProfile = "Bearer",
                ResponseTypes = new List<string>
                {
                    "code",
                    "token",
                    "id_token"
                }
            },
            new OpenIdClient
            {
                ClientId = "native",
                Secrets = new List<ClientSecret>
                {
                    new ClientSecret(ClientSecretTypes.SharedSecret, PasswordHelper.ComputeHash("nativeSecret"))
                },
                TokenEndPointAuthMethod = "pkce",
                ApplicationType = "web",
                UpdateDateTime = DateTime.UtcNow,
                CreateDateTime = DateTime.UtcNow,
                TokenExpirationTimeInSeconds = 60 * 30,
                RefreshTokenExpirationTimeInSeconds = 60 * 30,
                TokenSignedResponseAlg = "RS256",
                IdTokenSignedResponseAlg = "RS256",
                AllowedScopes = new List<OpenIdScope>
                {
                    SIDOpenIdConstants.StandardScopes.Profile,
                    SIDOpenIdConstants.StandardScopes.Email
                },
                GrantTypes = new List<string>
                {
                    "authorization_code"
                },
                RedirectionUrls = new List<string>
                {
                    "sid:/oauth2redirect"
                },
                PreferredTokenProfile = "Bearer",
                ResponseTypes = new List<string>
                {
                    "code"
                }
            },
            new OpenIdClient
            {
                ClientId = "caseManagementWebsite",
                Secrets = new List<ClientSecret>
                {
                    new ClientSecret(ClientSecretTypes.SharedSecret, PasswordHelper.ComputeHash("b98113b5-f45f-4a4a-9db5-610b7183e148"))
                },
                TokenEndPointAuthMethod = "client_secret_post",
                ApplicationType = "web",
                UpdateDateTime = DateTime.UtcNow,
                CreateDateTime = DateTime.UtcNow,
                TokenExpirationTimeInSeconds = 60 * 30,
                RefreshTokenExpirationTimeInSeconds = 60 * 30,
                TokenSignedResponseAlg = "RS256",
                IdTokenSignedResponseAlg = "RS256",
                AllowedScopes = new List<OpenIdScope>
                {
                    SIDOpenIdConstants.StandardScopes.Profile,
                    SIDOpenIdConstants.StandardScopes.Email,
                    SIDOpenIdConstants.StandardScopes.Role
                },
                GrantTypes = new List<string>
                {
                    "implicit"
                },
                RedirectionUrls = new List<string>
                {
                    "http://localhost:51724",
                    "http://localhost:8080",
                    "http://simpleidserver.northeurope.cloudapp.azure.com/casemanagement"
                },
                PreferredTokenProfile = "Bearer",
                ResponseTypes = new List<string>
                {
                    "token",
                    "id_token"
                }
            },
            new OpenIdClient
            {
                ClientId = "caseManagementTasklistWebsite",
                Secrets = new List<ClientSecret>
                {
                    new ClientSecret(ClientSecretTypes.SharedSecret, PasswordHelper.ComputeHash("b98113b5-f45f-4a4a-9db5-610b7183e148"))
                },
                TokenEndPointAuthMethod = "client_secret_post",
                ApplicationType = "web",
                UpdateDateTime = DateTime.UtcNow,
                CreateDateTime = DateTime.UtcNow,
                TokenExpirationTimeInSeconds = 60 * 30,
                RefreshTokenExpirationTimeInSeconds = 60 * 30,
                TokenSignedResponseAlg = "RS256",
                IdTokenSignedResponseAlg = "RS256",
                AllowedScopes = new List<OpenIdScope>
                {
                    SIDOpenIdConstants.StandardScopes.Profile,
                    SIDOpenIdConstants.StandardScopes.Email,
                    SIDOpenIdConstants.StandardScopes.Role
                },
                GrantTypes = new List<string>
                {
                    "implicit"
                },
                RedirectionUrls = new List<string>
                {
                    "http://localhost:51724",
                    "http://localhost:8081",
                    "http://simpleidserver.northeurope.cloudapp.azure.com/tasklist"
                },
                PreferredTokenProfile = "Bearer",
                ResponseTypes = new List<string>
                {
                    "token",
                    "id_token"
                }
            },
            new OpenIdClient
            {
                ClientId = "caseManagementPerformanceWebsite",
                Secrets = new List<ClientSecret>
                {
                    new ClientSecret(ClientSecretTypes.SharedSecret, PasswordHelper.ComputeHash("91894b86-c57e-489a-838d-fb82621a67ee"))
                },
                TokenEndPointAuthMethod = "client_secret_post",
                ApplicationType = "web",
                UpdateDateTime = DateTime.UtcNow,
                CreateDateTime = DateTime.UtcNow,
                TokenExpirationTimeInSeconds = 60 * 30,
                RefreshTokenExpirationTimeInSeconds = 60 * 30,
                TokenSignedResponseAlg = "RS256",
                IdTokenSignedResponseAlg = "RS256",
                AllowedScopes = new List<OpenIdScope>
                {
                    SIDOpenIdConstants.StandardScopes.Profile,
                    SIDOpenIdConstants.StandardScopes.Email,
                    SIDOpenIdConstants.StandardScopes.Role
                },
                GrantTypes = new List<string>
                {
                    "implicit"
                },
                RedirectionUrls = new List<string>
                {
                    "http://localhost:51725",
                    "http://localhost:8081",
                    "http://simpleidserver.northeurope.cloudapp.azure.com/casemanagementperformance"
                },
                PreferredTokenProfile = "Bearer",
                ResponseTypes = new List<string>
                {
                    "token",
                    "id_token"
                }
            },
            new OpenIdClient
            {
                ClientId = "medikitWebsite",
                Secrets = new List<ClientSecret>
                {
                    new ClientSecret(ClientSecretTypes.SharedSecret, PasswordHelper.ComputeHash("f200eeb0-a6a3-465e-be91-97806e5dd3bc"))
                },
                TokenEndPointAuthMethod = "client_secret_post",
                ApplicationType = "web",
                UpdateDateTime = DateTime.UtcNow,
                CreateDateTime = DateTime.UtcNow,
                TokenExpirationTimeInSeconds = 60 * 30,
                RefreshTokenExpirationTimeInSeconds = 60 * 30,
                TokenSignedResponseAlg = "RS256",
                IdTokenSignedResponseAlg = "RS256",
                AllowedScopes = new List<OpenIdScope>
                {
                    SIDOpenIdConstants.StandardScopes.Profile,
                    SIDOpenIdConstants.StandardScopes.Email,
                    SIDOpenIdConstants.StandardScopes.Role
                },
                GrantTypes = new List<string>
                {
                    "implicit"
                },
                RedirectionUrls = new List<string>
                {
                    "http://localhost:8080",
                    "http://simpleidserver.northeurope.cloudapp.azure.com/medikit"
                },
                PreferredTokenProfile = "Bearer",
                ResponseTypes = new List<string>
                {
                    "token",
                    "id_token"
                }
            }
        };
    }
}