using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryApp
{
    public class Notificator
    {
        IEventLogger _eventLogger;
        ISettingsManager _settingsManager;
        NotifyIcon _notifyIcon;

        public Notificator(IEventLogger eventLogger, ISettingsManager settingsManager)
        {
            _eventLogger = eventLogger;
            _settingsManager = settingsManager;
            _notifyIcon = new NotifyIcon();
            _notifyIcon.Icon = new System.Drawing.Icon("TryIcon.ico");
            _notifyIcon.Visible = true;
        }
    }
}
