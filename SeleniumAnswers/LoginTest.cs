using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumAnswers.Pages;

namespace SeleniumAnswers
{
    [TestFixture]
    public class LoginTest
    {
        private IWebDriver driver;

        [SetUp]
        public void CreateBrowserInstance()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void LoginSucceedsTest()
        {
            new LoginPage(driver).
                SetUserName("john").
                SetPassword("demo").
                ClickLogin();

            Assert.That(new AccountsOverviewPage(driver).PageIsLoaded(), Is.True);
        }

        [Test]
        public void LoginFailsTest()
        {
            LoginPage loginPage = new LoginPage(driver);

            loginPage.
                SetUserName("john").
                SetPassword("invalidpassword").
                ClickLogin();

            Assert.That(loginPage.ErrorMessageIsVisible(), Is.True);
        }

        [TearDown]
        public void CloseBrowserInstance()
        {
            driver.Quit();
        }
    }
}
