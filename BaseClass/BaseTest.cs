using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MarchPractice.BaseClass
{
   public class BaseTest
    {
       public IWebDriver driver;
       // ChromeDriver driver;
        [SetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.youtube.com/";
            //Thread.Sleep(5000);
        }
        [TearDown]
        public void Close()
        {
            driver.Quit();
        }
        
    }
}
