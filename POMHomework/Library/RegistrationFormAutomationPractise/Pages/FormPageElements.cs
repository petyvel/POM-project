using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace FirstHomeworkNavigationTests.RegistrationFormAutomationPractise.Pages
{
    public partial class FormPage : BasePage
    {
        
        public FormSectionAllertMessagePop Popup => new FormSectionAllertMessagePop(Driver);
               
        public IWebElement Title => Driver.FindElement(By.XPath($"//*[@id='id_gender1']"));

        public IWebElement FirstName => Driver.FindElement(By.CssSelector("#customer_firstname"));

        public IWebElement LastName => Driver.FindElement(By.CssSelector("#customer_lastname"));

        public IWebElement Email => Driver.FindElement(By.Id("email_create"));

        public IWebElement Password => Driver.FindElement(By.Id("passwd"));

        public IWebElement AddressLineFirstName => Driver.FindElement(By.CssSelector("#firstname"));

        public IWebElement AddressLineLastName => Driver.FindElement(By.CssSelector("#lastname"));

        public IWebElement Address => Driver.FindElement(By.Id("address1"));

        public IWebElement City => Driver.FindElement(By.Id("city"));

        public IWebElement State =>Driver.FindElement(By.Id("id_state"));

        public IWebElement ZipCode => Driver.FindElement(By.Id("postcode"));

        public IWebElement MobilePhone => Driver.FindElement(By.Id("phone_mobile"));

        public IWebElement AlternativeEmail => Driver.FindElement(By.CssSelector("#alias"));
               

            public IWebElement Submit => Driver.FindElement(By.CssSelector("#submitAccount"));

           

       
    }
}





         
   
           