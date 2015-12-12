using System;
using System.Collections.Generic;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class IntervalTests
    {
        private Interval GetTestInterval()
        {
            return new Interval
            {
                Days = new HashSet<DayOfWeek> {DayOfWeek.Friday, DayOfWeek.Monday},
                TimeFrom = new TimeSpan(03, 03, 03),
                TimeTo = new TimeSpan(20, 20, 20)
            };
        }

        [TestMethod]
        public void IsIn_DayAndTimeIn_ReturnTrue()
        {
            var interval = GetTestInterval();

            var result = interval.IsIn(new DateTime(2015, 12, 11, 20, 0, 0)); // frieday

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsIn_OtherDayAndTimeIn_ReturnFalse()
        {
            var interval = GetTestInterval();

            var result = interval.IsIn(new DateTime(2015, 12, 13, 20, 0, 0)); // sunday

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsIn_DayInAndTimeOut_ReturnFalse()
        {
            var interval = GetTestInterval();

            var result = interval.IsIn(new DateTime(2015, 12, 11, 22, 0, 0)); // fraiday

            Assert.IsFalse(result);
        }


        [TestMethod]
        public void TimeToStr_SetValue_ReturnTheSame()
        {
            var interval = GetTestInterval();
            var stringTime = "23:59";

            interval.TimeToStr = stringTime;

            Assert.AreEqual(interval.TimeToStr, stringTime);
        }

        [TestMethod]
        public void TimeFromStr_SetValue_ReturnTheSame()
        {
            var interval = GetTestInterval();
            var stringTime = "01:01";

            interval.TimeFromStr = stringTime;

            Assert.AreEqual(interval.TimeFromStr, stringTime);
        }
    }
}