using Microsoft.Office.Interop.Excel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Pom
{
    public class Pom
    {
        public IWebDriver driver;

        [Obsolete]
        public Pom(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "txtUsername")]
        public IWebElement Name { get; set; }

        

        [FindsBy(How = How.Id, Using = "txtPassword")]
        public IWebElement password { get; set; }



        [FindsBy(How = How.Id, Using = "btnLogin")]
        public IWebElement ok { get; set; }

        public void login(String u, String p)
        {   
            Name.SendKeys(u); 
            password.SendKeys(p);
            ok.Click();
        }


    }

}
