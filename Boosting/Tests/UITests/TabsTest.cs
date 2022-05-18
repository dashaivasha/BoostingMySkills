using NUnit.Framework;

namespace Boosting.Tests.UiTests
{
    [TestFixture]
    internal class TabsTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            WebDriver.Navigate().GoToUrl(Data.HomePageUrl);
        }

        [Test]
        public void OpenTwoTabs()
        {
            homePage.OpenCartInNewTab();
            homePage.OpenSignInNewTab();
            homePage.SwitchToNewTab();
            Assert.IsTrue(homePage.IsLastTabOpen());
        }
    }
}
