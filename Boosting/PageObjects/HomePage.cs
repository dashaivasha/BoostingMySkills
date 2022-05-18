using Boosting.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace Boosting.PageObjects
{
    public class HomePage : BasePage
    {
        private By MyCartButton = By.XPath("//div[@class='shopping_cart']//a[contains(@title,'View')]");
        private IWebElement SignInButton => Driver.FindElement(By.XPath("//div[@class='header_user_info']//a"));
        
        public HomePage()
        {
        }

        public void OpenCartInNewTab()
        {
            WebDriverExtensions.FindElement(Driver, MyCartButton, Data.WaitTime).SendKeys(Keys.Control + Keys.Enter);
        }
        public void OpenSignInNewTab()
        {
            SignInButton.SendKeys(Keys.Control + Keys.Enter);
        }

        public void SwitchToNewTab()
        {
            for (int i=0; i < GetTabsId();i++)
            { 
                Driver.SwitchTo().Window(Driver.WindowHandles[i]);
                Driver.Close();

            }
        }

        public int GetTabsId()
        {
            List<String> tabs_id = new List<String>(Driver.WindowHandles);
            return tabs_id.Count;
        }

        public bool IsLastTabOpen()
        {
            if (GetTabsId() == 1)
            {
                return true;
            }

            return false;
        }
    }
}
