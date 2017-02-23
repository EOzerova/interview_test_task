﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;

namespace Ssl_web_tests
{
    public class NavigationService: BaseService
    {
        public string BaseUrl { get; set; }

        public NavigationService(ApplicationManager manager, string baseUrl) : base(manager)
        {
            this.BaseUrl = baseUrl;
        }

        public void GoToHomePage()
        {
            if (Driver.Url == BaseUrl)
            {
                return;
            }

            Driver.Navigate().GoToUrl(BaseUrl);
        }

        public void GoToAutorizationPage()
        {
            Driver.Navigate().GoToUrl(BaseUrl + "/authorize");
        }

        public void GoToUserProfilePage()
        {
            Driver.Navigate().GoToUrl(BaseUrl + "/user/profile");
        }

        public string GetCurrentUrl()
        {
            return Driver.Url;
        }
    }
}
