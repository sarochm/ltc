﻿using System;
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
            numericUpDownSunday.Value = _settings.DayOfWeekLimits[0];
            numericUpDownMonday.Value = _settings.DayOfWeekLimits[1];
            numericUpDownTuesday.Value = _settings.DayOfWeekLimits[2];
            numericUpDownWednesday.Value = _settings.DayOfWeekLimits[3];
            numericUpDownThursday.Value = _settings.DayOfWeekLimits[4];
            numericUpDownFriday.Value = _settings.DayOfWeekLimits[5];
            numericUpDownSaturday.Value = _settings.DayOfWeekLimits[6];
            numericUpDownLeft.Value = _settings.TodayRemainsMinutes < numericUpDownLeft.Minimum
                ? numericUpDownLeft.Minimum
                : _settings.TodayRemainsMinutes;
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
            _settings.DayOfWeekLimits[0] = Convert.ToInt32(numericUpDownSunday.Value);
            _settings.DayOfWeekLimits[1] = Convert.ToInt32(numericUpDownMonday.Value);
            _settings.DayOfWeekLimits[2] = Convert.ToInt32(numericUpDownTuesday.Value);
            _settings.DayOfWeekLimits[3] = Convert.ToInt32(numericUpDownWednesday.Value);
            _settings.DayOfWeekLimits[4] = Convert.ToInt32(numericUpDownThursday.Value);
            _settings.DayOfWeekLimits[5] = Convert.ToInt32(numericUpDownFriday.Value);
            _settings.DayOfWeekLimits[6] = Convert.ToInt32(numericUpDownSaturday.Value);

            _settings.TodayRemainsMinutes = Convert.ToInt32(numericUpDownLeft.Value);
            _settings.LogoutStarted = false;
            _settingsManager.SaveSettings(_settings);
        }
    }
}