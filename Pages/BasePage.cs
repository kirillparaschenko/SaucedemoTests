﻿using NLog;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Tests;

namespace Tests.Pages
{
    public abstract class BasePage
    {
        public static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        protected static int WAIT_FOR_PAGE_LOADING_TIME = 60;
        protected IWebDriver? Driver { get; set; }

        public BasePage(IWebDriver? driver, bool openPageByUrl)
        {
            Driver = driver;

            if (openPageByUrl)
            {
                OpenPage();
            }
        }

        public BasePage() { }

        public abstract void OpenPage();
        public abstract bool IsPageOpened();
    }
}
