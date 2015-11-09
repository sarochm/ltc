using Common;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);

            Thread.CurrentThread.CurrentCulture = new CultureInfo("cs-CZ");

            var eventLogger = new EventLogger("LTC - TryApp");
            var notificator = new Notificator(eventLogger,new SettingsManager(eventLogger));

            Application.Run();
        }
    }
}
