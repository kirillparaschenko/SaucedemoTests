﻿using OpenQA.Selenium;
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
            ChromeDriver.FindElement(FirstNameInputLocator).SendKeys(firstame);
        } 

        void SetLastName(string lastname)
        {
            ChromeDriver.FindElement(LastNameInputLocator).SendKeys(lastname);
        }

        void SetPostalCode (string postalCode)
        {
            ChromeDriver.FindElement(LastNameInputLocator).SendKeys(postalCode);
        }

        void ClickContinueButton()
        {
            ChromeDriver.FindElement(ContinueButtonLocator).Click();
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
            return new CheckoutStepTwoPage(ChromeDriver);
        }
    }
}