using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using Serilog;
using System.Threading;
using Dove.Utilities;
using OpenQA.Selenium;
using NUnit.Framework;

namespace Dove.POM
{
    [Binding]
   public class ProhibitedUses
    {
        public static void OpenUrl()
        {
            Log.Information("Web browser and Tide Url is Entered into it ");
            BaseClass.driver.Navigate().GoToUrl("https://www.dove.com/in/home.html");
            BaseClass.driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
        }
        public static void TermsOfUse()
        {
            Log.Information("Click on Terms Of Use");
            BaseClass.driver.FindElement(By.XPath("//a[@href='https://www.dove.com/in/terms-of-use.html']")).Click();
            Thread.Sleep(5000);
        }
        public static void Prohibiteduses()
        {
            Log.Information("Verified the Prohibited Uses ");
            string res=BaseClass.driver.FindElement(By.XPath("//p[' Prohibited Uses'][3]")).Text;
            Assert.IsTrue(res.Contains("Prohibited Uses"));
            Thread.Sleep(5000);
        }
        public static void WebpageScreenshot(string Screenshot)
        {
            Thread.Sleep(5000);
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile(@"C:\Users\mindc1may216\source\repos\Dove\Utilities\" + Screenshot + ".Png");
        }

    }
}
