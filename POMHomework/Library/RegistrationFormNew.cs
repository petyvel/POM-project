using FirstHomeworkNavigationTests.RegistrationFormAutomationPractise.Tests;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace FirstHomeworkNavigationTests
{
    [TestFixture]
    public class RegistrationFormNew : BaseTest
    {
            private WebDriverWait _wait;

         
            [SetUp]
            public void SetUp()
            {
               
                Initialize();
                Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
                _wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            }


            [TearDown]
            public void TearDown()
            {
                Driver.Quit();
            }

            [Test]
        public void SignInMailValidation()
        {
            IWebElement signInButton = Driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[2]/div/div/nav/div[1]/a"));
            signInButton.Click();
            IWebElement createAccount = _wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#email_create")));
            createAccount.SendKeys("pro06us@yahoo.com");
            IWebElement submitButton = Driver.FindElement(By.XPath("//*[@id='SubmitCreate']"));
            submitButton.Click();
            IWebElement emailField = _wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#email"))); //Driver.FindElement(By.CssSelector("#email"));
           
            Assert.IsTrue(_wait.Until(d => d.FindElement(By.Id("email")).GetAttribute("value").Equals("pro06us@yahoo.com")));

            
        }

    }
}

