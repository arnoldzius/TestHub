using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTest
{
    class Class1
    {
        [Test]
        public static void TestuojameWebDriverElementFunkcija()
        {
            IWebDriver chrome = new ChromeDriver();
            {
                chrome.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";

                IWebElement enterMessageInput = chrome.FindElement(By.Id("user-message"));
                string expectedText = "Vasara";
                enterMessageInput.SendKeys(expectedText);
                IWebElement showMessageButton = chrome.FindElement(By.CssSelector("#get-input > button")); // copy is developer tools desini klavisa ir cssSelector
                showMessageButton.Click();
                IWebElement result = chrome.FindElement(By.Id("display"));
                Assert.AreEqual("Vasara", result.Text, "Nesutampa tekstas");
                chrome.Close();

            }
        }

        [Test]
        public static void namuDarbaiAirB()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
            IWebElement enterAInput = chrome.FindElement(By.Id("sum1"));
            string expectedA = "a";
            enterAInput.SendKeys(expectedA);
            IWebElement enterBInput = chrome.FindElement(By.Id("sum2"));
            string expectedB = "b";
            enterBInput.SendKeys(expectedB);
            IWebElement popUp = chrome.FindElement(By.Id("at-cv-lightbox-close"));
            popUp.Click();
            IWebElement getTotal = chrome.FindElement(By.CssSelector("#gettotal > button"));
            getTotal.Click();

            IWebElement realResult = chrome.FindElement(By.Id("displayvalue"));
            string expectedResult = "NaN";
            Assert.AreEqual("NaN", realResult.Text, "Nesutampa tekstas");
            chrome.Close();

        }

        [Test]
        public static void namuDarbaiminu5plus3()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
            IWebElement enterAInput = chrome.FindElement(By.Id("sum1"));
            string expectedA = "-5";
            /*Galima aprasyti expected kintamaji kaip int.Taciau vykdant metoda 'enterAInput.SendKeys()'
             butinai reikia int tipa paversti i string, nes 'SendKeys()' metodas priima tik string tipo reiksme.*/
            enterAInput.SendKeys(expectedA);
            IWebElement enterBInput = chrome.FindElement(By.Id("sum2"));
            string expectedB = "3";
            enterBInput.SendKeys(expectedB);
            IWebElement getTotal = chrome.FindElement(By.CssSelector("#gettotal > button"));
            getTotal.Click();

            IWebElement realResult = chrome.FindElement(By.Id("displayvalue"));
            string expectedResult = "-2";
            Assert.AreEqual("-2", realResult.Text, "Nesutampa tekstas");
            chrome.Close();

        }



        [Test]
        public static void namuDarbaim2Plius2()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
            chrome.Manage().Window.Maximize();
            IWebElement enterAInput = chrome.FindElement(By.Id("sum1"));
            string expectedA = "2";
            enterAInput.SendKeys(expectedA);
            IWebElement enterBInput = chrome.FindElement(By.Id("sum2"));
            string expectedB = "2";
            enterBInput.SendKeys(expectedB);
            IWebElement getTotal = chrome.FindElement(By.CssSelector("#gettotal > button"));
            getTotal.Click();

            IWebElement realResult = chrome.FindElement(By.Id("displayvalue"));
            Assert.AreEqual("4", realResult.Text, "Nesutampa tekstas");
            chrome.Close();


        }




        [Test]
        public static void vartuTechnika2000X2000()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "http://vartutechnika.lt/";
            IWebElement plotis = chrome.FindElement(By.Id("doors_width"));
            string width = "2000";
            plotis.SendKeys(width);
            IWebElement aukstis = chrome.FindElement(By.Id("doors_height"));
            string height = "2000";
            aukstis.SendKeys(height);
            IWebElement automatika = chrome.FindElement(By.Id("automatika"));
            automatika.Click();
            IWebElement confirm = chrome.FindElement(By.Id("calc_submit"));
            confirm.Click();
            IWebElement rezultatas = chrome.FindElement(By.Id("calc_result")); 
            Assert.AreEqual("Vartų kaina dabar - TIK 665.98€!", rezultatas.Text, "Neatitinka tekstas");
            // nesigauna paimti rezultato ir palyginti
        }





        public static IWebDriver _driver;
        
        [OneTimeSetUp]
        public static void Atidarymas()
        {
            _driver = new ChromeDriver();
            _driver.Url = "https://www.skelbiu.lt/";

            IWebElement popUp = _driver.FindElement(By.Id("onetrust-accept-btn-handler"));
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(x => popUp.Displayed);
            popUp.Click();
        }
        [OneTimeTearDown]
        public static void TearDown()
        {
            _driver.Close();
        }

        [TestCase("vizlas", TestName = "Vizlo paieska")]
        [TestCase("dviraciai", TestName = "Dviracio paieska")]
        [TestCase("valtys", TestName = "Valties paieska")]

        public static void TestoBlokas(string name, string result)
        {
            IWebElement searchField = _driver.FindElement(By.Id("searchKeyword"));
            searchField.Clear();
            searchField.SendKeys(name);
            IWebElement confirmButton = _driver.FindElement(By.CssSelector("#searchButton > i"));
            confirmButton.Click();

        }


    }
}
