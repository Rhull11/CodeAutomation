using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodeAutomation.Pages
{
    class ResortsAndSnow : IPages
    {
        public void NavigateSubMenu(IWebDriver driver, string subMenuName)
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
                if (item.GetAttribute("innerHTML").ToString().Contains(subMenuName))
                {
                    item.Click();
                    break;
                }
            }
        }
    }
}
