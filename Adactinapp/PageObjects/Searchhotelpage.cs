using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;



namespace Adactinapp.PageObjects
{
    class Searchhotelpage
    {
        private IWebDriver driver;



        [FindsBy(How = How.Id, Using = "location")]
        public SelectElement location { get; set; }


        [FindsBy(How = How.Id, Using = "hotels")]
        public SelectElement hotels { get; set; }



        [FindsBy(How = How.Id, Using = "room_type")]
        public SelectElement room { get; set; }


        [FindsBy(How = How.Id, Using = "room_nos")]
        public SelectElement roomno { get; set; }


        [FindsBy(How = How.Id, Using = "datepick_in")]
        public IWebElement Checkin { get; set; }



        [FindsBy(How = How.Id, Using = "datepick_out")]
        public IWebElement Checkout { get; set; }



        [FindsBy(How = How.Id, Using = "adult_room")]
        public SelectElement Adult { get; set; }



        [FindsBy(How = How.Id, Using = "child_room")]
        public SelectElement Child { get; set; }


        public IWebElement search { get; set; }

        public Searchhotelpage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        } 


        public void searchAction()
        {
            location.SelectByIndex(2);
            hotels.SelectByIndex(3);
            room.SelectByValue("Double");
            roomno.SelectByIndex(3);
            Checkin.SendKeys("24/2/2023");
            Checkout.SendKeys("24/2/2023");
            Adult.SelectByIndex(3);
            Child.SelectByIndex(3);
            search.Click();
        }










    }
}
