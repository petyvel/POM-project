using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstHomeworkNavigationTests.RegistrationFormAutomationPractise.Pages
{
    public partial class FormPage:BasePage
    {
        public void AssertNegativeFistName(IWebElement Popup)
        {
            this.WaitForLoad();
            Assert.IsFalse( Popup.Text.ToString().Contains("first name is required"));
        }

        public void AssertNegativeLastName(IWebElement Popup)
        {
            this.WaitForLoad();
            Assert.IsFalse(Popup.Text.ToString().Contains("last name is required"));
        }
        public void AssertNegativeMobilePhone(IWebElement Popup)
        {
            this.WaitForLoad();
            Assert.IsFalse(Popup.Text.ToString().Contains("phone is required"));
        }
        public void AssertNegativeCity(IWebElement Popup)
        {
            this.WaitForLoad();
            Assert.IsFalse(Popup.Text.ToString().Contains("city is required"));
        }
        public void AssertNegativePassword(IWebElement Popup)
        {
            this.WaitForLoad();
            Assert.IsFalse(Popup.Text.ToString().Contains("password is required"));
        }
        public void AssertNegativeAddress(IWebElement Popup)
        {
            this.WaitForLoad();
            Assert.IsFalse(Popup.Text.ToString().Contains("address is required"));
        }
        public void AssertNegativeZipcode(IWebElement Popup)
        {
            this.WaitForLoad();
            Assert.IsFalse(Popup.Text.ToString().Contains("Zipcode is required"));
        }
    }
}
