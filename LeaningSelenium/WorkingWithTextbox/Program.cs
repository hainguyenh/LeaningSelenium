using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithTextbox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initial chrome driver
            ChromeDriver driver = new ChromeDriver();

            // Call the driver to open the URL "google.com"
            driver.Url = "http://google.com";

            // Wait 1 s
            System.Threading.Thread.Sleep(1000);

            // Find the search textbox
            IWebElement search_txt = driver.FindElement(By.Name("q"));

            // Input "selenium" to the textbox
            search_txt.SendKeys("selenium");

            // Wait 2 s
            System.Threading.Thread.Sleep(2000);

            // Press ESC to close the suggestion
            search_txt.SendKeys(Keys.Enter);
        }
    }
}
