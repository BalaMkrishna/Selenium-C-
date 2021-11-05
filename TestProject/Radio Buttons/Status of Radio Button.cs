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
    class StatusofRadiobutton
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
            Console.WriteLine("No of radio buttons:" + " " + radiobutton.Count);
            IWebElement male = driver.FindElement(By.XPath("//*[@id='easycont']/div/div[2]/div[2]/div[2]/div[2]/label[3]/input"));
            male.Click();
            Thread.Sleep(1000);
            for (int i=0;i< radiobutton.Count; i++)
            {
                string nname = radiobutton.ElementAt(i).GetAttribute("name");
               
                if (radiobutton.ElementAt(i).Selected) 
                {
                    Console.WriteLine(nname + " " + "Active");
                }
                else
                {
                    Console.WriteLine(nname + " " + " Deactive");
                }
               
            }
            driver.Close();
        }
    }
    
}
