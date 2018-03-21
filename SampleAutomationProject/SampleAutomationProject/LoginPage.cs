using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAutomationProject
{   
    //Rename class and remove object
    public class LoginPage : CommonPage
    {
        public LoginPage(WebDriverHolder Driver) : base(Driver)
        {

        }
        
        public HomePage LoginToApplication(string EmailId, string Password)
        {
            Web.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Web.Driver.FindElement(By.Id("login")).Click();
            Web.Driver.FindElement(By.Id("EMail")).SendKeys(EmailId);
            Web.Driver.FindElement(By.Id("Password")).SendKeys(Password);
            Web.Driver.FindElement(By.CssSelector("input.login")).Submit();
            return new HomePage(new WebDriverHolder(Web.Driver));
        }

    }
}
