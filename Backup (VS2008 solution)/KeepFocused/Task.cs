using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using KeepFocused;

namespace KeepFocused
{
    public partial class Task : Form
    {
        string TaskFileName = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\KeepFocusedTask.txt";
        public Task()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            global::KeepFocused.Tasks.message = txtTask.Text;
            File.AppendAllText(TaskFileName, "\r start > [       ]" + DateTime.Now.ToString("dd:MMM:yyyy hh:mm") + ":: Task = " + KeepFocused.Tasks.message + "\r\n");
            this.Close();
        }

        private void Task_Load(object sender, EventArgs e)
        {
                txtSessionDataFileName.Text = TaskFileName;
        }

        private void btnViewDataFile_Click(object sender, EventArgs e)
        {
            if (File.Exists(TaskFileName))
                System.Diagnostics.Process.Start(TaskFileName);
            else
            {
                string message = "Log file cannot be read.\r\nThis may be because you are running Keep Focused very first time or you may have deleted the log file.\r\nLogfile will be automatically created when you run the application again.";
                MessageBox.Show(message, "Keep Focused", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnOptions_Click(object sender, EventArgs e)
        {
            new Options().ShowDialog();
        }
    }
}
