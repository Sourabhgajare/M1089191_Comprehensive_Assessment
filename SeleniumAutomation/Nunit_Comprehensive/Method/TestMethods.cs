using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Nunit_Comprehensive.Base;
using System.Threading;
using OpenQA.Selenium;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Model;
using Serilog;
using Log = Serilog.Log;
using Nunit_Comprehensive.ExcelRead;

namespace Nunit_Comprehensive.Method
{
    [TestFixture]
   public class TestMethods:BaseClass
    {
        BaseClass obj = new BaseClass();
        Excel obj1 = new Excel();
       
        [Test]
        public void ClickRegisterOption()
        {

            ExtentTest test = extents.CreateTest("ClickRegisterOption").Info("Click on Registration Started");
             Thread.Sleep(5000);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            BaseClass.driver.FindElement(By.XPath("//a[@href='/en-us/sign-in']")).Click();
            Log.Information("Clicked on The Registration option");
            test.Info("Clicked on The Registration option");
            Thread.Sleep(5000);
            obj.WebpageScreenshot("Regristration Page");
        }
       
        [Test]
        public void EnterProductName()
        {
            ExtentTest test = extents.CreateTest("EnterProductName").Info("Enter Product name Method Started");
            var text = BaseClass.driver.FindElement(By.XPath("//input[@placeholder='Search'][@name='q']"));
            test.Info("Click on the Search Field");
            text.SendKeys("Tide PODS® Plus Febreze™ 4in1 Spring and Renewal Laundry Detergent");
            test.Info("Product Name had Entered");
            Log.Information("Product Name had Entered");
            Thread.Sleep(5000);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            Thread.Sleep(5000);
            obj.WebpageScreenshot("Product Name");
            obj1.ReadExcelName();


        }
        [Test]
        public void ClickSearch()
        {
            ExtentTest test = extents.CreateTest("ClickSearch").Info("Click Search Method Started");
            Thread.Sleep(5000);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            BaseClass.driver.FindElement(By.XPath("//button[@aria-label='Sumbit Search']")).Click();
            test.Info("Serch button had click");
            Log.Information("Serch button had click");
            Thread.Sleep(5000);
            obj.WebpageScreenshot("Click search");
        }
        [Test]
        public void ClickLocation()
        {
            ExtentTest test = extents.CreateTest("ClickLocation").Info("ClickLocation method Started");
            Thread.Sleep(5000);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            BaseClass.driver.FindElement(By.XPath("//button[normalize-space()='US - English']")).Click();
            test.Info("Click on The Dropdown of Location");
            Log.Information("Click on The Dropdown of Location");
            Thread.Sleep(5000);
            obj.WebpageScreenshot("Click Location");
        }
      
        [Test]
        public void CuponReward()
        {
            ExtentTest test = extents.CreateTest("CuponReward").Info("CuponReward method Started");
            Thread.Sleep(5000);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            BaseClass.driver.FindElement(By.XPath("//a[@data-action-detail='Coupons and Rewards']")).Click();
            test.Info("Clicked on the CuponReward Option");
            Log.Information("Clicked on the CuponReward Option");
            Thread.Sleep(5000);
            obj.WebpageScreenshot("Cupon Reward");
        }
      
        [Test]
        public void WhatsNew()
        {
            ExtentTest test = extents.CreateTest("WhatsNew").Info("WhatsNew method Started");
            Thread.Sleep(8000);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            BaseClass.driver.FindElement(By.XPath("//a[@href='/en-us/latest-news']")).Click();
            test.Info("Clicked on the Whats new Option");
            Log.Information("Clicked on the Whats new Option");
            Thread.Sleep(5000);
            obj.WebpageScreenshot("Whats New");
        }
       
       
        [Test]
        public void LiveChat()
        {
            ExtentTest test = extents.CreateTest("LiveChat").Info("LiveChat method Started");
            Thread.Sleep(5000);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            BaseClass.driver.FindElement(By.XPath("//a[@href='/en-us/live-chat']")).Click();
            test.Info("Clicked on the LiveChat Option");
            Log.Information("Clicked on the LiveChat Option");
            Thread.Sleep(5000);
            obj.WebpageScreenshot("Live Chat");
        }
       
        [Test]
        public void ContactUs()
        {
            ExtentTest test = extents.CreateTest("ContactUs").Info("ContactUs method Started");
            Thread.Sleep(5000);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            BaseClass.driver.FindElement(By.XPath("/html/body/div[1]/div/header/div[1]/div/div/div/div[2]/a[2]")).Click();
            test.Info("Clicked on the ContactUs Option");
            Log.Information("Clicked on the ContactUs Option");
            Thread.Sleep(5000);
            obj.WebpageScreenshot("Contact Us");
        }

    }
}
