using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CodeAutomation.Pages
{
    class IndexPage
    {
        public void RetrieveTimeFromAirport(IWebDriver driver, string resort)
        {

            driver.FindElement(By.XPath("#ski-utah-welcome-map > div > div.map-Slate > img")).Click();

            IWebElement resortsMapDiv = driver.FindElement(By.XPath("//*[@id=\"ski - utah - welcome - map\"]/div/div[4]"));
            IList<IWebElement> skiResortsList = resortsMapDiv.FindElements(By.XPath("//*[@id=\"ski - utah - welcome - map\"]/div/div[4]/div[2]/div[1]/label[@*]"));

            foreach (IWebElement item in skiResortsList)
            {
                if (item.Text.Equals(resort))
                {
                    item.Click();
                    break;
                }
            }
        }
    }
}
