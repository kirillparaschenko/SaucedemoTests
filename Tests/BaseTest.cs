using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Tests.Models;
using Tests.Pages;

namespace Tests.Tests
{
    public class BaseTest
    {
        public static readonly string? BaseUrl = "https://www.saucedemo.com/";

        protected WebDriver ChromeDriver { get; set; }
        public LoginPage LoginPage { get; set; }

        [SetUp]
        public void Setup()
        {
            ChromeDriver = new ChromeDriver();
            ChromeDriver.Manage().Window.Maximize();
            ChromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            LoginPage = new LoginPage(ChromeDriver);

            LoginPage.OpenPage();
        }

        [TearDown]
        public void Teardown()
        {
            ChromeDriver.Quit();
        }

    }
}