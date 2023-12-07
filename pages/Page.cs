using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
namespace ConsoleApp1.pages
    
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
        public abstract bool At();
    }
}
