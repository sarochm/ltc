using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Common
{
    public class SettingsManager : ISettingsManager
    {
        public const int DefaultTicks = 300;
        public const string DefaultActualDay = "default";

        private readonly IEventLogger _eventLogger;
        private readonly string _fileName;
        private readonly XmlSerializer _xmlSerializer;

        public SettingsManager(IEventLogger eventLogger, string fileName = "LtcSettings.xml")
        {
            _eventLogger = eventLogger;
            _xmlSerializer = new XmlSerializer(typeof (Settings));
            _fileName = fileName;
        }

        public Settings LoadSettings()
        {
            Settings settings;
            try
            {
                if (!File.Exists(_fileName)) SaveSettings(new Settings());
                using (var fileStream = File.OpenRead(_fileName))
                {
                    settings = (Settings) _xmlSerializer.Deserialize(fileStream);
                }
            }
            catch (Exception exception)
            {
                _eventLogger.Error("Error when loading settings: " + exception.Message);
                settings = new Settings();
            }
            Repair(settings);

            return settings;
        }

        public bool SaveSettings(Settings settings)
        {
            try
            {
                using (var fileStream = new FileStream(_fileName, FileMode.Create))
                {
                    _xmlSerializer.Serialize(fileStream, settings);
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        private List<Interval> DefaultAllowIntervals()
        {
            return new List<Interval>
            {
                new Interval
                {
                    Days =
                        new HashSet<DayOfWeek>
                        {
                            DayOfWeek.Sunday,
                            DayOfWeek.Monday,
                            DayOfWeek.Tuesday,
                            DayOfWeek.Wednesday,
                            DayOfWeek.Thursday,
                            DayOfWeek.Friday,
                            DayOfWeek.Saturday
                        },
                    TimeFrom = new TimeSpan(8, 0, 0),
                    TimeTo = new TimeSpan(20, 0, 0)
                }
            };
        }

        private void Repair(Settings settings)
        {
            if (settings.DayOfWeekLimits == null || settings.DayOfWeekLimits.Length < 7)
                settings.DayOfWeekLimits = new int[7];
            if (settings.DayOfWeekLimits.All(l => l == 0))
            {
                for (var i = 0; i < settings.DayOfWeekLimits.Length; i++)
                {
                    settings.DayOfWeekLimits[i] = DefaultTicks;
                }
                settings.TodayRemainsMinutes = DefaultTicks;
            }
            if (string.IsNullOrWhiteSpace(settings.ActualDay))
            {
                settings.ActualDay = DefaultActualDay;
                settings.AllowIntervals = DefaultAllowIntervals();
            }
        }
    }
}