using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Base2;
using TestProject.Screenshots;

namespace TestProject.Base
{
    public class Base1 
    {
        public ExtentReports extent;
        public ExtentTest test;
        public IWebDriver driver;
        
        [OneTimeSetUp]
            public void init()
            {
                extent = new ExtentReports();
                var htmlReporter = new ExtentHtmlReporter("C:\\Users\\BalamaniKrishna\\source\\repos\\TestProject\\TestProject\\ExtentReports\\demo.html");
                extent.AttachReporter(htmlReporter);
            }
            [TearDown]
            public void GetResult()
            {
                var status = TestContext.CurrentContext.Result.Outcome.Status;
                var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";
                var errorMessage = TestContext.CurrentContext.Result.Message;
                if (status==TestStatus.Failed)
                {
                    string scPath = Getsc.Capture(driver, "ScreenShotName");
                    test.Log(Status.Fail, stackTrace + errorMessage);
                    test.Log(Status.Fail, "Snapshot below:" + test.AddScreenCaptureFromPath(scPath));
                }
              //driver.Close();
        }
            [OneTimeTearDown]
            public void Endreport()
            {
                driver.Quit();
                extent.Flush();
            }
        }
    }

