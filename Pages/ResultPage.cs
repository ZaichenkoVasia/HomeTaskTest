using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Pages
{
    public class SearchPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        private IWebElement button
        {
            get
            {
                return this.driver.FindElement(By.XPath("//a[@href='https://www.gismeteo.ua/weather-kyiv-4944/']"));
            }
        }

        public Gismeteo Click()
        {
            this.button.Click();
            return new Gismeteo(this.driver);
        }
    }
}