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
    class DragandDrop
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://jqueryui.com/droppable/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
        }
        [Test]
        public void test()
        {
            Actions AC = new Actions(driver);
            driver.SwitchTo().Frame(0);
            IWebElement drag = driver.FindElement(By.Id("draggable"));
            IWebElement drop = driver.FindElement(By.Id("droppable"));
            AC.DragAndDrop(drag, drop).Build().Perform();
            Thread.Sleep(2000);
        }
        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }



    }
}
