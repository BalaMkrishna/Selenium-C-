using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject.Web_Tables
{
    class CountofRowsandColumns
    {
        IWebDriver driver;

        [SetUp]
        public void setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://cosmocode.io/automation-practice-webtable/l";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }
        [Test]
        public void test()
        {
            IList<IWebElement> rowcount = driver.FindElements(By.TagName("tr"));
            Console.WriteLine("No of Rows:" + " " + rowcount.Count);
           IList<IWebElement> columncount = driver.FindElements(By.TagName("td"));
            Console.WriteLine("No of Columns:" + " " + columncount.Count);
        }
        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }
    }
}
