using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RelevantCodes.ExtentReports;
using Keys.Global;

namespace Keys.Pages
{
   public class OwnerDashboard 
    {
        internal void NListingPage()
        {
            //Test to Navigate to List A Rental Page from PO Dashboard- Add New Listing 

            //Populating data from Excel
            ExcelLib.PopulateInCollection(Base.ExcelPath, "ListARental");

            try
            {
                //Click on Dashboard
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(26, "Locator"), ExcelLib.ReadData(26, "Value"));
                Driver.wait(5);

                Base.test.Log(LogStatus.Pass, Details: " User has clicked Dashboard - New Listing");
                Console.WriteLine("User has clicked Dashboard- New Listing");

                //Verify User is able to Navigate to List A Rental Page 
                String strListRental = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "Value"));
                Console.WriteLine(strListRental);

                // Assert.AreEqual("List A Rental", strListRental);
                if (strListRental == "List A Rental")
                {
                    Base.test.Log(LogStatus.Pass, Details: " User is able to navigate to Dashboard - New Listing - List A Rental Page");
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
    }
}
