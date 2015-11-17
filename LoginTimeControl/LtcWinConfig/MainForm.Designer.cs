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
            this.labelDayLimits = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSunday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTuesday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWednesday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThursday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFriday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaturday)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLeft
            // 
            this.labelLeft.AutoSize = true;
            this.labelLeft.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelLeft.Location = new System.Drawing.Point(12, 102);
            this.labelLeft.Name = "labelLeft";
            this.labelLeft.Size = new System.Drawing.Size(93, 13);
            this.labelLeft.TabIndex = 12;
            this.labelLeft.Text = "Today minutes left";
            // 
            // numericUpDownLeft
            // 
            this.numericUpDownLeft.Location = new System.Drawing.Point(111, 100);
            this.numericUpDownLeft.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownLeft.Name = "numericUpDownLeft";
            this.numericUpDownLeft.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownLeft.TabIndex = 11;
            this.numericUpDownLeft.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // labelDayLimits
            // 
            this.labelDayLimits.AutoSize = true;
            this.labelDayLimits.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDayLimits.Location = new System.Drawing.Point(12, 9);
            this.labelDayLimits.Name = "labelDayLimits";
            this.labelDayLimits.Size = new System.Drawing.Size(101, 13);
            this.labelDayLimits.TabIndex = 10;
            this.labelDayLimits.Text = "Day limits in minutes";
            // 
            // numericUpDownSunday
            // 
            this.numericUpDownSunday.Location = new System.Drawing.Point(15, 54);
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
            this.buttonCancel.Location = new System.Drawing.Point(108, 135);
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
            this.buttonOK.Location = new System.Drawing.Point(27, 135);
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
            this.labelSunday.Location = new System.Drawing.Point(12, 38);
            this.labelSunday.Name = "labelSunday";
            this.labelSunday.Size = new System.Drawing.Size(43, 13);
            this.labelSunday.TabIndex = 13;
            this.labelSunday.Text = "Sunday";
            // 
            // labelMonday
            // 
            this.labelMonday.AutoSize = true;
            this.labelMonday.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelMonday.Location = new System.Drawing.Point(58, 38);
            this.labelMonday.Name = "labelMonday";
            this.labelMonday.Size = new System.Drawing.Size(45, 13);
            this.labelMonday.TabIndex = 15;
            this.labelMonday.Text = "Monday";
            // 
            // numericUpDownMonday
            // 
            this.numericUpDownMonday.Location = new System.Drawing.Point(61, 54);
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
            this.labelTuesday.Location = new System.Drawing.Point(104, 38);
            this.labelTuesday.Name = "labelTuesday";
            this.labelTuesday.Size = new System.Drawing.Size(48, 13);
            this.labelTuesday.TabIndex = 17;
            this.labelTuesday.Text = "Tuesday";
            // 
            // numericUpDownTuesday
            // 
            this.numericUpDownTuesday.Location = new System.Drawing.Point(107, 54);
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
            this.labelWednesday.Location = new System.Drawing.Point(150, 38);
            this.labelWednesday.Name = "labelWednesday";
            this.labelWednesday.Size = new System.Drawing.Size(64, 13);
            this.labelWednesday.TabIndex = 19;
            this.labelWednesday.Text = "Wednesday";
            // 
            // numericUpDownWednesday
            // 
            this.numericUpDownWednesday.Location = new System.Drawing.Point(153, 54);
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
            this.labelThursday.Location = new System.Drawing.Point(196, 38);
            this.labelThursday.Name = "labelThursday";
            this.labelThursday.Size = new System.Drawing.Size(51, 13);
            this.labelThursday.TabIndex = 21;
            this.labelThursday.Text = "Thursday";
            // 
            // numericUpDownThursday
            // 
            this.numericUpDownThursday.Location = new System.Drawing.Point(199, 54);
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
            this.labelFriday.Location = new System.Drawing.Point(242, 38);
            this.labelFriday.Name = "labelFriday";
            this.labelFriday.Size = new System.Drawing.Size(35, 13);
            this.labelFriday.TabIndex = 23;
            this.labelFriday.Text = "Friday";
            // 
            // numericUpDownFriday
            // 
            this.numericUpDownFriday.Location = new System.Drawing.Point(245, 54);
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
            this.labelSaturday.Location = new System.Drawing.Point(288, 38);
            this.labelSaturday.Name = "labelSaturday";
            this.labelSaturday.Size = new System.Drawing.Size(49, 13);
            this.labelSaturday.TabIndex = 25;
            this.labelSaturday.Text = "Saturday";
            // 
            // numericUpDownSaturday
            // 
            this.numericUpDownSaturday.Location = new System.Drawing.Point(291, 54);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 170);
            this.Controls.Add(this.labelSaturday);
            this.Controls.Add(this.numericUpDownSaturday);
            this.Controls.Add(this.labelFriday);
            this.Controls.Add(this.numericUpDownFriday);
            this.Controls.Add(this.labelThursday);
            this.Controls.Add(this.numericUpDownThursday);
            this.Controls.Add(this.labelWednesday);
            this.Controls.Add(this.numericUpDownWednesday);
            this.Controls.Add(this.labelTuesday);
            this.Controls.Add(this.numericUpDownTuesday);
            this.Controls.Add(this.labelMonday);
            this.Controls.Add(this.numericUpDownMonday);
            this.Controls.Add(this.labelSunday);
            this.Controls.Add(this.labelLeft);
            this.Controls.Add(this.numericUpDownLeft);
            this.Controls.Add(this.labelDayLimits);
            this.Controls.Add(this.numericUpDownSunday);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "LTC Config";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSunday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTuesday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWednesday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThursday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFriday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaturday)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLeft;
        private System.Windows.Forms.NumericUpDown numericUpDownLeft;
        private System.Windows.Forms.Label labelDayLimits;
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
    }
}

