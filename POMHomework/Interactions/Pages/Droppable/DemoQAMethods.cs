using InteractionsDemoQA.Tests;
using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteractionsDemoQA.Pages
{
    public partial class DemoQADroppable : BasePage
    {
        public DemoQADroppable(IWebDriver Driver)
            : base(Driver)
        {
        }

        public override string Url => "http://demoqa.com/droppable";

        


    }
}
