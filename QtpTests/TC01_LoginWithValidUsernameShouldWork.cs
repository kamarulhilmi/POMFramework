using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace QtpTests
{
    [TestClass]
    public class TC01_LoginWithValidUsernameShouldWork : TestBase
    {
        [TestMethod]
        public void RunTest()
        {
            Pages.Login.Goto();
            Pages.Login.Login("kamarul", "p@ssw0rd125977");
            Assert.IsTrue(Pages.MyMembership.IsAt(), "A valid user was not abl to seccessfully login.");
            
            ////instance of chrome 
            //var driver = new ChromeDriver(@"C:\Users\REG-LPT-077\Documents\Visual Studio 2015\Projects\POMFramework\Framework\Drivers");
            ////driver.Navigate().GoToUrl("http://www.qtptutorial.net/wp-login.php");

            //var masuk = driver.FindElement(By.LinkText("log in with a password"));
            //masuk.Click();
          

            //var user = driver.FindElement(By.Id("user_login"));
            //user.SendKeys("seleniumTestUser");


            //var pass = driver.FindElement(By.Id("user_pass"));
            //pass.SendKeys("Test12345!!$");

            //driver.FindElement(By.Id("wp-submit")).Click();

        }
    }
}
