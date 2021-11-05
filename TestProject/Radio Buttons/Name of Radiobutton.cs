using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TestProject.Radio_Buttons
{
    class NameofRadiobuttons
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
            IList<IWebElement> radiobutton = driver.FindElements(By.XPath("//input[@type='radio']"));
            Console.WriteLine("No of Radio buttons:" + " " + radiobutton.Count);
          

            for (int i=0; i< radiobutton.Count; i++)
            {
                Console.WriteLine(radiobutton.ElementAt(i).GetAttribute("name"));
            }
            driver.Close();

        }
    }
}
