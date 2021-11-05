using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject.Text
{
    class CountofNormalTextandBoldText
    {
        IWebDriver driver;
        [SetUp]
        public void setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.javatpoint.com/c-sharp-out-parameter";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }
        [Test]
        public void test()
        {
            IList<IWebElement> ntext = driver.FindElements(By.TagName("P"));
            Console.WriteLine("No of normal text:" + " " + ntext.Count);
            IList<IWebElement> btext = driver.FindElements(By.TagName("H"));

            Console.WriteLine("No of bold text:" + " " + btext.Count);
        }

        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }
    }
}
