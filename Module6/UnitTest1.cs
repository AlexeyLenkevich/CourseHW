using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace Module6
{
    public class Tests
    {

        private IWebDriver driver;
        private string baseUrl;

        [SetUp]
        public void Setup()
        {
            var service = FirefoxDriverService.CreateDefaultService();
            this.driver = new FirefoxDriver(service);
            this.baseUrl = "https://www.google.com/gmail/about/";

            this.driver.Navigate().GoToUrl(baseUrl);
            this.driver.Manage().Window.Maximize();
        }

        [Test]
        public void testLogin()
        {
            this.driver.FindElement(By.XPath("//a[text()='Sign in']")).Click();
            this.driver.FindElement(By.Id("identifierId")).SendKeys("alexeytest00@gmail.com");
            this.driver.FindElement(By.Id("identifierNext")).Click();
            Thread.Sleep(3000);
            this.driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("123456aA$");
            this.driver.FindElement(By.Id("passwordNext")).Click();
            Thread.Sleep(8000);
            this.driver.FindElement(By.XPath("//img[@class='gb_Ia gbii']")).Click();
            this.driver.SwitchTo().Frame(this.driver.FindElement(By.Name("account")));
            Thread.Sleep(3000);
            Assert.That(driver.FindElement(By.XPath("//div/div[2][contains(text(), 'alexeytest00@gmail.com')]")).Displayed, Is.EqualTo(true));
            this.driver.SwitchTo().DefaultContent();

            this.driver.FindElement(By.XPath("//*[contains(text(), 'Compose')]")).Click();
            Thread.Sleep(3000);
            this.driver.FindElement(By.XPath("//input[contains(@type, 'text') and contains(@role, 'combobox')]")).SendKeys("alexeytest0@gmail.com");
            this.driver.FindElement(By.Name("subjectbox")).SendKeys("Test");
            this.driver.FindElement(By.XPath("//div[@aria-label='Message Body']")).SendKeys("Test text");
            this.driver.FindElement(By.XPath("//img[@aria-label='Save & close']")).Click();
            
            Thread.Sleep(5000);
            this.driver.FindElement(By.XPath("//a[contains(@aria-label, 'Drafts') and contains(., 'Drafts')]")).Click();
            List<IWebElement> elementList = this.driver.FindElements(By.XPath("//span[@class='y2']")).ToList();
            List<string> bodyList = elementList.Select(element=>element.Text).ToList();
            Assert.That(bodyList.Contains("Test text"));

            this.driver.FindElement(By.XPath("//span[contains(text(), 'Test text')]")).Click();
            //Assert.That(listOfElements = this.driver.FindElements(By.XPath("//span[contains(text(), 'test text')]")).Displayed, Is.EqualTo(true));

            this.driver.FindElement(By.XPath("//div[@aria-label='Send ‪(Ctrl-Enter)‬']")).Click();
            Thread.Sleep(8000);



        }
    }
}
