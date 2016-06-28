using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KeepFocused
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
            //this.TickingSoundTextBox.Text = Properties.Settings.Default.TickingSoundFile;
            //this.AlarmSoundTextBox.Text = Properties.Settings.Default.AlarmSoundFile;
            //this.PlayTickingSoundCheckBox.Checked = Properties.Settings.Default.PlayTickingSound;
            //this.PlayAlarmSoundCheckBox.Checked = Properties.Settings.Default.PlayAlarmSound;

            this.TickingSoundTextBox.Text = GlobalSettings.TickingSoundFile;
            this.AlarmSoundTextBox.Text = GlobalSettings.AlarmSoundFile;
            this.PlayTickingSoundCheckBox.Checked = GlobalSettings.PlayTickingSound;
            this.PlayAlarmSoundCheckBox.Checked = GlobalSettings.PlayAlarmSound;
            this.SessionTimeComboBox.Text = GlobalSettings.SessionTime;
            this.BreakTimeComboBox.Text = GlobalSettings.BreakTime;
            this.HourFormatComboBox.Checked = GlobalSettings.HourFormat24Hr;
                        
        }

        private void Options_Load(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //close formwihout changes
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //save all values to properties
            Properties.Settings.Default.PlayAlarmSound = this.PlayAlarmSoundCheckBox.Checked;
            Properties.Settings.Default.PlayTickingSound = this.PlayTickingSoundCheckBox.Checked;
            Properties.Settings.Default.AlarmSoundFile = this.AlarmSoundTextBox.Text;
            Properties.Settings.Default.TickingSoundFile = this.TickingSoundTextBox.Text;
            Properties.Settings.Default.SessionTime = this.SessionTimeComboBox.Text;
            Properties.Settings.Default.BreakTime = this.BreakTimeComboBox.Text;
            Properties.Settings.Default.HourFormat24Hr = this.HourFormatComboBox.Checked;
            Properties.Settings.Default.Save();
            
            //Now save to app Settings so they become active now
            GlobalSettings.PlayAlarmSound = this.PlayAlarmSoundCheckBox.Checked;
            GlobalSettings.PlayTickingSound = this.PlayTickingSoundCheckBox.Checked;
            GlobalSettings.AlarmSoundFile = this.AlarmSoundTextBox.Text;
            GlobalSettings.TickingSoundFile = this.TickingSoundTextBox.Text;
            GlobalSettings.SessionTime = this.SessionTimeComboBox.Text;
            GlobalSettings.BreakTime = this.BreakTimeComboBox.Text;
            GlobalSettings.HourFormat24Hr = this.HourFormatComboBox.Checked;

            this.Close();
        }

        private void PickTickingSoundFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.Filter = "wav files (*.wav)|*.wav|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.TickingSoundTextBox.Text = openFileDialog1.FileName.ToString();                   
            }

        }

        private void PickAlarmSoundFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.Filter = "wav files (*.wav)|*.wav|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.AlarmSoundTextBox.Text = openFileDialog1.FileName.ToString();
            }

        }
     }
}
