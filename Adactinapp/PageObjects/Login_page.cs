using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Adactinapp.Extensions;



namespace Adactinapp.PageObjects
{
    class Login_page
    {
        private IWebDriver driver;
        [FindsBy(How = How.Id, Using = "username")]
        [CacheLookup]
        private IWebElement Username { get; set; }
        [FindsBy(How = How.Id, Using = "password")]
        [CacheLookup]
        private IWebElement pwd { get; set; }
        [FindsBy(How = How.Id, Using = "login")]
        [CacheLookup]

        private IWebElement loginbtn { get; set; }


        public Login_page(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void loginAction(string testName)
        {
            var userData = Exceldataaccess.GetTestData(testName);

            /* Username.SendKeys(userData.Username);
             pwd.SendKeys(userData.Password);*/
            Username.EnterText("Megha@123","Username");
            pwd.EnterText("Megha@2001"."password");
            loginbtn.clickonit("loginbtn");
        }


    }

        }

    

