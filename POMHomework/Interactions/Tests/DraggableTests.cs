using InteractionsDemoQA.Pages;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System.IO;

namespace InteractionsDemoQA.Tests
{
    [TestFixture]
    public class DraggableTests : BaseTest
    {
        private DemoQADraggable _demoQADraggable;


        [SetUp]
        public void Setup()
        {
            Initialize();
            _demoQADraggable = new DemoQADraggable(Driver);
            _demoQADraggable.NavigateTo();

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

        public void DraggableSimpleMove()
        {
            var initLocation = _demoQADraggable.draggableElement.Location;

            Builder.DragAndDropToOffset(_demoQADraggable.draggableElement, 100, 250).Perform();

            var newLocation = _demoQADraggable.draggableElement.Location;

            Assert.AreNotEqual(initLocation, newLocation);

        }
        [Test]

        public void DraggableContainerRestrictedPositive()
        {

            var containerRestrictedButton = Driver.FindElement(By.XPath("//*[@class='dragable-container']//a[@id='draggableExample-tab-containerRestriction']"));
            containerRestrictedButton.Click();
            var locationDraggableElementX = _demoQADraggable.draggableElementTestTwo.Location.X;
            var locationDraggableElementY = _demoQADraggable.draggableElementTestTwo.Location.Y;

            IJavaScriptExecutor js = Driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,400)");

            Builder.DragAndDropToOffset(_demoQADraggable.draggableElementTestTwo, (locationDraggableElementX + 25), (locationDraggableElementY - 30))
                .Perform();

            var newText = _demoQADraggable.containmentWrapper.Text;

            Assert.AreEqual(newText, "I'm contained within the box");


        }

        [Test]
        public void DraggableAxesRestricted()
        {
            var axesRestrictedButton = Driver.FindElement(By.XPath("//*[@class='dragable-container']//a[@id='draggableExample-tab-axisRestriction']"));
            axesRestrictedButton.Click();
            var initLocationOnlyXBoxLocationX = _demoQADraggable.onlyXBox.Location.X;
            var initLocationOnlyXBoxLocationY = _demoQADraggable.onlyXBox.Location.Y;
            IJavaScriptExecutor js = Driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,400)");

            Builder.DragAndDropToOffset(_demoQADraggable.onlyXBox, (initLocationOnlyXBoxLocationX + 25), (initLocationOnlyXBoxLocationY - 30))
                .Perform();


            Assert.Throws<WebDriverException>(() => Builder.Perform());





        }

    }
}
