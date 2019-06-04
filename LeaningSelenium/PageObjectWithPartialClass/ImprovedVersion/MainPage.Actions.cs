using OpenQA.Selenium;

namespace PageObjectWithPartialClass.ImprovedVersion
{
    public partial class MainPage
    {
        private readonly IWebDriver _driver;

        public MainPage(IWebDriver browser)
        {
            _driver = browser;
        }
        public void GoToLogInPage()
        {
            SignInPage.Click();
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
