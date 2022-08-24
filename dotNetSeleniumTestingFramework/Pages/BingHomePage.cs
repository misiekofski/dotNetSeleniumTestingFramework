using dotNetSeleniumTestingFramework.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace dotNetSeleniumTestingFramework.Pages
{
    public class BingHomePage
    {
        private IWebElement searchInput => Driver.Instance.FindElement(By.Name("q"));
        
        internal void SearchForText(string p0)
        {
            searchInput.SendKeys(p0);
            searchInput.Submit();
            Thread.Sleep(5500);
        }
    }
}
