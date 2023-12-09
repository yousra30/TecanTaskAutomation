using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System.IO;
using System.Numerics;

namespace Task1.pages
{
    public class CreateTicketPage: Page
    {
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
        private IWebElement fileInput => driver.FindElement(By.XPath("//*[@id=\"upload_file\"]"));
    
        public CreateTicketPage(IWebDriver driver) : base(driver)
        {
            // Pass the driver instance to the base constructor
        }

        public override void At()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("body.portal.portal--light:nth-child(2) main.fw-main-wrapper:nth-child(2) section.container-fluid.px-0.fw-page-title-wrapper:nth-child(2) div.container div.py-24.py-lg-60.mx-0.fw-search-meta-info.g-0 div.text-start > h1.fw-page-title")));
        }

        public void ClickSubmitTicketButton()
        {
            submitTicketButton.Click();
        }

        public void ClickNewRequestButton()
        {
            newRequest.Click();
        }

        public void ClickTicketOptionButton()
        {
            IWebElement ticketOption = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"choices--helpdesk_ticket_forms_dropdown-item-choice-4\"]")));
            ticketOption.Click();
        }

        public void SelectLocation()
        {
            ScrollToElement(location);
            location.Click();
            IWebElement locationOption = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"choices--helpdesk_ticket_custom_field_cf_country_2351753-item-choice-4\"]")));
            locationOption.Click();
        }

        public void SelectProductType()
        {
            productType.Click();
            IWebElement productTypeOption = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"choices--helpdesk_ticket_custom_field_cf_type_of_product_2351753-item-choice-4\"]")));
            productTypeOption.Click();
        }

        public void SelectProduct()
        {
            product.Click();
            IWebElement productOption = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"choices--helpdesk_ticket_custom_field_cf_product_2351753-item-choice-4\"]")));
            productOption.Click();
        }

        public void EnterSerialNumber()
        {
            serialNumber.SendKeys("12345");
        }

        public void EnterSubject()
        {
            subject.SendKeys("12345");
        }

        public void EnterRequestDescription()
        {
            ScrollToElement(requestDescription);
            requestDescription.SendKeys("12345");
        }

        public void SelectCheckBox()
        {
            checkBox1.Click();
            checkBox2.Click();
        }

        public void AttachFile()
        {
            string filePath = @"C:\Users\user\Downloads\img_1.jpg"; // specify the local path of your image
            fileInput.SendKeys(filePath);
        }
    }
}
