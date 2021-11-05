using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject.Web_Tables
{
    class DatafromAllColumnfirstrow
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
            string p1 = "/html/body/div[2]/div/div/main/article/div/div/table/tbody/tr[1]/td[";
            string p2 = "]";
            for (int i = 1; i < 6; i++)
            {
                string value = driver.FindElement(By.XPath(p1 + i + p2)).Text;
                Console.WriteLine(value);
            }
        }
        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }
    }
}
