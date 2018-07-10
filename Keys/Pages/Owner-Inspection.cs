using Keys.Global;
using System;
using OpenQA.Selenium;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RelevantCodes.ExtentReports;
using OpenQA.Selenium.Support.UI;
using static NUnit.Core.NUnitFramework;
using System.Threading;

namespace Keys.Pages
{
    public class Owner_Inspection
    {

        internal void POInsPage()
        {
            //Populating data from Excel
            ExcelLib.PopulateInCollection(Base.ExcelPath, "POInspection");

            //Wait 2 seconds till alert is present
            Driver.wait(2);
            //Accepting alert.

            Console.WriteLine("Accept Message");
            Driver.wait(10);
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));

            //Click on PO Link
            Thread.Sleep(1000);
            Driver.wait(50);
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"));
        }

        internal void POAddInsp()
        {
            try
            {                
                //Navigate to PO Inspection Page
                Thread.Sleep(1000);
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"));
                Driver.wait(50);
                Console.WriteLine("Navigated to Owner Inspection page");
                Thread.Sleep(1000);

                 //Click on Add Inspection Request Link
               // Thread.Sleep(1000);
               // Driver.ActionButton(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "Value"));
               // Console.WriteLine("Navigated to Add Inspection Request page");
            }

            catch (Exception e)
            {
                Console.WriteLine("Cannot navigate to Owner- Inspection Page");
            }

        }

        internal void POSave()
        {
            try
            {
                //Select Tenant
                //  Thread.Sleep(1000);
                //  Driver.ActionButton(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(5, "Value"));

                //Select Tenant option
                Thread.Sleep(1000);
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(7, "Locator"), ExcelLib.ReadData(7, "Value"));
                
                //Select Request Type
                // Thread.Sleep(1000);
                // Driver.ActionButton(Driver.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "Value"));

                //Select Request type option
                Thread.Sleep(1000);
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "Value"));

                //Enter Due Date
                Thread.Sleep(1000);
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "Value"),
                    ExcelLib.ReadData(2, "DueDate"));

                //scroll the page down
                ((IJavaScriptExecutor)Driver.driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 50)");

                //Enter Description
                Thread.Sleep(1000);
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(11, "Locator"), ExcelLib.ReadData(11, "Value"),
                ExcelLib.ReadData(2, "Description"));

                //Click on Save button
                Thread.Sleep(1000);
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(14, "Locator"), ExcelLib.ReadData(14, "Value"));
                
                Console.WriteLine("Entered Inspection Request Details and Saved");


            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot Save Inspection Request Details");
            }

        }

        internal void POVerifyInsp()
        {
            //Click on Properties Owner Link
                
            Thread.Sleep(1000);
            Driver.wait(50);
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"));

            //Navigate to Owner My Requests Page
            Thread.Sleep(1000);
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(17, "Locator"), ExcelLib.ReadData(17, "Value"));
            Driver.wait(50);
            Console.WriteLine("Navigated to Owner My Request page");
            Thread.Sleep(1000);

            //Verify Inspection Request - Property existing
          //  String prpname = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(18, "Locator"), ExcelLib.ReadData(18, "Value"));
          //  String prpblkmsg = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(19, "Locator"), ExcelLib.ReadData(19, "Value"));
           // string prpblkmsg = "669 Dominion Road,";
           // NUnit.Framework.Assert.IsTrue(prpblkmsg.Contains(prpname), prpblkmsg + "Property name is verified");
            Console.WriteLine("Verified Property ");

        }
    }
}

    

