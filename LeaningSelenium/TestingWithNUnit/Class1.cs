using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestingWithNUnit
{
    /*
     Please using NuGet Package to install
        - Selenium Web Driver
        - Chrome Driver
        - Nunit
        - Nunit3TestAdaptor
    */

    [TestFixture]
    public class Class1
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

            // Navigate to Google
            driver.Navigate().GoToUrl("http://google.com.vn");
        }

        [Test]
        [Category("04. Apply NUnit Framework to handle Test Script")]
        public void TestMethod_04()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("Finding the elements.........");


            // Find the textbox search by Xpath
            var textboxSearch = driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div/div[1]/div/div[1]/input"));
            if (textboxSearch is null)
                Console.WriteLine("The textbox search is not found.");
            else
                textboxSearch.SendKeys("Selenium");

            System.Threading.Thread.Sleep(2000);

            // Find the Button search by Name
            var buttonSearch = driver.FindElement(By.Name("btnK"));

            if (buttonSearch is null)
                Console.WriteLine("The button search is not found.");
            else
                buttonSearch.Click();

            System.Threading.Thread.Sleep(1000);

            var firstRecord = driver.FindElement(By.XPath("//*[@id='rso']/div/div/div[1]/div/div/div[1]/a[1]/h3")).Text;
            Assert.AreEqual("Selenium - Web Browser Automation", firstRecord);
        }
        
        [TearDown]
        public void TestCleanup()
        {
            // Runs after each test. (Optional)

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
