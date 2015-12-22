using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LtcWinConfig
{
    public partial class AddEditInterval : Form
    {
        public AddEditInterval()
        {
            InitializeComponent();
        }

        private void AddEditInterval_Load(object sender, EventArgs e)
        {
            foreach (var day in Enum.GetValues(typeof(DayOfWeek)))
            {
                checkedListBoxDays.Items.Add(day);
            }
            //dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            //dateTimePickerFrom.CustomFormat = "HH:mm";
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxDays.Items.Count; i++)
            {
                checkedListBoxDays.SetItemCheckState(i,CheckState.Checked);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxDays.Items.Count; i++)
            {
                checkedListBoxDays.SetItemCheckState(i, CheckState.Unchecked);
            }
        }
    }
}
