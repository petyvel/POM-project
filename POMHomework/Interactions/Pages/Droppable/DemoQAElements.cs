using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteractionsDemoQA.Pages
{
    public partial class DemoQADroppable : BasePage
    {
        public IWebElement draggableElement => Driver.FindElement(By.CssSelector("#draggable"));
        public IWebElement droppableElement => Driver.FindElement(By.Id("droppable"));

        public IWebElement draggableElementAcceptable =>Driver.FindElement(By.XPath("//div[@id='acceptable']"));
        public IWebElement droppableElementTestTwo =>Driver.FindElement(By.XPath("//div[@class='accept-drop-container']/div[@id='droppable']"));

        public IWebElement draggableElementTestThree => Driver.FindElement(By.XPath("//div[@id='dragBox']"));
        public IWebElement outerDroppableElement => Driver.FindElement(By.XPath("//div[@id='greedyDropBox']"));
        public IWebElement innerDroppableElementGreedy => Driver.FindElement(By.XPath("//div[@id='greedyDropBox']/div[@id='greedyDropBoxInner']"));


    }
}
