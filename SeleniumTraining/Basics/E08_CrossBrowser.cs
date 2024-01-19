using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;

namespace SeleniumTraining.Basics
{
    internal class E08_CrossBrowser
    {

        [Test]
        public void CrossBrowserTest()
        {
            //IWebDriver driver = new ChromeDriver();
            //IWebDriver driver = new EdgeDriver();
            //IWebDriver driver = new FirefoxDriver();

            ChromeOptions op = new ChromeOptions();
            op.AddArgument("--headless");


           /* options.AddArgument("--headless");
            options.AddArgument("--start-maximized");
            options.AddArguments("--window-size=1920,1080");
            options.AddArgument("--ignore-certificate-errors");
            options.AddArgument("incognito");
            options.AddArgument("--disable-infobars");
            options.AddArgument("--disable-web-security");
            options.AddArgument("--disable-notifications");*/

            IWebDriver driver = new ChromeDriver(op);



            driver.Url = "https://www.abrakh.com";
            driver.Manage().Window.Maximize();
            Console.WriteLine(driver.Title);

        }
        }
}
