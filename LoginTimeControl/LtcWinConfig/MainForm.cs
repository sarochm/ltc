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
            listBoxAllowedIntervals.DataSource = _settings.AllowedIntervals;
            // listBoxAllowedIntervals.DisplayMember = "TimeToStr";
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

        private void listBoxAllowedIntervals_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxAllowedIntervals.SelectedIndex == -1) return;
            //MessageBox.Show(_settings.AllowedIntervals[(sender as ListBox).SelectedIndex].ToString());
            var addWindow = new AddEditInterval
            {
                Interval = _settings.AllowedIntervals[listBoxAllowedIntervals.SelectedIndex]
            };
            addWindow.ShowDialog();
            RefreshListBoxAllowedIntervals();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            var selelectedIntervalIndex = listBoxAllowedIntervals.SelectedIndex;
            if (selelectedIntervalIndex == -1) return;
            _settings.AllowedIntervals.RemoveAt(selelectedIntervalIndex);
            RefreshListBoxAllowedIntervals();
        }

        private void RefreshListBoxAllowedIntervals()
        {
            listBoxAllowedIntervals.DataSource = null;
            listBoxAllowedIntervals.DataSource = _settings.AllowedIntervals;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var addWindow = new AddEditInterval();
            addWindow.ShowDialog();
            if (addWindow.DialogResult == DialogResult.Cancel || addWindow.Interval == null) return;
            // _settings.AllowedIntervals.Add(new Interval(){TimeFromStr = "08:08", TimeToStr = "18:18" , Days = new HashSet<DayOfWeek>()});
            _settings.AllowedIntervals.Add(addWindow.Interval);
            RefreshListBoxAllowedIntervals();
        }

        private void numericUpDownAll_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownMonday.Value =
                numericUpDownTuesday.Value =
                    numericUpDownWednesday.Value =
                        numericUpDownThursday.Value =
                            numericUpDownFriday.Value =
                                numericUpDownSaturday.Value = 
                                    numericUpDownSunday.Value = numericUpDownAll.Value;
        }
    }
}