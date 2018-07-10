using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace Keys
{
    [Binding]
    public class TenantMyRentalSteps
    {
         public IWebDriver driver =new ChromeDriver();
       // public IWebDriver driver = new FirefoxDriver();

        [Given(@"user is on Login Page")]
        public void GivenUserIsOnLoginPage()
        {
            //  ScenarioContext.Current.Pending();
            driver.Navigate().GoToUrl("http://new-keys.azurewebsites.net/Account/Login");
           
        }
        
        [When(@"user have entered (.*) and (.*)")]
        public void WhenUserHaveEnteredAnd(string username, string password)
        {
            //ScenarioContext.Current.Pending();
            //Enter Username and Password
            driver.FindElement(By.XPath("//input[@id='UserName']")).SendKeys(username);
            driver.FindElement(By.XPath("//input[@id='Password']")).SendKeys(password);
        }
        
        [When(@"Click on Login and Click on Tenants My Rentals option")]
        public void WhenClickOnLoginAndClickOnTenantsMyRentalsOption()
        {
            // ScenarioContext.Current.Pending();
            //Click on Login button
            driver.FindElement(By.XPath("//button[contains(.,'Login')]")).Click();

            //Click on Popup Message
            driver.FindElement(By.XPath("/html/body/div[5]/div/div[5]/a[1]")).Click();

            Thread.Sleep(50);

            //Click on Tenant Option
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]")).Click();

            //for firefox browser
           // driver.FindElement(By.CssSelector(".ui.dropdown.item")).Click();
            
             //Click on Tenant - My Rental option
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/a[1]")).Click();
        }
        
        [Then(@"the user is navigated to Tenants My Rental Page")]
        public void ThenTheUserIsNavigatedToTenantsMyRentalPage()
        {
           // ScenarioContext.Current.Pending();
        }
    }
}
