using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAutomationProject
{
    public class CommonPage : DriverElementSupplier
    {
        public CommonPage(WebDriverHolder driver): base(driver)
        {

        }

        public string GetTitle()
        {
            return Web.Driver.Title.ToString();
        }
    }
}
