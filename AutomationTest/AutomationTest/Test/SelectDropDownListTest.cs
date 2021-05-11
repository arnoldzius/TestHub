using AutomationSolution.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationSolution.Test
{
    public class SelectDropDownListTest
    {
        private static SelectDropDownListPage selectDropDownPage;

        [OneTimeSetUp]
        public static void SetUp()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "https://www.seleniumeasy.com/test/basic-select-dropdown-demo.html";
            selectDropDownPage = new SelectDropDownListPage(driver);
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            // selectDropDownPage.CloseBrowser();
        }

        [Test]
        public static void SelectDay()
        {
            string dayOfWeek = "Monday";
            selectDropDownPage.SelectDropDownByText(dayOfWeek)
                .ValidateFirstDropdDownResult(dayOfWeek);
        }

        [Test]
        public static void SelectState()
        {
            string state = "Texas";
            selectDropDownPage.SelectMultiDropDownByText(state)
                .ClickFirstSelectedButton()
                .ValidateMutiDropdDownResult(state);
        }

        [Test]
        public static void SelectTwoStates()
        {
            string firstState = "Texas";
            string secondState = "Florida";
            selectDropDownPage.SelectMultiDropDown(firstState, secondState)
                .ClickFirstSelectedButton();
        }
    }
}