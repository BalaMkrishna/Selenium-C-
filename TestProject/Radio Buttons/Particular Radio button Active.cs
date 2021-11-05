using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject.Radio_Buttons
{
    class ParticularRadiobuttonActive
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
            driver.Url = "https://www.seleniumeasy.com/test/basic-radiobutton-demo.html";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            IWebElement male = driver.FindElement(By.Name("optradio"));

            male.Click();
            if(male.Selected)
            {
                Console.WriteLine("Working Successfully");
            }
            else
            {
                Console.WriteLine("Not Working Successfully");
            }
            driver.Close();
        }
    }
}
