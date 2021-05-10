
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
    public class SingleFormDemoTest
    {
        public static IWebDriver _driver;
        // visi OneTimeSetUp/TearDown aprasomi TEST klasese.
        [OneTimeSetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
            IWebElement popUp = _driver.FindElement(By.Id("at-cv-lightbox-close"));
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(x => popUp.Displayed);
            popUp.Click();
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            _driver.Close();
        }

        [Test]
        public static void TestSingleInputField()                          // reikia INICIALIZUOTI musu sukurto page objekta SimpleFormDemoPage
        {                                                                 // raudonavo SimpleFormDemoPage, tad lemputeje pasirenkame using.AutomationTest.Page
            SimpleFormDemoPage page = new SimpleFormDemoPage(_driver);   // tam esamam musu sukurtam page sukuriame nauja objekta. IR tam objektui perduosime savo turima _driver
            string text = "Vasara";                                      // kad butent naudoja is musu sukurto page driveri

            page.InsertTextToSingleInputField(text);
            page.ClickShowMessageButton();
            page.VerifySingleInputField(text);
        }

        [TestCase("2", "2", "4", TestName = "2 + 2 = 4")]
        [TestCase("-5", "3", "-2", TestName = "-5 + 3 = -2")]
        [TestCase("a", "b", "NaN", TestName = "a + b = NaN")]
        public static void TestSumBlock(string firstInput, string secondInput, string result)
        {
            SimpleFormDemoPage page = new SimpleFormDemoPage(_driver);  // nukopinave ir iklijuoja kiekvienam testui objekta

            page.InsertBothValuesToInputFields(firstInput, secondInput);
            page.ClickGetTotalButton();
            page.VerifySumResult(result);


        }

















    }
}
