using FirstHomeworkNavigationTests.RegistrationFormAutomationPractise.Tests;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstHomeworkNavigationTests
{
    [TestFixture]
   public class GoogleSeleniumSearch:BaseTest
    {
       
        private WebDriverWait _wait;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Url = "http://www.google.com";
            _wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

        [Test]
        public void SeleniumGoogleSearch()
        {
            IWebElement searchField =Driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div[1]/div[1]/div/div[2]/input"));
            searchField.SendKeys("selenium");
            searchField.Submit();

            IWebElement firstResultLink = Driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div[9]/div[1]/div[2]/div/div[2]/div[2]/div/div/div[1]/div/div[1]/a/h3"));
            firstResultLink.Click();

            string pageTitle = Driver.Title;
            Assert.AreEqual("SeleniumHQ Browser Automation", pageTitle);
        }
    }
}
