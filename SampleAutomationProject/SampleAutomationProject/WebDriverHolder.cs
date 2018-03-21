using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAutomationProject
{
    public class WebDriverHolder
    {
        private IWebDriver _driver;
        private IWebElement _element;

        public WebDriverHolder(IWebDriver driver)
        {
            _driver = driver;
            _element = _driver.FindElement(By.CssSelector("body"));
        }

        public IWebDriver Driver
        {
            get
            {
                return _driver;
            }
        }

        public IWebElement Element
        {
            get
            {
                return _element;
            }
        }
    }
}
