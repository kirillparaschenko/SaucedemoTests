using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Tests.Models;
using Tests.Tests;

namespace Tests.Pages
{
    public class CheckoutStepOnePage : BasePage
    {
        private static string END_POINT = "checkout-step-one.html";

        By ContinueButtonLocator = By.Id("continue");
        By CancelButtonLocator = By.Id("cancel");
        By FirstNameInputLocator = By.Name("firstName");
        By LastNameInputLocator = By.Name("lastName");
        By PostalCodeInputLocator = By.Name("postalCode");

        public CheckoutStepOnePage(WebDriver driver) : base(driver, false)
        {
        }

        public CheckoutStepOnePage(WebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
        }

        void SetFirstName(string firstame)
        {
            Driver.FindElement(FirstNameInputLocator).SendKeys(firstame);
        } 

        void SetLastName(string lastname)
        {
            Driver.FindElement(LastNameInputLocator).SendKeys(lastname);
        }

        void SetPostalCode (string postalCode)
        {
            Driver.FindElement(PostalCodeInputLocator).SendKeys(postalCode);
        }

        void ClickContinueButton()
        {
            Driver.FindElement(ContinueButtonLocator).Click();
        }

        public void TryToContinue(User user)
        {
            SetFirstName(user.UserFirstName);
            SetLastName(user.UserLastName);
            SetPostalCode(user.UserPostalCode);
            ClickContinueButton();
        }

        public CheckoutStepTwoPage ContinueCheckout(User user)
        {
            TryToContinue(user);
            return new CheckoutStepTwoPage(Driver);
        }

        public CartPage ClickCancelButton()
        {
            Driver.FindElement(CancelButtonLocator).Click();
            return new CartPage(Driver);
        }

        public override void OpenPage()
        {
            Driver.Navigate().GoToUrl(BaseTest.BaseUrl + END_POINT);
        }

        public override bool IsPageOpened()
        {
            try
            {
                return Driver.FindElement(ContinueButtonLocator).Displayed;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
