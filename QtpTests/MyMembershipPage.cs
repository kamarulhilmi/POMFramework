using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtpTests
{
    public class MyMembershipPage
    {
        private int PAGE_LOAD_TIMEOUT = 10;

        public bool IsAt()
        {
            By element = By.XPath("//h1[contains(text(),'My Membership')]");
            return Browser.WaitUntilElementDisplayed(element, PAGE_LOAD_TIMEOUT);
        }

        internal void EditProfile()
        {
            var editProfile = Browser.Driver.FindElement(By.LinkText("Edit Profile"));
            editProfile.Click();
        }
    }
}
