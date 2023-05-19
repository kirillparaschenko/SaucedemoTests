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
            return ChromeDriver.FindElement(CheckoutButtonLocator).Displayed;
        }

        public InventoryPage ClickContinueShopingButton()
        {
            ChromeDriver.FindElement(ContinueShopingButtonLocator).Click();
            return new InventoryPage(ChromeDriver);
        }

        public CheckoutStepOnePage ClickCheckoutButton()
        {
            ChromeDriver.FindElement(CheckoutButtonLocator).Click();
            return new CheckoutStepOnePage(ChromeDriver);
        }
    }
}
