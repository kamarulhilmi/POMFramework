using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace QtpTests
{
    public static class Browser
    {
        private static IWebDriver webDriver = new ChromeDriver(@"C:\Users\REG-LPT-077\Documents\Visual Studio 2015\Projects\SIPTestFramework\SIPTestFramework\Drivers");

        internal static void SwitchTabs(int tabIndex)
        {
            var windows = webDriver.WindowHandles;
            webDriver.SwitchTo().Window(windows[tabIndex]);
        }

        

        private static string baseUrl = "http://www.qtptutorial.net";

        internal static bool WaitUntilElementDisplayed(By element, int timeout)
        {
            for (int i = 0; i < timeout; i++)
            {
                if (ElementIsDisplayed(element))
                {
                    return true;
                }
                Thread.Sleep(1000);
            }
            return false;

        }

        public static bool ElementIsDisplayed(By element)
        {
            var present = false;
            webDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(0));
            try
            {
                present = webDriver.FindElement(element).Displayed;
            }
            catch (NoSuchElementException)
            {

            }
            webDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            return present;
        }
        //properties
        public static ISearchContext Driver
        {
            get
            {
                return webDriver;
            }
            
        }

        public static string Title
        {
            get
            {
                return webDriver.Title;
            }
        }

        //method

        public static void Initialize()
        {
            Goto("");
        }

        public static void Close()
        {
            webDriver.Close();
        }

        internal static void Quit()
        {
            webDriver.Quit();
        }

        public static void Goto(string url, bool useBaseUrl = true)
        {
            if (useBaseUrl)
                webDriver.Navigate().GoToUrl(string.Format("{0}/{1}", baseUrl, url));
            else
                webDriver.Navigate().GoToUrl(url);
        }

    }
}
