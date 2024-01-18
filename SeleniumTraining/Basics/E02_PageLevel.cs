using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NUnit.Framework.Legacy;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTraining.Basics
{
    internal class E02_PageLevel
    {
        [Test]
        public void PageLevel()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.advantageonlineshopping.com";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Thread.Sleep(7000);

           

            var ContactLink = By.LinkText("CONTACT US"); // step1 : Identify Element                
            var contactLinkEle =  driver.FindElement(ContactLink); // step2: Find element
            contactLinkEle.Click(); //ste3. Do some action
            
            driver.FindElement(By.LinkText("CONTACT US")).Click(); // this is in 1 line
            driver.FindElement(By.Id("hrefUserIcon")).Click();
            var isEnabled = driver.FindElement(By.XPath("//button[@id='sign_in_btn']")).Enabled;
            ClassicAssert.IsFalse(isEnabled);
            string ftext = driver.FindElement(By.XPath("//a[@class='forgot-Passwowd ng-scope']")).Text;
            Console.WriteLine(ftext);

            driver.FindElement(By.XPath("//div[text()='Username']/following-sibling::input")).SendKeys("abc@nhsbt.com");

            driver.FindElement(By.XPath("//div[@class='closeBtn loginPopUpCloseBtn']")).Click();

            //Special element - Drop downs with TAG as SELECT
            var CatSelect = driver.FindElement(By.Name("categoryListboxContactUs"));
            SelectElement CatDropDown = new SelectElement(CatSelect);
            CatDropDown.SelectByText("Tablets");

        }

    }
}
