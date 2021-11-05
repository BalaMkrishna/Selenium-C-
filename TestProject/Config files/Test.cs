using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Threading;

namespace TestProject.Config_files
{
    class Test
    {
        IWebDriver driver;



        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();




        }



        [Test]
        public void Test1()
        {
            //driver = new ChromeDriver();
            driver.Url = "https://opensource-demo.orangehrmlive.com/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            IWebElement Name = driver.FindElement(By.Id("txtUsername"));
            var name = ConfigurationManager.AppSettings["Username"];
            Name.SendKeys(name);
            IWebElement pwd = driver.FindElement(By.Id("txtPassword"));
            var pass = ConfigurationManager.AppSettings["password"];
            pwd.SendKeys(pass);
            driver.FindElement(By.Id("btnLogin")).Click();
            Thread.Sleep(2000);
            driver.Close();
        }

    }  
}
