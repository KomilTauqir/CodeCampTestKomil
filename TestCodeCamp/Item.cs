using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestCodeCamp
{


    internal class Item
    {
        public string name;
        public IWebElement tile;
       

        public Item(IWebElement myitem)
        {
            tile = myitem;
            name = myitem.FindElement(By.ClassName("name")).Text.ToLower();
            

        }

        internal void Order()
        {
            tile.FindElement(By.CssSelector("aria-label=Add to order")).Click();
            //Thread.Sleep(1000);
            return;

        }
    }
}
