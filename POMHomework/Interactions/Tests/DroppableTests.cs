using InteractionsDemoQA;
using InteractionsDemoQA.Extentions;
using InteractionsDemoQA.Pages;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;

namespace InteractionsDemoQA.Tests
{
    [TestFixture]
    public class DroppableTests : BaseTest
    {
        private DemoQADroppable _demoQADroppable;
        

        [SetUp]
        public void Setup()
        {
            Initialize();
            _demoQADroppable = new DemoQADroppable(Driver);
            _demoQADroppable.NavigateTo();

        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string dirPath = Path.GetFullPath(@"..\..\..\", Directory.GetCurrentDirectory());
                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                screenshot.SaveAsFile($"{dirPath}\\Screenshots\\{TestContext.CurrentContext.Test.FullName}.png", ScreenshotImageFormat.Png);
            }
            Driver.Quit();
        }

        [Test]

        public void DroppableSimpleMOve()
        {
            var colorBefore = _demoQADroppable.droppableElement.GetCssColor();

            Builder.DragAndDrop(_demoQADroppable.draggableElement, _demoQADroppable.droppableElement).Perform();

            var colorAfter = _demoQADroppable.droppableElement.GetCssColor();

            Assert.AreNotEqual(colorAfter, colorBefore);

        }

        [Test]
         public void DroppableAcceptAcceptable()
        {
            var acceptButton = Driver.FindElement(By.XPath("//*[@class='nav nav-tabs']/a[@id='droppableExample-tab-accept']"));
            acceptButton.Click();
            var colorBefore = _demoQADroppable.droppableElementTestTwo.GetCssColor();
            IJavaScriptExecutor js = Driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,400)");

            Builder.DragAndDrop(_demoQADroppable.draggableElementAcceptable, _demoQADroppable.droppableElementTestTwo).Perform();
            var colorAfter = _demoQADroppable.droppableElementTestTwo.GetCssColor();

            Assert.AreNotEqual(colorAfter, colorBefore);

        }
        [Test]
        public void DroppablePreventPropogationInnerDroppableGreedy()
        {
            var preventPropogationButton = Driver.FindElement(By.XPath("//*[@class='nav nav-tabs']/a[@id='droppableExample-tab-preventPropogation']"));
            preventPropogationButton.Click();
            var initColorInnerDroppableElementGreedy = _demoQADroppable.innerDroppableElementGreedy.GetCssColor();

            Builder.DragAndDrop(_demoQADroppable.draggableElementTestThree, _demoQADroppable.innerDroppableElementGreedy).Perform();

            var newColorOuterDroppableElement = _demoQADroppable.outerDroppableElement.GetCssColor();
            var newColorInnerDroppableElementGreedy = _demoQADroppable.innerDroppableElementGreedy.GetCssColor();
            var newTextOuterDroppableElement = _demoQADroppable.outerDroppableElement.Text;
            var newTextInnerDroppableElementGreedy = _demoQADroppable.innerDroppableElementGreedy.Text;

             Assert.AreNotEqual(initColorInnerDroppableElementGreedy, newColorInnerDroppableElementGreedy);
             Assert.AreNotEqual(newColorInnerDroppableElementGreedy, newColorOuterDroppableElement);
             Assert.AreNotEqual(newTextOuterDroppableElement, newTextInnerDroppableElementGreedy);

            

        }

    }
}
