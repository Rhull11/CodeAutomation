using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace CodeAutomation
{
    class SetUp
    {
        public void GoToSkiUtahWebsite(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://www.skiutah.com/");
        }


    }
}