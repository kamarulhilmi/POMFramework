using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace QtpTests
{
    [TestClass]
    public class TC02_LoginWithInvalidUsernameShouldNotWork : TestBase
    {
        [TestMethod]
        public void RunTest()
        {
            Pages.Login.Goto();
            Pages.Login.Login("zamarul", "p@ssw0rd125977");
            Assert.IsFalse(Pages.MyMembership.IsAt());
        }
    }
}
