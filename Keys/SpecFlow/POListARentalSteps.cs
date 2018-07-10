using System;
using TechTalk.SpecFlow;
using Keys.Pages;
using Keys.Global;
using NUnit.Framework;
using RelevantCodes.ExtentReports;

namespace Keys.SpecFlow 
{
    [Binding]
    public class POListARentalSteps : Base
    {
        [Given(@"I have Navigated to List A Rental")]
        public void GivenIHaveNavigatedToListARental()
        {
            // ScenarioContext.Current.Pending();
            Owner_ListARental LRentalobj = new Owner_ListARental();
            //test = extent.StartTest(Name : "List A Rental");
            LRentalobj.ListRentalPage();

        }
        
        [Given(@"I have entered valid mandatory fields and press Save")]
        public void GivenIHaveEnteredValidMandatoryFieldsAndPressSave()
        {
            Owner_ListARental LRentalobj = new Owner_ListARental();
          //  test = extent.StartTest(Name: "List A Rental");
            LRentalobj.LARSave();
        }
        
        [Then(@"the property is listed")]
        public void ThenThePropertyIsListed()
        {
            Owner_ListARental LRentalobj = new Owner_ListARental();
          //  test = extent.StartTest(Name: "List A Rental");
            LRentalobj.LARverify();
            
        }
    }
}
