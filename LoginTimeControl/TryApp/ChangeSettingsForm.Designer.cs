namespace TryApp
{
    partial class ChangeSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeSettingsForm));
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.numericUpDownDayLimit = new System.Windows.Forms.NumericUpDown();
            this.labelDayLimit = new System.Windows.Forms.Label();
            this.labelLeft = new System.Windows.Forms.Label();
            this.numericUpDownLeft = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDayLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.buttonOK, "buttonOK");
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // numericUpDownDayLimit
            // 
            resources.ApplyResources(this.numericUpDownDayLimit, "numericUpDownDayLimit");
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
            this.numericUpDownDayLimit.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // labelDayLimit
            // 
            resources.ApplyResources(this.labelDayLimit, "labelDayLimit");
            this.labelDayLimit.Name = "labelDayLimit";
            // 
            // labelLeft
            // 
            resources.ApplyResources(this.labelLeft, "labelLeft");
            this.labelLeft.Name = "labelLeft";
            // 
            // numericUpDownLeft
            // 
            resources.ApplyResources(this.numericUpDownLeft, "numericUpDownLeft");
            this.numericUpDownLeft.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownLeft.Name = "numericUpDownLeft";
            this.numericUpDownLeft.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // ChangeSettingsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelLeft);
            this.Controls.Add(this.numericUpDownLeft);
            this.Controls.Add(this.labelDayLimit);
            this.Controls.Add(this.numericUpDownDayLimit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeSettingsForm";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDayLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.NumericUpDown numericUpDownDayLimit;
        private System.Windows.Forms.Label labelDayLimit;
        private System.Windows.Forms.Label labelLeft;
        private System.Windows.Forms.NumericUpDown numericUpDownLeft;
    }
}