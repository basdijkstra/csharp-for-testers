using Helpers;
using OpenQA.Selenium;

namespace SeleniumAnswers.Pages
{
    public class AdminPage : BasePage
    {
        private By TextlabelPageHeader = By.XPath("//h1[@class='title' and contains(text(),'Administration')]");

        public AdminPage(IWebDriver driver) : base(driver)
        {
        }

        public bool PageIsLoaded()
        {
            return SeleniumHelpers.ElementIsVisible(_driver, TextlabelPageHeader);
        }
    }
}
