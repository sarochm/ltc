using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryApp
{
    public partial class ChangeSettingsForm : Form
    {
        public ChangeSettingsForm(int dayLimit, int todayleft)
        {
            InitializeComponent();
            numericUpDownDayLimit.Value = dayLimit;
            numericUpDownLeft.Value = todayleft;
        }

        public int DayLimit()
        {
            return Convert.ToInt32(numericUpDownDayLimit.Value);
        }

        public int TodayLeft()
        {
            return Convert.ToInt32(numericUpDownLeft.Value);
        }
    }
}
