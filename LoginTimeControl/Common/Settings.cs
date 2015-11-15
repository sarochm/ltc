using System;
using System.Collections.Generic;

namespace Common
{
    [Serializable]
    public class Settings
    {
        public string ActualDay { get; set; }
        public int DayTicksLimit { get; set; }
        public int TicksLeft { get; set; }

        public int[] DaysOfWeekTicksLimit { get; set; }
    }
}