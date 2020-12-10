using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithDropdownList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initial chrome driver
            ChromeDriver driver = new ChromeDriver();
            // Working with Dropdown list
            driver.Url = "http://the-internet.herokuapp.com/dropdowns";
            System.Threading.Thread.Sleep(5000);

            // Find the element with id "dropdown"
            SelectElement dropdown_ddl = new SelectElement(driver.FindElement(By.Id("dropdown")));
            // Select the option in the dropdown by text
            dropdown_ddl.SelectByText("Option 1");
        }
    }
}
