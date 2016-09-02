using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace CodeAutomation.Pages
{
    public class PlanYourTrip : IPages
    {
        public void NavigateSubMenu(IWebDriver driver, string subMenuName)
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            var navBarButton = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@id=\'top_menu\']/ul/li/a")));
            var action = new Actions(driver);
            action.MoveToElement(navBarButton).Perform();

            IWebElement subMenuDiv = driver.FindElement(By.CssSelector("#top_menu > ul > li:nth-child(1) > ul"));
            IList<IWebElement> AllSubMenuLinks = subMenuDiv.FindElements(By.TagName("a"));

            foreach (IWebElement item in AllSubMenuLinks)
            {
                if (item.Text.Contains(subMenuName))
                {
                    item.Click();
                    break;
                }
            }
        }
    }
}
