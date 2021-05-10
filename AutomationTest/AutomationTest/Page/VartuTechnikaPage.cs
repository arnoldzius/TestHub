using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest.Page
{
    public class VartuTechnikaPage
    {

        private static IWebDriver _driver;

        private IWebElement widthInput => _driver.FindElement(By.Id("doors_width"));
        private IWebElement heightInput => _driver.FindElement(By.Id("doors_height"));
        private IWebElement automatikaCheckBox => _driver.FindElement(By.Id("automatika"));
        private IWebElement darbaiCheckBox => _driver.FindElement(By.Id("darbai"));
        private IWebElement calculatePriceButton => _driver.FindElement(By.Id("calc_submit"));
        private IWebElement resultBox => _driver.FindElement(By.CssSelector("#calc_result > div"));

        // susikuriame konstrukturiu sios klases VartuTechnikaPage
        public VartuTechnikaPage(IWebDriver webdriver)  // webdriver paveldesime is testu klases
        {
            _driver = webdriver;
        }



        public void InsertWidth(string width)
        {
            widthInput.Clear();
            widthInput.SendKeys(width);
        }
        public void InsertHeight(string height)
        {
            heightInput.Clear();
            heightInput.SendKeys(height);
        }
        public void InsertWidthAndHeight(string width, string height)
        {
            widthInput.Clear();
            widthInput.SendKeys(width);
            heightInput.Clear();
            heightInput.SendKeys(height);
        }

        public void CheckAutoCheckBox (bool shouldBeChecked)
        {
            if (shouldBeChecked != automatikaCheckBox.Selected)
            {
                automatikaCheckBox.Click();
            }
        }
        public void CheckWorkCheckBox(bool shouldBeChecked)
        {
            if (shouldBeChecked != darbaiCheckBox.Selected)
            {
                darbaiCheckBox.Click();
            }
        }
        public void ClickCalculateButton()
        {
            calculatePriceButton.Click();
        }
        public void CheckResult(string result)
        {
            Assert.IsTrue(resultBox.Text.Contains(result), $"Suma neteisinga! Expected value was {result}, but actual result is {resultBox.Text}");
        }
    }
}
