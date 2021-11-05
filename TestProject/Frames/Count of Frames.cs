using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject.Frames
{
    class CountofFrames
    {
        IWebDriver driver;
        [SetUp]
        public void setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.timeanddate.com/worldclock/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }
        [Test]
        public void test()
        {
            IList<IWebElement> framecount = driver.FindElements(By.TagName("iframe"));
            Console.WriteLine("No of Frames:" + " " + framecount.Count);
            driver.Close();
        }
        
    }
}
