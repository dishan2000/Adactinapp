using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Adactinapp.PageObjects;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Configuration;


namespace Adactinapp.TestCases
{
    class login_test
    {
        IWebDriver driver;
        [Test]
        public void Test()
        {
            driver = new ChromeDriver();
             driver.Url = "https://adactinhotelapp.com/";
           // var url = ConfigurationManager.AppSettings["URL"];
           // driver.Url = url;
            var loginpg = new Login_page(driver);
            loginpg.loginAction("LoginTest");
            //loginpg.loginAction();
            ////loginpg.Username.SendKeys("Megha123");
            //loginpg.pwd.SendKeys("Megha@2001");
           // loginpg.loginbtn.Click();
            /*driver.FindElement(By.Id("username")).SendKeys("Megha123");
            driver.FindElement(By.Id("password")).SendKeys("Megha@2001");
            driver.FindElement(By.Id("login")).Click();*/

           var searchpg = new Searchhotelpage(driver);
          searchpg.searchAction();
            //PageFactory.InitElements(driver, searchpg);
           /* searchpg.location.SelectByIndex(2);
            //searchpg.hotels.SelectByIndex(3);
            searchpg.room.SelectByValue("Double");
            searchpg.roomno.SelectByIndex(3);
            searchpg.Checkin.SendKeys("24/2/2023");
            searchpg.Checkout.SendKeys("24/2/2023");
            searchpg.Adult.SelectByIndex(3);
            searchpg.Child.SelectByIndex(3);
            searchpg.search.Click();*/

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
             driver.FindElement(By.LinkText("Logout")).Click();


        }
        





    }

    }

