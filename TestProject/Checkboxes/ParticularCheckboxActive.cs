using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject.Checkboxes
{
    class ParticularCheckboxActive
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
            driver.Url = "https://www.spicejet.com/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            IWebElement UnaccompaniedMinor = driver.FindElement(By.Id("ctl00_mainContent_chk_Unmr"));

            UnaccompaniedMinor.Click();
            Thread.Sleep(1000);
         

            if (UnaccompaniedMinor.Selected) 
            {

                Console.WriteLine("Working Successfully");
            }
            else
            {
                Console.WriteLine("not Working Successfully");
            }
            driver.Close();
        }
    

    }
}
