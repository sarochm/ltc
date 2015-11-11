using System;
using System.IO;
using System.Windows.Forms;
using Common;

namespace TryApp
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
            // CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.GetCultureInfo("cs-CZ");

            var eventLogger = new EventLogger("LTC - TryApp");
            var notificator = new Notificator(eventLogger, new SettingsManager(eventLogger));

            Application.Run();
        }
    }
}