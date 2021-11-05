using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace TestProject.Links
{
    class ActualTitle
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }
       
        [Test]
        public void test()
        {
            
            driver.Url = "https://www.mercurytravels.co.in/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            IWebElement title = driver.FindElement(By.Id("duration_d"));
            title.Click();
            Thread.Sleep(2000);
            string expected = "Select Duration";
            string actual = driver.Title;
            Console.WriteLine(actual);
            if
                (expected.Contains(actual)) 
            {
                Console.WriteLine("pass"); 
            }
            else
            {
                Console.WriteLine("fail");
            }

            driver.Close();
        }
    }
}
