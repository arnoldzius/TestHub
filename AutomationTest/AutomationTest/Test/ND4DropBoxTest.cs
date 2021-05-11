using AutomationTest.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest.Test
{
    public class ND4DropBoxTest
    {
        
        private static ND4DropBoxPage nd4DropBoxPage;

        [OneTimeSetUp]
        public static void SetUp()
        {
            IWebDriver driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "https://www.seleniumeasy.com/test/basic-select-dropdown-demo.html";
            nd4DropBoxPage = new ND4DropBoxPage(driver);
        }
 

       
        [Test]
        public static void GetFirstValueOfTwoSelected()
        {
            string pirmaState = "Florida";
            string antraState = "Texas";

            nd4DropBoxPage.SelectTwoStates(pirmaState, antraState)
                .ClickFirstValue()
                .ValidateFirstState(pirmaState);
        }

        [Test]
        public static void GetBothvaluesofTwoSelected()
        {
            string pirmaState = "Florida";
            string antraState = "Texas";

            nd4DropBoxPage.SelectTwoStates(pirmaState, antraState)
                .ClickAllValues()
                .ValidateTwoStates(pirmaState, antraState);
        }

        [Test]
        public static void SelectThreeStatesButValuateResultOfFirst()
        {
            string pirmaState = "Ohio";
            string antraState = "Pennsylvania";
            string treciaState = "California";
            nd4DropBoxPage.SelectThreeStates(pirmaState, antraState, treciaState)
                .ClickFirstValue()
                .ValidateFirstState(pirmaState);
        }
        [Test]
        public static void SelectFourStatesAndValuateAll()
        {
            string pirmaState = "Ohio";
            string antraState = "Pennsylvania";
            string treciaState = "California";
            string ketvirtaState = "Texas";
            nd4DropBoxPage.SelectFourStates(pirmaState, antraState, treciaState, ketvirtaState)
            .ClickAllValues()
            .ValidateFourStates(pirmaState, antraState, treciaState, ketvirtaState);
        }




    }
}
