using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject.Windows_handle
{
    class windowshandle
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
                driver.Url = "http://demo.automationtesting.in/Windows.html";
                driver.Manage().Window.Maximize();
                IWebElement tabedwindow = driver.FindElement(By.XPath("//*[@id='Tabbed']/a/button"));
            tabedwindow.Click();
               /* foreach (var item in driver.WindowHandles)
                {
                    Console.WriteLine(item);
                }*/
                driver.SwitchTo().Window(driver.WindowHandles[1]);
                Console.WriteLine("Current window title :" + " " + driver.Title);
                driver.SwitchTo().Window(driver.WindowHandles[0]);
                Console.WriteLine("Previous window title :" + " " + driver.Title);
                Thread.Sleep(2000);
                driver.Quit();
        }

    } 
}

    

