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
        private static IWebDriver _driver;

        [Test]
        public void ImplicityWait()
        {
            _driver = new ChromeDriver();
            _driver.Url = "http://vartutechnika.lt/";
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement cookies = _driver.FindElement(By.Id("cookiescript_close"));
            cookies.Click();

            cookies.Click();

        }


            /*_driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
            _driver.Url = "http://vartutechnika.lt/";
            IWebElement cookies = _driver.FindElement(By.Id("cookiescript_close"));
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
             wait.Until(x => cookies.Displayed);
            cookies.Click();*/
        

    
        
        
        
        
        
        
        
    }   



}
