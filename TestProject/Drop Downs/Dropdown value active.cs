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
    class DropdownValuesActive
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.seleniumeasy.com/test/basic-select-dropdown-demo.html";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [Test]
        public void test()
        {
            IWebElement SelectaDay = driver.FindElement(By.Id("select-demo"));
            SelectaDay.Click();
            IList<IWebElement> values = SelectaDay.FindElements(By.TagName("Option"));
            Console.WriteLine("No of Days:" + " " + values.Count);
            for(int i=0;i< values.Count;i++)
            {
                string name = values.ElementAt(i).Text;
                values.ElementAt(i).Click();
                Thread.Sleep(2000);
                if(values.ElementAt(i).Displayed)
                {
                    Console.WriteLine(name + " " + "Active");
                }
                else
                {
                    Console.WriteLine(name + " " + "Deactive");
                }
            }

           

        }
        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }
    }
}
