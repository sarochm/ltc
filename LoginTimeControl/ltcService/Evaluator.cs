using System;
using Common;

namespace LtcService
{
    public class Evaluator
    {
        private const int TicksAfterRise = 4;
        private readonly SettingsManager _settingsManager;

        public Evaluator(IEventLogger eventLogger)
        {
            _settingsManager = new SettingsManager(eventLogger);
            var settings = _settingsManager.LoadSettings();
            CheckToday(settings);
            settings.LogoutCountdown = TicksAfterRise;
            settings.LogoutStarted = false;
            _settingsManager.SaveSettings(settings);
        }

        public bool Tick()
        {
            var result = false;
            var settings = _settingsManager.LoadSettings();
            CheckToday(settings);

            settings.TodayRemainsMinutes--;
            if (settings.TodayRemainsMinutes < TicksAfterRise)
            {
                settings.LogoutStarted = true;
                settings.LogoutCountdown--;
                if (settings.LogoutCountdown <= 0)
                {
                    settings.LogoutCountdown = TicksAfterRise;
                    result = true;
                }
            }
            else
            {
                settings.LogoutStarted = false;
                settings.LogoutCountdown = TicksAfterRise;
            }
            _settingsManager.SaveSettings(settings);
            return result;
        }

        private void CheckToday(Settings settings)
        {
            var today = DateTime.Now.ToShortDateString();
            if (settings.ActualDay != today)
            {
                settings.ActualDay = today;
                settings.TodayRemainsMinutes = settings.TodayLimit;
                settings.LogoutCountdown = TicksAfterRise;
                settings.LogoutStarted = false;
            }
            ;
        }
    }
}