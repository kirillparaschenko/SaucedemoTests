using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V111.Browser;
using Tests.Models;
using Tests.Pages;
using Core;

namespace Tests.Tests
{
    public class BaseTest
    {
        public static readonly string? BaseUrl = "https://www.saucedemo.com/";

        protected IWebDriver ChromeDriver { get; set; }
        public LoginPage LoginPage { get; set; }

        [SetUp]
        public void Setup()
        {
            ChromeDriver = new Browser().Driver;

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