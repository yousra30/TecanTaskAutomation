﻿using Task1.Pages;
using NUnit.Framework;

namespace Task1.Tests.SupportTicketPageTest
{
    [TestFixture]
    public class CreateSupportTicketTest : BaseTest
    {
        private LoginPage? loginPage;
        private SupportPage? supportPage;
        private CreateTicketPage? createTicketPage;

        [SetUp]
        public override void Setup()
        {
            base.Setup();
            loginPage = new LoginPage(driver);
            supportPage = new SupportPage(driver);
            createTicketPage = new CreateTicketPage(driver);
        }

        [Test]
        public void TestCreateHelpdeskRequest()
        {
            loginPage?.Navigate();
            loginPage?.At();
            loginPage?.ScrollToLoginButton();
            loginPage?.ClickLoginOrSignupText();
            loginPage?.Login();
            supportPage?.At();
            supportPage?.ClickSubmitTicketButton();
            createTicketPage?.At();
            createTicketPage?.ClickSubmitTicketButton();
            createTicketPage?.ClickNewRequestButton();
            createTicketPage?.ClickTicketOptionButton();
            createTicketPage?.SelectLocation();
            createTicketPage?.SelectProductType();
            createTicketPage?.SelectProduct();
            createTicketPage?.EnterSerialNumber();
            createTicketPage?.EnterSubject();
            createTicketPage?.EnterRequestDescription();
            createTicketPage?.SelectCheckBox();
            createTicketPage?.AttachFile();
        }
    }
}
