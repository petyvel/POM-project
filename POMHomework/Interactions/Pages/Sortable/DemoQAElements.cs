using OpenQA.Selenium;


namespace InteractionsDemoQA.Pages
{
    public partial class DemoQASortable : BasePage
    {
        public IWebElement numberOne => Driver.FindElement(By.XPath("//*[@class='create-grid']/div[@class='list-group-item list-group-item-action'][text()='One']"));
        public IWebElement numberFive => Driver.FindElement(By.XPath("//*[@class='create-grid']/div[@class='list-group-item list-group-item-action'][text()='Five']"));

        public IWebElement numberSix => Driver.FindElement(By.XPath("//*[@class='vertical-list-container mt-4']/div[@class='list-group-item list-group-item-action'][text()='Six']"));
        public IWebElement numberTwo => Driver.FindElement(By.XPath("//*[@class='vertical-list-container mt-4']/div[@class='list-group-item list-group-item-action'][text()='Two']"));
        public IWebElement numberFiveSecondTest => Driver.FindElement(By.XPath("//*[@class='vertical-list-container mt-4']/div[@class='list-group-item list-group-item-action'][text()='Five']"));

       

    }
}
