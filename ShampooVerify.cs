using AventStack.ExtentReports.Model;
using Dove.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using Serilog;
using Log = Serilog.Log;
using System.Threading;
using OpenQA.Selenium;
using NUnit.Framework;

namespace Dove.POM
{
    [Binding]
   public class ShampooVerify
    {
        public static void OpenUrl()
        {
            Log.Information("Web browser and Tide Url is Entered into it ");
            BaseClass.driver.Navigate().GoToUrl("https://www.dove.com/in/home.html");
            BaseClass.driver.Manage().Window.Maximize();
            Thread.Sleep(5000);

        }
        public static void ClickOnSearch()
        {
            Log.Information("Clicked on The Search Option");
            BaseClass.driver.FindElement(By.XPath("//button[@class='o-navbar-label js-search-btn']")).Click();
            Thread.Sleep(5000);
        }

        public static void EnterShampooSearch()
        {
            Log.Information("Enter the Shampoo In The Search Field");
            BaseClass.driver.FindElement(By.XPath("//input[@class='c-global-search__textbox form-control typeahead tt-input'][1]")).SendKeys("Shampoo");
            Thread.Sleep(5000);
        }
        public static void VerifyShampoo()
        {
            Log.Information("Shampoo Verified from the result");
            BaseClass.driver.FindElement(By.XPath("/html/body/div[1]/header/div[2]/div[1]/div/div/div/div/div/div/form/div[2]/div/button[2]")).Click();
            Thread.Sleep(5000);
           string res= BaseClass.driver.FindElement(By.XPath("//button[@class='o-navbar-label js-search-btn']")).Text;
            Assert.IsTrue(res.Contains("The Real Women behind #StopTheBeautyTest"));
            
        }
        public static void WebpageScreenshot(string Screenshot)
        {
            Thread.Sleep(5000);
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile(@"C:\Users\mindc1may216\source\repos\Dove\Utilities\" + Screenshot + ".Png");
        }


    }
}
