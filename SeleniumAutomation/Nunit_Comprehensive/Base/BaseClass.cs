using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NPOI.XSSF.UserModel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Serilog;
using Serilog.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace Nunit_Comprehensive.Base
{
    
    public class BaseClass

    {
        public static IWebDriver driver;
        public static ExtentReports extents;
        public static ExtentTest feature;
        public static ExtentTest scenario;
        public static LoggingLevelSwitch loggingLevel;
        //public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        [OneTimeSetUp]
        public void ExtentReport()
        {
            var htmlreport = new ExtentHtmlReporter(@"C:\Users\mindc1may216\source\repos\Nunit_Comprehensive\ExtentReport\Tests.html");
            htmlreport.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;
            extents = new ExtentReports();
            extents.AttachReporter(htmlreport);
            LoggingLevelSwitch loggingLevel = new LoggingLevelSwitch(Serilog.Events.LogEventLevel.Debug);
            Serilog.Log.Logger = new LoggerConfiguration().MinimumLevel.ControlledBy(levelSwitch: loggingLevel).WriteTo.File(@"C:\Users\mindc1may216\source\repos\Nunit_Comprehensive\Logger.log", outputTemplate: "{TimeSpamp:yyyy-MM-dd-HH } | {Level:u3} |{Message}{NewLine}", rollingInterval: RollingInterval.Day).CreateLogger();


        }

        [SetUp]
        public void open()
        {
           

            driver = new ChromeDriver();
           // ExtentTest test = extents.CreateTest("Open Url").Info("Open url Started");
            driver.Navigate().GoToUrl("https://tide.com/en-us");
            driver.Manage().Window.Maximize();
            // String path = @"C:\Users\mindc1may216\source\repos\Nunit_Comprehensive\ExcelData\Book1.xlsx";
            // XSSFWorkbook workbook = new XSSFWorkbook(File.Open(path, FileMode.Open));
            // var sheet = workbook.GetSheetAt(0).GetRow(0).GetCell(0).StringCellValue.Trim();
            // Console.WriteLine("The Data in the ExcelSheet is :" + sheet);
        }
        public void WebpageScreenshot(string Screenshot)
        {
            Thread.Sleep(5000);
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile(@"C:\Users\mindc1may216\source\repos\Nunit_Comprehensive\Screenshot" + Screenshot + ".Png");
        }

        [TearDown]
        public void closed()
        {
            driver.Quit();
            extents.Flush();
        }
    }
}
