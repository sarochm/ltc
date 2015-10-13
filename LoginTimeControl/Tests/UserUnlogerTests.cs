using System;
using LtcService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UserUnlogerTests
    {
        [TestMethod]
        public void IsSomeOneLogedOn_returnsTrue()
        {
            var isLoged = UserUnloger.IsSomeOneLogedOn();
            Assert.IsTrue(isLoged);
        }

        [TestMethod]
        public void LogOffAll()
        {
            // UserUnloger.LogOffAll();  // beware . logs you out
        }
    }
}
