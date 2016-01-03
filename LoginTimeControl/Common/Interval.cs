using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace Common
{
    [Serializable]
    public class Interval
    {
        private const string SerializingTimeFormat = @"hh\:mm";

        public HashSet<DayOfWeek> Days { get; set; }

        [XmlIgnore]
        public TimeSpan TimeFrom { get; set; }

        [XmlIgnore]
        public TimeSpan TimeTo { get; set; }

        [XmlElement(ElementName = "TimeFrom")]
        public string TimeFromStr
        {
            get { return TimeFrom.ToString(SerializingTimeFormat); }
            set { TimeFrom = TimeSpan.ParseExact(value, SerializingTimeFormat, null); }
        }

        [XmlElement(ElementName = "TimeTo")]
        public string TimeToStr
        {
            get { return TimeTo.ToString(SerializingTimeFormat); }
            set { TimeTo = TimeSpan.ParseExact(value, SerializingTimeFormat, null); }
        }

        public bool IsIn(DateTime dateTime)
        {
            if (!Days.Contains(dateTime.DayOfWeek)) return false;
            var timeOfday = dateTime.TimeOfDay;
            if (timeOfday > TimeFrom && timeOfday < TimeTo) return true;
            return false;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}   {2}", TimeFromStr, TimeToStr, string.Join(",", Days.Select(d =>d.ToLocalizedString())));
        }
    }
}