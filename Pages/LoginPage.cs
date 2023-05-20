﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Pages
{
    public class LoginPage : BasePage
    {
        By UserNameInputLocator = By.XPath("//*[@data-test='username']");
        By PassrowdInputLocator = By.CssSelector("#password");
        By LoginButtonLocator = By.Name("login-button");
        By ErrorElement = By.XPath("//*[@data-test='error']");

        public LoginPage(WebDriver driver) : base(driver)
        {
        }

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
            SetUserName(user.Name);
            SetPasswrod(user.Password);
            ClickLoginButton();
        }

        public InventoryPage Login(User user)
        {
            TryToLogin(user);
            return new InventoryPage(Driver);
        }
    }
}
