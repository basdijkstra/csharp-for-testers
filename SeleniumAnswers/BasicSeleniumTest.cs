using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumAnswers
{
    [TestFixture]
    public class BasicSeleniumTest
    {
        [Test]
        public void ParabankLoginTest()
        {
            // Arrange - Create a new Chrome browser instance
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // Act - Go to the Parabank web site and login using valid credentials
            driver.Navigate().GoToUrl("http://parabank.parasoft.com");
            driver.FindElement(By.Name("username")).SendKeys("john");
            driver.FindElement(By.Name("password")).SendKeys("demo");
            driver.FindElement(By.XPath("//input[@value='Log In']")).Click();
            driver.FindElement(By.LinkText("12345")).Click();

            // PAS DE ONDERSTAANDE ASSERTION AAN
            // Na het succesvol toevoegen van de klikactie werkt deze niet meer..
            // Wat zou je moeten doen om te controleren dat de tekst 'Account Details' zichtbaar is?

            // Assert - Check that the login action has been successful
            //          and that the accounts overview screen is displayed
            Assert.That(
                driver.FindElement(By.XPath("//h1[@class='title' and text()='Account Details']")).Displayed,
                Is.True);

            driver.Quit();
        }
    }
}
