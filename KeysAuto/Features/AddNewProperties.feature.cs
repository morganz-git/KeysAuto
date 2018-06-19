﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace KeysAuto.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("AddNewProperties")]
    public partial class AddNewPropertiesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AddNewProperties.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AddNewProperties", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
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
#line 2
#line 3
 testRunner.Given("I have open the application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 4
 testRunner.Then("I should see the Login Page title is \"Log In\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "UserName",
                        "Password"});
            table1.AddRow(new string[] {
                        "hm.z@outlook.com",
                        "morgan1985"});
#line 5
 testRunner.When("I fill userName and password in form tick Remember Me and click Login Button", ((string)(null)), table1, "When ");
#line 8
 testRunner.Then("I will get into the \"Dashboard\" Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 9
 testRunner.When("I select \"Properties\" under Owner", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then("I will go to \"Properties | Property Community\" Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add Property Finance and so on")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void AddPropertyFinanceAndSoOn()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Property Finance and so on", new string[] {
                        "mytag"});
#line 14
this.ScenarioSetup(scenarioInfo);
#line 2
this.FeatureBackground();
#line 15
testRunner.Given("I am at the PropertyOwners page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
 testRunner.When("I click the  Add New Property button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
 testRunner.Then("the Page will navigate to \"Properties | Add New Property\" Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "PropertyName",
                        "SearchAddress",
                        "Number",
                        "Street",
                        "Suburb",
                        "City",
                        "PostCode",
                        "Region",
                        "TargetRent",
                        "LandArea",
                        "FloorArea",
                        "Bedroom",
                        "Bathroom",
                        "ParkingSpace",
                        "YearBuilt",
                        "Description",
                        "Rent Type"});
            table2.AddRow(new string[] {
                        "Morgan House",
                        "20 Canberra Avenue, Lynfield, Auckland, New Zealand",
                        "20",
                        "Canberra Avenue",
                        "Lynfield",
                        "Auckland",
                        "1042",
                        "Auckland",
                        "300",
                        "300",
                        "300",
                        "3",
                        "2",
                        "2",
                        "2015",
                        "Good Condition",
                        "Weekly"});
#line 18
 testRunner.When("i fill the Property Details with the data from form below and also tick Owner Occ" +
                    "upied and click Next button", ((string)(null)), table2, "When ");
#line 21
 testRunner.Then("should mobe to \"Finance Details\" Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
