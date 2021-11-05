using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;
using Microsoft.Edge.SeleniumTools;

namespace TestProject.Cross_Browser
{
    public class MultiBrowser
    {
        IWebDriver driver;

        [Test]
        public void chrome()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.lambdatest.com/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.Close();
        }

        [Test]
        public void firefox()
        {
            driver = new FirefoxDriver();
            driver.Url = "https://www.lambdatest.com/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.Close();
        }

        [Test]
        public void edge()
        {
            var edgeOptions = new EdgeOptions();
            edgeOptions.UseChromium = true;

            IWebDriver driver = new EdgeDriver(@"C:\Users\BalamaniKrishna\source\repos\TestProject\TestProject\Cross Browser\", edgeOptions);
            driver.Url = "https://www.lambdatest.com/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.Close();
        }
    }
}
