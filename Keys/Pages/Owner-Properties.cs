using Keys.Global;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keys.Pages
{
    class Owner_Properties
    {
        internal void ListaRentalPage()
        {
            // Test to Navigate to List A Rental Page from Owner-Properties-List As Rental

            //Populating data from Excel
            ExcelLib.PopulateInCollection(Base.ExcelPath, "ListARental");

            try
            {
                Driver.wait(2);
                //Click on Owner
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));

                //Click on Property
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"));
                Driver.wait(2);

                //Click on ListAsRental link on the property which you want to list as Rental
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(24, "Locator"), ExcelLib.ReadData(24, "Value"));
                Driver.wait(2);

                String strListRental = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "Value"));
                Console.WriteLine(strListRental);

                // Assert.AreEqual("List A Rental", strListRental);
                if (strListRental == "List A Rental")
                {
                    Base.test.Log(LogStatus.Pass, Details: " User is able to navigate to Owner-Properties-List As Rental - List A Rental Page");
                    Console.WriteLine("navigation Pass- List A Rental page loaded from List As a Rental - PO");
                }


            }

            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "User cannot navigate to Owner-Properties-List As Rental- List A Rental Page", e);
            }


        }
    }
}
