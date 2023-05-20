using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Tests.Models;
using Tests.Pages;

namespace Tests.Tests
{
    public class Tests
    {
        protected WebDriver ChromeDriver { get; set; }
        public LoginPage LoginPage { get; set; }

        [SetUp]
        public void Setup()
        {
            UserBuilder userBuilder = new UserBuilder();
            User user = userBuilder
                .SetUserName ("username")
                .SetPassword ("password")
                .SetUserFirstName ("username")
                .SetUserLastName ("username")
                .SetUserPostalCode ("password")
                .Build ();

            ChromeDriver = new ChromeDriver();
            ChromeDriver.Manage().Window.Maximize();
            ChromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            LoginPage = new LoginPage(ChromeDriver);

            ChromeDriver.Navigate().GoToUrl("https://www.sharelane.com/cgi-bin/main.py");
        }

        [TearDown]
        public void Teardown()
        {
            ChromeDriver.Quit();
        }

    }
}