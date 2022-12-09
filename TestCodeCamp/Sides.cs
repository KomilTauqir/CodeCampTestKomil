using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodeCamp
{
    internal class Sides
    {
        private WebDriver driver;

        public Sides(WebDriver driver)
        {
            this.driver = driver;
        }

       
        internal Item GetMenuItem(Predicate<Item> strategy)
        {

            foreach (IWebElement item1 in driver.FindElements(By.ClassName("name")))
            {
                var myitem = new Item(item1);

                if (strategy(myitem))
                {
                    return myitem;
                }
            }
            throw new NotFoundException();

        }

    }
}
