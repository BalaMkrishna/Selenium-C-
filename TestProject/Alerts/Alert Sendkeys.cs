using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject.Alerts
{
    class Sendkeys
    {
        IWebDriver driver;
        [SetUp]
        public void setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.hyrtutorials.com/p/alertsdemo.html";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }
        [Test]
        public void test()
        {
            driver.FindElement(By.Id("promptBox")).Click();
            Thread.Sleep(1000);
            IAlert alert = driver.SwitchTo().Alert();
            Console.WriteLine(alert.Text);
            alert.SendKeys("member");
            Thread.Sleep(3000);
            alert.Accept();
            Console.WriteLine(driver.FindElement(By.Id("output")).Text);
        }
        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }
    }
}
