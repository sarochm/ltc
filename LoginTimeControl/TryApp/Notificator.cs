using System;
using System.Drawing;
using System.Linq;
using System.Timers;
using System.Windows.Forms;
using Common;
using Timer = System.Timers.Timer;

namespace TryApp
{
    public class Notificator
    {
        private readonly NotifyIcon _notifyIcon;
        private readonly ISettingsManager _settingsManager;

        private readonly IEventLogger _eventLogger;

        public Notificator(IEventLogger eventLogger, ISettingsManager settingsManager)
        {
            _eventLogger = eventLogger;
            _settingsManager = settingsManager;

            var menuItem = new MenuItem(Strings.Exit);
            menuItem.Click += menuItem_Click;
            var contextMenu = new ContextMenu(new[] {menuItem});
            _notifyIcon = new NotifyIcon
            {
                Icon = new Icon("TryIcon.ico"),
                Visible = true,
                BalloonTipTitle = Strings.Caution,
                Text = Strings.Initializing,
                ContextMenu = contextMenu
            };

            var oneRunTimer = new Timer(3000)
            {
                AutoReset = false,
                Enabled = true
            };
            oneRunTimer.Elapsed += _timer_Elapsed; // runs only once after aplication start

            var timer = new Timer(60000)
            {
                AutoReset = true,
                Enabled = true
            };
            timer.Elapsed += _timer_Elapsed;
        }

        private void menuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                var settings = _settingsManager.LoadSettings();
                string notifyText = string.Format(Strings.P0P1MinutesLeft, settings.TodayRemainsMinutes, settings.TodayLimit) +
                           "\n\n"+
                           Strings.AllowedIntervals + "\n" + GetAllowedIntervalsToString(settings);
                _notifyIcon.Text = notifyText.Length > 63 ? notifyText.Substring(0,63): notifyText;
                if (settings.LogoutStarted)
                {
                    _notifyIcon.BalloonTipText = string.Format(Strings.YouWillBeLoggedOutInP0Minutes,
                        settings.LogoutCountdown);
                    _notifyIcon.ShowBalloonTip(3000);
                }
            }
            catch (Exception exception)
            {
                _eventLogger.Error("Error on try app notification: " + exception.Message);
            }
        }

        private string GetAllowedIntervalsToString(Settings settings)
        {
            return string.Join(" ",
                settings.AllowedIntervals.Select(i => i.TimeFromStr + ":" + i.TimeToStr));
        }
    }
}