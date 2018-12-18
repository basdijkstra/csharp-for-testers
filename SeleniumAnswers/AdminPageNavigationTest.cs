using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumAnswers.Pages;

namespace SeleniumAnswers
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
            new LoginPage(driver).
                OpenAdminPage();
            
            Assert.That(new AdminPage(driver).PageIsLoaded(), Is.True);
        }

        [Test]
        public void OpenAdminPageFromAccountsOverviewPage_ShouldWork()
        {
            new LoginPage(driver).
                SetUserName("john").
                SetPassword("demo").
                ClickLogin();

            new AccountsOverviewPage(driver).
                OpenAdminPage();

            Assert.That(new AdminPage(driver).PageIsLoaded(), Is.True);
        }

        [TearDown]
        public void CloseBrowserInstance()
        {
            driver.Quit();
        }
    }
}
