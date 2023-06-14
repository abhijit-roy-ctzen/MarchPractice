using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using MarchPractice.BaseClass;
using MarchPractice.PageObject;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace MarchPractice.TestScripts
{
    [TestFixture]
    public class Module1: BaseTest
    {
        [Test]
        public void Testmethod1()
        {
          var searchpage =  new SearchPage(driver);
           var resultpage = searchpage.NavigateToResultPage();
            //resultpage.NavigateTochannel();     
            //var channelname = resultpage.NavigateTochannel();
          var channelname =  resultpage.NavigateToChannel();
            String actualChannelName = channelname.getChannelName();
            String expectedChannelName = "Interview Point";
            Assert.IsTrue(actualChannelName.Equals(expectedChannelName));
            Thread.Sleep(3000);



           // Thread.Sleep(5000);

        }
    }
}
