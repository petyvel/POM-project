using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteractionsDemoQA.Extentions
{
   public static class DriverExtentions
    {
        public static string GetCssColor(this IWebElement element)
        {
            return element.GetCssValue("background-color");
        }
    }
}
