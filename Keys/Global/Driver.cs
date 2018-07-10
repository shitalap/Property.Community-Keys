﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using RelevantCodes.ExtentReports.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keys.Global
{
    public static class Driver
    {

        public static IWebDriver driver { get; set; }
       // public ExtentTest test { get; set; }

        #region WaitforElement 

        public static void wait(int time)
        {
            // driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(time));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }
        public static IWebElement WaitForElement(IWebDriver driver, By by, int timeOutinSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutinSeconds));
            return (wait.Until(ExpectedConditions.ElementIsVisible(by)));
        }
        #endregion

        //#region FindElement Extentsion
        //public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
        //{
        //    if (timeoutInSeconds > 0)
        //    {
        //        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
        //        return wait.Until(drv => drv.FindElement(by));
        //    }
        //    return driver.FindElement(by);
        //}
        //#endregion

        #region Element Present


        //Method to check the element is showing on screen
        public static bool ElementVisible(IWebDriver driver, string Locator, string Lvalue)
        {
            try
            {
                if (Locator == "Id")
                    return driver.FindElement(By.Id(Lvalue)).Displayed && driver.FindElement(By.Id(Lvalue)).Enabled;
                else if (Locator == "XPath")
                    return driver.FindElement(By.XPath(Lvalue)).Displayed && driver.FindElement(By.XPath(Lvalue)).Enabled;
                else if (Locator == "CSS")
                    return driver.FindElement(By.CssSelector(Lvalue)).Displayed && driver.FindElement(By.CssSelector(Lvalue)).Enabled;
                else
                {
                    Console.WriteLine("Invalid Locator value");
                    return false;
                }
            }
            catch (NoSuchElementException)
            {
                return false;

            }
        }

        internal static void Textbox(IWebDriver driver, string v1, string v2)
        {
            throw new NotImplementedException();
        }

        public static bool isElementPresent(By by)
        {
            try
            {
                Driver.driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        #endregion

        #region 
        //check for if alert present
        public static bool isDialogPresent(IWebDriver driver)
        {
            IAlert alert = ExpectedConditions.AlertIsPresent().Invoke(driver);
            return (alert != null);
        }
        #endregion

        #region DynamicIWebELement
        public static void ActionButton(IWebDriver driver, string Locator, string Lvalue, string InputValue)
        {
            if (Locator == "Id")
            {
                //driver.FindElement(By.Id(Lvalue)).Clear();
                driver.FindElement(By.Id(Lvalue)).SendKeys(InputValue);
            }
            else if (Locator == "XPath")
            {
               // driver.FindElement(By.XPath(Lvalue)).Clear();
                driver.FindElement(By.XPath(Lvalue)).SendKeys(InputValue);
            }
            else if (Locator == "CSS")
            {
               // driver.FindElement(By.XPath(Lvalue)).Clear();
                driver.FindElement(By.CssSelector(Lvalue)).SendKeys(InputValue);
            }
            else
                Console.WriteLine("Invalid Locator value");

        }
        public static string GetTextValue(IWebDriver driver, string Locator, string Lvalue)
        {
            if (Locator == "Id")
            {
               return  driver.FindElement(By.Id(Lvalue)).Text;
            }
            else if (Locator == "XPath")
            {
                return driver.FindElement(By.XPath(Lvalue)).Text;
            }
            else if (Locator == "CSS")
            {
                return driver.FindElement(By.CssSelector(Lvalue)).Text;
            }
            else
                Console.WriteLine("Invalid Locator value");
            return "";

        }
        public static void GetClear(IWebDriver driver, string Locator, string Lvalue)
        {
            if (Locator == "Id")
            {
                 driver.FindElement(By.Id(Lvalue)).Clear();
            }
            else if (Locator == "XPath")
            {
                 driver.FindElement(By.XPath(Lvalue)).Clear();
            }
            else if (Locator == "CSS")
            {
                 driver.FindElement(By.CssSelector(Lvalue)).Clear();
            }
            else
                Console.WriteLine("Invalid Locator value");
            

        }

        public static void ActionButton(IWebDriver driver, string Locator, string Lvalue)
        {
            if (Locator == "Id")
                driver.FindElement(By.Id(Lvalue)).Click();
            else if (Locator == "XPath")
                driver.FindElement(By.XPath(Lvalue)).Click();
            else if (Locator == "CSS")
                driver.FindElement(By.CssSelector(Lvalue)).Click();
            else
                Console.WriteLine("Invalid Locator value");
        }

        internal static void Textbox(IWebDriver driver, string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }

        internal static string GetTextValue(IWebDriver driver, string v)
        {
            throw new NotImplementedException();
        }

        internal static string GetTextValue(IWebDriver driver, string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }
        #endregion

    }


}
