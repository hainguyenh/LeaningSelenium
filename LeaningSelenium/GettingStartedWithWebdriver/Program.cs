using OpenQA.Selenium; // Using selenium library
using OpenQA.Selenium.Chrome; // Using Chrome Diver library
using System;

namespace GettingStartedWithWebdriver
{
    class Program
    {
        static void Main(string[] args)
        {

            // Using nutget package to download web driver
            // Right click on the project then select Manage Nutget Package
            // On Nutget explorer, click on "Browse" tab
            // Type "Selenium" then search
            // Select "Selenium.WebDriver" then click Install the lastest version

            // Declare the variable of Webdriver
            IWebDriver driver;

            // Create the instance of Web Driver => Chrome driver
            driver = new ChromeDriver();

            // Navigate to Google
            driver.Navigate().GoToUrl("http://google.com.vn");


            // Press any key on the console application to exit
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
            // Disppose the instance of webdriver
            driver.Dispose();
            Environment.Exit(0);

        }
    }
}
