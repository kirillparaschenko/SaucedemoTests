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
        [Test, Category("Smoke")]

        public void OrderingJacket()
        {
            UserBuilder userBuilder = new UserBuilder();
            User user = userBuilder
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
