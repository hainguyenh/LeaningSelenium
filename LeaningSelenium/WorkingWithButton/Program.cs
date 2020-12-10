using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithButton
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
            IWebElement search1st_btn = driver.FindElement(By.XPath("//div[not(@jsname)]/center/*[@name='btnI']"));

            // click button
            search1st_btn.Click();
        }
    }
}
