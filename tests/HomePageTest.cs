using ConsoleApp1.pages;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ConsoleApp1.tests
{
    [TestFixture]
    public class HomePageTest: BaseTest
    {
        private HomePage homePage;
        private ShopPage shopPage;
        private ContactPage contactPage;
        private SupportPage supportPage;

        [SetUp]
        public override void Setup()
        {
            base.Setup();
            homePage = new HomePage(driver);
            shopPage = new ShopPage(driver);
            contactPage = new ContactPage(driver);
            supportPage = new SupportPage(driver);
        }

        [Test]
        public void ShopPageNavigationTest()
        {
            ClassicAssert.IsTrue(homePage.At(), "Not on the expected homePage");
            homePage.ClickShopPage();
            ClassicAssert.IsTrue(shopPage.At(), "Not on the expected shopPage");
        }

        [Test]
        public void ContactPageNavigationTest()
        {
            ClassicAssert.IsTrue(homePage.At(), "Not on the expected homePage");
            homePage.ClickContactPage();
            ClassicAssert.IsTrue(contactPage.At(), "Not on the expected contactPage");
        }

        [Test]
        public void SupportPageNavigationTest()
        {
            ClassicAssert.IsTrue(homePage.At(), "Not on the expected homePage");
            homePage.ClickContactPage();
            ClassicAssert.IsTrue(contactPage.At(), "Not on the expected contactPage");
            contactPage.ClickSupportPage();
            ClassicAssert.IsTrue(supportPage.At(), "Not on the expected supportPage");
        }

        [Test]
        public void SearchBarVisible()
        {
            ClassicAssert.IsTrue(homePage.At(), "Not on the expected homePage");
            ClassicAssert.IsTrue(homePage.SearchBarVisible(), "Searchbar not shown");
        }

    }
}