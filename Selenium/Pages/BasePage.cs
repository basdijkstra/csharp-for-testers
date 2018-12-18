using OpenQA.Selenium;

namespace Selenium.Pages
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

        // Voeg een methode toe die naar de Admin Page navigeert door
        // op de link te klikken. Geef de methode een praktische naam
    }
}
