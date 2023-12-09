using Task1.pages;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Task1.tests
{
    [TestFixture]
    public class SearchBarTest: BaseTest
    {
        private HomePage homePage;
    
        [SetUp]
        public override void Setup()
        {
            base.Setup();
            homePage = new HomePage(driver);
        }

        [Test]
        public void TestSearchForMagniflex()
        {
            homePage.Navigate();
            homePage.At();
            ClassicAssert.IsTrue(homePage.SearchBarVisible(), "Searchbar not shown");
            homePage.EnterSearchText("Magniflex");
            ClassicAssert.GreaterOrEqual(1, homePage.CountSearchResults(), "Expected more than one search result");
        }
    }
}
