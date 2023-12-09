using NUnit.Framework;
using NUnit.Framework.Legacy;
using Task1.Pages;

namespace Task1.Tests.HomePageTest
{
    [TestFixture]
    public class HomePageSearchBarVisibleTest: BaseTest
    {
        private HomePage? homePage;

        [SetUp]
        public override void Setup()
        {
            base.Setup();
            homePage = new HomePage(driver);
        }

        [Test]
        public void SearchBarVisible()
        {
            homePage?.Navigate();
            homePage?.At();
            ClassicAssert.IsTrue(homePage?.SearchBarVisible(), "Searchbar not shown");
        }
    }
}
