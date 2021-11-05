using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject.Web_Tables
{
    class GetallrowsandColumns
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
            string p1 = "/html/body/div[2]/div/div/main/article/div/div/table/tbody/tr[";
            string p2 = "]/td[";
            string p3 = "]";
            for (int i = 1; i < 197; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    string value = driver.FindElement(By.XPath(p1 + i + p2 + j + p3)).Text;
                    Console.WriteLine(value);
                }
               
            }
        }
        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }
    }
}
