using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Timers;
using Common;

namespace LtcService
{
    public partial class LtcService : ServiceBase
    {
        private const int CheckInterval = 60000; // 60 seconds
        private List<string> _adminUsers;
        private Evaluator _evaluator;
        private EventLogger _eventLogger;
        private Timer _timer;
        private UserUnloger _userUnloger;

        public LtcService()
        {
            InitializeComponent();
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
        }

        protected override void OnStart(string[] args)
        {
            _eventLogger = new EventLogger(GetType().Name);
            _evaluator = new Evaluator(_eventLogger);
            _adminUsers = new OsUsersReader().GetAdmins();
            _userUnloger = new UserUnloger();
            _timer = new Timer(CheckInterval);
            _timer.Elapsed += OnTimer;
            _timer.Start();

            _eventLogger.Info("Service is starting");
        }

        private void OnTimer(object sender, ElapsedEventArgs e)
        {
            try
            {
                var logedUsers = _userUnloger.GetLogedUsers();
                if (!logedUsers.Any())
                {
                    _eventLogger.Debug("no users logedIn");
                    return;
                }
                var notAdminLogedUsers = logedUsers.Except(_adminUsers).ToList();
                if (notAdminLogedUsers.Any())
                {
                    if (_evaluator.Tick())
                    {
                        _eventLogger.Info(string.Format("Traing logoff users >{0}<", string.Join("-", logedUsers)));
                        _userUnloger.LogOffAll();
                    }
                }
                else
                    _eventLogger.Debug(string.Format("Only admin users are logedIn >{0}<", string.Join("-", logedUsers)));
            }
            catch (Exception ex)
            {
                _eventLogger.Error(string.Format("Exception on tick >{0}<", ex.Message));
            }
        }

        protected override void OnStop()
        {
            _eventLogger.Info("Service is stopping");
        }
    }
}