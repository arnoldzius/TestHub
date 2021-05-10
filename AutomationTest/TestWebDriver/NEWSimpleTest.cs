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
    class NEWSimpleTest
    {
        [Test]
        public static void SimpleTest()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://www.seleniumeasy.com/test/basic-checkbox-demo.html";
            IWebElement singleCheckBox = chrome.FindElement(By.Id("isAgeSelected"));
            singleCheckBox.Click();
            IWebElement singleCheckBoxActualResult = chrome.FindElement(By.Id("txtAge"));


            Assert.IsTrue("Success - Check box is checked".Contains(singleCheckBoxActualResult.Text), "Values are different!");
        }




    }
}
