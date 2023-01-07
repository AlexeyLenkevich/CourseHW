using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    public class EmailPage
    {
        private IWebDriver _driver;
        public EmailPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//img[@class='gb_Ia gbii']")]
        private IWebElement buttonUserProfile;

        [FindsBy(How = How.Name, Using = "account")]
        private IWebElement frameAccount;

        [FindsBy(How = How.XPath, Using = "//input[@type='password']")]
        private IWebElement password;

        [FindsBy(How = How.Id, Using = "passwordNext")]
        private IWebElement buttonNextDuringEnteringPassword;
        public void Account()
        {
            buttonUserProfile.Click();
            frameAccount.Click();
            // this.driver.SwitchTo().Frame(this.driver.FindElement(By.Name("account")));
            Thread.Sleep(3000);
            // Assert.That(driver.FindElement(By.XPath("//div/div[2][contains(text(), 'alexeytest00@gmail.com')]")).Displayed, Is.EqualTo(true));
            // this.driver.SwitchTo().DefaultContent();
        }
    }
}
