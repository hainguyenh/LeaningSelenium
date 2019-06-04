using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace InteractingWithElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare the variable of Webdriver
            IWebDriver driver;

            // Create the instance of Web Driver => Chrome driver
            driver = new ChromeDriver();

            // Navigate to Google
            driver.Navigate().GoToUrl("http://google.com.vn");

            Console.WriteLine("*******************************************");
            Console.WriteLine("Finding the elements.........");


            // Find the textbox search by Xpath
            var textboxSearch = driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div/div[1]/div/div[1]/input"));
            if (textboxSearch is null)
                Console.WriteLine("The textbox search is not found.");
            else
                textboxSearch.SendKeys("Selenium self-study");

            System.Threading.Thread.Sleep(2000);

            // Find the Button search by Name
            var buttonSearch = driver.FindElement(By.Name("btnK"));

            if (buttonSearch is null)
                Console.WriteLine("The button search is not found.");
            else
                buttonSearch.Click();

            // Press any key on the console application to exit


            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
            // Disppose the instance of webdriver
            driver.Dispose();
            Environment.Exit(0);
        }
    }
}
