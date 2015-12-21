using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace Common
{
    [Serializable]
    public class Settings
    {
        // unique identification of last dey when was setting changed
        public string ActualDay { get; set; }
        // limits in minutes for every day of week
        public int[] DayOfWeekLimits { get; set; }
        // todey minutes left
        public int TodayRemainsMinutes { get; set; }
        // logout is in progress
        public bool LogoutStarted { get; set; }
        //// logout counter
        public int LogoutCountdown { get; set; }

        public List<Interval> AllowedIntervals { get; set; }

        [XmlIgnore]
        public int TodayLimit
        {
            get { return DayOfWeekLimits[(int) DateTime.Now.DayOfWeek]; }
        }

        /// <summary>
        /// check when datetime is in allowed intervals
        /// </summary>
        /// <param name="dateTime">specific datetime</param>
        /// <returns>true if param datetime is in allowed intervals</returns>
        public bool IsInAllovedIntervals(DateTime dateTime)
        {
            return AllowedIntervals.Any(i => i.IsIn(dateTime));
        }

        /// <summary>
        /// returns nex allowed interval for specific day and time
        /// </summary>
        /// <param name="dateTime">specific datetime</param>
        /// <returns>intervals</returns>
        public List<Interval> GetNextAllowedIntervals(DateTime dateTime)
        {
            var intervalsAtDay = AllowedIntervals.Where(i => i.Days.Contains(dateTime.DayOfWeek));
            var intervalsEndingAfterToTime = intervalsAtDay.Where(i => i.TimeTo > dateTime.TimeOfDay).OrderBy(n=>n.TimeTo);
            return intervalsEndingAfterToTime.ToList();
        }
    }
}