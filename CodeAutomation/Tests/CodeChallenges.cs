using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using CodeAutomation.Pages;

namespace CodeAutomation
{
    [TestClass]
    public class CodeChallenges
    {
        SetUp setUp = new SetUp();
        IWebDriver chromeDriver = new ChromeDriver();
        PlanYourTrip pyt = new PlanYourTrip();
        ResortsAndSnow rsn = new ResortsAndSnow();
        Stories stories = new Stories();
        Deals deals = new Deals();
        Passes passes = new Passes();
        Explore explore = new Explore(); 

        //Challenge #1
        [TestMethod]
        public void TestForCorrectWebsite()
        {
            setUp.GoToSkiUtahWebsite(chromeDriver);

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
        public void TestForSubMenuNavigation()
        {
            setUp.GoToSkiUtahWebsite(chromeDriver);

            try
            {
                pyt.NavigateSubMenu(chromeDriver, "Lodging");
                rsn.NavigateSubMenu(chromeDriver, "Resort Comparison");
                deals.NavigateSubMenu(chromeDriver, "Beginner");
                passes.NavigateSubMenu(chromeDriver, "");
                // explore.NavigateSubMenu(chromeDriver, ""); 
            }
            catch
            {
                throw new AssertFailedException("Could not find Submenu Navigation Link"); 
            }
            
        }

        //Challenge #3
        [TestMethod]
        public void TestMethod3()
        {

        }

        //Challenge #4
        [TestMethod]
        public void TestMethod4()
        {

        }

        //Challenge #5
        [TestMethod]
        public void TestMethod5()
        {

        }


    }

}
