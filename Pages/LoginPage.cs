using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Tests.Models;
using Tests.Tests;

namespace Tests.Pages
{
    public class LoginPage : BasePage
    {
        private static string END_POINT = "";

        By UserNameInputLocator = By.XPath("//*[@data-test='username']");
        By PassrowdInputLocator = By.CssSelector("#password");
        By LoginButtonLocator = By.Name("login-button");
        By ErrorElement = By.XPath("//*[@data-test='error']");

        public LoginPage(IWebDriver? driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
        }

        public LoginPage(IWebDriver? driver) : base(driver, false) { } 

        void SetUserName(string name)
        {
            Driver.FindElement(UserNameInputLocator).SendKeys(name);
        }

        void SetPasswrod(string password)
        {
            Driver.FindElement(PassrowdInputLocator).SendKeys(password);
        }

        void ClickLoginButton()
        {
            Driver.FindElement(LoginButtonLocator).Click();
        }

        public string GetErrorMessage()
        {
            return Driver.FindElement(ErrorElement).Text;
        }

        public void TryToLogin(User user)
        {
            SetUserName(user.Username);
            SetPasswrod(user.Password);
            ClickLoginButton();
        }

        public InventoryPage Login(User user)
        {
            TryToLogin(user);
            return new InventoryPage(Driver);
        }

        public override void OpenPage()
        {
            Driver.Navigate().GoToUrl(BaseTest.BaseUrl + END_POINT);
        }

        public override bool IsPageOpened()
        {
            try
            {
                return Driver.FindElement(LoginButtonLocator).Displayed;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
