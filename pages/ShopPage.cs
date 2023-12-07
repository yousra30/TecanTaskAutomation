﻿using OpenQA.Selenium;

namespace ConsoleApp1.pages
{
    public class ShopPage: Page
    {
        public ShopPage(IWebDriver driver) : base(driver)
        {
            // Pass the driver instance to the base constructor
        }

        public override bool At()
        {
            try
            {
                bool isShopLogoDisplayed = driver.FindElement(By.CssSelector("body.site-page.wysiwyg-master-theme.home_17.hs-content-id-5108109707.hs-site-page.page:nth-child(2) div.header-container-wrapper div.header-container.container-fluid div.row-fluid-wrapper.row-depth-1.row-number-1:nth-child(1) div.row-fluid div.span12.widget-span.widget-type-cell div.row-fluid-wrapper.row-depth-1.row-number-2:nth-child(1) div.row-fluid div.span12.widget-span.widget-type-global_group div.row-fluid-wrapper.row-depth-1.row-number-1 div.row-fluid div.span12.widget-span.widget-type-cell.wysiwyg-master-theme div.row-fluid-wrapper.row-depth-1.row-number-2:nth-child(1) div.row-fluid div.span12.widget-span.widget-type-cell.custom-header-container-wrapper div.row-fluid-wrapper.row-depth-1.row-number-3 div.row-fluid div.span12.widget-span.widget-type-cell.top-menu-wrapper div.row-fluid-wrapper.row-depth-1.row-number-4 div.row-fluid div.span12.widget-span.widget-type-custom_widget div.hs_cos_wrapper.hs_cos_wrapper_widget.hs_cos_wrapper_type_module span.hs_cos_wrapper.hs_cos_wrapper_widget.hs_cos_wrapper_type_raw_html header.header div.main-nav div.main-nav-container.container nav.navbar.navbar-inverse.w-100.flex-auto:nth-child(1) div.navbar-header a.navbar-brand > img:nth-child(1)")).Displayed;
                // Also check for other shop page elements
                return isShopLogoDisplayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

    }
}
