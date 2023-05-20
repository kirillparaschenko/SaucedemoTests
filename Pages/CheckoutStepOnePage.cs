using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tests.Pages
{
    public class CheckoutStepOnePage : BasePage
    {
        By ContinueButtonLocator = By.Id("continue");
        By CancelButtonLocator = By.Id("cancel");
        By FirstNameInputLocator = By.Name("firstName");
        By LastNameInputLocator = By.Name("lastName");
        By PostalCodeInputLocator = By.Name("postalCode");

        public CheckoutStepOnePage(WebDriver driver) : base(driver)
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
            Driver.FindElement(LastNameInputLocator).SendKeys(postalCode);
        }

        void ClickContinueButton()
        {
            Driver.FindElement(ContinueButtonLocator).Click();
        }

        public void TryToContinue(string firstame, string lastname, string postalCode)
        {
            SetFirstName(firstame);
            SetLastName(lastname);
            SetPostalCode(postalCode);
            ClickContinueButton();
        }

        public CheckoutStepTwoPage ContinueCheckout(string firstame, string lastname, string postalCode)
        {
            TryToContinue(firstame, lastname, postalCode);
            return new CheckoutStepTwoPage(Driver);
        }

        public CartPage ClickCancelButton()
        {
            Driver.FindElement(CancelButtonLocator).Click();
            return new CartPage(Driver);
        }
    }
}
