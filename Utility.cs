using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarchPractice
{
    public class Utility
    {
        public static string CaptureScreen(IWebDriver driver, string filename)
        {
            ITakesScreenshot screenshot = (ITakesScreenshot)driver;
            Screenshot ss = screenshot.GetScreenshot();
            string path = "google" + DateTime.Now.ToString("yyyy-MM-dd--HH_mm_ss");
            string filepath = @"C:\Users\AbhijitR\source\repos\MarchPractice\Screenshots/" + path + ".png";
            ss.SaveAsFile(filepath);
            return filepath;
        }

        internal static void CaptureScreen()
        {
            throw new NotImplementedException();
        }
    }
}
