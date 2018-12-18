using Helpers;
using OpenQA.Selenium;

namespace Selenium.Pages
{
    public class LoginPage : BasePage
    {
        private readonly By TextfieldUsername = By.Name("username");
        private readonly By TextfieldPassword = By.Name("password");
        private readonly By ButtonLogin = By.XPath("//input[@value='Log In']");
        private readonly By TextlabelErrorMessage = By.XPath("//p[@class='error']");
        
        public LoginPage(IWebDriver driver) : base(driver)
        {
            driver.Navigate().GoToUrl("http://parabank.parasoft.com");
        }

        public LoginPage SetUserName(string userName)
        {
            SeleniumHelpers.SendKeys(_driver, TextfieldUsername, userName);
            return this;
        }

        public LoginPage SetPassword(string password)
        {
            SeleniumHelpers.SendKeys(_driver, TextfieldPassword, password);
            return this;
        }

        public void ClickLogin()
        {
            SeleniumHelpers.Click(_driver, ButtonLogin);
        }

        public bool ErrorMessageIsVisible()
        {
            return SeleniumHelpers.ElementIsVisible(_driver, TextlabelErrorMessage);
        }
    }
}
