using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestProject.Base;
using TestProject.Base2;

namespace TestProject.Parallel_Testing
{
    class Order:Base1

    {
        [Test, Order(2), Category("OrderAttribute")]
        public void test1()
        {
            test = extent.CreateTest("login").Info("Test");
            Browsers v = new Browsers();
            driver = v.launchBrowser("Chrome");
            test.Log(Status.Pass, "Chromelaunched");
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";
            test.Log(Status.Pass, "UrlPassed");
            IWebElement Search = driver.FindElement(By.Id("email"));
            Thread.Sleep(2000);
            Search.SendKeys("fb");

        }

        [Test, Order(1), Category("OrderAttribute")]
        [Ignore("Ignore a fixture")]//skip the test 
        public void test2()
        {
           
            test = extent.CreateTest("login").Info("Test");
            Browsers v = new Browsers();
            driver = v.launchBrowser("Edge");
            test.Log(Status.Pass, "Edgelaunched");
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";
            test.Log(Status.Pass, "UrlPassed");
            IWebElement Search = driver.FindElement(By.Id("email"));
            Thread.Sleep(2000);
            Search.SendKeys("fb");

        }


        [Test, Order(0), Category("OrderAttribute")]
        public void test3()
        {
            test = extent.CreateTest("login").Info("Test");
            Browsers v = new Browsers();
            driver = v.launchBrowser("Firefox");
            test.Log(Status.Pass, "Firefoxlaunched");
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";
            test.Log(Status.Pass, "UrlPassed");
            IWebElement Search = driver.FindElement(By.Id("email"));
            Thread.Sleep(2000);
            Search.SendKeys("fb");

        }

    }
}
