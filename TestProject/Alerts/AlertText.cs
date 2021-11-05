using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject.Alerts
{
    class AlertText
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.hyrtutorials.com/p/alertsdemo.html";
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
        }
        [Test]
        public void test()
        {
            driver.FindElement(By.Id("alertBox")).Click();
           string value = driver.SwitchTo().Alert().Text;
            Console.WriteLine(value);
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();
        }
        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }
    }
}
