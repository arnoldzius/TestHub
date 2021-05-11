using AutomationSolution.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest.Page
{
    public class ND4DropBoxPage : BasePage
    {
 
        private const string urlPage = "https://www.seleniumeasy.com/test/basic-select-dropdown-demo.html"; // nesuprantu, kokiu tikslu pasidarome const?

        private SelectElement multipleDropDown => new SelectElement(Driver.FindElement(By.Id("multi-select")));  // apsirasome SelectElement kintamaji
        private IWebElement firstSelectedValueButton => Driver.FindElement(By.Id("printMe"));
        private IWebElement allSelectedValuesButton => Driver.FindElement(By.Id("printAll"));
        private IWebElement getSelectedResult => Driver.FindElement(By.ClassName("getall-selected"));

        public ND4DropBoxPage(IWebDriver webdriver): base(webdriver) 
        {
            Driver = webdriver;                     
        }
        public ND4DropBoxPage SelectStateByTextFromDropDown(string text)
        {
            multipleDropDown.SelectByText(text);
            return this;
        }
        public ND4DropBoxPage ClickFirstValue()
        {
            firstSelectedValueButton.Click();
            return this;
        }
        public ND4DropBoxPage ClickAllValues()
        {
            allSelectedValuesButton.Click();
            return this;
        }

        public ND4DropBoxPage SelectTwoStates(string pirmaState,string antraState)
        {
            Actions action = new Actions(Driver);
            SelectStateByTextFromDropDown(pirmaState);
            action.KeyDown(Keys.Control);
            SelectStateByTextFromDropDown(antraState);
            action.KeyUp(Keys.Control);
            action.Build().Perform();
            return this;
        }
        public ND4DropBoxPage SelectThreeStates(string pirmaState, string antraState, string treciaState)
        {
            Actions action = new Actions(Driver);
            SelectStateByTextFromDropDown(pirmaState);
            action.KeyDown(Keys.Control);
            SelectStateByTextFromDropDown(antraState);
            SelectStateByTextFromDropDown(treciaState);
            action.KeyUp(Keys.Control);
            action.Build().Perform();
            return this;
        }
        public ND4DropBoxPage SelectFourStates(string pirmaState, string antraState, string treciaState, string ketvirtaState)
        {
            Actions action = new Actions(Driver);
            SelectStateByTextFromDropDown(pirmaState);
            action.KeyDown(Keys.Control);
            SelectStateByTextFromDropDown(antraState);
            SelectStateByTextFromDropDown(treciaState);
            action.KeyUp(Keys.Control);
            action.Build().Perform();
            return this;
        }
        public ND4DropBoxPage ValidateFirstState(string text)
        {
            Assert.IsTrue(getSelectedResult.Text.Contains(text), "Selected state is incorrect!"); 
            return this;
        }
        public ND4DropBoxPage ValidateTwoStates(string pirmaState, string antraState)
        {
            Assert.IsTrue(getSelectedResult.Text.Contains($"{pirmaState},{pirmaState}"), "Selected state is incorrect!");
            return this;
        }
        public ND4DropBoxPage ValidateFourStates(string pirmaState, string antraState, string treciaState, string ketvirtaState)
        {
            Assert.IsTrue(getSelectedResult.Text.Contains($"{pirmaState}, {antraState}, {treciaState}, {ketvirtaState}"), "Selected state is incorrect!");
            return this;
        }

    }
}
