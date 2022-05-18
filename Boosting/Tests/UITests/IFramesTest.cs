using Boosting.Tests.UiTests;
using NUnit.Framework;

namespace Boosting.Tests.UITests
{
    [TestFixture]
    internal class IFramesTest : BaseTest
    {
        [SetUp]
        public void Open()
        {
            WebDriver.Navigate().GoToUrl(Data.Url);
        }

        [Test]
        public void OpenTwoTabs()
        {
            demoQa.Switch();
            demoQa.SwitchToDefaultContent();
            Assert.IsTrue(demoQa.IsItDefaultContent());
        }
    }
}
