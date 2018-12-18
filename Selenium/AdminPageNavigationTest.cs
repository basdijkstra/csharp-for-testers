using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.Pages;

namespace Selenium
{
    [TestFixture]
    public class AdminPageNavigationTest
    {
        private IWebDriver driver;

        [SetUp]
        public void CreateBrowserInstance()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void OpenAdminPageFromHomePage_ShouldWork()
        {
            // Roep de eerder gemaakte base page-methode hier aan
            // Als het goed is, is deze ook beschikbaar voor de LoginPage
            new LoginPage(driver);
            
            Assert.That(new AdminPage(driver).PageIsLoaded(), Is.True);
        }

        [Test]
        public void OpenAdminPageFromAccountsOverviewPage_ShouldWork()
        {
            new LoginPage(driver).
                SetUserName("john").
                SetPassword("demo").
                ClickLogin();

            // Roep de eerder gemaakte base page-methode hier aan
            // Als het goed is, is deze ook beschikbaar voor de
            // AccountsOverviewPage
            new AccountsOverviewPage(driver);

            Assert.That(new AdminPage(driver).PageIsLoaded(), Is.True);
        }

        [TearDown]
        public void CloseBrowserInstance()
        {
            driver.Quit();
        }
    }
}
