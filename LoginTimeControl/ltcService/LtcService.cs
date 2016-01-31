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
        private readonly IEvaluator _evaluator;
        private readonly IEventLogger _eventLogger;
        private bool _notAdminUserLoggedIn;
        private Timer _timer;
        private readonly IUserUnloger _userUnloger;
        private readonly IOsUsersReader _osUsersReader;

        public LtcService(IEventLogger eventLogger, IUserUnloger userUnloger, IOsUsersReader osUsersReader, IEvaluator evaluator)
        {
            InitializeComponent();
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
            _notAdminUserLoggedIn = false;
            _eventLogger = eventLogger;
            _userUnloger = userUnloger;
            _osUsersReader = osUsersReader;
            _evaluator = evaluator;
        }


        protected override void OnStart(string[] args)
        {
            _adminUsers = _osUsersReader.GetAdmins();
            _evaluator.Initialize();
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
                    _notAdminUserLoggedIn = true;
                    if (_evaluator.Tick())
                    {
                        _eventLogger.Info(string.Format("Traing logoff users >{0}<", string.Join("-", logedUsers)));
                        _userUnloger.LogOffAll();
                    }
                }
                else
                {
                    if(_notAdminUserLoggedIn) _evaluator.ResetCountdown();
                    _notAdminUserLoggedIn = false;
                    _eventLogger.Debug(string.Format("Only admin users are logedIn >{0}<", string.Join("-", logedUsers)));
                }
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