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
    class ClickandHold
    {
        IWebDriver driver;
       [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://jqueryui.com/slider/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
        }
        [Test]
        public void test()
        {
            Actions Ac = new Actions(driver);
            driver.SwitchTo().Frame(0);
            IWebElement slider = driver.FindElement(By.Id("slider"));
            int widthslider = slider.Size.Width;
            Actions AC = new Actions(driver);
            AC.ClickAndHold(slider);
            AC.MoveByOffset(60, 70).Build().Perform();
            Thread.Sleep(2000);
        }
        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }
    }
}
