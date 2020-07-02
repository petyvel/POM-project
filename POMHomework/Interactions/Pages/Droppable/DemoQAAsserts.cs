using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteractionsDemoQA.Pages
{
    public partial class DemoQADroppable : BasePage
    {
        public void AssertDroppablePreventPropogationInnerDroppableGreedy(IWebElement initColorInnerDroppableElementGreedy, IWebElement newColorInnerDroppableElementGreedy, IWebElement newColorOuterDroppableElement, IWebElement newTextOuterDroppableElement, IWebElement newTextInnerDroppableElementGreedy)
        {
            this.WaitForLoad();
            Assert.AreNotEqual(initColorInnerDroppableElementGreedy, newColorInnerDroppableElementGreedy);
            Assert.AreNotEqual(newColorInnerDroppableElementGreedy, newColorOuterDroppableElement);
            Assert.AreNotEqual(newTextOuterDroppableElement, newTextInnerDroppableElementGreedy);
        }
    }
}
