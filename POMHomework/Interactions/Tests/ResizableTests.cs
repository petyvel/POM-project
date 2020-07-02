using InteractionsDemoQA.Pages;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InteractionsDemoQA.Tests
{
    [TestFixture]
    public class ResizableTests : BaseTest
    {
        private DemoQAResizable _demoQAResizable;

             [SetUp]
        public void Setup()
        {
            Initialize();
            _demoQAResizable = new DemoQAResizable(Driver);
            _demoQAResizable.NavigateTo();

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
        public void ResizableMoveOfTheFirstBox()
        {
            var resizableElementInitLocation = _demoQAResizable.resizableElement.Location;
            IJavaScriptExecutor js = Driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,400)");

            Builder.DragAndDropToOffset(_demoQAResizable.resizableElement, 150, 300)
                .Perform();

            var resizableElementNewLocation = _demoQAResizable.resizableElement.Location;

            Assert.AreNotEqual(resizableElementInitLocation, resizableElementNewLocation);


        }

        [Test]
        public void ResizableMoveOfTheLowerBox()
        {
            var resizableElementLowerBoxInitLocation = _demoQAResizable.resizableElementLowerBox.Location;
            IJavaScriptExecutor js = Driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,400)");

            Builder.DragAndDropToOffset(_demoQAResizable.resizableElementLowerBox, 80, 30).Perform();

            var resizableElementLowerBoxNewLocation = _demoQAResizable.resizableElementLowerBox.Location;

            Assert.AreNotEqual(resizableElementLowerBoxInitLocation, resizableElementLowerBoxNewLocation);


        }
    }


    }

