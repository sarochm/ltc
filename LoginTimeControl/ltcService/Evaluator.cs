﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace LtcService
{
    public class Evaluator
    {
        const int TicksAfterRise = 3;
        private SettingsManager _settingsManager;

        public Evaluator(IEventLogger eventLogger)
        {
            _settingsManager = new SettingsManager(eventLogger);
        }

        public bool Tick()
        {
            var settings = _settingsManager.LoadSettings();
            var today = GetTodayDatum();
            if (settings.ActualDay != today)
            {
                settings.ActualDay = today;
                settings.TicksLeft = settings.DayTicksLimit;
            };

            settings.TicksLeft--;
            if (settings.TicksLeft <= 0)
            {
                settings.TicksLeft = TicksAfterRise;
                _settingsManager.SaveSettings(settings);
                return true;
            }
            _settingsManager.SaveSettings(settings); 
            return false;
        }

        private static string GetTodayDatum()
        {
            return DateTime.Now.ToShortDateString();
        }
    }
}