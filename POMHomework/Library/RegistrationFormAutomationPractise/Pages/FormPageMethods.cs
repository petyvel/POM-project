using FirstHomeworkNavigationTests.Extentions;
using FirstHomeworkNavigationTests.RegistrationFormAutomationPractise.Models;
using OpenQA.Selenium;

namespace FirstHomeworkNavigationTests.RegistrationFormAutomationPractise.Pages
{
    public partial class FormPage : BasePage
    {

        public FormPage(IWebDriver Driver)
            : base(Driver)
        {
        }

            public void FillForm(RegistrationFormModel user)
            {

                Title. Click();
                FirstName.SendKeys(user.FirstName);
                LastName.SendKeys(user.LastName);
                Password.SendKeys(user.Password);
                Address.SendKeys(user.Address);
                City.SendKeys(user.City);
                State.SendKeys(user.State);
                ZipCode.SendKeys(user.ZipCode);
                MobilePhone.SendKeys(user.MobilePhone);
                AlternativeEmail.SendKeys(user.AlternativeEmail);

               // ScrollTo(Submit).Click();
            }
        }
    }


