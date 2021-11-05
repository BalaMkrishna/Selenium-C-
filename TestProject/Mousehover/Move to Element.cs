using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject.Mousehover
{
    class MovetoElement
    {
        IWebDriver driver;
        [SetUp]
        public  void setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.lambdatest.com/blog/selenium-c-tutorial-handling-alert-windows/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
        }
        [Test]
        public void test()
        {
            Actions Ac = new Actions(driver);
            IWebElement link = driver.FindElement(By.XPath("/html/body/header/nav/div/div[2]/ul/li[4]/a"));
            Ac.MoveToElement(link).Build().Perform();
            Thread.Sleep(2000);
        }
        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }
    }
}
