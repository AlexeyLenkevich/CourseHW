using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    public class GmailPage
    {
        private IWebDriver _driver;
        public GmailPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[text()='Sign in']")]
        private IWebElement buttonSignIn;

        public void ClickSignInButton ()
        {
            buttonSignIn.Click();
        }
    }

}
