using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baigiamasis_Test.Page
{
    public class LogInPage : BasePage
    {
        private const string urlPage = "https://aivashop.lt/index.php?route=account/login";
        private IWebElement mailField => Driver.FindElement(By.Name("email"));
        private IWebElement passwordField => Driver.FindElement(By.Name("password"));
        private IWebElement logInButton => Driver.FindElement(By.ClassName("button"));

        public LogInPage(IWebDriver webdriver): base (webdriver)
        {
            Driver = webdriver;
        }

        public LogInPage Prisijungimas()
        {

            mailField.SendKeys("Vincas88");
            passwordField.SendKeys("slaptazodis22");
            logInButton.Click();
            return this;

        }

    }
}
