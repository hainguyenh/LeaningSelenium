using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PageObjectModel
{

    /*
  Please using NuGet Package to install
     - Selenium Web Driver
     - Chrome Driver
     - Nunit
     - Nunit3TestAdaptor
 */

    [TestFixture]
    public class OldScript
    {
        // Declare the variable of Webdriver
        IWebDriver driver;

        [OneTimeSetUp]
        public void ClassInit()
        {
            // Executes once for the test class. (Optional)
            // Create the instance of Web Driver => Chrome driver
            driver = new ChromeDriver();
        }

        [SetUp]
        public void TestInit()
        {
            // Runs before each test. (Optional)

            // Navigate to PMA
            driver.Navigate().GoToUrl("http://automationpractice.com/");

            // Click Log in button
            driver.FindElement(By.XPath("//*[@id='header']/div[2]/div/div/nav/div[1]/a")).Click();
            System.Threading.Thread.Sleep(1000);

            // Log in
            var txtUserName = driver.FindElement(By.Id("email"));
            var txtPwds = driver.FindElement(By.Id("passwd"));
            var btnSignIn = driver.FindElement(By.Id("SubmitLogin"));


            txtUserName.SendKeys("truyentranhtuan@gmail.com");
            txtPwds.SendKeys("123456");
            System.Threading.Thread.Sleep(1000);

            btnSignIn.Click();
        }



        [Test]
        [Category("06. Apply Page Object Model")]
        public void TestMethod_06_Old()
        {
            // get the Title after log in successfully
            var stringTitle = driver.Title;

            // Verify 
            Assert.AreEqual("My account - My Store", stringTitle);

            // find the Textbox search
            var txtSearch = driver.FindElement(By.Id("search_query_top"));

            // Search value "VN-2" then Enter
            txtSearch.SendKeys("T-SHIRTS" + Keys.Enter);
            System.Threading.Thread.Sleep(1000);

            // get the Title after searching
            var actualTitle = driver.Title;

            // Verify 
            Assert.AreEqual("Search - My Store", actualTitle);
        }



        [TearDown]
        public void TestCleanup()
        {
            // Runs after each test. (Optional)
            // Log out
            driver.FindElement(By.XPath("//*[@id='header']/div[2]/div/div/nav/div[2]/a")).Click();
        }





        [OneTimeTearDown]
        public void ClassCleanup()
        {
            // Runs once after all tests in this class are executed. (Optional)
            // Not guaranteed that it executes instantly after all tests from the class.

            // Disppose the instance of webdriver
            driver.Dispose();
        }
    }


}
