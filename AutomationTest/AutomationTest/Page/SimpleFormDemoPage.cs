using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest.Page
{
    public class SimpleFormDemoPage
    {
        private static IWebDriver _driver; // susikuriame _driver; Driver privat, nes veiks tik sios klases viduje.

        private IWebElement enterMessageInput => _driver.FindElement(By.Id("user-message"));   // susirasome visus elementus. Elementai suraso pries konstruktorius
        private IWebElement showMessageButton => _driver.FindElement(By.CssSelector("#get-input > button")); // elementus darome private, nes bus naudojami tik page klaseje
        private IWebElement singleInputResult => _driver.FindElement(By.Id("display"));   // visi elementai su => zenklu kombinacija
        private IWebElement firstInputField => _driver.FindElement(By.Id("sum1"));
        private IWebElement secondInputField => _driver.FindElement(By.Id("sum2"));
        private IWebElement getTotalButton => _driver.FindElement(By.CssSelector("#gettotal > button"));
        private IWebElement actualResult => _driver.FindElement(By.Id("displayvalue"));



        public SimpleFormDemoPage(IWebDriver webdriver) // sukuriame sios klases konstruktoriu
        {
            _driver = webdriver;        // sukuriame driveri,kuri paveldes Test klase. Joje jau naudosime webdriver. Gausis kiap paveldejimas
        }

        // po konstruktoriu apsirasome funkcijas(metodus), kurias kvies testas, todel public tipas
        public void InsertTextToSingleInputField (string text)
        {
            enterMessageInput.Clear();  // galime issivalyti laukeli, kad neliktu praeito testo informacijos
            enterMessageInput.SendKeys(text);
        }
        public void ClickShowMessageButton()
        {
            showMessageButton.Click();
        }
        public void VerifySingleInputField(string expectedResult)
        {
            Assert.AreEqual(expectedResult, singleInputResult.Text, "Text is not the same!");  // visada tvarka - expected result, real result.
        }                                                 
        public void InsertFirstInputValue ( string firstInput)
        {
            firstInputField.Clear();
            firstInputField.SendKeys(firstInput);
        }
        public void InsertSecondInputValue(string secondInput)
        {
            secondInputField.Clear();
            secondInputField.SendKeys(secondInput);
        }
        public void InsertBothValuesToInputFields(string firstInput, string secondInput)
        {
            firstInputField.Clear();
            firstInputField.SendKeys(firstInput);
            secondInputField.Clear();
            secondInputField.SendKeys(secondInput);
        }
        public void ClickGetTotalButton()
        {
            getTotalButton.Click();
        }
        public void VerifySumResult(string expectedResult)
        {
            Assert.AreEqual(expectedResult, actualResult.Text, "Results are not equal!");
        }




    }
}
