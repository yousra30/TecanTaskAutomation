using NUnit.Framework.Legacy;
using NUnit.Framework;
using Task1.Pages;

namespace Task1.Tests.HomePageTest
{
    public class HomePageSearchTextTest: BaseTest
    {
        private HomePage? homePage;

        [SetUp]
        public override void Setup()
        {
            base.Setup();
            homePage = new HomePage(driver);
        }

        [Test]
        public void TestSearchForMagniflex()
        {
            homePage?.Navigate();
            homePage?.At();
            ClassicAssert.IsTrue(homePage?.SearchBarVisible(), "Searchbar not shown");
            homePage?.EnterSearchText("Magniflex");
            ClassicAssert.GreaterOrEqual(1, homePage?.CountSearchResults() ?? 0, "Expected more than one search result");
        }
    }
}
