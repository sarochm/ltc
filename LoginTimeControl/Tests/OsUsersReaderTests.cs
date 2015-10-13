using System;
using LtcService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class OsUsersReaderTests
    {
        [TestMethod]
        public void GetAdmins_ReturnAnyName()
        {
            var adminsNames = OsUsersReader.GetAdmins();

            Assert.IsTrue(adminsNames.Count > 0);
        }
    }
}
