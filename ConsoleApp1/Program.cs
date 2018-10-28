using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {


            

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.instagram.com/");
            Console.WriteLine(driver.Title);

            IWebElement enter = driver.FindElement(By.LinkText("Вход"));
            enter.Click();
            Thread.Sleep(2000);
            IWebElement UserName = driver.FindElement(By.Name("username"));
            UserName.SendKeys("mihailsivovna@gmail.com");

            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys("mishanya2014");

            IWebElement enter1 = driver.FindElement(By.CssSelector("button[type=submit]"));
            enter1.Click();
            Thread.Sleep(2000);

            IWebElement button2 = driver.FindElement(By.ClassName("aOOlW"));
            button2.Click();

            IWebElement button3 = driver.FindElement(By.CssSelector("button[type=text]"));
            button3.Click();

            
           
        }

    }
}