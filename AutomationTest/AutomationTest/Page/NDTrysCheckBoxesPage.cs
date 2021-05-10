using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest.Page
{
    public class NDTrysCheckBoxesPage : NDTrysCheckBoxesBasePage
    {
       

        private IWebElement singleCheckBox => Driver.FindElement(By.Id("isAgeSelected"));
        private IWebElement checkedsingleCheckBox => Driver.FindElement(By.Id("txtAge"));
        private IReadOnlyCollection<IWebElement> multipleCheckBox => Driver.FindElements(By.ClassName("cb1-element"));
        private IWebElement checkAllButton => Driver.FindElement(By.Id("check1"));
        private IWebElement checkedButton => Driver.FindElement(By.Id("isChkd"));


        public NDTrysCheckBoxesPage (IWebDriver webdriver) : base(webdriver) { } // nurodome BasePage konstruktoriu
        
        public void ClickSingleChecktBox()
        {
            singleCheckBox.Click();
        }
        public void CheckValueOCheckedBox()
        {
            Assert.IsTrue(checkedsingleCheckBox.Text.Contains("Success - Check box is checked"));
        }

        public void CheckAllValues()
        {
            foreach (IWebElement element in multipleCheckBox)
            {
                if (!element.Selected)  // sauktukas reiskia nepazymetas. If elementas nepazymeta, tada Click'iname
                {
                    element.Click();
                }
               
            }
        }
        public void CheckIfAllButtonValueIsUncheckAll()
        {
        
            
          
            
        }






    }
}
