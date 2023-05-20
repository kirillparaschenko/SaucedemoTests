using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Pages
{
    public abstract class BasePage
    {
        protected WebDriver Driver { get; set; }

        public BasePage(WebDriver driver)
        {
            Driver = driver;
        }

        public BasePage(IWebDriver? driver, bool openPageByUrl)
        {
            Driver = driver;

            if (openPageByUrl)
            {
                OpenPage();
            }
        }

        public abstract void OpenPage();
        public abstract bool IsPageOpened();
    }
}
