using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.Basics
{
    public class E01_BrowserWindow
    {

        [Test]
        public void BrowserWindowControls()
        {
            Console.WriteLine("This is a simple test");
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.bing.com/";
            var ps = driver.PageSource;
            File.WriteAllText("d:/temp/abc.txt", ps);
            driver.Navigate().GoToUrl("https://abrakh.com");
            driver.Navigate().Back();
            driver.Navigate().Forward();
            driver.Manage().Window.Maximize();
            var actualTitle = driver.Title;
            ClassicAssert.AreEqual("abrakh.com", actualTitle);

            driver.Close();
            driver.Quit();


        }

    }
}
