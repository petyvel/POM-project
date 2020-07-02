using OpenQA.Selenium;

namespace FirstHomeworkNavigationTests.RegistrationFormAutomationPractise.Pages
{
    public class FormSectionAllertMessagePop : BasePage
    {
        public FormSectionAllertMessagePop(IWebDriver Driver)
           : base(Driver)
        {
        }

        public IWebElement Message => Driver.FindElement(By.XPath("//*[@class='alert alert-danger']"));
    }
}