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
    public class CheckoutCompletePage : BasePage
    {
        private static string END_POINT = "checkout-complete.html";

        By BackHomeButtonLocator = By.Name("back-to-products");
        By CompleteTextLocator = By.ClassName("checkout_complete_container");

        public CheckoutCompletePage(WebDriver driver) : base(driver, false)
        {
        }

        public CheckoutCompletePage(WebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
        }

        public InventoryPage ClickBackHomeButton()
        {
            Driver.FindElement(BackHomeButtonLocator).Click();
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
                return Driver.FindElement(CompleteTextLocator).Displayed;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
