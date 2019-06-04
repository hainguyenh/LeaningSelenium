using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreFluentAndApplySingleton.ImprovedVersion
{
    public partial class PracticePage
    {
        public IWebElement SearchBox => WrappedDriver.FindElement(By.Id("search_query_top"));
        public IWebElement UserName_Txt => WrappedDriver.FindElement(By.Id("email"));
        public IWebElement Password_Txt => WrappedDriver.FindElement(By.Id("passwd"));
        public IWebElement SignIn_Btn => WrappedDriver.FindElement(By.Id("SubmitLogin"));
        public IWebElement SignInPage => WrappedDriver.FindElement(By.XPath("//*[@id='header']/div[2]/div/div/nav/div[1]/a"));

    }
}
