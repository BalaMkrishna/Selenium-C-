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

namespace TestProject.parallel_Testing
{
    class Category:Base1
    {
        [Test,Category("Smoke Testing")]
        public void test1()
        {
            test = extent.CreateTest("login").Info("Test");
            Browsers v = new Browsers();
            driver = v.launchBrowser("Edge");
            driver.Manage().Window.Maximize();
            test.Log(Status.Pass, "Browserlaunched");
            driver.Url = "https://accounts.google.com/signin/v2/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&service=mail&sacu=1&rip=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin";
            test.Log(Status.Pass, "UrlPassed");
            IWebElement email = driver.FindElement(By.Id("identifierId"));
            email.SendKeys("bmk@gmail.com");
           
            IWebElement signin = driver.FindElement(By.XPath("//*[@id='identifierNext']/div/button"));
            signin.Click();
            Thread.Sleep(2000);
            string title = driver.Title;
            Assert.AreEqual("Gmail", title);
        }

        [Test, Category("Smoke Testing")]
        public void test2()
        {
            test = extent.CreateTest("login").Info("Test");
            Browsers v = new Browsers();
            driver = v.launchBrowser("Chrome");
            driver.Manage().Window.Maximize();
            test.Log(Status.Pass, "Browserlaunched");
            driver.Url = "https://accounts.google.com/signin/v2/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&service=mail&sacu=1&rip=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin";
            test.Log(Status.Pass, "UrlPassed");
            IWebElement email = driver.FindElement(By.Id("identifierId"));
            email.SendKeys("bmk@gmail.com");

            IWebElement signin = driver.FindElement(By.XPath("//*[@id='identifierNext']/div/button"));
            signin.Click();
            Thread.Sleep(2000);
            string title = driver.Title;
            Assert.AreEqual("Gmail", title);
        }

        [Test, Category("Smoke Testing")]
        public void test3()
        {
            test = extent.CreateTest("login").Info("Test");
            Browsers v = new Browsers();
            driver = v.launchBrowser("Firefox");
            driver.Manage().Window.Maximize();
            test.Log(Status.Pass, "Browserlaunched");
            driver.Url = "https://accounts.google.com/signin/v2/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&service=mail&sacu=1&rip=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin";
            test.Log(Status.Pass, "UrlPassed");
            IWebElement email = driver.FindElement(By.Id("identifierId"));
            email.SendKeys("bmk@gmail.com");

            IWebElement signin = driver.FindElement(By.XPath("//*[@id='identifierNext']/div/button"));
            signin.Click();
            Thread.Sleep(2000);
            string title = driver.Title;
            Assert.AreEqual("Gmail", title);
        }

        [Test,Category("Regression Testing")]
        public void test4()
        {
            test = extent.CreateTest("login").Info("Test");
            Browsers v = new Browsers();
            driver = v.launchBrowser("Edge");
            driver.Manage().Window.Maximize();
            test.Log(Status.Pass, "Browserlaunched");
            driver.Url = "https://accounts.google.com/signin/v2/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&service=mail&sacu=1&rip=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin";
            test.Log(Status.Pass, "UrlPassed");
            IWebElement email = driver.FindElement(By.Id("identifierId"));
            email.SendKeys("Abcd@gmail.com");
            
            IWebElement signin = driver.FindElement(By.XPath("//*[@id='identifierNext']/div/button"));
            signin.Click();
            Thread.Sleep(2000);
            string title = driver.Title;
            Assert.AreEqual("Gmail-log in", title);

        }
        [Test, Category("Regression Testing")]
        public void test5()
        {
            test = extent.CreateTest("login").Info("Test");
            Browsers v = new Browsers();
            driver = v.launchBrowser("Chrome");
            driver.Manage().Window.Maximize();
            test.Log(Status.Pass, "Browserlaunched");
            driver.Url = "https://accounts.google.com/signin/v2/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&service=mail&sacu=1&rip=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin";
            test.Log(Status.Pass, "UrlPassed");
            IWebElement email = driver.FindElement(By.Id("identifierId"));
            email.SendKeys("Abcd@gmail.com");

            IWebElement signin = driver.FindElement(By.XPath("//*[@id='identifierNext']/div/button"));
            signin.Click();
            Thread.Sleep(2000);
            string title = driver.Title;
            Assert.AreEqual("Gmail-log in", title);

        }
        [Test, Category("Regression Testing")]
        public void test6()
        {
            test = extent.CreateTest("login").Info("Test");
            Browsers v = new Browsers();
            driver = v.launchBrowser("Firefox");
            driver.Manage().Window.Maximize();
            test.Log(Status.Pass, "Browserlaunched");
            driver.Url = "https://accounts.google.com/signin/v2/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&service=mail&sacu=1&rip=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin";
            test.Log(Status.Pass, "UrlPassed");
            IWebElement email = driver.FindElement(By.Id("identifierId"));
            email.SendKeys("Abcd@gmail.com");

            IWebElement signin = driver.FindElement(By.XPath("//*[@id='identifierNext']/div/button"));
            signin.Click();
            Thread.Sleep(2000);
            string title = driver.Title;
            Assert.AreEqual("Gmail-log in", title);

        }
        [Test, Category("UAT Testing"),Category("Module1")]
        public void test7()
        {
            test = extent.CreateTest("login").Info("Test");
            Browsers v = new Browsers();
            driver = v.launchBrowser("Chrome");
            driver.Manage().Window.Maximize();
            test.Log(Status.Pass, "Browserlaunched");
            driver.Url = "https://accounts.google.com/signin/v2/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&service=mail&sacu=1&rip=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin";
            test.Log(Status.Pass, "UrlPassed");
            IWebElement email = driver.FindElement(By.Id("identifierId"));
            email.SendKeys("Abcd@gmail.com");

            IWebElement signin = driver.FindElement(By.XPath("//*[@id='identifierNext']/div/button"));
            signin.Click();
            Thread.Sleep(2000);
            string title = driver.Title;
            Assert.AreEqual("Gmail-log in", title);

        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void test8()
        {
            test = extent.CreateTest("login").Info("Test");
            Browsers v = new Browsers();
            driver = v.launchBrowser("Firefox");
            driver.Manage().Window.Maximize();
            test.Log(Status.Pass, "Browserlaunched");
            driver.Url = "https://accounts.google.com/signin/v2/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&service=mail&sacu=1&rip=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin";
            test.Log(Status.Pass, "UrlPassed");
            IWebElement email = driver.FindElement(By.Id("identifierId"));
            email.SendKeys("Abcd@gmail.com");

            IWebElement signin = driver.FindElement(By.XPath("//*[@id='identifierNext']/div/button"));
            signin.Click();
            Thread.Sleep(2000);
            string title = driver.Title;
            Assert.AreEqual("Gmail-log in", title);

        }
    }
}
