using System.ServiceProcess;
using Common;
using Microsoft.Practices.Unity;

namespace LtcService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            UnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<IEventLogger, EventLogger>(new InjectionConstructor("MSC-LTC service"));
            unityContainer.RegisterType<IUserUnloger, UserUnloger>(new ContainerControlledLifetimeManager());
            unityContainer.RegisterType<IOsUsersReader,OsUsersReader>(new ContainerControlledLifetimeManager());
            unityContainer.RegisterType<ISettingsManager,SettingsManager>(new ContainerControlledLifetimeManager());
            unityContainer.RegisterType<IEvaluator,Evaluator>(new ContainerControlledLifetimeManager());

            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                unityContainer.Resolve<LtcService>() 
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
