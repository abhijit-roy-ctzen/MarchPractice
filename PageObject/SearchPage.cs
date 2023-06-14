using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
//using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;
using SeleniumExtras.PageObjects;
//using OpenQA.Selenium.Support.PageObjects;

namespace MarchPractice.PageObject
{
    public class SearchPage
    {
        IWebDriver driver;
        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;

            PageFactory.InitElements(driver,this);

        }

        [FindsBy(How = How.Name, Using = "search_query")]
        public IWebElement Searchtextbox { get; set; }

        [FindsBy(How = How.Id, Using = "search-icon-legacy")]
        public IWebElement SearchButton { get; set; }

        public ResultPage NavigateToResultPage()
        {
            Searchtextbox.SendKeys("Interview Point");
            SearchButton.Click();
            return new ResultPage(driver);
        }
    }
}
