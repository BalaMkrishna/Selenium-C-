using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject.Alerts
{
    class AlertConfirmation
    {
        IWebDriver driver;
        [OneTimeSetUp]
        public void setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.hyrtutorials.com/p/alertsdemo.html";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }
        [Test]
        public void Accept()
        {
            driver.FindElement(By.Id("confirmBox")).Click();
            Thread.Sleep(2000);
            IAlert confirmalert = driver.SwitchTo().Alert();
            Console.WriteLine(confirmalert.Text);
            Thread.Sleep(2000);
            confirmalert.Accept();
            Console.WriteLine(driver.FindElement(By.Id("output")).Text);
            Thread.Sleep(5000);         
        }
        [Test]
        public void Dismiss()
        {
            driver.FindElement(By.Id("confirmBox")).Click();
            Thread.Sleep(2000);
            IAlert confirmalert = driver.SwitchTo().Alert();
            Console.WriteLine(confirmalert.Text);
            Thread.Sleep(2000);
            confirmalert.Dismiss();
            Console.WriteLine(driver.FindElement(By.Id("output")).Text);
            Thread.Sleep(2000);       
        }
        [OneTimeTearDown]
        public void Teardown()
        {
            driver.Close();
        }

    }
}

