using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TestProject.Checkboxes
{
    class StatusofCheckbox
    {
        IWebDriver driver;
        [SetUp]
        public void setup()
        {
            driver = new ChromeDriver();
        }
        [Test]
        public void test1()
        {
            driver.Url = "https://www.spicejet.com/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            IList<IWebElement> checkboxes = driver.FindElements(By.XPath("//input[@type='checkbox']"));
            Console.WriteLine("no of checkboxes " + "" + checkboxes.Count);
            IWebElement UnaccompaniedMinor = driver.FindElement(By.Id("ctl00_mainContent_chk_Unmr"));

            UnaccompaniedMinor.Click();
            Thread.Sleep(1000);



            for (int i = 0; i < checkboxes.Count; i++)
            {
                string bname = checkboxes.ElementAt(i).GetAttribute("name");
                if (checkboxes.ElementAt(i).Selected)
                {
                    Console.WriteLine(bname + " " + "Active");
                }
                else
                {
                    Console.WriteLine(bname + " " + "Notactive");
                }
                
            }
            driver.Close();
        }
    }
}
