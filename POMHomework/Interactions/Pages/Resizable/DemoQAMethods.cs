using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteractionsDemoQA.Pages
{
    public partial class DemoQAResizable : BasePage
    {
       
            public DemoQAResizable(IWebDriver Driver)
                : base(Driver)
            {
            }

            public override string Url => "http://demoqa.com/resizable";




    }   
}

