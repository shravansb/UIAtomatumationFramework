using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAutomationProject
{
    public class Application
    {
        RemoteWebDriver _driver;

        public Application()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("http://knoema.com");
        }
        
        public HomePage Homepage()
        {
            return new HomePage(new WebDriverHolder(_driver));
        }

        public LoginPage LoginPage()
        {
            return new LoginPage(new WebDriverHolder(_driver));
        }

        public AtlasPage AtlasPage()
        {
            return new AtlasPage(new WebDriverHolder(_driver));
        }

        public static void Main()
        {

        }
    }
}
