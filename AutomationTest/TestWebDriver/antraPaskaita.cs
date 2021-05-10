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
    class antraPaskaita
    {
        
        public static IWebDriver driver;


        [OneTimeSetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Url = "http://vartutechnika.lt/";
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            driver.Close();
        }
       
        [TestCase("2000", "2000", true, false, "665.98€", TestName = "2000 x 2000 + Vartų automatika = 665.98€")]
        [TestCase("2000", "2000", true, true, "780.49€", TestName = "2000 x 2000 + Vartų automatika + Vartų montavimo darbai = 1006.43€")]
        [TestCase("4000", "2000", false, false, "692.35€", TestName = "4000 x 2000 = 692.35€")]
        [TestCase("5000", "2000", false, true, "989.21€", TestName = "5000 x 2000 + Vartų montavimo darbai = 989.21€")]
       

        public static void TestVartuAutomatika(string width, string height, bool gateAuto, bool darbai, string result)
        {
            IWebElement widthInput = driver.FindElement(By.Id("doors_width"));
            widthInput.Clear();
            widthInput.SendKeys(width);

            IWebElement heightInput = driver.FindElement(By.Id("doors_height"));
            heightInput.Clear();
            heightInput.SendKeys(height);

            IWebElement automatikaCheckBox = driver.FindElement(By.Id("automatika"));
            if (gateAuto && !automatikaCheckBox.Selected)
            {
                automatikaCheckBox.Click();
            }
            driver.FindElement(By.Id("calc_submit")).Click();
            IWebElement resultBox = driver.FindElement(By.CssSelector("#calc_result > div"));

            Assert.IsTrue(resultBox.Text.Contains(result), $"Suma neteisinga. Expected value is {result}, but actual result is {resultBox.Text}");

        }

     
    }











}

