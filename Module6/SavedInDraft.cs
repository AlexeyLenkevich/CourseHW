using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    public class SavedInDraft
    {
        private IWebDriver _driver;
        public SavedInDraft(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[contains(@aria-label, 'Drafts') and contains(., 'Drafts')]")]
        private IWebElement buttonDraft;

        [FindsBy(How = How.XPath, Using = "//span[@class='y2']")]
        private IWebElement letterInList;

    

        public void DraftSaved()
        {
            buttonDraft.Click();
            // List<IWebElement> elementList = this.driver.FindElements(By.XPath("//span[@class='y2']")).ToList();
            // List<string> bodyList = elementList.Select(element => element.Text).ToList();
            // Assert.That(bodyList.Contains("Test text"));
        }
    }
}
