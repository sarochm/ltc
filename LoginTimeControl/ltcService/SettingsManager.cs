﻿using System;
using System.IO;
using System.Xml.Serialization;
using Common;

namespace LtcService
{
    public class SettingsManager
    {
        public const int DefaultTicks = 300;
        public const string DefaultActualDay = "default";

        private readonly IEventLogger _eventLogger;
        private readonly string _fileName;
        private readonly XmlSerializer _xmlSerializer;

        public SettingsManager(IEventLogger eventLogger, string fileName = "Settings.xml")
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
                using (var fileStream = new FileStream(_fileName, FileMode.Open))
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
            if (settings.DayTicksLimit == 0) settings.DayTicksLimit = settings.TicksLeft = DefaultTicks;
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