using Microsoft.Office.Interop.Excel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestProject.Pom
{
    class POM1
    {
        public IWebDriver driver;

        [Test]
        [Obsolete]
        public void TestMethod()
        {
            
            driver = new ChromeDriver();
            
            driver.Url = "https://opensource-demo.orangehrmlive.com";
            driver.Manage().Window.Maximize();
            var page = new Pom(driver);
            page.login("Admin", "admin123");

            Thread.Sleep(2000);
            driver.Close();


        }
    }
}
