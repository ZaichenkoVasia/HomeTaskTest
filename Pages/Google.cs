using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Pages
{
    public class Google
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        private readonly string url = @"https://www.google.com.ua";

        private IWebElement search
        {
            get { return this.driver.FindElement(By.Name("q")); }
        }

        private IWebElement btn
        {
            get { return this.driver.FindElement(By.Name("btnK")); }
        }

        private IWebElement img
        {
            get { return this.driver.FindElement(By.Id("hplogo")); }
        }

        public Google(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void NavigateToGoogle()
        {
            this.driver.Navigate().GoToUrl(this.url);
        }

        public void SearchText(string txt)
        {
            search.Clear();
            search.SendKeys(txt);
        }

        public SearchPage Click()
        {
            this.img.Click();
            this.btn.Click();
            return new SearchPage(this.driver);
        }
    }
}

