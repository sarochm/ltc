using System;
using System.IO;
using System.Windows.Forms;
using Common;

namespace LtcWinConfig
{
    public partial class MainForm : Form
    {
        private Settings _settings;
        private SettingsManager _settingsManager;


        public MainForm()
        {
            InitializeComponent();
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var eventLogger = new EventLogger("LTC Config");
            _settingsManager = new SettingsManager(eventLogger);
            LoadSettings();
        }

        private void LoadSettings()
        {
            _settings = _settingsManager.LoadSettings();
            numericUpDownDayLimit.Value = _settings.DayOfWeekLimits[0];
            numericUpDownLeft.Value = (_settings.TodayRemainsMinutes < numericUpDownLeft.Minimum) ? numericUpDownLeft.Minimum : _settings.TodayRemainsMinutes;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Application.Exit();
        }

        private void SaveSettings()
        {
            for (var i = 0; i < _settings.DayOfWeekLimits.Length; i++)
            {
                _settings.DayOfWeekLimits[i] = Convert.ToInt32(numericUpDownDayLimit.Value);
            }
            _settings.TodayRemainsMinutes = Convert.ToInt32(numericUpDownLeft.Value);
            _settings.LogoutStarted = false;
            _settingsManager.SaveSettings(_settings);
        }
    }
}