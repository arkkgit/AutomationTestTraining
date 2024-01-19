using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace SeleniumTraining.Basics
{
    internal class E03_Actions
    {
        [Test]
        public void MouseHoverAndKeyBoard()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.advantageonlineshopping.com";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Thread.Sleep(7000);

            var cartLink = driver.FindElement(By.CssSelector("#shoppingCartLink"));
            Actions myActions = new Actions(driver);
            myActions.MoveToElement(cartLink).Build().Perform();

            driver.FindElement(By.Id("search")).Click();

            Thread.Sleep(4000);

            var searchLinkInput = driver.FindElement(By.XPath("//div[@id='search']//input"));
            
            myActions.MoveToElement(searchLinkInput).Click().
                KeyDown(Keys.Shift).SendKeys("l").KeyUp(Keys.Shift).SendKeys("aptop")
                .SendKeys(Keys.Enter).Build().Perform() ;

        }
    }
}
