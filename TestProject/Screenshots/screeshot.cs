using Docker.DotNet.Models;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Screenshots
{
    class screeshot
    {
        IWebDriver driver;
        [Test]
        public void CaptureScreenshot()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://opensource-demo.orangehrmlive.com/";
            string title = driver.Title;
            Assert.AreEqual("OrangeHRM", title);
            Getsc.Capture(driver, "screenShotName");
            driver.Close();
        }
    }
}
