using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace Task1.Pages
{
    public class CreateTicketPage(IWebDriver driver): Page(driver)
    {
        private IWebElement SubmitTicketButton => driver.FindElement(By.XPath("//a[contains(text(),'Submit a ticket')]"));
        private IWebElement NewRequest => driver.FindElement(By.XPath("//body/main[@id='fw-main-content']/section[3]/div[1]/div[2]/div[1]/div[1]/div[1]/form[1]/div[1]/div[1]/div[1]/div[1]/div[1]"));
        private IWebElement Location => driver.FindElement(By.XPath("/html[1]/body[1]/main[1]/section[3]/div[1]/div[2]/div[1]/div[1]/form[1]/div[6]/div[1]/div[1]/div[1]/div[1]"));
        private IWebElement ProductType => driver.FindElement(By.XPath("/html[1]/body[1]/main[1]/section[3]/div[1]/div[2]/div[1]/div[1]/form[1]/div[8]/div[1]/div[1]/div[1]/div[1]/div[1]"));
        private IWebElement Product => driver.FindElement(By.XPath("/html[1]/body[1]/main[1]/section[3]/div[1]/div[2]/div[1]/div[1]/form[1]/div[8]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]"));
        private IWebElement SerialNumber => driver.FindElement(By.XPath("/html[1]/body[1]/main[1]/section[3]/div[1]/div[2]/div[1]/div[1]/form[1]/div[9]/input[1]"));
        private IWebElement Subject => driver.FindElement(By.XPath("/html[1]/body[1]/main[1]/section[3]/div[1]/div[2]/div[1]/div[1]/form[1]/div[10]/input[1]"));
        private IWebElement RequestDescription => driver.FindElement(By.XPath("/html[1]/body[1]/main[1]/section[3]/div[1]/div[2]/div[1]/div[1]/form[1]/div[11]/div[1]/div[3]/div[1]/p[1]"));
        private IWebElement CheckBox1 => driver.FindElement(By.XPath("/html[1]/body[1]/main[1]/section[3]/div[1]/div[2]/div[1]/div[1]/form[1]/div[12]/input[2]"));
        private IWebElement CheckBox2 => driver.FindElement(By.XPath("/html[1]/body[1]/main[1]/section[3]/div[1]/div[2]/div[1]/div[1]/form[1]/div[13]/input[2]"));
        private IWebElement FileInput => driver.FindElement(By.XPath("//*[@id=\"upload_file\"]"));

        private const string RandomText = "TestText";

        public override void At()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("body.portal.portal--light:nth-child(2) main.fw-main-wrapper:nth-child(2) section.container-fluid.px-0.fw-page-title-wrapper:nth-child(2) div.container div.py-24.py-lg-60.mx-0.fw-search-meta-info.g-0 div.text-start > h1.fw-page-title")));
        }

        public void ClickSubmitTicketButton()
        {
            SubmitTicketButton.Click();
        }

        public void ClickNewRequestButton()
        {
            NewRequest.Click();
        }

        public void ClickTicketOptionButton()
        {
            IWebElement ticketOption = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"choices--helpdesk_ticket_forms_dropdown-item-choice-4\"]")));
            ticketOption.Click();
        }

        public void SelectLocation()
        {
            ScrollToElement(Location);
            Location.Click();
            IWebElement locationOption = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"choices--helpdesk_ticket_custom_field_cf_country_2351753-item-choice-4\"]")));
            locationOption.Click();
        }

        public void SelectProductType()
        {
            ProductType.Click();
            IWebElement productTypeOption = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"choices--helpdesk_ticket_custom_field_cf_type_of_product_2351753-item-choice-4\"]")));
            productTypeOption.Click();
        }

        public void SelectProduct()
        {
            Product.Click();
            IWebElement productOption = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"choices--helpdesk_ticket_custom_field_cf_product_2351753-item-choice-4\"]")));
            productOption.Click();
        }

        public void EnterSerialNumber()
        {
            SerialNumber.SendKeys(RandomText);
        }

        public void EnterSubject()
        {
            Subject.SendKeys(RandomText);
        }

        public void EnterRequestDescription()
        {
            ScrollToElement(RequestDescription);
            RequestDescription.SendKeys(RandomText);
        }

        public void SelectCheckBox()
        {
            CheckBox1.Click();
            CheckBox2.Click();
        }

        public void AttachFile()
        {
            string filePath = @"C:\Users\user\Downloads\img_1.jpg"; // specify the local path of your image
            FileInput.SendKeys(filePath);
        }
    }
}
