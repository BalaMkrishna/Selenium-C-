  using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject.Drop_Downs
{
    class CountofDropDowns
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.mercurytravels.co.in/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [Test]
        public void test()
        {
            IList<IWebElement> dropdown = driver.FindElements(By.TagName("select"));
            Console.WriteLine("No of Dropdowns:" + " " + dropdown.Count);
        }

        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }
    }
    }

