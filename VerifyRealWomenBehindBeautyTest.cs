using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using Serilog;
using Dove.Utilities;
using System.Threading;
using OpenQA.Selenium;
using NUnit.Framework;

namespace Dove.POM
{
    [Binding]
   public class VerifyRealWomenBehindBeautyTest
    {
        public static void OpenUrl()
        {
            Log.Information("Web browser and Tide Url is Entered into it ");
            BaseClass.driver.Navigate().GoToUrl("https://www.dove.com/in/home.html");
            BaseClass.driver.Manage().Window.Maximize();
            Thread.Sleep(5000);

        }
        public static void DiscoverMore()
        {
            Log.Information("Click on the Discover option");
            BaseClass.driver.FindElement(By.XPath("//a[@data-title='Discover more']")).Click();
            Thread.Sleep(5000);

        }
        public static void VerifyRealWomen()
        {
            Log.Information("Verify the Real Women Behind Beauty Test");
            string res = BaseClass.driver.FindElement(By.XPath("/html/body/div[1]/section/div[1]/div[2]/div/div/div/div[1]/h2")).Text;
            Assert.IsTrue(res.Contains("“The Real Women behind #StopTheBeautyTest"));
            Thread.Sleep(5000);

        }
        public static void WebpageScreenshot(string Screenshot)
        {
            Thread.Sleep(5000);
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile(@"C:\Users\mindc1may216\source\repos\Dove\Utilities\" + Screenshot + ".Png");
        }
    }
}
