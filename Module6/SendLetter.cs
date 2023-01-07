using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    public class SendLetter
    {
        private IWebDriver _driver;
        public SendLetter(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Test text')]")]
        private IWebElement clickOnLetter;

        [FindsBy(How = How.XPath, Using = "//div[@aria-label='Send ‪(Ctrl-Enter)‬']")]
        private IWebElement buttonSend;

        public void LetterSent()
        {
            clickOnLetter.Click();
            buttonSend.Click();
            Thread.Sleep(8000);
            // Assert.AreEqual(true, this.driver.FindElement(By.XPath("//td[@class='TC']")).Displayed);
        }
    }
}
