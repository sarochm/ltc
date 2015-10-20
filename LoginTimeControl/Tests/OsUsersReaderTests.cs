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
            var osUserReader = new OsUsersReader();

            var adminsNames = osUserReader.GetAdmins();

            Assert.IsTrue(adminsNames.Count > 0);
        }
    }
}
