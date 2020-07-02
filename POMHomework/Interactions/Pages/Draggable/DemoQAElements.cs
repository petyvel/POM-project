using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteractionsDemoQA.Pages
{
    public partial class DemoQADraggable : BasePage
    {
        public IWebElement draggableElement => Driver.FindElement(By.Id("dragBox"));
        public IWebElement containmentWrapper => Driver.FindElement(By.XPath("//div[@id='containmentWrapper']"));
        public IWebElement draggableElementTestTwo => Driver.FindElement(By.XPath("//div[@id='containmentWrapper']/div"));
        public IWebElement onlyXBox => Driver.FindElement(By.XPath("//div[@class='axis-restriction-container mt-4']/div[@id='restrictedX']"));
    }
}
