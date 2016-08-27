using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace CodeAutomation.Pages
{
    class Passes : IPages
    {
        public void NavigateSubMenu(IWebDriver driver, string subMenuNav)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            //Hover Over
            var navBarButton = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"top_menu\"]/ul/li[2]")));
            var action = new Actions(driver);
            action.MoveToElement(navBarButton).Perform();

            IWebElement subMenuDiv = driver.FindElement(By.CssSelector("#top_menu > ul > li:nth-child(2) > ul"));
            IList<IWebElement> AllSubMenuLinks = subMenuDiv.FindElements(By.TagName("a"));

            foreach (IWebElement item in AllSubMenuLinks)
            {
                if (item.GetAttribute("innerHTML").ToString().Contains(subMenuNav))
                {
                    item.Click();
                    break;
                }
            }
        }
    }
}
