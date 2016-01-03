using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Common;

namespace LtcWinConfig
{
    public partial class AddEditInterval : Form
    {
        public AddEditInterval()
        {
            InitializeComponent();
        }

        public Interval Interval { get; set; }

        private void AddEditInterval_Load(object sender, EventArgs e)
        {
            foreach (DayOfWeek day in Enum.GetValues(typeof (DayOfWeek)))
            {
                checkedListBoxDays.Items.Add(day.ToLocalizedString());
            }
            if (Interval == null) SetupForAdding();
            else SetupForEditing();
            SetSaveButtonEnable();
        }

        private void SetupForEditing()
        {
            Text = Strings.EditInterval;
            dateTimePickerFrom.Value = DateTime.Today + Interval.TimeFrom;
            dateTimePickerTo.Value = DateTime.Today + Interval.TimeTo;
            foreach (var dayOfWeek in Interval.Days)
            {
                checkedListBoxDays.SetItemCheckState((int) dayOfWeek, CheckState.Checked);
            }
        }

        private void SetupForAdding()
        {
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < checkedListBoxDays.Items.Count; i++)
            {
                checkedListBoxDays.SetItemCheckState(i, CheckState.Checked);
            }
            SetSaveButtonEnable();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < checkedListBoxDays.Items.Count; i++)
            {
                checkedListBoxDays.SetItemCheckState(i, CheckState.Unchecked);
            }
            SetSaveButtonEnable();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (Interval == null) Interval = new Interval();
            Interval.TimeFrom = dateTimePickerFrom.Value.TimeOfDay;
            Interval.TimeTo = dateTimePickerTo.Value.TimeOfDay;
            Interval.Days = new HashSet<DayOfWeek>();
            foreach (var checkedItem in checkedListBoxDays.CheckedIndices)
            {
                Interval.Days.Add((DayOfWeek) checkedItem);
            }
        }

        private void SetSaveButtonEnable()
        {
            if (checkedListBoxDays.CheckedItems.Count > 0 && dateTimePickerFrom.Value < dateTimePickerTo.Value)
                buttonSave.Enabled = true;
            else
                buttonSave.Enabled = false;
        }


        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            SetSaveButtonEnable();
        }

        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            SetSaveButtonEnable();
        }

        private void checkedListBoxDays_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // http://stackoverflow.com/questions/3666682/which-checkedlistbox-event-triggers-after-a-item-is-checked
            // for delay check
            this.BeginInvoke(new MethodInvoker(SetSaveButtonEnable), null);
        }
    }
}