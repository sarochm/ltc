using System;
using System.IO;
using System.Threading;
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
            var createdNew = true;
            using (var mutex = new Mutex(true, "MSC-LTC-TryApp", out createdNew))
            // for only one instance http://stackoverflow.com/questions/184084/how-to-force-c-sharp-net-app-to-run-only-one-instance-in-windows
            {
                if (createdNew)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
                    //CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.GetCultureInfo("cs-CZ");

                    var eventLogger = new EventLogger("LTC - TryApp");
                    var notificator = new Notificator(eventLogger, new SettingsManager(eventLogger));

                    Application.Run();
                }
            }
        }
    }
}