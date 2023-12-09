using NUnit.Framework;
using Task1.Pages;

namespace Task1.Tests.HomePageTest
{
    [TestFixture]
    public class HomePageShopNavigationTest: BaseTest
    {
        private HomePage? homePage;
        private ShopPage? shopPage;

        [SetUp]
        public override void Setup()
        {
            base.Setup();
            homePage = new HomePage(driver);
            shopPage = new ShopPage(driver);
        }

        [Test]
        public void ShopPageNavigationTest()
        {
            homePage?.Navigate();
            homePage?.At();
            homePage?.ClickShopPage();
            shopPage?.At();
        }
    }
}
