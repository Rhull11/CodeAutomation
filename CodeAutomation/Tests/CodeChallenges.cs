using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using CodeAutomation.Pages;
using System.Threading;

namespace CodeAutomation
{
    [TestClass]
    public class CodeChallenges
    {
        Common common = new Common();
        IWebDriver chromeDriver = new ChromeDriver();
        PlanYourTrip pyt = new PlanYourTrip();
        ResortsAndSnow rsn = new ResortsAndSnow();
        Stories stories = new Stories();
        Deals deals = new Deals();
        Passes passes = new Passes();
        Explore explore = new Explore();
        IndexPage indexPage = new IndexPage();

        //Challenge #1
        [TestMethod]
        public void TestForCorrectWebsite()
        {
            common.GoToSkiUtahWebsite(chromeDriver);

            string titleString = chromeDriver.Title;
            string validationTitle = "Ski Utah";
            string actualTitle = titleString.Substring(0, 8);

            try
            {
                Assert.IsTrue(validationTitle.Equals(actualTitle));
            }
            catch
            {
                Assert.IsFalse(validationTitle.Equals(actualTitle));
                throw new AssertFailedException(validationTitle + " does not match " + actualTitle); //Force fails test if strings are not equal              
            }

        }

        //Challenge #2
        [TestMethod]
        public void TestForMenuNav()
        {
            common.GoToSkiUtahWebsite(chromeDriver);

            try
            {
                common.NavigateMenu(chromeDriver, "PLAN YOUR TRIP");
                common.NavigateMenu(chromeDriver, "RESORTS & SNOW");
                common.NavigateMenu(chromeDriver, "STORIES");
                common.NavigateMenu(chromeDriver, "DEALS");
                common.NavigateMenu(chromeDriver, "PASSES");
                common.NavigateMenu(chromeDriver, "EXPLORE");
            }
            catch
            {
                throw new AssertFailedException("Could not find menu navigation link");
            }

        }

        //Challenge #3
        [TestMethod]
        public void TestForSubMenuNavigation()
        {
            common.GoToSkiUtahWebsite(chromeDriver);

            try
            {
                //here is one example for each submenu:
                pyt.NavigateSubMenu(chromeDriver, "Lodging");
                rsn.NavigateSubMenu(chromeDriver, "Resort Comparison");
                deals.NavigateSubMenu(chromeDriver, "Beginner");
                passes.NavigateSubMenu(chromeDriver, "Purchase Utah Lift Tickets");
                explore.NavigateSubMenu(chromeDriver, "Utah Areas 101");
            }
            catch
            {
                throw new AssertFailedException("Could not find submenu navigation link");
            }

        }


        //Challenge #4
        [TestMethod]
        public void TestForTimeFromAirport()
        {
            common.GoToSkiUtahWebsite(chromeDriver);
            Thread.Sleep(5000);

            try
            {

                indexPage.RetrieveTimeFromAirport(chromeDriver, "Beaver Mountain");
            }
            catch
            {
                throw new AssertFailedException("Could not find ski resort");
            }

        }

        //Challenge #5
        [TestMethod]
        public void TestMethod5()
        {

        }


    }

}
