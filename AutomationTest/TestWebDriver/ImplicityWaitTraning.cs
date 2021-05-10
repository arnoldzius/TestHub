using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWebDriver
{
    class ImplicityWaitTraning
    {
        public static IWebDriver _driver;

        [Test]
        public void ImplicityTest()
        {
            _driver = new ChromeDriver();
            _driver.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
            IWebElement popUp = _driver.FindElement(By.Id("at-cv-lightbox-close"));
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            popUp.Click();
            
        }

        /*_driver = new ChromeDriver();
        _driver.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
            IWebElement popUp = _driver.FindElement(By.Id("at-cv-lightbox-close"));
        WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        wait.Until(x => popUp.Displayed);
            popUp.Click();*/
        









    }   



}
