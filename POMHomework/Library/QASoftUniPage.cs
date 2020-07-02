using FirstHomeworkNavigationTests.RegistrationFormAutomationPractise.Tests;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;


namespace QAAutomation
{
    [TestFixture]
    public class QAAutomation:BaseTest
    {
       
        private WebDriverWait _wait;


        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Url = "https://softuni.bg";
            _wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        }

       
        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

        [Test]
        public void QAAutomationCoursePage()
        {

            IWebElement coursesMenuNavigationBar = Driver.FindElement(By.XPath("/html/body/div[1]/div[1]/header/nav/div[1]/ul/li[2]/a/span"));
            coursesMenuNavigationBar.Click();
            IWebElement activeModulesOpenCourses = Driver.FindElement(By.CssSelector("#header-nav > div.toggle-nav.toggle-holder > ul > li.nav-item.dropdown-item.open > div > div > div.row.no-margin-offset.courses-and-modules-wrapper > div.col-md-8.open-courses-wrapper.open-courses-background > div > div:nth-child(2) > div > div.category-title.sub.uppercase.my-collapsible-header"));
            activeModulesOpenCourses.Click();
            IWebElement qa = Driver.FindElement(By.CssSelector("#header-nav > div.toggle-nav.toggle-holder > ul > li.nav-item.dropdown-item.open > div > div > div.row.no-margin-offset.courses-and-modules-wrapper > div.col-md-8.open-courses-wrapper.open-courses-background > div > div:nth-child(2) > div > div.my-collapsible-body.category-list > div:nth-child(1) > ul > li > h2 > a"));
            qa.Click();
            IWebElement qaAutomation = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[@href='/trainings/2550/qa-automation-may-2020']"))); 
            qaAutomation.Click();

           
            string courceHeaderText = Driver.FindElement(By.CssSelector("body > div.content > header > h1")).Text;
           
            Assert.IsTrue(courceHeaderText.Contains("QA Automation - май 2020"));
        }
    }
}
