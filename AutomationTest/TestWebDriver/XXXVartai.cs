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
    class XXXVartai
    {
        public static IWebDriver _driver;  // apsirasome kintamaji


        [OneTimeSetUp]
        public void SetUp()   // apsirasome viena karta PRIES visus testus naudojama metoda, kuris atidaro puslapi.
        {
            _driver = new ChromeDriver();
            _driver.Url = "http://vartutechnika.lt/"; 
        }
        [OneTimeTearDown]
        public void TearDown()// apsirasome viena karta Po visu testu naudojama metoda, kuris uzdaro puslapi.
        {
            _driver.Close();
        }

        [TestCase("2000", "2000", true, false, "665.98€", TestName = "2000 x 2000 + Vartų automatika = 665.98€")]
        [TestCase("2000", "2000", true, true, "780.49€", TestName = "2000 x 2000 + Vartų automatika + Vartų montavimo darbai = 1006.43€")]
        [TestCase("4000", "2000", false, false, "692.35€", TestName = "4000 x 2000 = 692.35€")]
        [TestCase("5000", "2000", false, true, "989.21€", TestName = "5000 x 2000 + Vartų montavimo darbai = 989.21€")]
        // aprasomi visi testcase'ai. True/false reiksmes pazymimos kaip pazymetas/nepazymetas check box'as.
        // TestName tiesiog suteikia testcase'ui paprastesni, mums labiau patogesni pavadinima
        public static void vartuTechnikosTestoBlokas(string width, string height, bool gateAuto, bool darbai, string result)
        {
            IWebElement widthInput = _driver.FindElement(By.Id("doors_width")); // widthInput laukelio uzpildymas
            widthInput.Clear();  // issivalomas langelis witdhInput, kad galetume ivesti reiksme, nes reiksmes isirasys kitos
            widthInput.SendKeys(width);  // irasomos reiksmes 

            IWebElement heightInput = _driver.FindElement(By.Id("doors_height")); // heightInput laukelio uzpildymas
            heightInput.Clear();
            heightInput.SendKeys(height);

            IWebElement automatikaCheckBox = _driver.FindElement(By.Id("automatika"));
            if (gateAuto && !automatikaCheckBox.Selected)
            {
                automatikaCheckBox.Click();
            }
            IWebElement darbaiCheckBox = _driver.FindElement(By.Id("darbai"));
            if (darbai && !darbaiCheckBox.Selected)
            {
                darbaiCheckBox.Click();
            }

            _driver.FindElement(By.Id("calc_submit")).Click();
            IWebElement resultBox = _driver.FindElement(By.CssSelector("#calc_result > div"));

            Assert.IsTrue(resultBox.Text.Contains(result), $"Suma neteisinga. Expected value is {result}, but actual result is {resultBox.Text}");

        }



    }
}
