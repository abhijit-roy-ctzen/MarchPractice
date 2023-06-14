using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using AventStack.ExtentReports.Reporter;

namespace MarchPractice
{
    [TestFixture]
   public class SeleniumCsharp
    {
        ChromeDriver driver;
        ExtentReports extent = null;
        //ChromeDriver driver;
        [OneTimeSetUp]
        public void ExtentStart()
        {
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\AbhijitR\source\repos\MarchPractice\ExtentReports\SeleniumCsharp.html");
            extent.AttachReporter(htmlReporter);
        }
        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush();
        }
        [Test]
    
        public void Test1()

        {
            
            ExtentTest test = null;
            try
            {
                test = extent.CreateTest("Test1").Info("Test Started");
                driver = new ChromeDriver();
                driver.Url = "https://www.google.com/";
                driver.Manage().Window.Maximize();
                test.Log(Status.Info, "Browser launched");
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                driver.FindElement(By.Name("q")).SendKeys("SeleniumSS");
                test.Log(Status.Info, "details filled");
                Thread.Sleep(2000);

                //click on search button

                driver.FindElement(By.Name("btnK")).Click();
                Thread.Sleep(2000);
                driver.Navigate().Back();
                Thread.Sleep(2000);
                driver.Close();
                test.Log(Status.Pass, "Test1 Passed");

                

            }
            catch (Exception e)
            {
               
                Console.WriteLine(e.StackTrace);

                throw;
            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }


        }

       
    }
}
