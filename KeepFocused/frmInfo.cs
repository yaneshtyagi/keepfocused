using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeepFocused
{
    public partial class frmInfo : Form
    {
        public frmInfo()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://keepfocused.codeplex.com");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to connect to internet.", "Keep Focused", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://keepfocused.codeplex.com");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to connect to internet.", "Keep Focused", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://keepfocused.codeplex.com/documentation");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to connect to internet.", "Keep Focused", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OptionsButton_Click(object sender, EventArgs e)
        {
            new Options().ShowDialog();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            this.Close();
            new Options().Show();
        }

  
    }
}
