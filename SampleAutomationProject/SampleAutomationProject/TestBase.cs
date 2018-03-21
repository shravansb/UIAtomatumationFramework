using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAutomationProject
{
    public class TestBase
    {
        public TestBase()
        {
            App = new Application();
        }

        public static SampleAutomationProject.Application App { get; set; }

    }
}
