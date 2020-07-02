using InteractionsDemoQA.Pages;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.IO;

namespace InteractionsDemoQA.Tests
{
    [TestFixture]
    class SortableTests : BaseTest
    {

        private DemoQASortable _demoQASortable;

        [SetUp]
        public void Setup()
        {
            Initialize();
            _demoQASortable = new DemoQASortable(Driver);
            _demoQASortable.NavigateTo();

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
        public void SortableGrid()
        {
            var sortableGridButton = Driver.FindElement(By.XPath("//a[@id='demo-tab-grid']"));
            sortableGridButton.Click();
            var initTextInFirstGrid = _demoQASortable.numberOne.Text;
      
            Builder
                .MoveToElement(_demoQASortable.numberOne)
                .ClickAndHold(_demoQASortable.numberOne)
                .MoveToElement(_demoQASortable.numberFive)
                .ClickAndHold(_demoQASortable.numberFive)
                .Perform();


            var textNewFirstGrid = _demoQASortable.numberOne.Text;

            Assert.AreNotEqual(initTextInFirstGrid, textNewFirstGrid);
        }

        [Test]
        public void SortableList()
        {
            
            var initTextNumberFive = _demoQASortable.numberFiveSecondTest.Text;
          
            Builder.DragAndDrop(_demoQASortable.numberTwo, _demoQASortable.numberSix).Perform();

            var newTextNumberFive = _demoQASortable.numberTwo.Text;

            Assert.AreNotEqual(initTextNumberFive, newTextNumberFive);
        }

    }
}
