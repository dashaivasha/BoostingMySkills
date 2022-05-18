using Boosting.Driver;
using OpenQA.Selenium;

namespace Boosting.PageObjects
{
    internal class DemoQa : BasePage
    {
        public DemoQa()
        {
        }

        public int GetIframes()
        {
            var iframeElements = Driver.FindElements(By.TagName("iframe"));

            return iframeElements.Count;
        }

        public void SwitchToDefaultContent()
        {
            Driver.SwitchTo().DefaultContent();
        }

        public void Switch()
        {
            for (int i = 0; i < GetIframes(); i++)
            {
                Driver.SwitchTo().Frame(i);
            }
        }

        public bool IsItDefaultContent()
        {
            return WebDriverExtensions.FindElement(Driver, By.XPath("//div[@id='framesWrapper']"), Data.WaitTime).Enabled;
        }
    }
}
