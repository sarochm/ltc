using System;
using System.Xml.Serialization;

namespace Common
{
    [Serializable]
    public class Interval
    {
        private const string SerializingTimeFormat = @"hh\:mm";

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
    }
}