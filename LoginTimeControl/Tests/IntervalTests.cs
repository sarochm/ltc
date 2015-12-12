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
            return new Interval()
            {
                Days = new HashSet<DayOfWeek>() {DayOfWeek.Friday, DayOfWeek.Monday},
                TimeFrom = new TimeSpan(03, 03, 03),
                TimeTo = new TimeSpan(20)

            };
        }



        [TestMethod]
        public void TimeToStr_SetValue_ReturnTheSame()
        {
            Interval interval = GetTestInterval();
            string stringTime = "23:59";

            interval.TimeToStr = stringTime;

            Assert.AreEqual(interval.TimeToStr,stringTime);
        }

        [TestMethod]
        public void TimeFromStr_SetValue_ReturnTheSame()
        {
            Interval interval = GetTestInterval();
            string stringTime = "01:01";

            interval.TimeFromStr = stringTime;

            Assert.AreEqual(interval.TimeFromStr, stringTime);
        }
    }
}
