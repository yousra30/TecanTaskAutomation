using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace Task1.Pages
{
    public class ContactPage(IWebDriver driver): Page(driver)
    {
        public override void At()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("body.site-page.wysiwyg-master-theme.home_17.hs-content-id-3545266046.hs-site-page.page:nth-child(2) div.body-container-wrapper div.body-container.container-fluid div.row-fluid-wrapper.row-depth-1.row-number-3:nth-child(3) div.row-fluid section.flexpanels div.container div.row div.span12.widget-span.widget-type-widget_container span.hs_cos_wrapper.hs_cos_wrapper_widget_container.hs_cos_wrapper_type_widget_container div.hs_cos_wrapper.hs_cos_wrapper_widget.hs_cos_wrapper_type_custom_widget:nth-child(2) div.row.padding--bottom--sm div.col-xs-12.col-sm-7.col-md-6:nth-child(1) div.panel--lead > h1:nth-child(1)")));
        }

        public void RemoveTargetSupportPage()
        {
            IWebElement supportLink = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html[1]/body[1]/div[2]/div[3]/div[1]/div[3]/div[1]/section[1]/div[1]/div[1]/div[1]/span[1]/div[2]/div[1]/div[1]/div[1]/p[3]/a[1]")));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].removeAttribute('target')", supportLink);
        }
        public void ClickSupportPage()
        {
         IWebElement supportLink = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html[1]/body[1]/div[2]/div[3]/div[1]/div[3]/div[1]/section[1]/div[1]/div[1]/div[1]/span[1]/div[2]/div[1]/div[1]/div[1]/p[3]/a[1]")));
         supportLink.Click();
        }
    }
}
