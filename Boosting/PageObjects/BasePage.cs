using OpenQA.Selenium;
using Boosting.Driver;
using Boosting.TestData;

namespace Boosting.PageObjects
{
    public class BasePage
    {
        protected IWebDriver Driver;
        internal TestDetails Data = JsonManager.GetTestData();

        public BasePage()
        {
            DriverFactory.InitalizerDriver();
            Driver = DriverFactory.Driver;
        }
    }
}
