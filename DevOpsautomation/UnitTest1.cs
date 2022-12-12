using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Security.Policy;
using OpenQA.Selenium.Firefox;
using System.Threading;


namespace DevOpsautomation
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Login()
        {
            WebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.saucedemo.com/";
            Thread.Sleep(1000);
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(1000);
            driver.Close();            
        } 

        [TestMethod]
        public void AddProduct()
        {
            WebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.saucedemo.com/";
            Thread.Sleep(1000);
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();
            driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light")).Click();
            Thread.Sleep(1000);
            //driver.FindElement(By.Id("remove-sauce-labs-backpack")).Click();  //remove item
            //scroll down
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,300)");
            driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt")).Click();
            driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket")).Click();
            js.ExecuteScript("window.scrollBy(0,200)");
            driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie")).Click();
            driver.FindElement(By.Id("add-to-cart-test.allthethings()-t-shirt-(red)")).Click();
            Thread.Sleep(500);
            js.ExecuteScript("window.scrollBy(0,100)");
            Thread.Sleep(1000);
            driver.Close();
        }
    
    [TestMethod]
    public void ClickOnSoicalIcon()
    {
        WebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Url = "https://www.saucedemo.com/";
        Thread.Sleep(1000);
        driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
        driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
        driver.FindElement(By.Id("login-button")).Click();
        Thread.Sleep(1000);        
        //driver.FindElement(By.Id("remove-sauce-labs-backpack")).Click();
        //scroll down
        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        js.ExecuteScript("window.scrollBy(0,800)");
        Thread.Sleep(1000);
            driver.FindElement(By.ClassName("social_twitter")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.ClassName("social_facebook")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.ClassName("social_linkedin")).Click();
            Thread.Sleep(1000);
        }
    }

}
