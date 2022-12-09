using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using TestProject6;
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

            driver.Url = "https://d3nay7txmslpgb.cloudfront.net/#/";

        }


        [TestMethod]
        public void ClickMenu()
        {
            new Toolbar(driver).ClickMenuButton();
        }

        [TestMethod]
        public void ClickMenuSidebutton()
        {
            new Toolbar(driver).ClickMenuButton();
            new Toolbar(driver).ClickMenuSideButton();

        }



        [TestMethod]
        public void ClickContact()
        {
            new Toolbar(driver).ClickContactButton();
        }


        [TestMethod]
        public void VerifyitemKJandPrice()
        {
            string name = "hawaiian";
            new Toolbar(driver).ClickMenuButton();
            new Toolbar(driver).ClickMenuSideButton();
            var myside = new Sides(driver);
            Item myitem;
     
                foreach (IWebElement item in driver.FindElements(By.ClassName("name")))
                {
                if (item.Text.ToLower() == name)
                {
                    IWebElement orderbtn;
                   item.FindElement(By.XPath("//*[contains(text(),'Order')]")).Click();
                    // myitem = item;
                    // item.FindElement(By.CssSelector("aria-label=Add to order")).Click();
                    // orderbtn =item.FindElement(By.CssSelector("aria-label=Add to order")).Click();
                }
            }
            throw new NotFoundException();

           //   myitem = myside.GetMenuItem(PT => PT.name.ToLower() == name);
            //  myitem.Order();
            //  string text = myitem.popupmsgmethod(driver);
            
        }

        [TestMethod]
        public void ConatactPagetest()
        {

            new Toolbar(driver).ClickContactButton();

            var form = new Form(driver);

            form.SetName("Dan");
            form.SetEmail("dan@abc.com");
            form.SetMeassage("Nice Pizza");
            form.ClickSubmit();
        }




        [TestCleanup]
        public void Cleanup()
        {
           // driver.Quit();
        }


    }

}

//  I spent all the time in TEST 2, that is Menu item in KiloJoules and Price. 
// Biggest problem that i face is, can't find the elements in webpage.. no practice to use selectors/locators.. so stuck on that part.
// 