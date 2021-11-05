using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestProject.Base;
using excel = Microsoft.Office.Interop.Excel;

namespace TestProject.Hybrid_Frame_work
{
   public class Hybrid:Base1
    {
        [Test]
        public void test1()
        {
            test = extent.CreateTest("login").Info("Test");
            driver = new ChromeDriver();
            test.Log(Status.Pass, "Chromelaunched");
            driver.Url = "https://opensource-demo.orangehrmlive.com/";
            test.Log(Status.Pass, "UrlPassed");
            driver.Manage().Window.Maximize();
          
            var page1 = new HRMlogin(driver);
            
            excel.Application x = new excel.Application();
            excel.Workbook y = x.Workbooks.Open("C:\\excel\\Testdata.xlsx");
            excel.Worksheet z = (excel.Worksheet)y.Sheets[1];
            excel.Range valuerange = z.UsedRange;
            
            int sw = valuerange.Rows.Count;
            
            for (int i=2; i<=valuerange.Rows.Count;i++)
            {
                string Username=Convert.ToString((valuerange.Cells[i,1]as excel.Range).Value2);
                string password = Convert.ToString((valuerange.Cells[i, 2] as excel.Range).Value2);
                page1.login(Username, password);
                Thread.Sleep(100);
                driver.Navigate().Back();
                Thread.Sleep(1000);
            }
        }

    }
}
