using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V111.Browser;
using Tests.Models;
using Tests.Pages;
using Core;
using Allure.Commons;
using NUnit.Allure.Core;

namespace Tests.Tests
{
    [AllureNUnit]
    public class BaseTest
    {
        public static readonly string? BaseUrl = "https://www.saucedemo.com/";

        protected IWebDriver ChromeDriver { get; set; }
        public LoginPage LoginPage { get; set; }

        private AllureLifecycle _allure;

        [SetUp]
        public void Setup()
        {
            ChromeDriver = new Browser().Driver;

            LoginPage = new LoginPage(ChromeDriver);
            LoginPage.OpenPage();

            _allure = AllureLifecycle.Instance;
        }

        [TearDown]
        public void Teardown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                Screenshot screenshot = ((ITakesScreenshot)ChromeDriver).GetScreenshot();
                byte[] screenshotBytes = screenshot.AsByteArray;

                _allure.AddAttachment("Screenshot", "image/png", screenshotBytes);
            }

            ChromeDriver.Quit();
        }

    }
}