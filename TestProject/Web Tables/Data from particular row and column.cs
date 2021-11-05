using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject.Web_Tables
{
    class Datafromparticularrowandcolumn
    {
        IWebDriver driver;
        [SetUp]
        public void setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://customerfeaturestatetest.z6.web.core.windows.net/feature-state-management/features/all";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }
        [Test]
        public void test()
        {

            string value1 = driver.FindElement(By.XPath("/html/body/feature-state-web-root/compositions-feature-state-management-root/compositions-feature-state-management-features/div/div/div[2]/feature-state-management-feature-list/div/div/div/div/div/div/table/tbody/tr[2]/td[3]")).Text;
            Console.WriteLine(value1);
            Assert.That(value1, Is.EqualTo("Aug 31, 2021"));
           // string value2 = driver.FindElement(By.XPath("/html/body/div[2]/div/div/main/article/div/div/table/tbody/tr[10]/td[3]")).Text;
            //Console.WriteLine(value2);
        }
        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }
    }
}
