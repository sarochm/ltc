using System.ServiceProcess;
using System.Timers;
using Common;

namespace LtcService
{
    public partial class LtcService : ServiceBase
    {
        private const int CheckInterval = 60000; // 60 seconds
        private EventLogger _eventLogger;
        private Timer _timer;

        public LtcService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            _timer = new Timer(CheckInterval);
            _timer.Elapsed += OnTimer;
            _timer.Start();
            _eventLogger = new EventLogger(GetType().Name);
            _eventLogger.Info("Service is starting");
        }

        private void OnTimer(object sender, ElapsedEventArgs e)
        {
            _eventLogger.Info("Timer elapsed");
        }

        protected override void OnStop()
        {
            _eventLogger.Info("Service is stopping");
        }
    }
}