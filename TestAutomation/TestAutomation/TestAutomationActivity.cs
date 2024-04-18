using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestAutomation
{
    [TestClass]
    public class TestAutomationActivity
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Instantiating webdriver
            IWebDriver webDriver = new ChromeDriver();

            // Accessing the site url
            webDriver.Navigate().GoToUrl("https://hackernoon.com/");


            //First Test:validating the login link
            webDriver.FindElement(By.ClassName("sc-b3d23cc4-0 biyRsJ")).Click();

        }
    }
}
