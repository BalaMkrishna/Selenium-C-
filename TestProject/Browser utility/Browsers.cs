using Microsoft.Edge.SeleniumTools;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Base2
{
   public  class Browsers
    {
        

        public  IWebDriver driver;
          
         public IWebDriver launchBrowser(string browser)
            {
                if (browser.Equals("Chrome"))
                {
                    driver = new ChromeDriver();
                    driver.Manage().Window.Maximize();
            }
                else if (browser.Equals("Firefox"))
                {
                   
                    driver = new FirefoxDriver();
                    driver.Manage().Window.Maximize();
                }

               
                else if (browser.Equals("Edge"))
                {
                    var edgeOptions = new EdgeOptions();
                    edgeOptions.UseChromium = true;
                    driver = new EdgeDriver(@"C:\Users\BalamaniKrishna\source\repos\TestProject\TestProject\Cross Browser\", edgeOptions);
                    driver.Manage().Window.Maximize();
            }
                return driver;
            }
        }



        
    }

