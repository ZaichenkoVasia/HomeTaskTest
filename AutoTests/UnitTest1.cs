using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Pages;

namespace Tests
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void Test1()
        {
            using (IWebDriver driver = new ChromeDriver(@"D:\"))
            {
                Google google = new Google(driver);
                google.NavigateToGoogle();
                google.SearchText("gismeteo");
                Thread.Sleep(2000);
                SearchPage search = google.Click();
                Thread.Sleep(2000);
                Gismeteo gismeteo = search.Click();
                Thread.Sleep(2000);
                gismeteo.Click();
                Thread.Sleep(2000);
                bool result = gismeteo.IsResult("list_2week");
                Assert.True(result);
            }
        }
    }
}