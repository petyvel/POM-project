using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteractionsDemoQA.Pages
{
    public partial class DemoQASelectable : BasePage
    {
        public DemoQASelectable(IWebDriver Driver)
               : base(Driver)
        {
        }

        public override string Url => "http://demoqa.com/selectable";

    }
}
