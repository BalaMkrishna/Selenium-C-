using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject.Text
{
    class VerifyNormltextandBoldtext
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
            IWebElement text = driver.FindElement(By.XPath("/html/body/div/div/div[6]/div[2]/div[1]/table/tbody/tr/td/p[3]"));
            string expected = "p";
            string actual = text.TagName;
            if (expected.Equals(actual))
            {
                Console.WriteLine("Normal Text");
            }
            else
            {
                Console.WriteLine("Bold Text");
            }
        }
        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }
    }
}
