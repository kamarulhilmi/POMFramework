using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtpTests
{
    public class EditProfilePage
    {
        private static int PAGE_LOAD_TIMEOUT = 10;

        public bool IsAt()
        {
            Browser.SwitchTabs(1);
            By element = By.XPath("//h1[contains(text(),'Edit Profile')]");
            return Browser.WaitUntilElementDisplayed(element, PAGE_LOAD_TIMEOUT);
        }
    }
}
