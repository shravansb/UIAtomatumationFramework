using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAutomationProject
{
    [TestClass]
    public class AtlasTests : TestBase
    {
        [TestMethod]
        public void AtlasTest()
        {
            var Home = App.LoginPage().LoginToApplication("sbongale@knoema.com", "test123");
            Home.ClickAtlas().ClickIndiaFlag();
            var Atlas = App.AtlasPage();
            Assert.AreEqual(Atlas.GetTitle(), "India | Data and Statistics - knoema.com");
        }
    }
}
