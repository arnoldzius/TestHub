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
    public class NDTrysCheckBoxesTest
    {
        public static IWebDriver _driver;

        [OneTimeSetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Url = "https://www.seleniumeasy.com/test/basic-checkbox-demo.html";
        }
        [TearDown]
        public void CloseDriver()
        {
            _driver.Close();
        }


        [Test]
        public static void TestOfSingleCheckBox()
        {
            NDTrysCheckBoxesPage page = new NDTrysCheckBoxesPage(_driver);

            page.ClickSingleChecktBox();
            page.CheckValueOCheckedBox();
        }
        [Test]
        public static void MultipleCheckBox()
        {
            NDTrysCheckBoxesPage page = new NDTrysCheckBoxesPage(_driver);

            page.CheckAllValues();
            
            
        }
    }
}
