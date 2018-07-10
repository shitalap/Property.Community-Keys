using Keys.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//using static NUnit.Core.NUnitFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Interactions;
using AutoItX3Lib;

namespace Keys
{
    public class Tenant_Sendnewrequest
    {
        public static int RowCountBase = Int32.Parse(KeysResource.RowNum);
        internal void SendNewRequest()
        {
            ExcelLib.PopulateInCollection(Base.ExcelPath, "TenantSendRequest");
            try
            {
                // click on Dashboard
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));
                //click on Send New Request
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"));
                Thread.Sleep(1000);
                string sendrequest = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "Value"));
                Thread.Sleep(1000);
                if (sendrequest == "Rental Request Form")
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Tenant is able to navigate to add new request");
                    //   select property
                    IList<IWebElement> proptypelists = Driver.driver.FindElements(By.XPath("//*[@id='RequestPage']/div[2]/form/fieldset/div[1]/div/div/select/option"));

                    int ListsCount = proptypelists.Count();

                    for (int i = 0; i < ListsCount; i++)
                    {
                        if (proptypelists[i].Text == ExcelLib.ReadData(2, "PropertyAddress"))
                        {
                            proptypelists[i].Click();
                        }
                    }

                    Thread.Sleep(5000);
                    //  Select type of request
                    IList<IWebElement> proptypelists1 = Driver.driver.FindElements(By.XPath("//*[@id='jobRequestType']/option"));

                    int ListsCount1 = proptypelists1.Count();

                    for (int i = 0; i < ListsCount1; i++)
                    {
                        if (proptypelists1[i].Text == ExcelLib.ReadData(2, "SelectType"))
                        {
                            proptypelists1[i].Click();
                        }
                    }

                    Thread.Sleep(5000);
                    // message
                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "Value"), ExcelLib.ReadData(2, "Message"));
                    Thread.Sleep(1000);

                    //scrolling down the page
                    Thread.Sleep(5000);
                    IJavaScriptExecutor js = Driver.driver as IJavaScriptExecutor;
                    Thread.Sleep(1000);
                    js.ExecuteScript("window.scrollBy(0,950);");
                    // upload new document
                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(7, "Locator"), ExcelLib.ReadData(7, "Value"));
                    Thread.Sleep(5000);


                    AutoItX3 autoIt = new AutoItX3();
                    autoIt.WinActivate("Open");
                    autoIt.Send(@"C:\Users\Pradnya\Pictures\Saved Pictures\3.jpg");

                    // autoIt.Send(ExcelLib.ReadData(2, "Photopath"));
                    Thread.Sleep(3000);
                    autoIt.Send("{ENTER}");
                    Thread.Sleep(3000);

                    //click on Save
                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "Value"));
                    Thread.Sleep(3000);
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Tenant successfully  sent new request");
                    //checking if request has been sent   
                    // click on tenant
                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "Value"));
                    Thread.Sleep(1000);
                    //click on My request
                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(11, "Locator"), ExcelLib.ReadData(11, "Value"));
                    Thread.Sleep(1000);
                    //enter message in search textbox
                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(12, "Locator"), ExcelLib.ReadData(12, "Value"), ExcelLib.ReadData(2, "Message"));
                    Thread.Sleep(1000);
                    //click on search button
                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(13, "Locator"), ExcelLib.ReadData(13, "Value"));
                    Thread.Sleep(1000);

                    string sendrequest1 = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(14, "Locator"), ExcelLib.ReadData(14, "Value"));

                    Thread.Sleep(1000);
                    if (sendrequest1 == ExcelLib.ReadData(2, "Message"))
                    {

                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Tenant can see sent request in My request page");
                    }
                    else
                    {
                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Tenant not able to see sent request in My request page");

                    }
                }

                else
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Tenant is not  able to navigate to add new request");
                }
                
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Tenant is not able to Send new request");
                Base.test.Log(LogStatus.Info, e.Message + "No messages found");
            }
        }
    }
}