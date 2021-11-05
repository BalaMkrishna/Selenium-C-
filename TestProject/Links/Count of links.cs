using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading;
using TestProject.Base;
using TestProject.Base2;

namespace TestProject
{
  
    public class Countoflinks
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
            driver.Url = "https://www.facebook.com/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
            IList<IWebElement> links = driver.FindElements(By.TagName("a"));
            Assert.That(links.Count(), Is.EqualTo(46));
            driver.Quit();

        }
    }
}