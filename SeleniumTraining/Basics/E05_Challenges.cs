using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.Basics
{
    internal class E05_Challenges
    {

        [Test]
        public void uploadFile()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://the-internet.herokuapp.com/upload";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.FindElement(By.Id("file-upload")).SendKeys("D:/temp/a.txt");
            driver.FindElement(By.CssSelector(".button")).Click();

        }

        [Test]
        public void downloadFile()
        {




            ChromeOptions options = new ChromeOptions();
            options.AddUserProfilePreference("download.prompt_for_download", false);
            options.AddUserProfilePreference("download.default_directory", "D:\\Temp\\");

            IWebDriver driver = new ChromeDriver(options);
            driver.Url = "https://the-internet.herokuapp.com/download";
            driver.FindElement(By.LinkText("some-file.txt")).Click();

        }


        [Test]
        public void BasicAuth()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://admin:admin@the-internet.herokuapp.com/basic_auth";
        }

    }
}
