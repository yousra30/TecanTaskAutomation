using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace Task1.Pages
{
    public class ShopPage(IWebDriver driver): Page(driver)
    {
        public override void At()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("tec-storefront.LandingPage2Template.stop-navigating div.tec-content:nth-child(3) div.tec-content__wrapper aside.tec-content__aside:nth-child(1) cx-page-layout.navigation cx-page-slot.NavigationSlot.has-components.ng-star-inserted tec-navigation.ng-star-inserted div.tec-navigation.ng-star-inserted nav:nth-child(1) > div.tec-navigation__headline:nth-child(1)")));
        }

    }
}
