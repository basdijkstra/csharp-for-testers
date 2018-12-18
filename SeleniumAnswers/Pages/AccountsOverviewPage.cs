using Helpers;
using OpenQA.Selenium;

namespace SeleniumAnswers.Pages
{
    public class AccountsOverviewPage : BasePage
    {
        public AccountsOverviewPage(IWebDriver driver) : base(driver)
        {
        }

        private By TextlabelPageHeader = By.XPath("//h1[@class='title' and text()='Accounts Overview']");

        public bool PageIsLoaded()
        {
            return SeleniumHelpers.ElementIsVisible(_driver, TextlabelPageHeader);
        }

        public AccountDetailsPage SelectAccount(string accountNumber)
        {
            SeleniumHelpers.Click(_driver, By.LinkText(accountNumber));
            return new AccountDetailsPage(_driver);
        }
    }
}
