using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    public class DraftLetter
    {
        private IWebDriver _driver;
        public DraftLetter(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(), 'Compose')]")]
        private IWebElement buttonCompose;

        [FindsBy(How = How.XPath, Using = "//input[contains(@type, 'text') and contains(@role, 'combobox')]")]
        private IWebElement enterReceiverLetter;

        [FindsBy(How = How.Name, Using = "subjectbox")]
        private IWebElement enterSubjectLetter;

        [FindsBy(How = How.XPath, Using = "//div[@aria-label='Message Body']")]
        private IWebElement enterBodyLetter;

        [FindsBy(How = How.XPath, Using = "//img[@aria-label='Save & close']")]
        private IWebElement buttonSaveDraft;
        public void SaveDraft()
        {
            buttonCompose.Click();
            Thread.Sleep(3000);
            enterReceiverLetter.SendKeys("alexeytest0@gmail.com");
            enterSubjectLetter.SendKeys("Test");
            enterBodyLetter.SendKeys("Test text");
            buttonSaveDraft.Click();
            Thread.Sleep(5000);
        }
    }
}