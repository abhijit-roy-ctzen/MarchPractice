using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
//using OpenQA.Selenium;
using System;
using System.Threading;
using System.Collections;
using MarchPractice;

namespace MyNunitProject
{
    [TestFixture]

    public class Tests

    {

        ChromeDriver driver;
        [Test]
        [TestCaseSource("DataDrivenTesting")]

        public void Test1(string urlName)

        {
            try
            {
                driver = new ChromeDriver();

                driver.Url = urlName;
                //driver.Url = "https://www.google.com/";

                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                driver.FindElement(By.Name("q")).SendKeys("Selenium");

                Thread.Sleep(2000);

                //click on search button

                driver.FindElement(By.Name("btnK")).Click();
                Thread.Sleep(2000);
                driver.Navigate().Back();
                Thread.Sleep(2000);

                driver.Close();

            }
            catch (Exception e)
            {
                Utility.CaptureScreen(driver, "google");
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

        static IList DataDrivenTesting()
        {
            ArrayList list = new ArrayList();
            list.Add("https://www.google.com/");
            //list.Add("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            //list.Add("https://www.youtube.com/");

            return list;
        }

    }
}

