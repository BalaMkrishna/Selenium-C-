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
    class DoubleClick
    {
        IWebDriver driver;
        [SetUp]
        public void setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
        }
        [Test]
        public void Doubleclick()
        {

            IWebElement Gsearch = driver.FindElement(By.Name("q"));
            Actions Ac = new Actions(driver);
            Ac.DoubleClick(Gsearch).Build().Perform();
            Thread.Sleep(1000);

        }
        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }
    }
}
