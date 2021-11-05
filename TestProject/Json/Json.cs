using Newtonsoft.Json;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestProject.Json;

namespace TestProject.Pom
{
    class Json
    {
        public IWebDriver driver;

        [Test]
        [Obsolete]
        public void TestMethod()
        {

            driver = new ChromeDriver();

            driver.Url = "https://opensource-demo.orangehrmlive.com";
            driver.Manage().Window.Maximize();
            var page = new Pom(driver);
            var Rootobj = new Rootobject();
            using (StreamReader r = new StreamReader(@"C:\Users\BalamaniKrishna\source\repos\TestProject\TestProject\Json\Read.json"))
            {
                string json = r.ReadToEnd();
                Rootobj = JsonConvert.DeserializeObject<Rootobject>(json);
            }
            page.login(Rootobj.Username, Rootobj.Password);

            Thread.Sleep(2000);
            driver.Close();

        }
    }
}
    
