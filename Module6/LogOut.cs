using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    public class LogOut
    {
        private IWebDriver _driver;
        public LogOut(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//img[@class='gb_Ia gbii']")]
        private IWebElement buttonImageOfProfile;

        [FindsBy(How = How.Name, Using = "account")]
        private IWebElement profileFrame;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Logout')]")]
        private IWebElement buttonLogOut;

        public void SignOut()
        {
            buttonImageOfProfile.Click();
            // this.driver.SwitchTo().Frame(this.driver.FindElement(By.Name("account")));
            Thread.Sleep(3000);
            buttonLogOut.Click();
        }
    }
}