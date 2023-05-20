using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Pages
{
    public class CheckoutStepTwoPage : BasePage
    {
        By FinishButtonLocator = By.Id("finish");
        By CancelButtonLocator = By.Id("cancel");

        public CheckoutStepTwoPage(WebDriver driver) : base(driver)
        {
        }

        public InventoryPage ClickCancelButton()
        {
            Driver.FindElement(CancelButtonLocator).Click();
            return new InventoryPage(Driver);
        }

        public CheckoutCompletePage ClickContinueButton()
        {
            Driver.FindElement(FinishButtonLocator).Click();
            return new CheckoutCompletePage(Driver);
        }
    }
}
