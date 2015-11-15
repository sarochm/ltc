using System;

namespace Common
{
    [Serializable]
    public class Settings
    {
        // unique identification of last dey when was setting changed
        public string ActualDay { get; set; }
        // todo: remove
        public int DayTicksLimit { get; set; }
        // limits in minutes for every day of week
        public int[] DayOfWeekLimits { get; set; }
        // todey minutes left
        public int TodeyRemainsCounter { get; set; }
        // logout is in progress
        public bool LogoutStarted { get; set; }
        // logout counter
        public int LogoutCountdown { get; set; }
    }
}