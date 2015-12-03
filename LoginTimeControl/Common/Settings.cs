﻿using System;
using System.Collections.Generic;
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

        public List<Interval> AllowIntervals { get; set; }

        [XmlIgnore]
        public int TodayLimit
        {
            get { return DayOfWeekLimits[(int) DateTime.Now.DayOfWeek]; }
        }
    }
}