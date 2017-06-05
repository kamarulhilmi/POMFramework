using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;


namespace QtpTests
{
    public static class Pages
    {
        //method
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.Driver, page);
            return page;
        }
        //properties
        public static LoginPage Login
        {
            get
            {
                return GetPage<LoginPage>();
            }
        }

        public static MyMembershipPage MyMembership
        {
            get
            {
                return GetPage<MyMembershipPage>();
            }
        }

        public static EditProfilePage EditProfile
        {
            get
            {
                return GetPage<EditProfilePage>();
            }
        }
        
    }
}
