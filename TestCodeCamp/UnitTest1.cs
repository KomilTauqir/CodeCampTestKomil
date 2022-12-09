using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace TestCodeCamp
{
    [TestClass]
    public class UnitTest1
    {

        private WebDriver driver = new ChromeDriver();
        [TestInitialize]
        public void Initialize()
        {
            driver.Url = "https://d18u5zoaatmpxx.cloudfront.net/#/forms";

        }
         [TestMethod]
        public void setname()
        {
           
            string name = "komal";
            IWebElement iwe = driver.FindElement(By.Id("name"));
            iwe.SendKeys(name);
            // Assert.AreEqual(expected:"1",actual:"1");
        }

        [TestCleanup]
        public void Cleanup()
        {
            driver.Quit();
        }


    }

}