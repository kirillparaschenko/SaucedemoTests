using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Pages
{
    public class InventoryPage : BasePage
    {
        By CartIconLocator = By.ClassName("shopping_cart_link");
        By AddToCartJacketButtonLocator = By.Id("add-to-cart-sauce-labs-fleece-jacket");
        By ProductSortDropDownLocator = By.ClassName("product_sort_container");

        public InventoryPage(WebDriver driver) : base(driver)
        {
            Assert.IsTrue(CheckCartIconPresented());
        }

        public bool CheckCartIconPresented()
        {
            return ChromeDriver.FindElement(CartIconLocator).Displayed;
        }

        public CartPage ClickCartIcon()
        {
            ChromeDriver.FindElement(CartIconLocator).Click();
            return new CartPage(ChromeDriver);
        }

        public void ClickAddToCartJacketButtonLocator()
        {
            ChromeDriver.FindElement(AddToCartJacketButtonLocator).Click();
        }

        /// <summary>
        /// Options: "Name (A to Z)", "Name (Z to A)", "Price (low to high)", "Price (high to low)"
        /// </summary>
        /// <param name="option"></param>
        public void SelectSortOption(string option)
        {
            new SelectElement(ChromeDriver.FindElement(ProductSortDropDownLocator))
                .SelectByText(option);
        }
    }
}
