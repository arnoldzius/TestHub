using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationSolution.Page
{
    public class SelectDropDownListPage : BasePage
    {
        private const string urlPage = "https://www.seleniumeasy.com/test/basic-select-dropdown-demo.html";

        private SelectElement selectADayDropDown => new SelectElement(Driver.FindElement(By.Id("select-demo")));
        private IWebElement selectedDayResult => Driver.FindElement(By.ClassName("selected-value"));

        private SelectElement multipleDropDown => new SelectElement(Driver.FindElement(By.Id("multi-select")));

        private IWebElement firstSelectedButton => Driver.FindElement(By.Id("printMe"));

        private IWebElement getAllSelectedButton => Driver.FindElement(By.Id("printAll"));

        private IWebElement multiDropDownResult => Driver.FindElement(By.ClassName("getall-selected"));


        public SelectDropDownListPage(IWebDriver webdriver) : base(webdriver)
        {
            Driver.Url = urlPage;
        }

        public SelectDropDownListPage SelectDropDownByText(string text)
        {
            selectADayDropDown.SelectByText(text);
            return this;
        }

        public SelectDropDownListPage ValidateFirstDropdDownResult(string text)
        {
            Assert.IsTrue(selectedDayResult.Text.Contains(text), "Selected day is incorrect!");
            return this;
        }

        public SelectDropDownListPage SelectMultiDropDownByText(string text)
        {
            multipleDropDown.SelectByText(text);
            return this;
        }

        public SelectDropDownListPage ClickFirstSelectedButton()
        {
            firstSelectedButton.Click();
            return this;
        }

        public SelectDropDownListPage ValidateMutiDropdDownResult(string text)
        {
            Assert.IsTrue(multiDropDownResult.Text.Contains(text), "Selected state is incorrect!");
            return this;
        }

        public SelectDropDownListPage SelectMultiDropDown(string firstState, string secondState)
        {
            Actions action = new Actions(Driver);
            SelectMultiDropDownByText(firstState);
            action.KeyDown(Keys.Control);
            SelectMultiDropDownByText(secondState);
            action.KeyUp(Keys.Control);
            action.Build().Perform();
            return this;
            
        }

        public SelectDropDownListPage ValidateTwoStates(string firstState, string secondState)
        {
            Assert.IsTrue(multiDropDownResult.Text.Contains($"{firstState},{secondState}"), "Selected state is incorrect!");
            return this;
        }

    }
}