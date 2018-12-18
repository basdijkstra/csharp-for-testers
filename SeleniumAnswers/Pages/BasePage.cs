using Helpers;
using OpenQA.Selenium;

namespace SeleniumAnswers.Pages
{
    public class BasePage
    {
        public IWebDriver _driver;

        private readonly By LinkToAdminPage = By.LinkText("Admin Page");

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateTo(string urlToGoTo)
        {
            _driver.Navigate().GoToUrl(urlToGoTo);
        }

        public void OpenAdminPage()
        {
            SeleniumHelpers.Click(_driver, LinkToAdminPage);
        }
    }
}
