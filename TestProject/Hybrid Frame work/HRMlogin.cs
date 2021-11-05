using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestProject.Hybrid_Frame_work
{
    class HRMlogin
    {
        IWebDriver driver;
        public HRMlogin(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "txtUsername")]
        public IWebElement Name { get; set; }

        [FindsBy(How = How.Id, Using = "txtPassword")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "btnLogin")]
        public IWebElement OK { get; set; }

        public void login(string u, string p)
        {
            Name.Clear();
            Name.SendKeys(u);
            Password.Clear();
            Password.SendKeys(p);
            OK.Click();
            Thread.Sleep(2000);
            
        }
    
    }
}
