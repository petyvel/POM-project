using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteractionsDemoQA.Pages
{
    public partial class DemoQASelectable : BasePage
    {
        public IWebElement firstRow => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/ul/li[1]"));
        public IWebElement thirdRow => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/ul/li[3]"));
        public IWebElement One => Driver.FindElement(By.XPath("//div[@id='row1']//li[text()='One']"));
        public IWebElement Five => Driver.FindElement(By.XPath("//div[@id='row2']//li[text()='Five']"));

    }
}
