using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    public class VerifyLetterInSent
    {
        private IWebDriver _driver;
        public VerifyLetterInSent(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@aria-label='Sent']")]
        private IWebElement sentFolder;


        public void LetterInSentFolder()
        {
            sentFolder.Click();
            // Assert.That(bodyList.Contains(" - \r\nTest text"));
        }
    }
}
