using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SeleniumTraining.Basics
{
    internal class E04_SwitchTo
    {
        [Test]
        public void FramesDemo()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://the-internet.herokuapp.com/iframe";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.SwitchTo().Frame("mce_0_ifr");
            var ftext = driver.FindElement(By.Id("tinymce")).Text;
            Console.WriteLine(ftext);

        }

        [Test]
        public void AlertsDemo()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://the-internet.herokuapp.com/javascript_alerts";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//button[text()='Click for JS Confirm']")).Click();
            driver.SwitchTo().Alert().Accept();

            driver.FindElement(By.XPath("//button[text()='Click for JS Prompt']")).Click();
            driver.SwitchTo().Alert().SendKeys("Learning switch To");
            driver.SwitchTo().Alert().Accept();
 
        }


        [Test]
        public void WindowsDemo()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://the-internet.herokuapp.com/windows";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Click Here")).Click();

            var winHandles =driver.WindowHandles.ToList<string>();
            foreach (var winHandle in winHandles)
            {
                Console.WriteLine(winHandle);
            }

            string OriginalWindow = winHandles.ElementAt(0);
            string NewWindow = winHandles.ElementAt(1);
            driver.SwitchTo().Window(NewWindow);
            
            Console.WriteLine(driver.FindElement(By.TagName("h3")).Text);

            driver.SwitchTo().Window(OriginalWindow);
            driver.Url = "https://abrakh.com";



        }


    }
}
