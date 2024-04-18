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

            try
            {
                // Instantiating webdriver
                IWebDriver webDriver = new ChromeDriver();

                // Accessing the site url
                webDriver.Navigate().GoToUrl("https://hackernoon.com/");


                //First Test: validating the login link
                webDriver.FindElement(By.ClassName("sc-b3d23cc4-0")).Click();

                //Second Test: Validating the email address
                webDriver.FindElement(By.Id("email")).SendKeys("A00276443@mycambrian.ca");

                //Third Test: Validating the password of the website
                webDriver.FindElement(By.Id("password")).SendKeys("Password123");

                //Fourth Test: Validating the login button class="sc-629a08f7-5 kmfnwX"
                webDriver.FindElement(By.ClassName("sc-629a08f7-5")).Click();

            }
            catch(Exception ex) {
               Console.WriteLine(ex.Message);
            }
           
           



        }
    }
}
