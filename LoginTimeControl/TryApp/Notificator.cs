using System;
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
        private readonly ISettingsManager _settingsManager;

        public Notificator(IEventLogger eventLogger, ISettingsManager settingsManager)
        {
            _eventLogger = eventLogger;
            _settingsManager = settingsManager;
            var contextMenu = new ContextMenu(new[] {new MenuItem("text")});
            _notifyIcon = new NotifyIcon
            {
                Icon = new Icon("TryIcon.ico"),
                Visible = true,
                BalloonTipTitle = "Caution",
                ContextMenu = contextMenu
            };
            _notifyIcon.Click += _notifyIcon_Click;
            _timer = new Timer(60000)
            {
                AutoReset = true,
                Enabled = true
            };
            _timer.Elapsed += _timer_Elapsed;
        }

        private void _notifyIcon_Click(object sender, EventArgs e)
        {
            var settings = _settingsManager.LoadSettings();
            var form = new ChangeSettingsForm(settings.DayTicksLimit, settings.TicksLeft);
            if (form.ShowDialog() == DialogResult.OK)
            {
                settings.TicksLeft = form.TodayLeft();
                settings.DayTicksLimit = form.DayLimit();
                if (_settingsManager.SaveSettings(settings) == false)
                {
                    MessageBox.Show("You can't write settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }
            }
            else  Application.Exit();
        }

        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            var settings = _settingsManager.LoadSettings();
            _notifyIcon.Text = string.Format("{0}/{1} minutes left", settings.TicksLeft, settings.DayTicksLimit);
            if (settings.TicksLeft < 6)
            {
                _notifyIcon.BalloonTipText = string.Format("You will be logged out in {0} minutes", settings.TicksLeft);
                _notifyIcon.ShowBalloonTip(5000);
            }
            //settings.TicksLeft--;
            //_settingsManager.SaveSettings(settings);
        }
    }
}