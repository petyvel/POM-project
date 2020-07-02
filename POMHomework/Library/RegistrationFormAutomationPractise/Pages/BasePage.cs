using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace FirstHomeworkNavigationTests.RegistrationFormAutomationPractise.Pages
{
    public class BasePage
    {
        private IWebDriver driver1;

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
           
        }

        public BasePage(IWebDriver driver, IWebDriver driver1) : this(driver)
        {
            this.driver1 = driver1;
        }

        public IWebDriver Driver { get; }

        public WebDriverWait Wait { get; }

        public IWebElement ScrollTo(IWebElement element)
        {
            //((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(false);", element);
            

           return element;
        }

        public void WaitForLoad(int timeoutSec = 30)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            WebDriverWait wait = new WebDriverWait(Driver, new TimeSpan(0, 0, timeoutSec));
            wait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
        }

        
    }
}
