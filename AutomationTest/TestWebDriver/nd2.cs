using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWebDriver
{
    class nd2
    {

        public static IWebDriver _driver;

        [TearDown]
        public static void TearDown()
        {
            _driver.Close();
           
           
        }


        [TestCase("chrome", "Chrome 90 on Windows 7", TestName = "ChromeCase")]
        [TestCase("firefox", "Firefox 88 on Windows 7", TestName = "FirefoxCase")]
        public static void testoBlokas(string type, string expectedResult)
        {

             /*if (type.Equals("chrome"))
             {
                 _driver = new ChromeDriver();
                 _driver.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
                 IWebElement realResult = _driver.FindElement(By.CssSelector("#primary-detection > div"));
                 Assert.AreEqual(expectedResult, realResult.Text, $"Turejo buti {expectedResult}, bet buvo {realResult}");
             }
            if (type.Equals("firefox"))
            {
                _driver = new FirefoxDriver();
                _driver.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
                IWebElement realResult = _driver.FindElement(By.CssSelector(".simple-major"));
                Assert.AreEqual(expectedResult, realResult.Text, $"Turejo buti {expectedResult}, bet buvo {realResult}");
            }*/



            switch (type)
            {
                case "chrome":
                    _driver = new ChromeDriver();
                    _driver.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
                    IWebElement realResult = _driver.FindElement(By.CssSelector("#primary-detection > div"));
                    Assert.AreEqual(expectedResult, realResult.Text, $"Turejo buti {expectedResult}, bet buvo {realResult}");
                    break;

                case "firefox":
                    if (type.Equals("firefox"))
                    
                    _driver = new FirefoxDriver();
                    _driver.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
                    realResult = _driver.FindElement(By.CssSelector(".simple-major"));                               
                    Assert.AreEqual(expectedResult, realResult.Text, $"Turejo buti {expectedResult}, bet buvo {realResult}"); 
                    break;
             }

           
        }
    }
}
    
