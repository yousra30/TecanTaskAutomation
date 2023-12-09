using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace Task1.Pages
{
    public class LoginPage(IWebDriver driver): Page(driver)
    {
        private const string LoginPageUrl = "https://helpdesk.tecan.com/en/support/login";
        private IWebElement LoginOrSignUpText => driver.FindElement(By.XPath("//a[contains(text(),'log in or sign-up')]"));
        private IWebElement EmailField => driver.FindElement(By.XPath("//input[@id='1-email']"));
        private IWebElement PasswordField => driver.FindElement(By.XPath("//input[@id='1-password']"));
        private IWebElement LoginButton => driver.FindElement(By.XPath("/html[1]/body[1]/main[1]/div[1]/div[2]/form[1]/div[1]/div[1]/div[1]/button[1]/span[1]"));

        private const string Email = "yousra.ishtiaque@gmail.com";
        private const string Password = "testTASK_123";

        public override void At()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//body/main[@id='fw-main-content']/div[1]/div[1]")));
        }

        public void ScrollToLoginButton()
        {
            ScrollToElement(LoginOrSignUpText);
        }

        public void Navigate()
        {
            driver.Navigate().GoToUrl(LoginPageUrl);
        }

        public void ClickLoginOrSignupText()
        {
            LoginOrSignUpText.Click();
        }
        public void Login(string email = Email, string password = Password)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@id='1-email']")));
            EmailField.SendKeys(email);
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@id='1-password']")));
            PasswordField.SendKeys(password);
            LoginButton.Click();
        }
    }
}
