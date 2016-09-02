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
    class Common
    {
        public void GoToSkiUtahWebsite(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://www.skiutah.com/");
        }

        public void NavigateMenu(IWebDriver driver, string menuName)
        {
            IWebElement navMenu = driver.FindElement(By.XPath("//*[@id=\"top_menu\"]/ul"));
            IList<IWebElement> navMenuButtons = navMenu.FindElements(By.XPath("//*[@id=\"top_menu\"]/ul/li[@*]"));

            foreach (IWebElement item in navMenuButtons)
            {
                if (item.Text.Contains(menuName))
                {
                    item.Click();
                    break;
                }
            }
        }


    }
}