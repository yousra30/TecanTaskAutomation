using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace ConsoleApp1.pages
{
    public class SupportPage: Page
    {
        private readonly string supportPageUrl = "https://helpdesk.tecan.com/en/support/login";
        private IWebElement loginOrSignUpText => driver.FindElement(By.XPath("//a[contains(text(),'log in or sign-up')]"));
        private IWebElement emailField => driver.FindElement(By.XPath("//input[@id='1-email']"));
        private IWebElement passwordField => driver.FindElement(By.XPath("//input[@id='1-password']"));
        private IWebElement loginButton => driver.FindElement(By.XPath("/html[1]/body[1]/main[1]/div[1]/div[2]/form[1]/div[1]/div[1]/div[1]/button[1]/span[1]"));
       
     //   WebDriverWait wait;

        public SupportPage(IWebDriver driver): base(driver)
        {
            // Pass the driver instance to the base constructor
          //  wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
        public override bool At()
        {
            driver.Navigate().GoToUrl(supportPageUrl);
            try
            {
                bool isSupportHeadingVisible = driver.FindElement(By.XPath("/html[1]/body[1]/main[1]/section[1]/section[1]/div[1]/div[1]/h2[1]")).Displayed;
                return isSupportHeadingVisible;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        public void ClickLoginOrSignupText()
        {

         loginOrSignUpText.Click();
        }
         public void ScrollPageToLoginBotton()
         {

             Actions actions = new Actions(driver);
             actions.KeyDown(Keys.Control).SendKeys(Keys.End).KeyUp(Keys.Control).Perform();

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

