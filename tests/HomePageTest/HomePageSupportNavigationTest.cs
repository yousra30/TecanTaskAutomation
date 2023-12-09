using NUnit.Framework;
using System.ComponentModel.DataAnnotations;
using Task1.Pages;

namespace Task1.Tests.HomePageTest
{
    [TestFixture]
    public class HomePageSupportNavigationTest: BaseTest
    {
        private HomePage? homePage;
        private ContactPage? contactPage;
        private LoginPage? loginPage;
        private SupportPage? supportPage;

        [SetUp]
        public override void Setup()
        {
            base.Setup();
            homePage = new HomePage(driver);
            contactPage = new ContactPage(driver);
            loginPage = new LoginPage(driver);
            supportPage = new SupportPage(driver);
        }

        [Test]
        public void SupportPageNavigationTest()
        {
            homePage?.Navigate();
            homePage?.At();
            homePage?.ClickContactPage();
            contactPage?.At();
            contactPage?.RemoveTargetSupportPage();
            contactPage?.ClickSupportPage();
            loginPage?.At();
            loginPage?.ScrollToLoginButton();
            loginPage?.ClickLoginOrSignupText();
            loginPage?.Login();
            supportPage?.At();
        }
    }
}
