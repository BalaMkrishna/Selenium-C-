using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TestProject.Frames
{
    class TextofFrames
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
            IList<IWebElement> frametext = driver.FindElements(By.TagName("iframe"));
            Console.WriteLine("No of Framestext:" + " " + frametext.Count);
            for (int i=0; i<frametext.Count;i++)
            {
                Console.WriteLine(frametext.ElementAt(i).GetAttribute("name"));
            }
            driver.Close();
        }
    }
}
