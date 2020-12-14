using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Diagnostics;
using System.Threading;

namespace SpecMSNUnit.Utilities
{
    public class Utility
    {
        IWebDriver driver = null;
        public Utility()
        {

        }
        public Utility(IWebDriver webdriver)
        {
            driver = webdriver;
        }

        public void NavigateToURL(String url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public void TakeScreenShot()
        {
            DateTime time = DateTime.Now;
            string dateToday = "_date_" + time.ToString("yyyy-MM-dd") + "_time_" + time.ToString("HH-mm-ss");
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile("C:\\Users\\sindhu.diddi\\source\\repos\\SpecMSNUnit\\SpecMSNUnit\\Screenshots\\"+ dateToday +".png", ScreenshotImageFormat.Png);
        }
       

        public IWebElement GetElement(By locator)
        {
            try
            {
                IWebElement element = driver.FindElement(locator);
                return element;

            }
            catch (NoSuchElementException e)
            {
                Thread.Sleep(2000);
                IWebElement element = driver.FindElement(locator);

                return element;
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }

        }
       
       public void SlideToNextWindow(IWebElement element)
        {
            string originalWindow = driver.CurrentWindowHandle;
            Assert.AreEqual(driver.WindowHandles.Count, 1);
            element.Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(wd => wd.WindowHandles.Count == 2);

            foreach (string window in driver.WindowHandles)
            {
                if (originalWindow != window)
                {
                    driver.SwitchTo().Window(window);
                    break;
                }
            }
        }
        
        public void ScrollToElement(IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", element);
        }
        public void ScrollToElement(By locatore)
        {
            IWebElement element = GetElement(locatore);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", element);
        }

        public void SlideToNextWindow(By locator)
        {
            string originalWindow = driver.CurrentWindowHandle;
            Assert.AreEqual(driver.WindowHandles.Count, 1);
            IWebElement element = GetElement(locator);
            element.Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(wd => wd.WindowHandles.Count == 2);

            foreach (string window in driver.WindowHandles)
            {
                if (originalWindow != window)
                {
                    driver.SwitchTo().Window(window);
                    break;
                }
            }
        }
        public void Click(IWebElement element)
        {
            element.Click();
        }
        public void Click(By locator)
        {
            IWebElement element = GetElement(locator);
            element.Click();
        }
        public void EnterText(IWebElement element, String value)
        {
            element.SendKeys(value);
        }
        public void EnterText(By locator, String value)
        {
            IWebElement element = GetElement(locator);
            element.SendKeys(value);
        }
        public void WaitForTheElement(By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(e => GetElement(locator));
        }
        public void WaitForTheElement(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(e => element);
        }
        public void Asserting(String value)
        {
            String val = driver.Title;
            Debug.Assert(val.Equals(value));
        }
        public void Asserting(IWebElement element ,String value)
        {
            Debug.Assert(element.Text.Equals(value));
        }
        public void Asserting(By locator,String value)
        {
            IWebElement element = GetElement(locator);
            Debug.Assert(element.Text.Equals(value));
        }
        public IWebDriver OpenBroswer(String browser)
        {

            switch (browser.ToLower())
            {
                case "chrome":
                    driver = new ChromeDriver();
                    break;
                default:
                    Console.WriteLine("Choosed Invalid browser");
                    break;
            }
            return driver;
        }
    }
}


