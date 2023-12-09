using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Task1.Pages
{   
    public abstract class Page
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;

        protected Page(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void ScrollToElement(IWebElement elementToScroll)
        {
            int deltaY = elementToScroll.Location.Y;
            new Actions(driver)
              .ScrollByAmount(0, deltaY - 400)
              .Perform();
        }

        public abstract void At();
    }
}
