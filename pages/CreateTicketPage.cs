using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace ConsoleApp1.pages
{
    public class CreateTicketPage: Page
    {
        private string ticketPageUrl = "https://helpdesk.tecan.com/en/support/home";
        private IWebElement submitTicketButton => driver.FindElement(By.XPath("//a[contains(text(),'Submit a ticket')]"));
        private IWebElement newRequest => driver.FindElement(By.XPath("//body/main[@id='fw-main-content']/section[3]/div[1]/div[2]/div[1]/div[1]/div[1]/form[1]/div[1]/div[1]/div[1]/div[1]/div[1]"));
        private IWebElement location => driver.FindElement(By.XPath("/html[1]/body[1]/main[1]/section[3]/div[1]/div[2]/div[1]/div[1]/form[1]/div[6]/div[1]/div[1]/div[1]/div[1]"));
        private IWebElement productType => driver.FindElement(By.XPath("/html[1]/body[1]/main[1]/section[3]/div[1]/div[2]/div[1]/div[1]/form[1]/div[8]/div[1]/div[1]/div[1]/div[1]/div[1]"));
        private IWebElement product => driver.FindElement(By.XPath("/html[1]/body[1]/main[1]/section[3]/div[1]/div[2]/div[1]/div[1]/form[1]/div[8]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]"));
        private IWebElement serialNumber => driver.FindElement(By.XPath("/html[1]/body[1]/main[1]/section[3]/div[1]/div[2]/div[1]/div[1]/form[1]/div[9]/input[1]"));
        private IWebElement subject => driver.FindElement(By.XPath("/html[1]/body[1]/main[1]/section[3]/div[1]/div[2]/div[1]/div[1]/form[1]/div[10]/input[1]"));
        private IWebElement requestDescription => driver.FindElement(By.XPath("/html[1]/body[1]/main[1]/section[3]/div[1]/div[2]/div[1]/div[1]/form[1]/div[11]/div[1]/div[3]/div[1]/p[1]"));
        private IWebElement checkBox1 => driver.FindElement(By.XPath("/html[1]/body[1]/main[1]/section[3]/div[1]/div[2]/div[1]/div[1]/form[1]/div[12]/input[2]"));
        private IWebElement checkBox2 => driver.FindElement(By.XPath("/html[1]/body[1]/main[1]/section[3]/div[1]/div[2]/div[1]/div[1]/form[1]/div[13]/input[2]"));
        private IWebElement Attachment => driver.FindElement(By.XPath("//button[@id='attach_btn']"));
        private IWebElement fileInput => driver.FindElement(By.XPath("//*[@id=\"attachment_1\"]/div/span[2]"));

       // WebDriverWait wait;

        public CreateTicketPage(IWebDriver driver) : base(driver)
        {
          //  wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public override bool At()
        {
            driver.Navigate().GoToUrl(ticketPageUrl);
            try
            {
                bool isSumitATicketLogoDisplayed = driver.FindElement(By.XPath("//header/section[2]/nav[1]/div[1]/ul[1]/li[3]/a[1]")).Displayed;
                return isSumitATicketLogoDisplayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        public void FillTicketForm()
        {
            submitTicketButton.Click();
            newRequest.Click();
            IWebElement ticketOption = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"choices--helpdesk_ticket_forms_dropdown-item-choice-4\"]")));
            ticketOption.Click();

            scrollToElement(newRequest, driver); 
            location.Click();
            IWebElement locationOption = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"choices--helpdesk_ticket_custom_field_cf_country_2351753-item-choice-4\"]")));
            locationOption.Click();

            productType.Click();
            IWebElement productTypeOption = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"choices--helpdesk_ticket_custom_field_cf_type_of_product_2351753-item-choice-4\"]")));
            productTypeOption.Click();

            product.Click();
            IWebElement productOption = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"choices--helpdesk_ticket_custom_field_cf_product_2351753-item-choice-4\"]")));
            productOption.Click();

            serialNumber.SendKeys("12345");
            subject.SendKeys("12345");

            scrollToElement(location, driver);

            requestDescription.SendKeys("12345");
            checkBox1.Click();
            checkBox2.Click();

          //  string filePath = @"C:\Users\user\Downloads\img_1.jpg";
            Attachment.Click();
            // fileInput.SendKeys(filePath);
            //   ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].setAttribute('value', 'C:\\Users\\user\\Downloads\\img_1.jpg');", fileInput);

            // String script = "document.getElementById('fileInput').value= '" + "C \\\\Users\\\\user\\\\Downloads\\\\img_1.jpg";
            // ((IJavaScriptExecutor)driver).ExecuteScript(script);


        }

        public void scrollToElement(IWebElement elementToScroll, IWebDriver driver)
        {
 
            int deltaY = elementToScroll.Location.Y;
            new Actions(driver)
              .ScrollByAmount(0, deltaY)
              .Perform();
        }

    }
}
