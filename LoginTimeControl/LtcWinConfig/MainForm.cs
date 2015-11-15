using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace LtcWinConfig
{
    public partial class MainForm : Form
    {
        SettingsManager _settingsManager;
        private Settings _settings;


        public MainForm()
        {
            InitializeComponent();
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            EventLogger eventLogger = new EventLogger("LTC Config");
            _settingsManager = new SettingsManager(eventLogger);
            LoadSettings();
        }

        private void LoadSettings()
        {
            _settings = _settingsManager.LoadSettings();
            numericUpDownDayLimit.Value = _settings.DayOfWeekLimits[0];
            numericUpDownLeft.Value = _settings.TodayRemainsMinutes;
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
            for (int i = 0; i < _settings.DayOfWeekLimits.Length; i++)
            {
                _settings.DayOfWeekLimits[i] = Convert.ToInt32(numericUpDownDayLimit.Value);
            }
            _settings.TodayRemainsMinutes = Convert.ToInt32(numericUpDownLeft.Value);
            _settingsManager.SaveSettings(_settings);
        }
    }
}
