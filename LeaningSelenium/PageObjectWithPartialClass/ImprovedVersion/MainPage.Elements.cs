using OpenQA.Selenium;

namespace PageObjectWithPartialClass.ImprovedVersion
{
    public partial class MainPage
    {
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

        public IWebElement SignInPage
        {
            get
            {
                return _driver.FindElement(By.XPath("//*[@id='header']/div[2]/div/div/nav/div[1]/a"));

            }
        }
    }
}
