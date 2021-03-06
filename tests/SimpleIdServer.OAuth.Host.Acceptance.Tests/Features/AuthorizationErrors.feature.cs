// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SimpleIdServer.OAuth.Host.Acceptance.Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class AuthorizationErrorsFeature : Xunit.IClassFixture<AuthorizationErrorsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "AuthorizationErrors.feature"
#line hidden
        
        public AuthorizationErrorsFeature(AuthorizationErrorsFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AuthorizationErrors", "\tCheck the errors returned by the authorization endpoint", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when response_type parameter is missing")]
        [Xunit.TraitAttribute("FeatureTitle", "AuthorizationErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when response_type parameter is missing")]
        public virtual void ErrorIsReturnedWhenResponse_TypeParameterIsMissing()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when response_type parameter is missing", null, ((string[])(null)));
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
#line 5
 testRunner.When("execute HTTP GET request \'http://localhost/authorization\'", ((string)(null)), table1, "When ");
#line 8
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 11
 testRunner.Then("JSON \'error_description\'=\'missing parameter response_type\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when response_type parameter is invalid")]
        [Xunit.TraitAttribute("FeatureTitle", "AuthorizationErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when response_type parameter is invalid")]
        public virtual void ErrorIsReturnedWhenResponse_TypeParameterIsInvalid()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when response_type parameter is invalid", null, ((string[])(null)));
#line 13
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table2.AddRow(new string[] {
                        "response_type",
                        "invalid"});
#line 14
 testRunner.When("execute HTTP GET request \'http://localhost/authorization\'", ((string)(null)), table2, "When ");
#line 18
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.Then("JSON \'error\'=\'unsupported_response_type\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
 testRunner.Then("JSON \'error_description\'=\'missing response types invalid\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when client_id parameter is missing")]
        [Xunit.TraitAttribute("FeatureTitle", "AuthorizationErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when client_id parameter is missing")]
        public virtual void ErrorIsReturnedWhenClient_IdParameterIsMissing()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when client_id parameter is missing", null, ((string[])(null)));
#line 23
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table3.AddRow(new string[] {
                        "response_type",
                        "code"});
#line 24
 testRunner.When("execute HTTP GET request \'http://localhost/authorization\'", ((string)(null)), table3, "When ");
#line 28
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 31
 testRunner.Then("JSON \'error_description\'=\'missing parameter client_id\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when state parameter is missing")]
        [Xunit.TraitAttribute("FeatureTitle", "AuthorizationErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when state parameter is missing")]
        public virtual void ErrorIsReturnedWhenStateParameterIsMissing()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when state parameter is missing", null, ((string[])(null)));
#line 33
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table4.AddRow(new string[] {
                        "response_type",
                        "code"});
            table4.AddRow(new string[] {
                        "client_id",
                        "clientId"});
#line 34
 testRunner.When("execute HTTP GET request \'http://localhost/authorization\'", ((string)(null)), table4, "When ");
#line 39
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 42
 testRunner.Then("JSON \'error_description\'=\'missing parameter state\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when client doesn\'t exist")]
        [Xunit.TraitAttribute("FeatureTitle", "AuthorizationErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when client doesn\'t exist")]
        public virtual void ErrorIsReturnedWhenClientDoesntExist()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when client doesn\'t exist", null, ((string[])(null)));
#line 44
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table5.AddRow(new string[] {
                        "response_type",
                        "code"});
            table5.AddRow(new string[] {
                        "client_id",
                        "clientId"});
            table5.AddRow(new string[] {
                        "state",
                        "state"});
#line 45
 testRunner.When("execute HTTP GET request \'http://localhost/authorization\'", ((string)(null)), table5, "When ");
#line 51
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.Then("JSON \'error\'=\'invalid_client\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 54
 testRunner.Then("JSON \'error_description\'=\'unknown client clientId\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when redirect_uri is invalid")]
        [Xunit.TraitAttribute("FeatureTitle", "AuthorizationErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when redirect_uri is invalid")]
        public virtual void ErrorIsReturnedWhenRedirect_UriIsInvalid()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when redirect_uri is invalid", null, ((string[])(null)));
#line 56
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table6.AddRow(new string[] {
                        "response_type",
                        "code"});
            table6.AddRow(new string[] {
                        "client_id",
                        "f3d35cce-de69-45bf-958c-4a8796f8ed37"});
            table6.AddRow(new string[] {
                        "state",
                        "state"});
            table6.AddRow(new string[] {
                        "redirect_uri",
                        "invalid"});
#line 57
 testRunner.When("execute HTTP GET request \'http://localhost/authorization\'", ((string)(null)), table6, "When ");
#line 64
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 67
 testRunner.Then("JSON \'error_description\'=\'redirect uri invalid is not correct\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when response_mode is not supported")]
        [Xunit.TraitAttribute("FeatureTitle", "AuthorizationErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when response_mode is not supported")]
        public virtual void ErrorIsReturnedWhenResponse_ModeIsNotSupported()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when response_mode is not supported", null, ((string[])(null)));
#line 69
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table7.AddRow(new string[] {
                        "response_type",
                        "code"});
            table7.AddRow(new string[] {
                        "client_id",
                        "f3d35cce-de69-45bf-958c-4a8796f8ed37"});
            table7.AddRow(new string[] {
                        "state",
                        "state"});
            table7.AddRow(new string[] {
                        "redirect_uri",
                        "http://localhost:8080"});
            table7.AddRow(new string[] {
                        "response_mode",
                        "invalid"});
#line 70
 testRunner.When("execute HTTP GET request \'http://localhost/authorization\'", ((string)(null)), table7, "When ");
#line 78
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.Then("JSON \'error\'=\'unsupported_response_mode\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 81
 testRunner.Then("JSON \'error_description\'=\'response mode invalid is not supported\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when scope is not supported by the client")]
        [Xunit.TraitAttribute("FeatureTitle", "AuthorizationErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when scope is not supported by the client")]
        public virtual void ErrorIsReturnedWhenScopeIsNotSupportedByTheClient()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when scope is not supported by the client", null, ((string[])(null)));
#line 83
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table8.AddRow(new string[] {
                        "response_type",
                        "code"});
            table8.AddRow(new string[] {
                        "client_id",
                        "f3d35cce-de69-45bf-958c-4a8796f8ed37"});
            table8.AddRow(new string[] {
                        "state",
                        "state"});
            table8.AddRow(new string[] {
                        "redirect_uri",
                        "http://localhost:8080"});
            table8.AddRow(new string[] {
                        "scope",
                        "role"});
#line 84
 testRunner.When("execute HTTP GET request \'http://localhost/authorization\'", ((string)(null)), table8, "When ");
#line 92
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 95
 testRunner.Then("JSON \'error_description\'=\'scopes role are not supported\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when the code_challenge parameter is missing")]
        [Xunit.TraitAttribute("FeatureTitle", "AuthorizationErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when the code_challenge parameter is missing")]
        public virtual void ErrorIsReturnedWhenTheCode_ChallengeParameterIsMissing()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when the code_challenge parameter is missing", null, ((string[])(null)));
#line 97
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table9.AddRow(new string[] {
                        "redirect_uris",
                        "[http://localhost]"});
            table9.AddRow(new string[] {
                        "token_endpoint_auth_method",
                        "pkce"});
            table9.AddRow(new string[] {
                        "response_types",
                        "[code]"});
            table9.AddRow(new string[] {
                        "grant_types",
                        "[authorization_code]"});
            table9.AddRow(new string[] {
                        "scope",
                        "scope1"});
#line 98
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table9, "When ");
#line 106
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
 testRunner.And("extract parameter \'client_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
 testRunner.And("add user consent : user=\'administrator\', scope=\'scope1\', clientId=\'$client_id$\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table10.AddRow(new string[] {
                        "response_type",
                        "code"});
            table10.AddRow(new string[] {
                        "client_id",
                        "$client_id$"});
            table10.AddRow(new string[] {
                        "state",
                        "state"});
            table10.AddRow(new string[] {
                        "scope",
                        "scope1"});
#line 110
 testRunner.And("execute HTTP GET request \'http://localhost/authorization\'", ((string)(null)), table10, "And ");
#line 117
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 120
 testRunner.Then("JSON \'error_description\'=\'missing parameter code_challenge\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when the code_challenge_method parameter is invalid")]
        [Xunit.TraitAttribute("FeatureTitle", "AuthorizationErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when the code_challenge_method parameter is invalid")]
        public virtual void ErrorIsReturnedWhenTheCode_Challenge_MethodParameterIsInvalid()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when the code_challenge_method parameter is invalid", null, ((string[])(null)));
#line 122
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table11.AddRow(new string[] {
                        "redirect_uris",
                        "[http://localhost]"});
            table11.AddRow(new string[] {
                        "token_endpoint_auth_method",
                        "pkce"});
            table11.AddRow(new string[] {
                        "response_types",
                        "[code]"});
            table11.AddRow(new string[] {
                        "grant_types",
                        "[authorization_code]"});
            table11.AddRow(new string[] {
                        "scope",
                        "scope1"});
#line 123
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table11, "When ");
#line 131
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 132
 testRunner.And("extract parameter \'client_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 133
 testRunner.And("add user consent : user=\'administrator\', scope=\'scope1\', clientId=\'$client_id$\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table12.AddRow(new string[] {
                        "response_type",
                        "code"});
            table12.AddRow(new string[] {
                        "client_id",
                        "$client_id$"});
            table12.AddRow(new string[] {
                        "state",
                        "state"});
            table12.AddRow(new string[] {
                        "scope",
                        "scope1"});
            table12.AddRow(new string[] {
                        "code_challenge",
                        "code_challenge"});
            table12.AddRow(new string[] {
                        "code_challenge_method",
                        "invalid"});
#line 135
 testRunner.And("execute HTTP GET request \'http://localhost/authorization\'", ((string)(null)), table12, "And ");
#line 144
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 146
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 147
 testRunner.Then("JSON \'error_description\'=\'transform algorithm invalid is not supported\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                AuthorizationErrorsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                AuthorizationErrorsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
