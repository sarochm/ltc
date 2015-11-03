using System.Drawing;
using System.Timers;
using System.Windows.Forms;
using Common;
using Timer = System.Timers.Timer;

namespace TryApp
{
    public class Notificator
    {
        private readonly NotifyIcon _notifyIcon;
        private readonly Timer _timer;

        private IEventLogger _eventLogger;
        private ISettingsManager _settingsManager;

        public Notificator(IEventLogger eventLogger, ISettingsManager settingsManager)
        {
            _eventLogger = eventLogger;
            _settingsManager = settingsManager;
            _notifyIcon = new NotifyIcon
            {
                Icon = new Icon("TryIcon.ico"),
                Visible = true,
                BalloonTipTitle = "Caution"
            };
            _timer = new Timer(60000)
            {
                AutoReset = true,
                Enabled = true
            };
            _timer.Elapsed += _timer_Elapsed;
        }

        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            var settings = _settingsManager.LoadSettings();
            _notifyIcon.BalloonTipText = string.Format("You will be logged out in {0} minutes", settings.TicksLeft);
            _notifyIcon.Text = string.Format("{0}/{1} minutes left", settings.TicksLeft, settings.DayTicksLimit);
            settings.TicksLeft--;
            _settingsManager.SaveSettings(settings);
            _notifyIcon.ShowBalloonTip(5000);
        }
    }
}