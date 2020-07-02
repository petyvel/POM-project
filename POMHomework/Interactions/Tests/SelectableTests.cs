using InteractionsDemoQA.Extentions;
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
    class SelectableTests : BaseTest
    {



        private DemoQASelectable _demoQASelectable;

        [SetUp]
        public void Setup()
        {
            Initialize();
            _demoQASelectable = new DemoQASelectable(Driver);
            _demoQASelectable.NavigateTo();

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
        public void SelectableList()
        {
            var initColorFirstRow = _demoQASelectable.firstRow.GetCssValue("color");
            var initColorThirdRow = _demoQASelectable.thirdRow.GetCssValue("color");


            Builder
                 .MoveToElement(_demoQASelectable.firstRow)
                .Click(_demoQASelectable.firstRow)
                .MoveToElement(_demoQASelectable.thirdRow)
                .Click(_demoQASelectable.thirdRow)
                .Perform();


            var newColorFirstRow = _demoQASelectable.firstRow.GetCssColor();
            var newColorThirdRow = _demoQASelectable.thirdRow.GetCssColor(); ;

            Assert.AreNotEqual(initColorFirstRow, newColorFirstRow);
            Assert.AreNotEqual(initColorThirdRow, newColorThirdRow);

        }

        [Test]

        public void SelectableGrid()
        {
            var gridButton = Driver.FindElement(By.XPath("//a[@id='demo-tab-grid']"));
            gridButton.Click();
            var initColorOne = _demoQASelectable.One.GetCssColor();
            var initColorFive = _demoQASelectable.Five.GetCssColor();


            Builder
                .MoveToElement(_demoQASelectable.One)
                .Click(_demoQASelectable.One)
                .MoveToElement(_demoQASelectable.Five)
                .Click(_demoQASelectable.Five)
                .Perform();


            var newColorOne = _demoQASelectable.One.GetCssColor();
            var newColorFive = _demoQASelectable.Five.GetCssColor();

            Assert.AreNotEqual(initColorOne, newColorOne);
            Assert.AreNotEqual(initColorFive, newColorFive);

        }
    }
}

