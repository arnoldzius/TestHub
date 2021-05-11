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
    class sportoTestas
    {
        public static IWebDriver _driver;
        [Test]
        public static void TestuojameSportoPuslapi()

        {
            _driver = new ChromeDriver();
            _driver.Url = "https://www.active.com/fitness/calculators/pace";
            IWebElement popUp = _driver.FindElement(By.CssSelector("#page-wrapper > aside > div > header > span"));
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            popUp.Click();
            IWebElement hourInputfield = _driver.FindElement(By.Name("time_hours"));
            hourInputfield.SendKeys("1");
            IWebElement minuteInputField = _driver.FindElement(By.Name ("time_minutes"));
            minuteInputField.SendKeys("5");
            IWebElement secondInputField = _driver.FindElement(By.Name("time_seconds"));
            secondInputField.SendKeys("0");
            IWebElement distanceInput = _driver.FindElement(By.Name("distance"));
            distanceInput.SendKeys("13");
            IWebElement openDistanceBox = _driver.FindElement(By.ClassName("selectboxit-arrow-container"));
            openDistanceBox.Click();                 
            IWebElement selectKm = _driver.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(3) > div > span > ul > li.selectboxit-option.selectboxit-option-first"));
            selectKm.Click();                                          
            IWebElement openPaceBox = _driver.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(4) > div > span > span"));
            openPaceBox.Click();                         
            IWebElement selectPerKm = _driver.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(4) > div > span > ul > li.selectboxit-option.selectboxit-option-first"));
            selectPerKm.Click();
            IWebElement confirm = _driver.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(6) > div > a"));
            confirm.Click();
            IWebElement paceResult = _driver.FindElement(By.Name("pace_minutes"));

            Assert.AreEqual("5", paceResult.Text ,"Values are different!"); // labiau pasigilinti i Assert palyginimus
             

           
            


        }


    }
}
