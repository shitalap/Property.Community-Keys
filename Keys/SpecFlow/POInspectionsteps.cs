using System;
using TechTalk.SpecFlow;
using Keys.Global;
using Keys.Pages;
using NUnit.Framework.Internal;
using RelevantCodes.ExtentReports;

namespace Keys.SpecFlow
{
    [Binding]
    public class POInspectionsteps
    {
        [Given(@"I have Navigated to Add Inspection Request Page")]
        public void GivenIHaveNavigatedToAddInspectionRequestPage()
        {
            // ScenarioContext.Current.Pending();
          //  Base.test = Base.extent.StartTest(Name : "Property Inspection");

            Owner_Inspection OInsObj  = new   Owner_Inspection();
            OInsObj.POInsPage();
            OInsObj.POAddInsp();

        }
        
        [Given(@"I have entered valid mandatory fields and clicked on Save")]
        public void GivenIHaveEnteredValidMandatoryFieldsAndClickecOnSave()
        {
            // ScenarioContext.Current.Pending();
            Console.WriteLine("Entering PO inspection info specflow");
            Owner_Inspection OInsObj = new Owner_Inspection();
            OInsObj.POInsSave();

           // Owner_Inspection OInsObj = new Owner_Inspection();
           // OInsObj.POInsSave();
           
        }
        
        [Then(@"the property is displayed for Inspection")]
        public void ThenThePropertyIsDisplayedForInspection()
        {
            //ScenarioContext.Current.Pending();
            Owner_Inspection OInsObj = new Owner_Inspection();
            OInsObj.POVerifyInsp();
        }
    }
}
