using NUnit.Framework;
using OpenQA.Selenium;
using Boosting.Driver;
using Boosting.PageObjects;
using Boosting.TestData;
using System.Net.Http;

namespace Boosting.Tests.UiTests
{
    public class BaseTest
    {
        protected TestDetails Data = JsonManager.GetTestData();
        internal HomePage homePage = new HomePage();
        internal DemoQa demoQa = new DemoQa();
        public IWebDriver WebDriver => DriverFactory.Driver;

        [OneTimeSetUp]
        public void Start()
        {
            DriverFactory.InitalizerDriver(); ;
            WebDriver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public void Close()
        {
            DriverFactory.QuitDriver();
        }
    }
}
