using System;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Common;

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

        private void Repair(Settings settings)
        {
            if (settings.DayOfWeekLimits == null) settings.DayOfWeekLimits = new int[6];
            if (settings.DayOfWeekLimits.All(l => l == 0))
            {
                for (int i = 0; i < settings.DayOfWeekLimits.Length; i++)
                {
                    
                    settings.DayOfWeekLimits[i] = DefaultTicks;
                }
                settings.TodayRemainsMinutes = DefaultTicks;
            }
            if (string.IsNullOrWhiteSpace(settings.ActualDay)) settings.ActualDay = DefaultActualDay;
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
    }
}