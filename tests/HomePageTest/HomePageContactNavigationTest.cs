using NUnit.Framework;
using Task1.Pages;

namespace Task1.Tests.HomePageTest
{
    [TestFixture]
    public class HomePageContactNavigatioTest: BaseTest
    {
        private HomePage? homePage;
        private ContactPage? contactPage;

        [SetUp]
        public override void Setup()
        {
            base.Setup();
            homePage = new HomePage(driver);
            contactPage = new ContactPage(driver);
        }

        [Test]
        public void ContactPageNavigationTest()
        {
            homePage?.Navigate();
            homePage?.At();
            homePage?.ClickContactPage();
            contactPage?.At();
        }
    }
}
