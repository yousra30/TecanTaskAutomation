using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace Task1.pages
{
    public class SupportPage: Page
    {
        private IWebElement SubmitTicketButton => driver.FindElement(By.CssSelector("body.portal.portal--light:nth-child(2) header.container-fluid.px-0.fw-nav-wrapper.fixed-top:nth-child(1) section.container nav.navbar.navbar-expand-xl.navbar-light.px-0.py-8.pt-xl-4.pb-xl-0 div.collapse.navbar-collapse ul.navbar-nav.ms-auto.mt-64.mt-xl-0:nth-child(1) li.nav-item.no-hover:nth-child(4) > a.btn.fw-secondary-button"));

        public SupportPage(IWebDriver driver): base(driver)
        {
            // Pass the driver instance to the base constructor
        }
        public override void At()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("body.portal.portal--light:nth-child(2) header.container-fluid.px-0.fw-nav-wrapper.fixed-top:nth-child(1) section.container nav.navbar.navbar-expand-xl.navbar-light.px-0.py-8.pt-xl-4.pb-xl-0 div.collapse.navbar-collapse ul.navbar-nav.ms-auto.mt-64.mt-xl-0:nth-child(1) li.nav-item.no-hover:nth-child(4) > a.btn.fw-secondary-button")));
        }

        public void ClickSubmitTicketButton()
        {
            SubmitTicketButton.Click();
        }
    }
}

