using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.Basics
{
    internal class E09_SeleniumGrid
    {
        [Test]
        public void GridTest()
        {
            var GridURI = new Uri("http://192.168.1.10:4444");
            ChromeOptions options = new ChromeOptions();
            //options.PlatformName = "Windows 11";
            //options.BrowserVersion = 


            IWebDriver driver = new RemoteWebDriver(GridURI, options);

            driver.Url = "https://www.abrakh.com";
            driver.Manage().Window.Maximize();
            Console.WriteLine(driver.Title);

        }

    }
}
