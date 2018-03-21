using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAutomationProject
{
    public class AtlasPage: CommonPage
    {
        public AtlasPage(WebDriverHolder Driver) : base(Driver)
        {

        }

        public void ClickIndiaFlag()
        {
            Web.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Web.Driver.FindElement(By.XPath("//p[contains(text(),'India')]")).Click();
        }

        public string GetTitle()
        {
            return Web.Driver.Title.ToString();
        }
    }
}
