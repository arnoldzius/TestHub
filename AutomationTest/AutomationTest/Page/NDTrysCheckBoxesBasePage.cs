using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest.Page
{
    public class NDTrysCheckBoxesBasePage
    {
        protected static IWebDriver Driver; // sukuriame kintamaji protected. Driver susikuriame su didziaja raide.

        public NDTrysCheckBoxesBasePage (IWebDriver webdriver)  // sukuriame onstruktoriu butent sitai BasePage klasei
        {
            Driver = webdriver;
        }

        public void CloseDriver()
        {
            Driver.Close();
        }


    }
}
