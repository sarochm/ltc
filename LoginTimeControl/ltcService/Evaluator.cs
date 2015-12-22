using System;
using Common;

namespace LtcService
{
    public class Evaluator
    {
        private const int TicksForCountDown = 4;
        private const int TicksAfterLogOff = 2;
        private readonly SettingsManager _settingsManager;

        public Evaluator(IEventLogger eventLogger)
        {
            _settingsManager = new SettingsManager(eventLogger);
            var settings = _settingsManager.LoadSettings();
            CheckToday(settings);
            settings.LogoutCountdown = TicksForCountDown;
            settings.LogoutStarted = false;
            _settingsManager.SaveSettings(settings);
        }

        public bool Tick()
        {
            var result = false;
            var settings = _settingsManager.LoadSettings();
            CheckToday(settings);

            settings.TodayRemainsMinutes--;
            if (settings.TodayRemainsMinutes < TicksForCountDown || !settings.IsInAllovedIntervals(DateTime.Now.AddMinutes(TicksForCountDown)))
            {
                settings.LogoutStarted = true;
                settings.LogoutCountdown--;
                if (settings.LogoutCountdown <= 0)
                {
                    settings.LogoutStarted = false;
                    settings.LogoutCountdown = TicksAfterLogOff;
                    result = true;
                }
            }
            else
            {
                ResetCountdown(settings);
            }
            _settingsManager.SaveSettings(settings);
            return result;
        }

        public void ResetCountdown()
        {
            var settings = _settingsManager.LoadSettings();
            ResetCountdown(settings);
            _settingsManager.SaveSettings(settings);
        }


        private void ResetCountdown(Settings settings)
        {
            settings.LogoutStarted = false;
            settings.LogoutCountdown = TicksForCountDown;
        }

        private void CheckToday(Settings settings)
        {
            var today = DateTime.Now.ToShortDateString();
            if (settings.ActualDay != today)
            {
                settings.ActualDay = today;
                settings.TodayRemainsMinutes = settings.TodayLimit;
                ResetCountdown(settings);
            }
        }
    }
}