using OpenQA.Selenium;

namespace TestCodeCamp
{
    internal class Toolbar
    {
        private WebDriver driver;

        public Toolbar(WebDriver driver)
        {
            this.driver = driver;
        }

        internal void ClickContactButton()
        {
            driver.FindElement(By.CssSelector("[aria-label=contact].v-btn")).Click();

        }

        internal void ClickMenuButton()
        {

            driver.FindElement(By.CssSelector("[aria-label=menu].v-btn")).Click();

        }
        internal void ClickMenuSideButton()
        { 
           driver.FindElement(By.XPath("//*[contains(text(),' Sides ')]")).Click();
        
        }

    }
}