using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace QtpTests
{
    public class LoginPage
    {
        //method
        public void Goto()
        {
            Browser.Goto("/wp-login.php");
        }

        public void Login(string username, string password)
        {
            var masuk = Browser.Driver.FindElement(By.LinkText("log in with a password"));
            masuk.Click();

            var usernameield = Browser.Driver.FindElement(By.Id("user_login"));
            usernameield.SendKeys(username);

            var passwordField = Browser.Driver.FindElement(By.Id("user_pass"));
            passwordField.SendKeys(password);

            Browser.Driver.FindElement(By.Id("wp-submit")).Click();

        }
    }
}
