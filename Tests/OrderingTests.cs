using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Models;
using Tests.Pages;

namespace Tests.Tests
{
    public class OrderingTests : BaseTest
    {
        [Test(Description = "Successful ordering a jacket")]
        [AllureSeverity(Allure.Commons.SeverityLevel.critical)]
        [AllureOwner("standard_user")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("GUI")]
        [AllureIssue("TMS-39")]
        [AllureTms("SL-3")]
        [AllureTag("Smoke")]
        [AllureLink("https://app.qase.io/")]
        [Description("Placing an order for a jacket")]
        public void OrderingJacket()
        {
            User user  = new UserBuilder()             
                .SetUserName("standard_user")
                .SetPassword("secret_sauce")
                .SetUserFirstName("username")
                .SetUserLastName("username")
                .SetUserPostalCode("123456")
                .Build();

            LoginPage.Login(user)
                .AddCartJacketToCart()
                .ClickCheckoutButton()
                .ContinueCheckout(user)
                .ClickFinishButton();
            Assert.IsTrue(new CheckoutCompletePage(ChromeDriver).IsPageOpened());
   
        }
    }
}
