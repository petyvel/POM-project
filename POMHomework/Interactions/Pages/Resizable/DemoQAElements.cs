using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteractionsDemoQA.Pages
{
    public partial class DemoQAResizable : BasePage
    {
        public IWebElement resizableElement => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div[1]/div/span"));
        public IWebElement resizableElementLowerBox => Driver.FindElement(By.XPath("//*[@class='resizable-nolimit mt-4']/div[@id='resizable']/span"));


    }
}
