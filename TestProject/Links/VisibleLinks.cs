using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TestProject.Links
{
    class VisibleLinks
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test()

        {

            driver.Url = "https://www.mercurytravels.co.in/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            IList<IWebElement> links = driver.FindElements(By.TagName("a"));
            int Count = 0;
            for (int i=0; i < links.Count(); i++) 
            {
            if (links.ElementAt(i).Displayed)
                {
                    Count++;

                }

            }
            Console.WriteLine("No of total links:" + " " + links.Count());
            Console.WriteLine("No of visibled links:" + " " + Count);
            Console.WriteLine("No of visibled links:" + " " + (links.Count() - Count));


            driver.Close();
        }

       

          

    }

   
}
