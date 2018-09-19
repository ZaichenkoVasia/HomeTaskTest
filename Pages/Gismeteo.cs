using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pages
{
    public class Gismeteo
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public Gismeteo(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        private IWebElement buttonTwoWeek
        {
            get
            {
                return this.driver.FindElement(By.XPath("//a[@href='/weather-kyiv-4944/14-days/']"));
            }
        }

        private IWebElement buttonPrint
        {
            get
            {
                return this.driver.FindElement(By.XPath("//a[@href='/ajax/print/4944/weekly/']"));
            }
        }
        public void Click()
        {
            this.buttonTwoWeek.Click();
            this.buttonPrint.Click();
        }

        public bool IsResult(string className)
        {
            try
            {
                var result = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(className)));
                return result != null;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}