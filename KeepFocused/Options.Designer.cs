namespace KeepFocused
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.TickSoundFileLabel = new System.Windows.Forms.Label();
            this.AlarmSoundFileLabel = new System.Windows.Forms.Label();
            this.TickingSoundTextBox = new System.Windows.Forms.TextBox();
            this.PickTickingSoundFile = new System.Windows.Forms.Button();
            this.PickAlarmSoundFile = new System.Windows.Forms.Button();
            this.AlarmSoundTextBox = new System.Windows.Forms.TextBox();
            this.PlayTickingSoundCheckBox = new System.Windows.Forms.CheckBox();
            this.PlayAlarmSoundCheckBox = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SessionTimeLabel = new System.Windows.Forms.Label();
            this.BreakTimeLabel = new System.Windows.Forms.Label();
            this.SessionTimeComboBox = new System.Windows.Forms.ComboBox();
            this.BreakTimeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HourFormatComboBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TickSoundFileLabel
            // 
            this.TickSoundFileLabel.AutoSize = true;
            this.TickSoundFileLabel.Location = new System.Drawing.Point(13, 13);
            this.TickSoundFileLabel.Name = "TickSoundFileLabel";
            this.TickSoundFileLabel.Size = new System.Drawing.Size(98, 13);
            this.TickSoundFileLabel.TabIndex = 0;
            this.TickSoundFileLabel.Text = "Ticking Sound File:";
            // 
            // AlarmSoundFileLabel
            // 
            this.AlarmSoundFileLabel.AutoSize = true;
            this.AlarmSoundFileLabel.Location = new System.Drawing.Point(13, 33);
            this.AlarmSoundFileLabel.Name = "AlarmSoundFileLabel";
            this.AlarmSoundFileLabel.Size = new System.Drawing.Size(89, 13);
            this.AlarmSoundFileLabel.TabIndex = 1;
            this.AlarmSoundFileLabel.Text = "Alarm Sound File:";
            // 
            // TickingSoundTextBox
            // 
            this.TickingSoundTextBox.Location = new System.Drawing.Point(118, 5);
            this.TickingSoundTextBox.Name = "TickingSoundTextBox";
            this.TickingSoundTextBox.Size = new System.Drawing.Size(415, 20);
            this.TickingSoundTextBox.TabIndex = 2;
            // 
            // PickTickingSoundFile
            // 
            this.PickTickingSoundFile.Location = new System.Drawing.Point(539, 3);
            this.PickTickingSoundFile.Name = "PickTickingSoundFile";
            this.PickTickingSoundFile.Size = new System.Drawing.Size(24, 23);
            this.PickTickingSoundFile.TabIndex = 3;
            this.PickTickingSoundFile.Text = "...";
            this.PickTickingSoundFile.UseVisualStyleBackColor = true;
            this.PickTickingSoundFile.Click += new System.EventHandler(this.PickTickingSoundFile_Click);
            // 
            // PickAlarmSoundFile
            // 
            this.PickAlarmSoundFile.Location = new System.Drawing.Point(539, 25);
            this.PickAlarmSoundFile.Name = "PickAlarmSoundFile";
            this.PickAlarmSoundFile.Size = new System.Drawing.Size(24, 23);
            this.PickAlarmSoundFile.TabIndex = 4;
            this.PickAlarmSoundFile.Text = "...";
            this.PickAlarmSoundFile.UseVisualStyleBackColor = true;
            this.PickAlarmSoundFile.Click += new System.EventHandler(this.PickAlarmSoundFile_Click);
            // 
            // AlarmSoundTextBox
            // 
            this.AlarmSoundTextBox.Location = new System.Drawing.Point(118, 30);
            this.AlarmSoundTextBox.Name = "AlarmSoundTextBox";
            this.AlarmSoundTextBox.Size = new System.Drawing.Size(415, 20);
            this.AlarmSoundTextBox.TabIndex = 5;
            // 
            // PlayTickingSoundCheckBox
            // 
            this.PlayTickingSoundCheckBox.AutoSize = true;
            this.PlayTickingSoundCheckBox.Location = new System.Drawing.Point(570, 8);
            this.PlayTickingSoundCheckBox.Name = "PlayTickingSoundCheckBox";
            this.PlayTickingSoundCheckBox.Size = new System.Drawing.Size(52, 17);
            this.PlayTickingSoundCheckBox.TabIndex = 6;
            this.PlayTickingSoundCheckBox.Text = "Play?";
            this.PlayTickingSoundCheckBox.UseVisualStyleBackColor = true;
            // 
            // PlayAlarmSoundCheckBox
            // 
            this.PlayAlarmSoundCheckBox.AutoSize = true;
            this.PlayAlarmSoundCheckBox.Location = new System.Drawing.Point(569, 29);
            this.PlayAlarmSoundCheckBox.Name = "PlayAlarmSoundCheckBox";
            this.PlayAlarmSoundCheckBox.Size = new System.Drawing.Size(52, 17);
            this.PlayAlarmSoundCheckBox.TabIndex = 7;
            this.PlayAlarmSoundCheckBox.Text = "Play?";
            this.PlayAlarmSoundCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(546, 136);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(456, 136);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SessionTimeLabel
            // 
            this.SessionTimeLabel.AutoSize = true;
            this.SessionTimeLabel.Location = new System.Drawing.Point(13, 63);
            this.SessionTimeLabel.Name = "SessionTimeLabel";
            this.SessionTimeLabel.Size = new System.Drawing.Size(73, 13);
            this.SessionTimeLabel.TabIndex = 10;
            this.SessionTimeLabel.Text = "Session Time:";
            // 
            // BreakTimeLabel
            // 
            this.BreakTimeLabel.AutoSize = true;
            this.BreakTimeLabel.Location = new System.Drawing.Point(13, 86);
            this.BreakTimeLabel.Name = "BreakTimeLabel";
            this.BreakTimeLabel.Size = new System.Drawing.Size(64, 13);
            this.BreakTimeLabel.TabIndex = 11;
            this.BreakTimeLabel.Text = "Break Time:";
            // 
            // SessionTimeComboBox
            // 
            this.SessionTimeComboBox.FormattingEnabled = true;
            this.SessionTimeComboBox.Items.AddRange(new object[] {
            "5:00",
            "10:00",
            "15:00",
            "20:00",
            "25:00",
            "30:00"});
            this.SessionTimeComboBox.Location = new System.Drawing.Point(118, 60);
            this.SessionTimeComboBox.Name = "SessionTimeComboBox";
            this.SessionTimeComboBox.Size = new System.Drawing.Size(121, 21);
            this.SessionTimeComboBox.TabIndex = 13;
            // 
            // BreakTimeComboBox
            // 
            this.BreakTimeComboBox.FormattingEnabled = true;
            this.BreakTimeComboBox.Items.AddRange(new object[] {
            "5:00",
            "10:00",
            "15:00"});
            this.BreakTimeComboBox.Location = new System.Drawing.Point(118, 83);
            this.BreakTimeComboBox.Name = "BreakTimeComboBox";
            this.BreakTimeComboBox.Size = new System.Drawing.Size(121, 21);
            this.BreakTimeComboBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "24 hr format:";
            // 
            // HourFormatComboBox
            // 
            this.HourFormatComboBox.AutoSize = true;
            this.HourFormatComboBox.Checked = true;
            this.HourFormatComboBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HourFormatComboBox.Location = new System.Drawing.Point(118, 116);
            this.HourFormatComboBox.Name = "HourFormatComboBox";
            this.HourFormatComboBox.Size = new System.Drawing.Size(15, 14);
            this.HourFormatComboBox.TabIndex = 15;
            this.HourFormatComboBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(9, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Version: 1.0 Alpha";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 171);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.HourFormatComboBox);
            this.Controls.Add(this.BreakTimeComboBox);
            this.Controls.Add(this.SessionTimeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BreakTimeLabel);
            this.Controls.Add(this.SessionTimeLabel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.PlayAlarmSoundCheckBox);
            this.Controls.Add(this.PlayTickingSoundCheckBox);
            this.Controls.Add(this.AlarmSoundTextBox);
            this.Controls.Add(this.PickAlarmSoundFile);
            this.Controls.Add(this.PickTickingSoundFile);
            this.Controls.Add(this.TickingSoundTextBox);
            this.Controls.Add(this.AlarmSoundFileLabel);
            this.Controls.Add(this.TickSoundFileLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Options";
            this.Text = "Keep Focused Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TickSoundFileLabel;
        private System.Windows.Forms.Label AlarmSoundFileLabel;
        private System.Windows.Forms.TextBox TickingSoundTextBox;
        private System.Windows.Forms.Button PickTickingSoundFile;
        private System.Windows.Forms.Button PickAlarmSoundFile;
        private System.Windows.Forms.TextBox AlarmSoundTextBox;
        private System.Windows.Forms.CheckBox PlayTickingSoundCheckBox;
        private System.Windows.Forms.CheckBox PlayAlarmSoundCheckBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label SessionTimeLabel;
        private System.Windows.Forms.Label BreakTimeLabel;
        private System.Windows.Forms.ComboBox SessionTimeComboBox;
        private System.Windows.Forms.ComboBox BreakTimeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox HourFormatComboBox;
        private System.Windows.Forms.Label label5;
    }
}