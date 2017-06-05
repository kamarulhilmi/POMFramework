using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace QtpTests
{
    [TestClass]
    public class TC03_ValidUserCanSuccesfullyAccessEditPage : TestBase
    {
        [TestMethod]
        public void RunTest()
        {
            Pages.Login.Goto();
            Pages.Login.Login("kamarul", "p@ssw0rd125977");
            Assert.IsTrue(Pages.MyMembership.IsAt(), "User can log in");

            Pages.MyMembership.EditProfile();
            Assert.IsTrue(Pages.EditProfile.IsAt(), "The user can't access edit profile page");
        }
    }
}
