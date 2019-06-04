using OpenQA.Selenium;

namespace PageObjectWithPartialClass
{
    public class MainPage
    {
        private readonly IWebDriver _driver;

        public MainPage(IWebDriver browser)
        {
            _driver = browser;
        }

        public IWebElement SearchBox
        {
            get
            {
                return _driver.FindElement(By.Id("search_query_top"));
            }
        }

        public IWebElement UserName_Txt
        {
            get
            {
                return _driver.FindElement(By.Id("email"));
            }
        }

        public IWebElement Password_Txt
        {
            get
            {
                return _driver.FindElement(By.Id("passwd"));
            }
        }

        public IWebElement SignIn_Btn
        {
            get
            {
                return _driver.FindElement(By.Id("SubmitLogin"));
            }
        }

        public void GoToLogInPage()
        {
            SignInPage.Click();
        }
        public IWebElement SignInPage
        {
            get
            {
                return _driver.FindElement(By.XPath("//*[@id='header']/div[2]/div/div/nav/div[1]/a"));

            }
        }

        public string GetTitle
        {
            get
            {
                return _driver.Title;
            }
        }

        public void InputUserAccount(string userName, string password)
        {
            UserName_Txt.SendKeys(userName);
            Password_Txt.SendKeys(password);
        }

        public void SearchingValue(string value)
        {
            SearchBox.SendKeys(value + Keys.Enter);
            System.Threading.Thread.Sleep(1000);
        }

        public void LogOut()
        {
            // Log out
            _driver.FindElement(By.XPath("//*[@id='header']/div[2]/div/div/nav/div[2]/a")).Click();
        }
    }
}
