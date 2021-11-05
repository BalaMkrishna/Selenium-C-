using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TestProject.Links
{
    class HeaderLinks
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
            driver.Url = "https://www.google.com/";
            driver.Navigate().GoToUrl("https://www.youtube.com/");

            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            IWebElement header = driver.FindElement(By.Id("container"));

            IList<IWebElement> headerlinks = header.FindElements(By.TagName("a"));


            for (int i = 0; i < headerlinks.Count(); i++)
            {


                Console.WriteLine(headerlinks.ElementAt(i).Text);
            }

            driver.Quit();
        }
    }
}
