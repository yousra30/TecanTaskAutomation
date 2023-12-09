using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace Task1.pages
{
    public class LoginPage: Page
    {
        private string loginPage = "https://helpdesk.tecan.com/en/support/login";
        private IWebElement loginOrSignUpText => driver.FindElement(By.XPath("//a[contains(text(),'log in or sign-up')]"));
        private IWebElement emailField => driver.FindElement(By.XPath("//input[@id='1-email']"));
        private IWebElement passwordField => driver.FindElement(By.XPath("//input[@id='1-password']"));
        private IWebElement loginButton => driver.FindElement(By.XPath("/html[1]/body[1]/main[1]/div[1]/div[2]/form[1]/div[1]/div[1]/div[1]/button[1]/span[1]"));
        private IWebElement banner => driver.FindElement(By.XPath("//body/main[@id='fw-main-content']/div[1]/div[1]"));


        public LoginPage(IWebDriver driver) : base(driver)
        {
            // Pass the driver instance to the base constructor
        }

        public override void At()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//body/main[@id='fw-main-content']/div[1]/div[1]")));
        }

        public void ScrollToLoginButton()
        {
            ScrollToElement(loginOrSignUpText);
        }

        public void Navigate()
        {
            driver.Navigate().GoToUrl(loginPage);
        }

        public void ClickLoginOrSignupText()
        {
            loginOrSignUpText.Click();
        }
        public void LoginCredentials(string email, string password)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@id='1-email']")));
            emailField.SendKeys(email);
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@id='1-password']")));
            passwordField.SendKeys(password);
            loginButton.Click();
        }
    }
}
