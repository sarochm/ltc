using System;
using System.Globalization;
using System.Windows.Forms;
using Common;
using Microsoft.Practices.Unity;

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
            //CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.GetCultureInfo("de-DE");
            
            IUnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<IEventLogger, EventLogger>(new InjectionConstructor("MSC-LTC config app"));
            unityContainer.RegisterType<ISettingsManager, SettingsManager>();
            
            Application.Run(unityContainer.Resolve<MainForm>());
        }
    }
}