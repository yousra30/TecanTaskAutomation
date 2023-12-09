using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace Task1.pages
{
    public class ShopPage: Page
    {
        public ShopPage(IWebDriver driver) : base(driver)
        {
            // Pass the driver instance to the base constructor
        }

        public override void At()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("tec-storefront.LandingPage2Template.stop-navigating div.tec-content:nth-child(3) div.tec-content__wrapper aside.tec-content__aside:nth-child(1) cx-page-layout.navigation cx-page-slot.NavigationSlot.has-components.ng-star-inserted tec-navigation.ng-star-inserted div.tec-navigation.ng-star-inserted nav:nth-child(1) > div.tec-navigation__headline:nth-child(1)")));
        }

    }
}
