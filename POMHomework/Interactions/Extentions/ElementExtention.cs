using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteractionsDemoQA.Extentions
{
   public static class ElementExtention
    {
        public static void ScrollTo(this IWebDriver Driver, IWebElement element)
       {
       ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
         }

    }
}
