using Helpers;
using OpenQA.Selenium;

namespace SeleniumAnswers.Pages
{
    public class AccountDetailsPage : BasePage
    {
        public AccountDetailsPage(IWebDriver driver) : base(driver)
        {
        }

        private By TextlabelPageHeader = By.XPath("//h1[@class='title' and text()='Account Details']");

        public bool PageIsLoaded()
        {
            return SeleniumHelpers.ElementIsVisible(_driver, TextlabelPageHeader);
        }
    }
}
