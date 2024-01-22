using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.Extensions;
using System.IO;

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
            //usrname:password@<url>
            driver.Url = "https://admin:admin@the-internet.herokuapp.com/basic_auth";
        }


        [Test]
        public void JSExceutor()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://abrakh.com";
            driver.Manage().Window.Maximize();
            driver.ExecuteJavaScript("window.scrollBy(0, 2000);");
        }

        [Test]
        public void ScreenShotDemo()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://abrakh.com";
            driver.Manage().Window.Maximize();
            driver.TakeScreenshot().SaveAsFile("D:/temp/ss101.png");
            var b64 = driver.TakeScreenshot().AsBase64EncodedString;

            //File.WriteAllLines(@"D:/temp/str101.txt", b64);
            WriteToFile("D:/temp/str101.txt", b64);

            //SS of a particular element
            var ss = ((ITakesScreenshot)driver.FindElement(By.XPath("(//img[@data-ux='ImageLogo'])[2]"))).GetScreenshot();
            ss.SaveAsFile("D:/temp/elementSS.png");
        }




        static void WriteToFile(string fileName, string content)
        {
            try
            {
                // Open a StreamWriter to the specified file
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    // Write the content to the file
                    writer.Write(content);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, for example, by logging or displaying an error message
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

        }
    }
}

