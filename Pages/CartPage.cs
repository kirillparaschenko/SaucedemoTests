using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Pages
{
    public class CartPage : BasePage
    {
        By ContinueShopingButtonLocator = By.Id("continue-shopping");
        By CheckoutButtonLocator = By.Id("checkout");


        public CartPage(WebDriver driver) : base(driver)
        {
            Assert.IsTrue(CheckCheckoutButtonPresented());
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
    }
}
