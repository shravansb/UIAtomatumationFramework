using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAutomationProject
{
    public class DriverElementSupplier 
    {
        private WebDriverHolder _web;

        public DriverElementSupplier(WebDriverHolder webDriverElement)
        {
            _web = webDriverElement;
        }

        protected WebDriverHolder Web
        {
            get
            {
                return _web;
            }
        }

    }
}
