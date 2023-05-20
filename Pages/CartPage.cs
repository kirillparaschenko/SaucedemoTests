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
    public class CartPage : BasePage
    {
        private static string END_POINT = "cart.html";

        By ContinueShopingButtonLocator = By.Id("continue-shopping");
        By CheckoutButtonLocator = By.Id("checkout");

        public CartPage(WebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
        }

        public CartPage(WebDriver driver) : base(driver, false)
        {
        }

        public bool CheckCheckoutButtonPresented()
        {
            return Driver.FindElement(CheckoutButtonLocator).Displayed;
        }

        public InventoryPage ClickContinueShopingButton()
        {
            Driver.FindElement(ContinueShopingButtonLocator).Click();
            return new InventoryPage(Driver);
        }

        public CheckoutStepOnePage ClickCheckoutButton()
        {
            Driver.FindElement(CheckoutButtonLocator).Click();
            return new CheckoutStepOnePage(Driver);
        }

        public override void OpenPage()
        {
            Driver.Navigate().GoToUrl(BaseTest.BaseUrl + END_POINT);
        }

        public override bool IsPageOpened()
        {
            try
            {
                return Driver.FindElement(CheckoutButtonLocator).Displayed;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
