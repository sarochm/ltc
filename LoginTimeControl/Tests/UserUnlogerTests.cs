using System;
using LtcService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UserUnlogerTests
    {
        readonly UserUnloger _userUnloger = new UserUnloger();

        [TestMethod]
        public void IsSomeOneLogedOn_returnsTrue()
        {

            var isLoged = _userUnloger.IsSomeOneLogedOn();
            Assert.IsTrue(isLoged);
        }

        [TestMethod]
        public void LogOffAll()
        {
            _userUnloger.LogOffAll();  // beware . logs you out
        }
    }
}
