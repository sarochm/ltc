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
            this.labelDayLimit = new System.Windows.Forms.Label();
            this.numericUpDownDayLimit = new System.Windows.Forms.NumericUpDown();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDayLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLeft
            // 
            this.labelLeft.AutoSize = true;
            this.labelLeft.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelLeft.Location = new System.Drawing.Point(55, 122);
            this.labelLeft.Name = "labelLeft";
            this.labelLeft.Size = new System.Drawing.Size(93, 13);
            this.labelLeft.TabIndex = 12;
            this.labelLeft.Text = "Today minutes left";
            // 
            // numericUpDownLeft
            // 
            this.numericUpDownLeft.Location = new System.Drawing.Point(157, 120);
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
            // labelDayLimit
            // 
            this.labelDayLimit.AutoSize = true;
            this.labelDayLimit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDayLimit.Location = new System.Drawing.Point(53, 61);
            this.labelDayLimit.Name = "labelDayLimit";
            this.labelDayLimit.Size = new System.Drawing.Size(96, 13);
            this.labelDayLimit.TabIndex = 10;
            this.labelDayLimit.Text = "Day limit in minutes";
            // 
            // numericUpDownDayLimit
            // 
            this.numericUpDownDayLimit.Location = new System.Drawing.Point(155, 59);
            this.numericUpDownDayLimit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownDayLimit.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownDayLimit.Name = "numericUpDownDayLimit";
            this.numericUpDownDayLimit.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownDayLimit.TabIndex = 9;
            this.numericUpDownDayLimit.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCancel.Location = new System.Drawing.Point(146, 178);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonOK.Location = new System.Drawing.Point(53, 178);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelLeft);
            this.Controls.Add(this.numericUpDownLeft);
            this.Controls.Add(this.labelDayLimit);
            this.Controls.Add(this.numericUpDownDayLimit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Name = "MainForm";
            this.Text = "LTC Config";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDayLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLeft;
        private System.Windows.Forms.NumericUpDown numericUpDownLeft;
        private System.Windows.Forms.Label labelDayLimit;
        private System.Windows.Forms.NumericUpDown numericUpDownDayLimit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
    }
}

