using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using AventStack.ExtentReports;
using Comprehensive.Utility;

using ImageMagick;

using NPOI.XSSF.UserModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using Serilog;
using WDSE;
using WDSE.Decorators;
using WDSE.ScreenshotMaker;


namespace Comprehensive.Methods
{
   public  class Method
    {
        
        public void OpenUrl()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            BaseClass.driver.Manage().Window.Maximize();
            Log.Information("Web browser and Tide Url is Entered into it ");
            
        }
        public void ClickRegisterOption()
        {
            Thread.Sleep(4000);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            BaseClass.driver.FindElement(By.XPath("//a[@href='/en-us/sign-in']")).Click();
            Thread.Sleep(500);
            Log.Information("Clicked on The Registration Option");
        }
        public void ClickSignUp()
        {
            BaseClass.driver.FindElement(By.XPath("//a[@class='event_internal_link']")).Click();
            Thread.Sleep(500);
            Log.Information("Clicked on the SignUp option");
        }
        public void EnterFirstName()
        {
            var text = BaseClass.driver.FindElement(By.XPath("//input[@aria-label='text']"));
            text.SendKeys("Sourabh");
            Thread.Sleep(5000);
        }
     
       
        public  void WebpageScreenshot(string Screenshot)
        {
            Thread.Sleep(5000);
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile(@"C:\Users\mindc1may216\source\repos\Comprehensive\Utility\"+Screenshot+".Png");
        }

        public void ReadDataFromExcel()
        {
            String path = @"C:\Users\mindc1may216\Desktop\MY_Folder\Book1.xlsx";
            XSSFWorkbook workbook = new XSSFWorkbook(File.Open(path, FileMode.Open));
            var sheet = workbook.GetSheetAt(0).GetRow(0).GetCell(0).StringCellValue.Trim();
            Console.WriteLine("The Data in the ExcelSheet is :" + sheet);
        }
        public static MediaEntityModelProvider Screen(string Name)
        {
            var screenshot = ((ITakesScreenshot)BaseClass.driver).GetScreenshot().AsBase64EncodedString;
            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot, Name).Build();
        }
        public void HoverShopProducts()
        {
            WebElement ele = (WebElement)BaseClass.driver.FindElement(By.XPath(""));
            Actions action = new Actions(BaseClass.driver);
            action.MoveToElement(ele).Perform();
        }
        public void ClickPacs()
        {
            BaseClass.driver.FindElement(By.XPath("//span[@class='active']"));
        }
        public void FebrezeSpringClick()
        {
            BaseClass.driver.FindElement(By.XPath("//*[@href='/en-us/shop/type/laundry-pods/tide-pods-plus-febreze-spring-and-renewal'][@class='product-preview-title']"));
        }
        public void RetailersFebreze()
        {
            BaseClass.driver.FindElement(By.XPath("//div[@class='col-12 col-lg-3 right-column']"));
        }
        public void EnterProductName()
        {
           var text= BaseClass.driver.FindElement(By.XPath("//input[@placeholder='Search'][@name='q']"));
            text.SendKeys("Tide PODS® Plus Febreze™ 4in1 Spring and Renewal Laundry Detergent");
            Thread.Sleep(5000);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            Thread.Sleep(5000);
            Log.Information("The Product name has been Entered");


        }
        public void ClickSearch()
        {
            BaseClass.driver.FindElement(By.XPath("//button[@aria-label='Sumbit Search']")).Click();
            Thread.Sleep(5000);
            BaseClass.generateReport();
            Log.Information("Clicked on The Search Option");
        }
        public void ClickLocation()
        {
            Thread.Sleep(5000);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            BaseClass.driver.FindElement(By.XPath("//button[normalize-space()='US - English']")).Click();
            Thread.Sleep(5000);
            Log.Information("Clicked on the Location option");

        }
        public void SelectLocation()
        {
            BaseClass.driver.FindElement(By.XPath("//a[normalize-space()='US - English']")).Click();
            Log.Information("Selected the US-English Option");
        }
        public void CuponReward()
        {
            Thread.Sleep(5000);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            BaseClass.driver.FindElement(By.XPath("//a[@data-action-detail='Coupons and Rewards']")).Click();
            Thread.Sleep(5000);
            Log.Information("Clicked on the Cupons and Reward");
        }
        public void SaveCupon()
        {
            BaseClass.driver.FindElement(By.XPath("//a[@class='event_internal_link']")).Click();
            Thread.Sleep(5000);
            Log.Information("Clicked on The Save Cupon");
        }
        public void WhatsNew()
        {
            Thread.Sleep(5000);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            BaseClass.driver.FindElement(By.XPath("//a[@href='/en-us/latest-news']")).Click();
            Log.Information("Clicked on the WhatsNew Option");
            Thread.Sleep(5000);
        }
        public void ClickOnLearnMore()
        {
            BaseClass.driver.FindElement(By.XPath("//a[@href='/en-us/shop/type/laundry-pods/tide-hygienic-clean-heavy-duty-10x-power-pods-original']")).Click();
            Thread.Sleep(5000);
            Log.Information("Clicked on the Click on Learn more");
        }

        public void Ingrediants()
        {
            BaseClass.driver.FindElement(By.XPath("//a[@href='https://smartlabel.pg.com/00037000590804.html']")).Click();
            Thread.Sleep(5000);
            Log.Information("Clicked on the More option and Selected the Ingrediants");
        }
        public void LiveChat()
        {
            Thread.Sleep(5000);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            BaseClass.driver.FindElement(By.XPath("//a[@href='/en-us/live-chat']")).Click();
            Thread.Sleep(5000);
            Log.Information("Click on LiveChat");
        }
        public void ChatNow()
        {
            BaseClass.driver.FindElement(By.XPath("//button[@class='button-link / chat-button event_button_click']")).Click();
            Thread.Sleep(5000);
            Log.Information("Clicked on the Chat now Option");
        }
        public void ContactUs()
        {
            Thread.Sleep(5000);
            BaseClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            BaseClass.driver.FindElement(By.XPath("/html/body/div[1]/div/header/div[1]/div/div/div/div[2]/a[2]")).Click();
            Thread.Sleep(5000);
            Log.Information("Clicked on the Contact Us ");
        }
        public void PutQuestion()
        {
           var text= BaseClass.driver.FindElement(By.XPath("//input[@value='Tide Cupons']"));
            text.Click();
            text.SendKeys("Tide Cupons");
            Thread.Sleep(5000);
            
        }
       

    }
}
