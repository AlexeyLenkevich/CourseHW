using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    public class LoginPage
    {
        private IWebDriver _driver;
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "identifierId")]
        private IWebElement email;

        [FindsBy(How = How.Id, Using = "identifierNext")]
        private IWebElement buttonNextDuringEnteringEmail;

        [FindsBy(How = How.XPath, Using = "//input[@type='password']")]
        private IWebElement password;

        [FindsBy(How = How.Id, Using = "passwordNext")]
        private IWebElement buttonNextDuringEnteringPassword;
        public void Login()
        {
            email.SendKeys("alexeytest00@gmail.com");
            buttonNextDuringEnteringEmail.Click();
            Thread.Sleep(3000);
            password.SendKeys("123456aA$");
            buttonNextDuringEnteringPassword.Click();
            Thread.Sleep(6000);
        }
    }
}
