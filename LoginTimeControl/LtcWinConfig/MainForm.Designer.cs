namespace LtcWinConfig
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelLeft = new System.Windows.Forms.Label();
            this.numericUpDownLeft = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSunday = new System.Windows.Forms.NumericUpDown();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelSunday = new System.Windows.Forms.Label();
            this.labelMonday = new System.Windows.Forms.Label();
            this.numericUpDownMonday = new System.Windows.Forms.NumericUpDown();
            this.labelTuesday = new System.Windows.Forms.Label();
            this.numericUpDownTuesday = new System.Windows.Forms.NumericUpDown();
            this.labelWednesday = new System.Windows.Forms.Label();
            this.numericUpDownWednesday = new System.Windows.Forms.NumericUpDown();
            this.labelThursday = new System.Windows.Forms.Label();
            this.numericUpDownThursday = new System.Windows.Forms.NumericUpDown();
            this.labelFriday = new System.Windows.Forms.Label();
            this.numericUpDownFriday = new System.Windows.Forms.NumericUpDown();
            this.labelSaturday = new System.Windows.Forms.Label();
            this.numericUpDownSaturday = new System.Windows.Forms.NumericUpDown();
            this.listBoxAllowedIntervals = new System.Windows.Forms.ListBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxIntervals = new System.Windows.Forms.GroupBox();
            this.groupBoxDayLimits = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSunday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTuesday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWednesday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThursday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFriday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaturday)).BeginInit();
            this.groupBoxIntervals.SuspendLayout();
            this.groupBoxDayLimits.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLeft
            // 
            this.labelLeft.AutoSize = true;
            this.labelLeft.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelLeft.Location = new System.Drawing.Point(12, 287);
            this.labelLeft.Name = "labelLeft";
            this.labelLeft.Size = new System.Drawing.Size(93, 13);
            this.labelLeft.TabIndex = 12;
            this.labelLeft.Text = "Today minutes left";
            // 
            // numericUpDownLeft
            // 
            this.numericUpDownLeft.Location = new System.Drawing.Point(111, 285);
            this.numericUpDownLeft.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownLeft.Name = "numericUpDownLeft";
            this.numericUpDownLeft.Size = new System.Drawing.Size(72, 20);
            this.numericUpDownLeft.TabIndex = 11;
            this.numericUpDownLeft.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numericUpDownSunday
            // 
            this.numericUpDownSunday.Location = new System.Drawing.Point(9, 34);
            this.numericUpDownSunday.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownSunday.Name = "numericUpDownSunday";
            this.numericUpDownSunday.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownSunday.TabIndex = 9;
            this.numericUpDownSunday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownSunday.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCancel.Location = new System.Drawing.Point(108, 320);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonOK.Location = new System.Drawing.Point(15, 320);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelSunday
            // 
            this.labelSunday.AutoSize = true;
            this.labelSunday.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSunday.Location = new System.Drawing.Point(6, 18);
            this.labelSunday.Name = "labelSunday";
            this.labelSunday.Size = new System.Drawing.Size(43, 13);
            this.labelSunday.TabIndex = 13;
            this.labelSunday.Text = "Sunday";
            // 
            // labelMonday
            // 
            this.labelMonday.AutoSize = true;
            this.labelMonday.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelMonday.Location = new System.Drawing.Point(52, 18);
            this.labelMonday.Name = "labelMonday";
            this.labelMonday.Size = new System.Drawing.Size(45, 13);
            this.labelMonday.TabIndex = 15;
            this.labelMonday.Text = "Monday";
            // 
            // numericUpDownMonday
            // 
            this.numericUpDownMonday.Location = new System.Drawing.Point(55, 34);
            this.numericUpDownMonday.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownMonday.Name = "numericUpDownMonday";
            this.numericUpDownMonday.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownMonday.TabIndex = 14;
            this.numericUpDownMonday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownMonday.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // labelTuesday
            // 
            this.labelTuesday.AutoSize = true;
            this.labelTuesday.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTuesday.Location = new System.Drawing.Point(98, 18);
            this.labelTuesday.Name = "labelTuesday";
            this.labelTuesday.Size = new System.Drawing.Size(48, 13);
            this.labelTuesday.TabIndex = 17;
            this.labelTuesday.Text = "Tuesday";
            // 
            // numericUpDownTuesday
            // 
            this.numericUpDownTuesday.Location = new System.Drawing.Point(101, 34);
            this.numericUpDownTuesday.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownTuesday.Name = "numericUpDownTuesday";
            this.numericUpDownTuesday.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownTuesday.TabIndex = 16;
            this.numericUpDownTuesday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownTuesday.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // labelWednesday
            // 
            this.labelWednesday.AutoSize = true;
            this.labelWednesday.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelWednesday.Location = new System.Drawing.Point(144, 18);
            this.labelWednesday.Name = "labelWednesday";
            this.labelWednesday.Size = new System.Drawing.Size(64, 13);
            this.labelWednesday.TabIndex = 19;
            this.labelWednesday.Text = "Wednesday";
            // 
            // numericUpDownWednesday
            // 
            this.numericUpDownWednesday.Location = new System.Drawing.Point(147, 34);
            this.numericUpDownWednesday.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownWednesday.Name = "numericUpDownWednesday";
            this.numericUpDownWednesday.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownWednesday.TabIndex = 18;
            this.numericUpDownWednesday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownWednesday.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // labelThursday
            // 
            this.labelThursday.AutoSize = true;
            this.labelThursday.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelThursday.Location = new System.Drawing.Point(190, 18);
            this.labelThursday.Name = "labelThursday";
            this.labelThursday.Size = new System.Drawing.Size(51, 13);
            this.labelThursday.TabIndex = 21;
            this.labelThursday.Text = "Thursday";
            // 
            // numericUpDownThursday
            // 
            this.numericUpDownThursday.Location = new System.Drawing.Point(193, 34);
            this.numericUpDownThursday.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownThursday.Name = "numericUpDownThursday";
            this.numericUpDownThursday.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownThursday.TabIndex = 20;
            this.numericUpDownThursday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownThursday.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // labelFriday
            // 
            this.labelFriday.AutoSize = true;
            this.labelFriday.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelFriday.Location = new System.Drawing.Point(236, 18);
            this.labelFriday.Name = "labelFriday";
            this.labelFriday.Size = new System.Drawing.Size(35, 13);
            this.labelFriday.TabIndex = 23;
            this.labelFriday.Text = "Friday";
            // 
            // numericUpDownFriday
            // 
            this.numericUpDownFriday.Location = new System.Drawing.Point(239, 34);
            this.numericUpDownFriday.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownFriday.Name = "numericUpDownFriday";
            this.numericUpDownFriday.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownFriday.TabIndex = 22;
            this.numericUpDownFriday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownFriday.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // labelSaturday
            // 
            this.labelSaturday.AutoSize = true;
            this.labelSaturday.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSaturday.Location = new System.Drawing.Point(282, 18);
            this.labelSaturday.Name = "labelSaturday";
            this.labelSaturday.Size = new System.Drawing.Size(49, 13);
            this.labelSaturday.TabIndex = 25;
            this.labelSaturday.Text = "Saturday";
            // 
            // numericUpDownSaturday
            // 
            this.numericUpDownSaturday.Location = new System.Drawing.Point(285, 34);
            this.numericUpDownSaturday.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownSaturday.Name = "numericUpDownSaturday";
            this.numericUpDownSaturday.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownSaturday.TabIndex = 24;
            this.numericUpDownSaturday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownSaturday.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // listBoxAllowedIntervals
            // 
            this.listBoxAllowedIntervals.FormattingEnabled = true;
            this.listBoxAllowedIntervals.Location = new System.Drawing.Point(6, 17);
            this.listBoxAllowedIntervals.Name = "listBoxAllowedIntervals";
            this.listBoxAllowedIntervals.Size = new System.Drawing.Size(368, 121);
            this.listBoxAllowedIntervals.TabIndex = 26;
            this.listBoxAllowedIntervals.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxAllowedIntervals_MouseDoubleClick);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(6, 142);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 27;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(84, 142);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 28;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBoxIntervals
            // 
            this.groupBoxIntervals.Controls.Add(this.listBoxAllowedIntervals);
            this.groupBoxIntervals.Controls.Add(this.buttonAdd);
            this.groupBoxIntervals.Controls.Add(this.buttonRemove);
            this.groupBoxIntervals.Location = new System.Drawing.Point(4, 12);
            this.groupBoxIntervals.Name = "groupBoxIntervals";
            this.groupBoxIntervals.Size = new System.Drawing.Size(380, 170);
            this.groupBoxIntervals.TabIndex = 29;
            this.groupBoxIntervals.TabStop = false;
            this.groupBoxIntervals.Text = "Allowed intervals";
            // 
            // groupBoxDayLimits
            // 
            this.groupBoxDayLimits.Controls.Add(this.numericUpDownTuesday);
            this.groupBoxDayLimits.Controls.Add(this.labelSaturday);
            this.groupBoxDayLimits.Controls.Add(this.numericUpDownSunday);
            this.groupBoxDayLimits.Controls.Add(this.numericUpDownSaturday);
            this.groupBoxDayLimits.Controls.Add(this.labelSunday);
            this.groupBoxDayLimits.Controls.Add(this.labelFriday);
            this.groupBoxDayLimits.Controls.Add(this.numericUpDownMonday);
            this.groupBoxDayLimits.Controls.Add(this.numericUpDownFriday);
            this.groupBoxDayLimits.Controls.Add(this.labelMonday);
            this.groupBoxDayLimits.Controls.Add(this.labelThursday);
            this.groupBoxDayLimits.Controls.Add(this.labelTuesday);
            this.groupBoxDayLimits.Controls.Add(this.numericUpDownThursday);
            this.groupBoxDayLimits.Controls.Add(this.numericUpDownWednesday);
            this.groupBoxDayLimits.Controls.Add(this.labelWednesday);
            this.groupBoxDayLimits.Location = new System.Drawing.Point(4, 193);
            this.groupBoxDayLimits.Name = "groupBoxDayLimits";
            this.groupBoxDayLimits.Size = new System.Drawing.Size(380, 65);
            this.groupBoxDayLimits.TabIndex = 30;
            this.groupBoxDayLimits.TabStop = false;
            this.groupBoxDayLimits.Text = "Day limits in minutes";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 356);
            this.Controls.Add(this.groupBoxDayLimits);
            this.Controls.Add(this.groupBoxIntervals);
            this.Controls.Add(this.labelLeft);
            this.Controls.Add(this.numericUpDownLeft);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "LTC Config";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSunday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTuesday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWednesday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThursday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFriday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaturday)).EndInit();
            this.groupBoxIntervals.ResumeLayout(false);
            this.groupBoxDayLimits.ResumeLayout(false);
            this.groupBoxDayLimits.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLeft;
        private System.Windows.Forms.NumericUpDown numericUpDownLeft;
        private System.Windows.Forms.NumericUpDown numericUpDownSunday;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelSunday;
        private System.Windows.Forms.Label labelMonday;
        private System.Windows.Forms.NumericUpDown numericUpDownMonday;
        private System.Windows.Forms.Label labelTuesday;
        private System.Windows.Forms.NumericUpDown numericUpDownTuesday;
        private System.Windows.Forms.Label labelWednesday;
        private System.Windows.Forms.NumericUpDown numericUpDownWednesday;
        private System.Windows.Forms.Label labelThursday;
        private System.Windows.Forms.NumericUpDown numericUpDownThursday;
        private System.Windows.Forms.Label labelFriday;
        private System.Windows.Forms.NumericUpDown numericUpDownFriday;
        private System.Windows.Forms.Label labelSaturday;
        private System.Windows.Forms.NumericUpDown numericUpDownSaturday;
        private System.Windows.Forms.ListBox listBoxAllowedIntervals;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBoxIntervals;
        private System.Windows.Forms.GroupBox groupBoxDayLimits;
    }
}

