using System;
using System.Globalization;
using System.Windows.Forms;

namespace LtcWinConfig
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
            //CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.GetCultureInfo("cs-CZ");
            Application.Run(new MainForm());
        }
    }
}