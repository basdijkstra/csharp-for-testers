using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Helpers
{
    public class SeleniumHelpers
    {
        public static void SendKeys(IWebDriver driver, By by, string valueToType)
        {
            try
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementToBeClickable(by));
                driver.FindElement(by).Clear();
                driver.FindElement(by).SendKeys(valueToType);
            }
            catch (Exception ex) when (ex is NoSuchElementException || ex is WebDriverTimeoutException)
            {
                Console.WriteLine("Could not find element within the given timeout period: " + by.ToString());
                throw;
            }
            catch (Exception ex) when (ex is StaleElementReferenceException)
            {
                Console.WriteLine("Element went stale: " + by.ToString());
                throw;
            }
        }

        public static void Click(IWebDriver driver, By by)
        {
            try
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementToBeClickable(by));
                driver.FindElement(by).Click();
            }
            catch (Exception ex) when (ex is NoSuchElementException || ex is WebDriverTimeoutException)
            {
                Console.WriteLine("Could not find element within the given timeout period: " + by.ToString());
                throw;
            }
            catch (Exception ex) when (ex is StaleElementReferenceException)
            {
                Console.WriteLine("Element went stale: " + by.ToString());
                throw;
            }
        }

        public static bool ElementIsVisible(IWebDriver driver, By by)
        {
            try
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible((by)));
            }
            catch (Exception ex) when (ex is NoSuchElementException || ex is WebDriverTimeoutException)
            {                
                return false;
            }
            return true;
        }
    }
}
