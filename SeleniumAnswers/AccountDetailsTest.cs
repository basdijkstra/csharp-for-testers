using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumAnswers.Pages;

namespace SeleniumAnswers
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

            new AccountsOverviewPage(driver).
                SelectAccount("12345");

            Assert.That(new AccountDetailsPage(driver).PageIsLoaded(), Is.True);
        }

        [TearDown]
        public void CloseBrowserInstance()
        {
            driver.Quit();
        }
    }
}
