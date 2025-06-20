﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by Reqnroll (https://www.reqnroll.net/).
//      Reqnroll Version:2.0.0.0
//      Reqnroll Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
using Reqnroll;
namespace ReqnrollProject.Features
{
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "2.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Login")]
    [NUnit.Framework.FixtureLifeCycleAttribute(NUnit.Framework.LifeCycle.InstancePerTestCase)]
    public partial class LoginFeature
    {
        
        private global::Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private static global::Reqnroll.FeatureInfo featureInfo = new global::Reqnroll.FeatureInfo(new global::System.Globalization.CultureInfo("en-US"), "Features", "Login", "A short summary of the feature\r\ntest the login functionality", global::Reqnroll.ProgrammingLanguage.CSharp, featureTags);
        
#line 1 "login.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public static async global::System.Threading.Tasks.Task FeatureSetupAsync()
        {
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public static async global::System.Threading.Tasks.Task FeatureTearDownAsync()
        {
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public async global::System.Threading.Tasks.Task TestInitializeAsync()
        {
            testRunner = global::Reqnroll.TestRunnerManager.GetTestRunnerForAssembly(featureHint: featureInfo);
            try
            {
                if (((testRunner.FeatureContext != null) 
                            && (testRunner.FeatureContext.FeatureInfo.Equals(featureInfo) == false)))
                {
                    await testRunner.OnFeatureEndAsync();
                }
            }
            finally
            {
                if (((testRunner.FeatureContext != null) 
                            && testRunner.FeatureContext.BeforeFeatureHookFailed))
                {
                    throw new global::Reqnroll.ReqnrollException("Scenario skipped because of previous before feature hook error");
                }
                if ((testRunner.FeatureContext == null))
                {
                    await testRunner.OnFeatureStartAsync(featureInfo);
                }
            }
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public async global::System.Threading.Tasks.Task TestTearDownAsync()
        {
            if ((testRunner == null))
            {
                return;
            }
            try
            {
                await testRunner.OnScenarioEndAsync();
            }
            finally
            {
                global::Reqnroll.TestRunnerManager.ReleaseTestRunner(testRunner);
                testRunner = null;
            }
        }
        
        public void ScenarioInitialize(global::Reqnroll.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public async global::System.Threading.Tasks.Task ScenarioStartAsync()
        {
            await testRunner.OnScenarioStartAsync();
        }
        
        public async global::System.Threading.Tasks.Task ScenarioCleanupAsync()
        {
            await testRunner.CollectScenarioErrorsAsync();
        }
        
        public virtual async global::System.Threading.Tasks.Task FeatureBackgroundAsync()
        {
#line 4
#line hidden
#line 5
    await testRunner.GivenAsync("User is on the orangehrm login page", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify login with valid credentials")]
        [NUnit.Framework.CategoryAttribute("Sanity")]
        public async global::System.Threading.Tasks.Task VerifyLoginWithValidCredentials()
        {
            string[] tagsOfScenario = new string[] {
                    "Sanity"};
            global::System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new global::System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Verify login with valid credentials", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 8
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 4
await this.FeatureBackgroundAsync();
#line hidden
#line 9
 await testRunner.WhenAsync("User enters the username \"Admin\" and password \"admin123\" in the text fields", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 10
 await testRunner.WhenAsync("User clicks on the submit button", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 11
 await testRunner.ThenAsync("User is navigated to home page", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify login with test parameters")]
        [NUnit.Framework.CategoryAttribute("Regression")]
        [NUnit.Framework.TestCaseAttribute("Admin", "admin123", null)]
        [NUnit.Framework.TestCaseAttribute("Ad", "adn", null)]
        [NUnit.Framework.TestCaseAttribute("Adn", "adhjd", null)]
        public async global::System.Threading.Tasks.Task VerifyLoginWithTestParameters(string username, string password, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Regression"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            global::System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new global::System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("username", username);
            argumentsOfScenario.Add("password", password);
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Verify login with test parameters", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 15
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 4
await this.FeatureBackgroundAsync();
#line hidden
#line 16
 await testRunner.WhenAsync(string.Format("user enters the \"{0}\" and \"{1}\"", username, password), ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 17
 await testRunner.WhenAsync("User clicks on the submit button", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 18
 await testRunner.ThenAsync("User is navigated to home page", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify login with data table parameters")]
        [NUnit.Framework.CategoryAttribute("Regr")]
        [NUnit.Framework.TestCaseAttribute("Admin", "admin123", null)]
        [NUnit.Framework.TestCaseAttribute("Ad", "adn", null)]
        [NUnit.Framework.TestCaseAttribute("Adn", "adhjd", null)]
        public async global::System.Threading.Tasks.Task VerifyLoginWithDataTableParameters(string username, string password, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Regr"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            global::System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new global::System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("username", username);
            argumentsOfScenario.Add("password", password);
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Verify login with data table parameters", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 27
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 4
await this.FeatureBackgroundAsync();
#line hidden
#line 28
 await testRunner.WhenAsync(string.Format("user enters the \"{0}\" and \"{1}\"", username, password), ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 29
 await testRunner.WhenAsync("User clicks on the submit button", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 30
 await testRunner.ThenAsync("User is navigated to home page", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
                global::Reqnroll.Table table1 = new global::Reqnroll.Table(new string[] {
                            "city",
                            "country"});
                table1.AddRow(new string[] {
                            "Delhi",
                            "India"});
                table1.AddRow(new string[] {
                            "Boston",
                            "USA"});
#line 31
 await testRunner.ThenAsync("User selected city and country information", ((string)(null)), table1, "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify login with valid credentails")]
        [NUnit.Framework.CategoryAttribute("Regression,")]
        [NUnit.Framework.CategoryAttribute("Functional")]
        public async global::System.Threading.Tasks.Task VerifyLoginWithValidCredentails()
        {
            string[] tagsOfScenario = new string[] {
                    "Regression,",
                    "Functional"};
            global::System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new global::System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Verify login with valid credentails", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 42
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 4
await this.FeatureBackgroundAsync();
#line hidden
#line 43
 await testRunner.WhenAsync("User enters the username \"Admin\" and password \"admin123\" in the text fields", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 44
 await testRunner.WhenAsync("User clicks on submit button", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 45
 await testRunner.ThenAsync("User is navigated to home page", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion
