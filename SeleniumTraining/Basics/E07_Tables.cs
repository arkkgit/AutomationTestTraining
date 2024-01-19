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
    internal class E07_Tables
    {
        IWebDriver driver;

        [Test]
        public void Tables()
        {
            driver = new ChromeDriver();
            driver.Url = "https://the-internet.herokuapp.com/tables";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(11);

            //int rowIndex = 3;
            int rowIndex = getRowIndex("Smith");
            int colIndex = 3;

            var tvalue = driver.FindElement(By.XPath("//table[@id='table1']/tbody/tr["+rowIndex+"]/td["+colIndex+"]")).Text;

            Console.WriteLine(tvalue);

            driver.Quit();


        }

            public int getRowIndex( string rowname)
            {
            var noOfRows= driver.FindElements(By.XPath("//table[@id='table1']/tbody/tr")).Count;

            for (int i = 1; i <= noOfRows; i++)
            {
               var actualrowname = driver.FindElement(By.XPath("//table[@id='table1']/tbody/tr[" + i + "]/td[1]")).Text;
                
                if(actualrowname == rowname)
                {
                    return i;
                }
            
            }
            return 0;
        }


        }
}
