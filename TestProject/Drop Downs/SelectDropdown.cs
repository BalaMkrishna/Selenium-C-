using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject.Drop_Downs
{
    class SelectDropDown
    {
        IWebDriver driver;
        [OneTimeSetUp]
        public void setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.seleniumeasy.com/test/basic-select-dropdown-demo.html";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [Test]
        public void test()
        {
            IWebElement States = driver.FindElement(By.Id("multi-select"));
            SelectElement St = new SelectElement(States);
            St.SelectByIndex(3);
            Thread.Sleep(1000);

            St.SelectByIndex(6);
            Thread.Sleep(1000);
        }
        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }
    }
}
