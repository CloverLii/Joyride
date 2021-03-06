﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.3.0
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34014
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Tests.Android.Native.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.3.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Modal Dialog")]
    [NUnit.Framework.CategoryAttribute("android")]
    public partial class ModalDialogFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ModalDialog.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Modal Dialog", "  In order to interact with modal dialog\r\nAs a user\r\nI want to be able to respond" +
                    " with accept / dismiss", ProgrammingLanguage.CSharp, new string[] {
                        "android"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 8
#line 9
testRunner.Given("I launch the \"Api Demo App\" mobile application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Navigate to Alert Dialogs screen")]
        public virtual void NavigateToAlertDialogsScreen()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigate to Alert Dialogs screen", ((string[])(null)));
#line 11
this.ScenarioSetup(scenarioInfo);
#line 8
this.FeatureBackground();
#line 12
testRunner.Given("I tap the \"App\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 13
testRunner.When("I tap the \"Alert Dialogs\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
testRunner.Then("I should be on the \"Alert Dialogs\" screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should detect a modal dialog")]
        public virtual void ShouldDetectAModalDialog()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should detect a modal dialog", ((string[])(null)));
#line 16
this.ScenarioSetup(scenarioInfo);
#line 8
this.FeatureBackground();
#line 17
testRunner.Given("I tap the \"App\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 18
testRunner.And("I tap the \"Alert Dialogs\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
testRunner.When("I tap the \"Ok Cancel Dialog\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
testRunner.Then("I should see the \"Lorem Ipsum\" modal dialog", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should see title containing text in modal dialog")]
        public virtual void ShouldSeeTitleContainingTextInModalDialog()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should see title containing text in modal dialog", ((string[])(null)));
#line 22
this.ScenarioSetup(scenarioInfo);
#line 8
this.FeatureBackground();
#line 23
testRunner.Given("I tap the \"App\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 24
testRunner.And("I tap the \"Alert Dialogs\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
testRunner.When("I tap the \"Ok Cancel Dialog\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
testRunner.Then("I should see the \"Lorem Ipsum\" modal dialog containing title text \"Plloaso mako n" +
                    "uto siwuf\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should see title ending text in modal dialog")]
        public virtual void ShouldSeeTitleEndingTextInModalDialog()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should see title ending text in modal dialog", ((string[])(null)));
#line 28
this.ScenarioSetup(scenarioInfo);
#line 8
this.FeatureBackground();
#line 29
testRunner.Given("I tap the \"App\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 30
testRunner.And("I tap the \"Alert Dialogs\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
testRunner.When("I tap the \"Ok Cancel Dialog\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
testRunner.Then("I should see the \"Lorem Ipsum\" modal dialog ends with title text \"cakso dodtos an" +
                    "r koop.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should see body containing text in modal dialog")]
        public virtual void ShouldSeeBodyContainingTextInModalDialog()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should see body containing text in modal dialog", ((string[])(null)));
#line 34
this.ScenarioSetup(scenarioInfo);
#line 8
this.FeatureBackground();
#line 35
testRunner.Given("I tap the \"App\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 36
testRunner.And("I tap the \"Alert Dialogs\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
testRunner.When("I tap the \"Ok Cancel Dialog With Long Message\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
testRunner.Then("I should see the \"Long Message\" modal dialog containing body text \"Swipontgwook p" +
                    "roudgs\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should see body starts with text in modal dialog")]
        public virtual void ShouldSeeBodyStartsWithTextInModalDialog()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should see body starts with text in modal dialog", ((string[])(null)));
#line 40
this.ScenarioSetup(scenarioInfo);
#line 8
this.FeatureBackground();
#line 41
testRunner.Given("I tap the \"App\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 42
testRunner.And("I tap the \"Alert Dialogs\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
testRunner.When("I tap the \"Ok Cancel Dialog With Long Message\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
testRunner.Then("I should see the \"Long Message\" modal dialog starts with body text \"Plloaso mako " +
                    "nuto\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should be able to accept or dismiss modal dialog")]
        [NUnit.Framework.TestCaseAttribute("accept", null)]
        [NUnit.Framework.TestCaseAttribute("dismiss", null)]
        public virtual void ShouldBeAbleToAcceptOrDismissModalDialog(string acceptOrDismiss, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should be able to accept or dismiss modal dialog", exampleTags);
#line 46
this.ScenarioSetup(scenarioInfo);
#line 8
this.FeatureBackground();
#line 47
testRunner.Given("I tap the \"App\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 48
testRunner.And("I tap the \"Alert Dialogs\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
testRunner.And("I tap the \"Ok Cancel Dialog\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
testRunner.When(string.Format("I {0} the \"Lorem Ipsum\" modal dialog", acceptOrDismiss), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
testRunner.Then("I should be on the \"Alert Dialogs\" screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should be able to dismiss any modal dialog")]
        public virtual void ShouldBeAbleToDismissAnyModalDialog()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should be able to dismiss any modal dialog", ((string[])(null)));
#line 58
this.ScenarioSetup(scenarioInfo);
#line 8
this.FeatureBackground();
#line 59
testRunner.Given("I tap the \"App\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 60
testRunner.And("I tap the \"Alert Dialogs\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
testRunner.And("I tap the \"Ok Cancel Dialog\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
testRunner.When("I dismiss any modal dialog", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 63
testRunner.Then("I should be on the \"Alert Dialogs\" screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should detect the long message modal dialog")]
        public virtual void ShouldDetectTheLongMessageModalDialog()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should detect the long message modal dialog", ((string[])(null)));
#line 65
this.ScenarioSetup(scenarioInfo);
#line 8
this.FeatureBackground();
#line 66
testRunner.Given("I tap the \"App\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 67
testRunner.And("I tap the \"Alert Dialogs\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
testRunner.When("I tap the \"Ok Cancel Dialog With Long Message\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 69
testRunner.Then("I should see the \"Long Message\" modal dialog", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Respond to with the long message modal dialog")]
        [NUnit.Framework.TestCaseAttribute("Something", null)]
        [NUnit.Framework.TestCaseAttribute("Ok", null)]
        [NUnit.Framework.TestCaseAttribute("Cancel", null)]
        public virtual void RespondToWithTheLongMessageModalDialog(string response, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Respond to with the long message modal dialog", exampleTags);
#line 71
this.ScenarioSetup(scenarioInfo);
#line 8
this.FeatureBackground();
#line 72
testRunner.Given("I tap the \"App\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 73
testRunner.And("I tap the \"Alert Dialogs\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
testRunner.And("I tap the \"Ok Cancel Dialog With Long Message\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
testRunner.When(string.Format("I respond to the \"Long Message\" modal dialog with \"{0}\"", response), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 76
testRunner.Then("I should be on the \"Alert Dialogs\" screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should not see any modal dialog")]
        public virtual void ShouldNotSeeAnyModalDialog()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should not see any modal dialog", ((string[])(null)));
#line 84
this.ScenarioSetup(scenarioInfo);
#line 8
this.FeatureBackground();
#line 85
testRunner.Given("I tap the \"App\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 86
testRunner.When("I tap the \"Alert Dialogs\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 87
testRunner.Then("I should not see any modal dialog", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should see any modal dialog")]
        public virtual void ShouldSeeAnyModalDialog()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should see any modal dialog", ((string[])(null)));
#line 89
this.ScenarioSetup(scenarioInfo);
#line 8
this.FeatureBackground();
#line 90
testRunner.Given("I tap the \"App\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 91
testRunner.And("I tap the \"Alert Dialogs\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
testRunner.When("I tap the \"Ok Cancel Dialog With Long Message\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 93
testRunner.Then("I should see any modal dialog", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
