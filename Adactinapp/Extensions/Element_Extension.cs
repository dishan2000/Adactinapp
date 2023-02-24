using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Adactinapp.Extensions;

namespace Adactinapp.Extensions
{
    class Element_Extension
    {
        public static void EnterText(this IWebElement element,string text,string elementName)
        {
            element.Clear();
            element.SendKeys(text);
            Console.WriteLine(text+ " Entered in  " + elementName);
        }
        public static void clickonit(this IWebElement element, string elementName)
        {
            element.Click();
            Console.WriteLine("Clicked on   " + elementName);

        }


    }
}
