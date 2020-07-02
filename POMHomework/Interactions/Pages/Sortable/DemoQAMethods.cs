using OpenQA.Selenium;


namespace InteractionsDemoQA.Pages
{
    public partial class DemoQASortable : BasePage
    {
        public DemoQASortable(IWebDriver Driver)
              : base(Driver)
        {
        }

        public override string Url => "http://demoqa.com/sortable";

    }
}
    

