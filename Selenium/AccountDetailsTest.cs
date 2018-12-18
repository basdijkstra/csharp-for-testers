using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.Pages;

namespace Selenium
{
    [TestFixture]
    public class AccountDetailsTest
    {
        private IWebDriver driver;

        [SetUp]
        public void CreateBrowserInstance()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void SelectAccount_ShouldDisplayAccountDetails()
        {
            new LoginPage(driver).
                SetUserName("john").
                SetPassword("demo").
                ClickLogin();
            
            // VOEG TOE
            // Klikactie op de Accounts Overview-pagina die de
            // rekening met nummer 12345 selecteert. Gebruik de methode
            // SelectAccount() uit AccountsOverviewPage hiervoor

            // Pas ook de assertion hieronder aan, nu moet er gecontroleerd
            // worden of de AccountDetails-pagina is geladen...

            Assert.That(new AccountsOverviewPage(driver).PageIsLoaded(), Is.True);
        }

        [TearDown]
        public void CloseBrowserInstance()
        {
            driver.Quit();
        }
    }
}
