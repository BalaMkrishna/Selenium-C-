using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject.Images
{
    class CountofImages
    {
        IWebDriver driver;
        [SetUp]
        public void setup()
        {
            driver = new ChromeDriver();
        }
        [Test]
        public void test()
        {
            driver.Url = "https://www.amazon.in/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            IList<IWebElement> images = driver.FindElements(By.TagName("img"));
            Console.WriteLine("No of Images:" + " " + images.Count);
        }
        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }
    }
}
