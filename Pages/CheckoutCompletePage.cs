using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Pages
{
    public class CheckoutCompletePage : BasePage
    {
        By BackHomeButtonLocator = By.Name("back-to-products");
        By CompleteTextLocator = By.ClassName("checkout_complete_container");

        public CheckoutCompletePage(WebDriver driver) : base(driver)
        {
        }

        public InventoryPage ClickBackHomeButton()
        {
            Driver.FindElement(BackHomeButtonLocator).Click();
            return new InventoryPage(Driver);
        }

    }
}
