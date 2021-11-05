using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject.Checkboxes
{
    class CountofCheckboxes
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
            driver.Url = "https://www.irctc.co.in/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            IList<IWebElement> checkboxes=driver.FindElements(By.XPath("//input[@type='checkbox']"));
            Console.WriteLine("no of total checkboxes:" + " " + checkboxes.Count);
            driver.Close();

        }
    }
}
