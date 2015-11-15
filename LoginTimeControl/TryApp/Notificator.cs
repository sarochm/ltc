using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
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
        private readonly Timer _timer;

        private IEventLogger _eventLogger;

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
            _timer = new Timer(60000)
            {
                AutoReset = true,
                Enabled = true
            };
            _timer.Elapsed += _timer_Elapsed;
        }

        private void menuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            var settings = _settingsManager.LoadSettings();
            _notifyIcon.Text = string.Format(Strings.P0P1MinutesLeft, settings.TodayRemainsMinutes, settings.TodayLimit);
            if (settings.TodayRemainsMinutes < 6)
            {
                _notifyIcon.BalloonTipText = string.Format(Strings.YouWillBeLoggedOutInP0Minutes, settings.TodayRemainsMinutes);
                _notifyIcon.ShowBalloonTip(3000);
            }
            //settings.TicksLeft--;
            //_settingsManager.SaveSettings(settings);
        }
    }
}