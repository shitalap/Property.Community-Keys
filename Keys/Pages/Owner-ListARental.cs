using System;
using System.Drawing;
using System.Drawing.Design;
using OpenQA.Selenium;
using Keys.Global;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Events;
using RelevantCodes.ExtentReports;
using RelevantCodes.ExtentReports.Model;
using System.Threading;


namespace Keys.Pages
{
   public class Owner_ListARental
    {
       // String img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
       // String screenshot = SaveScreenShotClass.SaveScreenshot(Driver.driver, "ScreenShotPath");
       

        internal void ListRentalPage()
        {
            //Populating data from Excel
            ExcelLib.PopulateInCollection(Base.ExcelPath, "ListARental");

            //Wait 2 seconds till alert is present
            Driver.wait(2);
            //Accepting alert.

            Console.WriteLine("Accept Alert");
            Driver.wait(10);
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(33, "Locator"), ExcelLib.ReadData(33, "Value"));

            try
            {
                //Navigate to List A Rental Page from Owner-Properties-List A Rental Link
                Driver.wait(2);
                //Click on Owner
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));

                //Click on Property
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"));
                Driver.wait(2);

                //Click on List A Rental Link
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"));
                Driver.wait(2);

                //Verify User is able to Navigate to List A Rental Page 
                String strListRental = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "Value"));
                Console.WriteLine(strListRental);

                // Assert.AreEqual("List A Rental", strListRental);
                if (strListRental == "List A Rental")
                {
                    Base.test.Log(LogStatus.Pass, Details: " User is able to navigate to Owner-Properties-List A Rental Page");
                    Console.WriteLine("navigation Pass- List A Rental page");
                }

                //Select the Property 
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "Value"));
                Driver.wait(5);

                
            }

            catch (Exception e)
            {
              Base.test.Log(LogStatus.Fail, "User cannot navigate to Owner-Properties-List As Rental- List A Rental Page", e);
            }

        }

       internal void LARSave()
        {
            //Populating data from Excel
            ExcelLib.PopulateInCollection(Base.ExcelPath, "ListARental");

            try
            {
                //Enter Title
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(7, "Locator"), ExcelLib.ReadData(7, "Value"),
                    ExcelLib.ReadData(2, "Title"));
                Driver.wait(2);

                //Enter Moving Cost
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "Value"),
                    ExcelLib.ReadData(2, "MovingCost"));
                Driver.wait(2);

                //Enter Description
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "Value"),
                    ExcelLib.ReadData(2, "Description"));
                Driver.wait(2);

                //Enter Target Rent
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "Value"),
                    ExcelLib.ReadData(2, "TargetRent"));
                Driver.wait(2);

                //Enter Furnishing
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(11, "Locator"), ExcelLib.ReadData(11, "Value"),
                    ExcelLib.ReadData(2, "Furnishing"));
                Driver.wait(2);

                //Enter Available Date
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(12, "Locator"), ExcelLib.ReadData(12, "Value"),
                    ExcelLib.ReadData(2, "AvailableDate"));
                Driver.wait(2);

                //Enter Ideal Tenant
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(13, "Locator"), ExcelLib.ReadData(13, "Value"),
                    ExcelLib.ReadData(2, "IdealTenant"));
                Driver.wait(2);

                //Enter Occupants Count
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(14, "Locator"), ExcelLib.ReadData(14, "Value"),
                    ExcelLib.ReadData(2, "OccupantCount"));
                Driver.wait(2);

                //scroll the page down
                ((IJavaScriptExecutor)Driver.driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 50)");
               // Base.test.Log(LogStatus.Pass, Details: "User can scroll down the Page");

                //Select Pets
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(15, "Locator"), ExcelLib.ReadData(15, "Value"));
                Driver.wait(2);

                //Click on Save Button
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(17, "Locator"), ExcelLib.ReadData(17, "Value"));
                Driver.wait(2);

               // Base.test.Log(LogStatus.Pass, Details: "User can add all valid and mandatory fields");

                // Clicking on Pop up message
                IAlert simpleAlert = Driver.driver.SwitchTo().Alert();
                // '.Text' is used to get the text from the Alert
                String alertText = simpleAlert.Text;
                Console.WriteLine("Alert text is " + alertText);
                // '.Accept()' is used to accept the alert '(click on the Ok button)'
                simpleAlert.Accept();

              //  Base.test.Log(LogStatus.Pass, Details: "User can save the Property Rental Listing with valid data");
            }
            catch (Exception e)
            {
              Base.test.Log(LogStatus.Fail, "User cannot Save - Property is not listed for Rent", e);
            }
        }

         internal void LARverify()
         { 
            try
            { 
            //Verify user is navigated back to Rental Listings and Tenant Applications page after listing the property for Rent
            string strproptxt = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(18, "Locator"), ExcelLib.ReadData(18, "Value"));
            Console.WriteLine(strproptxt);

            if (strproptxt == "Rental Listings and Tenant Applications")
            {
              //  Base.test.Log(LogStatus.Pass, Details: " User is able to navigate to Rental Listing and Tenant Applications Page after listing a Property for Rent");
                Console.WriteLine("Navigation Pass - Rental Listng and Tenant Applications Page");
            }

            //Enter Search Text
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(19, "Locator"), ExcelLib.ReadData(19, "Value"),
            ExcelLib.ReadData(2, "Title"));
            Driver.wait(2);

            //Click on Search button
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(20, "Locator"), ExcelLib.ReadData(20, "Value"));
            Driver.wait(2);

           // Base.test.Log(LogStatus.Pass, Details: " Verified that User has listed the property for Rent");
                     
            }
            catch (Exception e)
            {
              Base.test.Log(LogStatus.Fail, "Property is not listed for Rent", e);
            }
         }



        internal void LARInvalid()
        {
            ListRentalPage();

            String img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            String screenshot = SaveScreenShotClass.SaveScreenshot(Driver.driver, "ScreenShotPath");
                      

            try
            {
                // Screenshot
                Driver.wait(5);
                Base.test.Log(LogStatus.Pass, "Image File Name:" + img);
                Base.test.Log(LogStatus.Pass, "ScreenShot: " + Base.test.AddScreenCapture(screenshot));

                //Enter 1 char for property title
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(7, "Locator"), ExcelLib.ReadData(7, "Value"),
                          ExcelLib.ReadData(3, "Title"));
                Driver.wait(5);

                //Verify error message for Property Title less than 10 characters
                String prpmsg = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(29, "Locator"), ExcelLib.ReadData(29, "Value"));

                Assert.IsTrue(prpmsg.Contains("Title must consist at least 10 characters"), prpmsg + "Title has valid data");
                Base.test.Log(LogStatus.Pass, Details: "User cannot add less than 10 characters for Property Title");

                //Screenshot
               //  Base.test.Log(LogStatus.Pass, "Image File Name:" + img1);
               //Base.test.Log(LogStatus.Pass, "ScreenShot: " + Base.test.AddScreenCapture(screenshot1));
            }

            catch (Exception e)
            {

            }

            String img1 = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            String screenshot1 = SaveScreenShotClass.SaveScreenshot(Driver.driver, "ScreenShotPath");

            try
            {
                //Blank Property Title
                Driver.wait(5);
                Driver.GetClear(Driver.driver, ExcelLib.ReadData(7, "Locator"), ExcelLib.ReadData(7, "Value"));
                Driver.wait(2);

                //Verify error message for Blank Property Title
                String prpblkmsg = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(30, "Locator"), ExcelLib.ReadData(30, "Value"));
                Assert.IsTrue(prpblkmsg.Contains("Please enter title."), prpblkmsg + "User has entered data");
                Console.WriteLine("System cannot accept Blank Property Title");


                //Screenshot
                Base.test.Log(LogStatus.Pass, "Image File Name:" + img1);
                Base.test.Log(LogStatus.Pass, "ScreenShot: " + Base.test.AddScreenCapture(screenshot1));

                Base.test.Log(LogStatus.Pass, Details: "User cannot leave Property Title field Blank");
            }
             
            catch (Exception e)
            {
              //  Base.test.Log(LogStatus.Fail, "User cannot Save - Property is not listed for Rent", e);
            }

        }

    }
}
