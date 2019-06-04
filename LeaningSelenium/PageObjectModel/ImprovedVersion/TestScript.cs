using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PageObjectModel
{
    [TestFixture]
    public class TestScript
    {
        /*
      Please using NuGet Package to install
         - Selenium Web Driver
         - Chrome Driver
         - Nunit
         - Nunit3TestAdaptor
     */



        // Declare the variable of Webdriver
        IWebDriver driver;
        MainPage _page;

        [OneTimeSetUp]
        public void ClassInit()
        {
            // Executes once for the test class. (Optional)
            // Create the instance of Web Driver => Chrome driver
            driver = new ChromeDriver();

            _page = new MainPage(driver);
        }

        [SetUp]
        public void TestInit()
        {
            // Runs before each test. (Optional)

            // Navigate to PMA
            driver.Navigate().GoToUrl("http://automationpractice.com/");
            _page.GoToLogInPage();
            // Log in
            _page.InputUserAccount("truyentranhtuan@gmail.com", "123456");
            System.Threading.Thread.Sleep(1000);

            _page.SignIn_Btn.Click();
        }



        [Test]
        [Category("06. Apply Page Object Model")]
        public void TestMethod_06()
        {
            // Verify 
            Assert.AreEqual("My account - My Store", _page.GetTitle);

            // Search value "VN-2" then Enter
            _page.SearchingValue("T-Shirts");

            // Verify 
            Assert.AreEqual("Search - My Store", _page.GetTitle);
        }



        [TearDown]
        public void TestCleanup()
        {
            // Runs after each test. (Optional)
            _page.LogOut();
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
