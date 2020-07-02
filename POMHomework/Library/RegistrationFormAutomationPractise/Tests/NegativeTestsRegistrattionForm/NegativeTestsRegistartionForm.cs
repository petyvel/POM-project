using FirstHomeworkNavigationTests.RegistrationFormAutomationPractise.Factories;
using FirstHomeworkNavigationTests.RegistrationFormAutomationPractise.Models;
using FirstHomeworkNavigationTests.RegistrationFormAutomationPractise.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstHomeworkNavigationTests.RegistrationFormAutomationPractise.Tests.NegativeTestsRegistrattionForm
{
    [TestFixture]
    public class NegativeTestsRegistartionForm : BaseTest
       
    {
        private FormPage _formPage;
        private RegistrationFormModel _user;
        private WebDriverWait _wait;

        [SetUp]
        public void Setup()
        {
             Initialize();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            _formPage = new FormPage(Driver);

            _user = RegistrationFormFactory.Create();
            _wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

        [Test]
          
        public void AutomationPractiseNegativeFistName()
        {
            SignInNavigation();

            
            _user.FirstName = string.Empty;
            _user.AddressLineFirstName = string.Empty;

            _formPage.FillForm(_user);


            _formPage.AssertNegativeFistName(_formPage.FirstName);



        }

        [Test]

        public void AutomationPractiseNegativeLastName()
        {
            SignInNavigation();


            _user.LastName = string.Empty;
            _user.AddressLineLastName = string.Empty;

            _formPage.FillForm(_user);

            _formPage.AssertNegativeLastName(_formPage.LastName);

        }

        [Test]

        public void AutomationPractiseNegativePhone()
        {
            SignInNavigation();


            _user.MobilePhone = string.Empty;
            
            _formPage.FillForm(_user);

            _formPage.AssertNegativeMobilePhone(_formPage.MobilePhone);

        }

        [Test]

        public void AutomationPractiseNegativeCity()
        {
            SignInNavigation();


            _user.City = string.Empty;

            _formPage.FillForm(_user);

            _formPage.AssertNegativeCity(_formPage.City);

        }

        [Test]

        public void AutomationPractiseNegativePassword()
        {
            SignInNavigation();


            _user.Password = string.Empty;

            _formPage.FillForm(_user);

            _formPage.AssertNegativePassword(_formPage.Password);

        }

        [Test]

        public void AutomationPractiseNegativeAddress()
        {
            SignInNavigation();


            _user.Address = string.Empty;

            _formPage.FillForm(_user);

            _formPage.AssertNegativeAddress(_formPage.Address);

        }
        [Test]

        public void AutomationPractiseNegativeZipcode()
        {
            SignInNavigation();


            _user.ZipCode = string.Empty;

            _formPage.FillForm(_user);

            _formPage.AssertNegativeZipcode(_formPage.ZipCode);

        }

        private void SignInNavigation ()
        {
            _wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            IWebElement signInButton = Driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[2]/div/div/nav/div[1]/a"));
            signInButton.Click();
            IWebElement createAccount = _wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#email_create")));
            createAccount.SendKeys("pro06us@yahoo.com");
            IWebElement submitButton = Driver.FindElement(By.XPath("//*[@id='SubmitCreate']"));
            submitButton.Click();
            IWebElement emailField = _wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#email")));
        }

    }

}

