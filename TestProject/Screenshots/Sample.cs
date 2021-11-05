using AventStack.ExtentReports;
using AventStack.ExtentReports.Model;
using Docker.DotNet.Models;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestProject.Base;

namespace TestProject.Screenshots
{
   public class Sample : Base1
    {
        [Test]
        public void test1()
        {
            test = extent.CreateTest("login").Info("Test");
            driver = new ChromeDriver();
            test.Log(Status.Pass, "chromelaunched");
            driver.Url = "https://opensource-demo.orangehrmlive.com";
            test.Log(Status.Pass, "Urlpassed");

            driver.Manage().Window.Maximize();
            IWebElement Name = driver.FindElement(By.Id("txtUsername"));
            Name.SendKeys("Admin");
            IWebElement pwd = driver.FindElement(By.Id("txtPassword"));
            pwd.SendKeys("admin123");
            driver.FindElement(By.Id("btnLogin")).Click();
            Thread.Sleep(2000);
            string title = driver.Title;
            Assert.AreEqual("OrangeHRM", title);
            driver.Navigate().Back();
            Thread.Sleep(3000);
            
        }
        [Test]
        public void test2()
        {
            IWebElement Name = driver.FindElement(By.Id("txtUsername"));
            Name.SendKeys("Admin");
            IWebElement pwd = driver.FindElement(By.Id("txtPassword"));
            pwd.SendKeys("admin123");
            driver.FindElement(By.Id("btnLogin")).Click();
            Thread.Sleep(2000);
            string title = driver.Title;
            Assert.AreEqual("HomeHRM", title);
        }

    }
}
