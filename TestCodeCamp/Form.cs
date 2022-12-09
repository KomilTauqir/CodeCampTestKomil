using OpenQA.Selenium;

namespace TestProject6
{
    internal class Form
    {
        private WebDriver driver;

        public Form(WebDriver driver)
        {
            this.driver = driver;
        }

    
      

        internal void ClickSubmit()
        {
            driver.FindElement(By.XPath("//*[contains(text(),'Submit')]")).Click();
        }

     

        internal void SetEmail(string email)
        {
            driver.FindElement(By.Id("email")).SendKeys(email);
        }

        internal void SetName(String name)
        {
            driver.FindElement(By.Id("forename")).SendKeys(name);
        }
        internal void SetMeassage(String message)
        {
            driver.FindElement(By.Id("message")).SendKeys(message);
        }
    }
}