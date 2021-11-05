using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject.Web_Tables
{
    class CountofTables
    {
        IWebDriver driver;
        [SetUp]
        public void setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://cosmocode.io/automation-practice-webtable/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }
        [Test]
        public void test()
        {
            IList<IWebElement> tablecount = driver.FindElements(By.TagName("table"));
            Console.WriteLine("No of Tables:" + " " + tablecount.Count);
        }
        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }
    }
}
