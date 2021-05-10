using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWebDriver
{
    public class TestWebDriver
    {
       [Test]
        public static void TestChromeDriver()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://autoplius.lt";
            chrome.Close();
        }



        [Test]
        public static void TestYahooPage()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://login.yahoo.com/";

            IWebElement emailInputField = chrome.FindElement(By.Id("login-username"));
            emailInputField.SendKeys("Test@Automation.com");
            IWebElement nextButton = chrome.FindElement(By.CssSelector("#login-signin"));
            nextButton.Click();
            string expectedErrorMessage = "Sorry, we don't recognise this email adress.";   // persiziureti paskaita, issiaiskinti, kaip cia mes dareme? 
            IWebElement actualErrorMessage = chrome.FindElement(By.Id("username-error"));

            Assert.AreEqual(expectedErrorMessage, actualErrorMessage.Text);
           chrome.Close();

        }

        [Test]

        public static void SingleInputField()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";

            IWebElement enterMessageInput = chrome.FindElement(By.Id("user-message"));
            string expectedText = "Vasara";
            enterMessageInput.SendKeys(expectedText);
            IWebElement showMessageButton = chrome.FindElement(By.CssSelector("#get-input > button"));
            showMessageButton.Click();
            IWebElement result = chrome.FindElement(By.Id("display"));
            Assert.AreEqual("Vasara", result.Text, "Message is wrong!");
            chrome.Close();


        }
    }
}
