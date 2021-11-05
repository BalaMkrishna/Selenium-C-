using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject.Radio_Buttons
{
    class CountofRadioButtons
    {
        IWebDriver driver;

        [SetUp]
        public void setup ()
        {
            driver = new ChromeDriver();
        }
        [Test]
        public void test()
        {
            driver.Url = "https://www.seleniumeasy.com/test/basic-radiobutton-demo.html";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            IList<IWebElement> radiobutton = driver.FindElements(By.XPath("//input[@type='radio']"));
            Console.WriteLine("No of Radiobuttons:" + " " + radiobutton.Count);
            driver.Close();

        }
    }
}
