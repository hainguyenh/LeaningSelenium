using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WorkingWithCheckbox
{
    class Program
    {
        static void Main(string[] args)
        {
            ChromeDriver driver = new ChromeDriver();
            // Go to the other site and practice with the checkbox
            driver.Url = "http://the-internet.herokuapp.com/checkboxes";
            System.Threading.Thread.Sleep(5000);

            // Find the checkbox 1
            IWebElement checkbox1_chk = driver.FindElement(By.XPath("//*[@id='checkboxes']/input[1]"));

            // Check checkbox 1 if it uncheck
            if (checkbox1_chk.GetAttribute("checked") == "checked")
            {
                Console.WriteLine("Checkbox 1 is checked");
            }
            else
            {
                checkbox1_chk.Click();
            }
        }
    }
}
