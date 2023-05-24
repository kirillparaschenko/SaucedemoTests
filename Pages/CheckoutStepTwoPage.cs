using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Tests.Tests;

namespace Tests.Pages
{
    public class CheckoutStepTwoPage : BasePage
    {
        private static string END_POINT = "checkout-step-two.html";

        By FinishButtonLocator = By.Id("finish");
        By CancelButtonLocator = By.Id("cancel");

        public CheckoutStepTwoPage(IWebDriver? driver) : base(driver, false)
        {
            _logger.Info("CheckoutStepTwo Page opened");
        }
        public CheckoutStepTwoPage(IWebDriver? driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
            _logger.Info("CheckoutStepTwo Page opened");
        }

        public InventoryPage ClickCancelButton()
        {
            Driver.FindElement(CancelButtonLocator).Click();
            return new InventoryPage(Driver);
        }

        public CheckoutCompletePage ClickFinishButton()
        {
            Driver.FindElement(FinishButtonLocator).Click();
            return new CheckoutCompletePage(Driver);
        }

        public override void OpenPage()
        {
            Driver.Navigate().GoToUrl(BaseTest.BaseUrl + END_POINT);
        }

        public override bool IsPageOpened()
        {
            try
            {
                return Driver.FindElement(FinishButtonLocator).Displayed;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
