using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Legacy;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SeleniumTraining.Basics
{
    internal class E06_Tuning
    {

        [Test]
        public void Tuning2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://the-internet.herokuapp.com/dynamic_loading/2";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(11); // 2. Implicit wait
            //works with FindElement() and FindElements() if they are NOT present in the DOM
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);

            driver.FindElement(By.XPath("//button")).Click();
            //Thread.Sleep(8000); // 1. Hard Wait

            var  isDisplayed = driver.FindElement(By.Id("finish")).Displayed;

            ClassicAssert.IsTrue(isDisplayed);

        }

        [Test]
        public void Tuning1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://the-internet.herokuapp.com/dynamic_loading/1";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(11);
            //works with FindElement and FindElements if they are NOT present in the DOM


            driver.FindElement(By.XPath("//button")).Click();
            //Thread.Sleep(8000); // 1. Hard Wait
            //3. Explicit wait

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
           
            
            // Selenium 3 way with Excpected conditions.
            //Need to install nuget package - dotnetExtra selenium wait helpers
           // wait.Until(ExpectedConditions.ElementIsVisible(By.Id("finish")));


            //Selenium 4 onwards
            wait.Until(d => driver.FindElement(By.Id("loading"))
                      .GetAttribute("style").Contains("display: none;"));


            var isDisplayed = driver.FindElement(By.Id("finish")).Displayed;

            ClassicAssert.IsTrue(isDisplayed);

        }

    }
}
