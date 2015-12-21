using System;
using System.Collections.Generic;
using System.Linq;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class SettingsTests
    {
        [TestMethod]
        public void GetNextAllowedIntervals_NoIntervalsForDay_ReturnsEmptyList()
        {
            var settings = GetSettingsForTest();
            var result = settings.GetNextAllowedIntervals(new DateTime(2015, 12, 20, 9, 30, 30)); // sunday
            Assert.AreEqual(result.Count, 0);
        }

        [TestMethod]
        public void GetNextAllowedIntervals_InFirstInterval_ReturnsAllIntervalsForDay()
        {
            var settings = GetSettingsForTest();
            var result = settings.GetNextAllowedIntervals(new DateTime(2015, 12, 21, 9, 30, 30)); // monday
            Assert.AreEqual(result.Count, 3);
        }

        [TestMethod]
        public void GetNextAllowedIntervals_BeforeLastInterval_ReturnsLastInterval()
        {
            var settings = GetSettingsForTest();
            var result = settings.GetNextAllowedIntervals(new DateTime(2015, 12, 23, 12, 00, 01)); // wednesday
            Assert.AreEqual(result.Count, 1);
            Assert.AreEqual(result.First().TimeFromStr,"20:00");
            Assert.AreEqual(result.First().TimeToStr, "22:00");
        }
        private Settings GetSettingsForTest()
        {
            return new Settings
            {
                AllowedIntervals =
                    new List<Interval>
                    {
                        new Interval
                        {
                            Days = new HashSet<DayOfWeek> {DayOfWeek.Monday, DayOfWeek.Wednesday},
                            TimeFrom = new TimeSpan(9, 0, 0),
                            TimeTo = new TimeSpan(10, 0, 0)
                        },
                        new Interval
                        {
                            Days = new HashSet<DayOfWeek> {DayOfWeek.Monday, DayOfWeek.Wednesday},
                            TimeFrom = new TimeSpan(11, 0, 0),
                            TimeTo = new TimeSpan(12, 0, 0)
                        },
                        new Interval
                        {
                            Days = new HashSet<DayOfWeek> {DayOfWeek.Monday, DayOfWeek.Wednesday},
                            TimeFrom = new TimeSpan(20, 0, 0),
                            TimeTo = new TimeSpan(22, 0, 0)
                        }
                    }
            };
        }
    }
}