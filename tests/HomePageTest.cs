using Task1.pages;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task1.tests
{
    [TestFixture]
    public class HomePageTest: BaseTest
    {
        private HomePage homePage;
        private ShopPage shopPage;
        private ContactPage contactPage;
        private LoginPage loginPage;
        private SupportPage supportPage;

        [SetUp]
        public override void Setup()
        {
            base.Setup();
            homePage = new HomePage(driver);
            shopPage = new ShopPage(driver);
            contactPage = new ContactPage(driver);
            loginPage = new LoginPage(driver);
            supportPage = new SupportPage(driver);
        }

        [Test]
        [TestMethod]
        public void ShopPageNavigationTest()
        {
            homePage.Navigate();
            homePage.At();
            homePage.ClickShopPage();
            shopPage.At();
        }

        [Test]
        [TestMethod]
        public void ContactPageNavigationTest()
       {
            homePage.Navigate();
            homePage.At();
            homePage.ClickContactPage();
            contactPage.At();
        }

        [Test]
        [TestMethod]
        public void SupportPageNavigationTest()
         {
            homePage.Navigate();
            homePage.At();
            homePage.ClickContactPage();
            contactPage.At();
            contactPage.RemoveTargetSupportPage();
            contactPage.ClickSupportPage();
            loginPage.At();
            loginPage.ScrollToLoginButton();
            loginPage.ClickLoginOrSignupText();
            loginPage.LoginCredentials("yousra.ishtiaque@gmail.com", "testTASK_123");
            supportPage.At();
        }

        [Test]
        [TestMethod]
        public void SearchBarVisible()
        {
            homePage.Navigate();
            homePage.At();
            ClassicAssert.IsTrue(homePage.SearchBarVisible(), "Searchbar not shown");
        }

    }
}