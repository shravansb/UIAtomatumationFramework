using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAutomationProject
{
    public class HomePage : CommonPage
    {
        public HomePage(WebDriverHolder driver) : base(driver)
        {

        }

        public AtlasPage ClickAtlas()
        {
            Web.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Web.Driver.FindElement(By.XPath("//a[text()='Data']")).Click();
            return new AtlasPage(new WebDriverHolder(Web.Driver));
        }
    }
}
