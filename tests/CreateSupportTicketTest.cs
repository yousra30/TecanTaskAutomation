using ConsoleApp1.pages;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace ConsoleApp1.tests
{
    [TestFixture]
    public class CreateSupportTicketTest: BaseTest
    {
        private SupportPage supportPage;
        private CreateTicketPage createTicketPage;

        [SetUp]
        public override void Setup()
        {
            base.Setup();
            supportPage = new SupportPage(driver);
            createTicketPage = new CreateTicketPage(driver);
        }

        [Test]
        public void TestCreateHelpdeskRequest()
        {

            ClassicAssert.IsTrue(supportPage.At(), "Not on the expected supportPage");
            supportPage.ScrollPageToLoginBotton();
            supportPage.ClickLoginOrSignupText();
            supportPage.LoginCredentials("yousra.ishtiaque@gmail.com", "youSRA_786");
            ClassicAssert.IsTrue(createTicketPage.At(), "Not on the expected TicketPage");
            createTicketPage.FillTicketForm();
        }
    }
}
