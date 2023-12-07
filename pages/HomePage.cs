using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
namespace ConsoleApp1.pages
{
    public class HomePage : Page
    {
        private string homeUrl = "https://www.tecan.com";
        private IWebElement shopLink => driver.FindElement(By.CssSelector("body.site-page.wysiwyg-master-theme.home_17.hs-content-id-5108109707.hs-site-page.page:nth-child(2) div.header-container-wrapper div.header-container.container-fluid div.row-fluid-wrapper.row-depth-1.row-number-1:nth-child(1) div.row-fluid div.span12.widget-span.widget-type-cell div.row-fluid-wrapper.row-depth-1.row-number-2:nth-child(1) div.row-fluid div.span12.widget-span.widget-type-global_group div.row-fluid-wrapper.row-depth-1.row-number-1 div.row-fluid div.span12.widget-span.widget-type-cell.wysiwyg-master-theme div.row-fluid-wrapper.row-depth-1.row-number-2:nth-child(1) div.row-fluid div.span12.widget-span.widget-type-cell.custom-header-container-wrapper div.row-fluid-wrapper.row-depth-1.row-number-3 div.row-fluid div.span12.widget-span.widget-type-cell.top-menu-wrapper div.row-fluid-wrapper.row-depth-1.row-number-4 div.row-fluid div.span12.widget-span.widget-type-custom_widget div.hs_cos_wrapper.hs_cos_wrapper_widget.hs_cos_wrapper_type_module span.hs_cos_wrapper.hs_cos_wrapper_widget.hs_cos_wrapper_type_raw_html header.header div.main-nav div.main-nav-container.container div:nth-child(2) div.shop-view > a.shop-button:nth-child(2)"));
        private IWebElement contactLink => driver.FindElement(By.XPath("//header/div[1]/div[1]/div[1]/div[1]/ul[1]/li[4]/a[1]"));
        private IWebElement searchBar => driver.FindElement(By.XPath("//*[@id='search-icon']"));

        
        public HomePage(IWebDriver driver) : base(driver)
        {
            
        }

        public override bool At()
        {
            driver.Navigate().GoToUrl(homeUrl);
            try
            {
                bool isHomeLogoDisplayed = driver.FindElement(By.CssSelector("body.site-page.wysiwyg-master-theme.home_17.hs-content-id-5108109707.hs-site-page.page:nth-child(2) div.header-container-wrapper div.header-container.container-fluid div.row-fluid-wrapper.row-depth-1.row-number-1:nth-child(1) div.row-fluid div.span12.widget-span.widget-type-cell div.row-fluid-wrapper.row-depth-1.row-number-2:nth-child(1) div.row-fluid div.span12.widget-span.widget-type-global_group div.row-fluid-wrapper.row-depth-1.row-number-1 div.row-fluid div.span12.widget-span.widget-type-cell.wysiwyg-master-theme div.row-fluid-wrapper.row-depth-1.row-number-2:nth-child(1) div.row-fluid div.span12.widget-span.widget-type-cell.custom-header-container-wrapper div.row-fluid-wrapper.row-depth-1.row-number-3 div.row-fluid div.span12.widget-span.widget-type-cell.top-menu-wrapper div.row-fluid-wrapper.row-depth-1.row-number-4 div.row-fluid div.span12.widget-span.widget-type-custom_widget div.hs_cos_wrapper.hs_cos_wrapper_widget.hs_cos_wrapper_type_module span.hs_cos_wrapper.hs_cos_wrapper_widget.hs_cos_wrapper_type_raw_html header.header div.main-nav div.main-nav-container.container nav.navbar.navbar-inverse.w-100.flex-auto:nth-child(1) div.navbar-header a.navbar-brand > img:nth-child(1)")).Displayed;
                // Also check for other home page elements
                return isHomeLogoDisplayed;    
            }
            catch (NoSuchElementException)
            {
                return false;
            } 
        }
        public void ClickShopPage()
        {
            shopLink.Click();
         
        }
        public void ClickContactPage()
        {
            contactLink.Click();
        }
        public bool SearchBarVisible()
        {
            return searchBar.Displayed;
        }
        public void EnterSearchText(string searchText)
        {
            searchBar.Click();
            IWebElement SearchField = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@id='search-input']")));
            SearchField.SendKeys(searchText);
        }
        public int CountSearchResults()
        {
            IReadOnlyCollection<IWebElement> searchResults = wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//body/div[@id='siq_searchIndexResult']/ul[@id='siq-searchResultItems']/li[2]/a[1]")));
            int numberOfResults = searchResults.Count;
            return numberOfResults;
        }
        public void SubmitSearch()
        {
            searchBar.Submit();
        }
    }
}