using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Screenshots
{
    class Getsc
    {
        public static string Capture(IWebDriver driver, String screenShotName)
        {
            ITakesScreenshot sc = (ITakesScreenshot)driver;
            Screenshot screenshot = sc.GetScreenshot();
            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string finalpth = pth.Substring(0, pth.LastIndexOf("bin")) + "ErrorScreenshot\\" + screenShotName + " .Png";
            string localpath = new Uri(finalpth).LocalPath;
            screenshot.SaveAsFile(localpath, ScreenshotImageFormat.Png);
            return localpath;

        }
    }
}
