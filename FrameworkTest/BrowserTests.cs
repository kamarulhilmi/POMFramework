using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QtpTests;
using OpenQA.Selenium;

namespace FrameworkTest
{
    [TestClass]
    public class BrowserTests
    {
        [TestMethod]
        public void GivenValidElement_WhenElementIsVisible_ElementIsDisplayedFindElement()
        {
            Browser.Goto("data:text/html,<span id =\"hello\">Hello</span>", false);
            Assert.IsTrue(Browser.ElementIsDisplayed(By.Id("hello")), "Element display did not find the element");
        }
    }
}
