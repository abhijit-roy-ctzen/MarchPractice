using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MarchPractice.PageObject
{
    public class ChannelPage
    {
        IWebDriver driver;
        public ChannelPage(IWebDriver driver)
        {
            this.driver = driver;

            PageFactory.InitElements(driver, this);

        }

        [FindsBy(How = How.XPath, Using = "/html/body/ytd-app/div[1]/ytd-page-manager/ytd-browse[2]/div[3]/ytd-c4-tabbed-header-renderer/tp-yt-app-header-layout/div/tp-yt-app-header/div[2]/div[2]/div/div[1]/div/div[1]/ytd-channel-name/div/div/yt-formatted-string")]
        
        public IWebElement ChannelName { get; set; }
        public string getChannelName()
        {
            Thread.Sleep(4000);
            return ChannelName.Text;
        }
    }
}

