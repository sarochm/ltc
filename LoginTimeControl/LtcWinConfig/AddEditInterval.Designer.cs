namespace LtcWinConfig
{
    partial class AddEditInterval
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditInterval));
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.checkedListBoxDays = new System.Windows.Forms.CheckedListBox();
            this.buttonAll = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelFrom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePickerFrom
            // 
            resources.ApplyResources(this.dateTimePickerFrom, "dateTimePickerFrom");
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.ShowUpDown = true;
            this.dateTimePickerFrom.Value = new System.DateTime(2015, 12, 22, 10, 0, 0, 0);
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.dateTimePickerFrom_ValueChanged);
            // 
            // dateTimePickerTo
            // 
            resources.ApplyResources(this.dateTimePickerTo, "dateTimePickerTo");
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.ShowUpDown = true;
            this.dateTimePickerTo.Value = new System.DateTime(2015, 12, 22, 10, 0, 0, 0);
            this.dateTimePickerTo.ValueChanged += new System.EventHandler(this.dateTimePickerTo_ValueChanged);
            // 
            // checkedListBoxDays
            // 
            resources.ApplyResources(this.checkedListBoxDays, "checkedListBoxDays");
            this.checkedListBoxDays.CheckOnClick = true;
            this.checkedListBoxDays.FormattingEnabled = true;
            this.checkedListBoxDays.Name = "checkedListBoxDays";
            this.checkedListBoxDays.SelectedValueChanged += new System.EventHandler(this.checkedListBoxDays_SelectedValueChanged);
            // 
            // buttonAll
            // 
            resources.ApplyResources(this.buttonAll, "buttonAll");
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.UseVisualStyleBackColor = true;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // buttonClear
            // 
            resources.ApplyResources(this.buttonClear, "buttonClear");
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSave
            // 
            resources.ApplyResources(this.buttonSave, "buttonSave");
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelFrom
            // 
            resources.ApplyResources(this.labelFrom, "labelFrom");
            this.labelFrom.Name = "labelFrom";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // AddEditInterval
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAll);
            this.Controls.Add(this.checkedListBoxDays);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditInterval";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddEditInterval_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.CheckedListBox checkedListBoxDays;
        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label label2;
    }
}