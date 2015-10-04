using System;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class EventLoggerTests
    {
        [TestMethod]
        public void WritingToEventLog()
        {
            EventLogger eventLogger = new EventLogger("LoginTimeControlTest"); 

            eventLogger.Info("Test info message");
            eventLogger.Warning("Test warning message");
            eventLogger.Error("Test error message");
            
            // assert - manual check in Windows Logs - Application
        }
    }
}
