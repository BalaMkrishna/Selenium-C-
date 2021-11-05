using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TestProject.Drop_Downs
{
    class SelectValueDropdown
    {
        IWebDriver driver;
        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.seleniumeasy.com/test/basic-select-dropdown-demo.html";
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

        }

        [Test]
        public void Selectvaluedropdown()
        {

            IWebElement Others = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/nav/div/div[2]/ul[2]/li[4]/a"));
            Others.Click();
            Thread.Sleep(1000);
            IList<IWebElement> values = Others.FindElements(By.XPath("/html/body/div[1]/div[2]/nav/div/div[2]/ul[2]/li[4]/ul"));
            Console.WriteLine("no of total values" + "" + values.Count);
            for (int i = 0; i < values.Count; i++)
            {
                Console.WriteLine(values.ElementAt(i).Text);

            }

        }
        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }
    }
}
