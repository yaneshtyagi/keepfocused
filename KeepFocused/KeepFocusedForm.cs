using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Resources;
using System.Reflection;

namespace KeepFocused
{
    public partial class KeepFocusedForm : Form
    {
        #region Form Dragging API Support
        //The SendMessage function sends a message to a window or windows.
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);
        //ReleaseCapture releases a mouse capture
        [DllImportAttribute("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        public static extern bool ReleaseCapture();
        #endregion

        string sessionDuration = "25:00";   //session duration in mm:ss format
        string pauseDuration = "05:00"; //pause duration in mm:ss format
        bool breakPeriod = false;

        bool optionPlaySound = true;
        bool optionShowMessage = true;
        SoundPlayer player = new SoundPlayer();

        string TaskFileName = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\KeepFocusedTask.txt";

        public KeepFocusedForm()
        {
            InitializeComponent();

            //Read last application position from settings
            if (GlobalSettings.Top != 0)
                this.Top = Properties.Settings.Default.Top;

            if (GlobalSettings.Left != 0)
                this.Top = Properties.Settings.Default.Left;

            if (File.Exists(GlobalSettings.TickingSoundFile))
                player.SoundLocation = GlobalSettings.TickingSoundFile;
            else
                player.Stream = Properties.Resources.clock_tick1;
            player.Load();

        }

        private void lblMoveHandler_MouseDown(object sender, MouseEventArgs e)
        {
            // drag the form without the caption bar
            // present on left mouse button
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0xa1, 0x2, 0);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] arr;
            arr = lblTimer.Text.Split(':');
            int mins = int.Parse(arr[0]);
            int secs = int.Parse(arr[1]);
            KeepFocused.Tasks.paused = false;

            if (mins == 0 && secs == 0)
            {
                if (breakPeriod)
                {
                    // Break is over.
                    timer1.Enabled = false;
                    breakPeriod = false;

                    if (File.Exists(GlobalSettings.TickingSoundFile))

                        player.SoundLocation = GlobalSettings.TickingSoundFile;
                    else
                        player.Stream = Properties.Resources.clock_tick1;
                    player.Load();


                    lblTimer.ForeColor = Color.White;
                    if (optionPlaySound)
                        SystemSounds.Beep.Play();
                }
                else
                {
                    // Acitivity is over, start break
                    // when the pomodoro finish
                    startPause();
                    arr = lblTimer.Text.Split(':');
                    mins = int.Parse(arr[0]);
                    secs = int.Parse(arr[1]);
                    if (GlobalSettings.PlayAlarmSound)
                    {
                        if (File.Exists(GlobalSettings.AlarmSoundFile))

                            player.SoundLocation = GlobalSettings.AlarmSoundFile;
                        else
                            player.Stream = Properties.Resources.ringing;
                        player.Load();
                        player.PlaySync();

                    }
                    if (optionShowMessage)
                        MessageBox.Show("Pomodoro activity finished", "Keep Focused", MessageBoxButtons.OK, MessageBoxIcon.Asterisk,
                            MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);

                    //reset sound file 
                    if (File.Exists(GlobalSettings.TickingSoundFile))
                        player.SoundLocation = GlobalSettings.TickingSoundFile;
                    else
                        player.Stream = Properties.Resources.clock_tick1;
                    player.Load();


                }
            }

            TimeSpan ts = new TimeSpan(0, mins, secs);
            ts = ts.Subtract(new TimeSpan(10));
            lblTimer.Text = String.Format(ts.Minutes.ToString("D2")) + ":" + String.Format(ts.Seconds.ToString("D2"));
            if (GlobalSettings.PlayTickingSound && !breakPeriod)
                // SystemSounds.Beep.Play();
                player.PlaySync();
        }

        private void KeepFocusedForm_Load(object sender, EventArgs e)
        {
            lblPlayPause.Image = global::KeepFocused.Properties.Resources.stop_Icon_White;
            lblMoveHandle.Font = new Font("Wingdings", 12.00F, FontStyle.Bold);
            OpenTaskForm();
            startTimer();
            timer1.Enabled = true;
        }

        private void startTimer()
        {
            lblTimer.ForeColor = Color.White;
            lblTimer.Text = GlobalSettings.SessionTime;
            breakPeriod = false;
            if (optionPlaySound)
                SystemSounds.Beep.Play();

        }

        private void startPause()
        {
            lblTimer.ForeColor = Color.HotPink;
            lblTimer.Text = GlobalSettings.BreakTime;
            breakPeriod = true;
        }

        /// <summary>
        /// This function is not used now. It is a candidate for blogging or source library.
        /// </summary>
        /// <param name="button"></param>
        private void RemoveButtonBorder(Button button)
        {
            button.TabStop = false;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = Color.Transparent;
            //button.FlatAppearance.BorderColor = Color.White;
            //button.FlatAppearance.CheckedBackColor = Color.White;
            //button.FlatAppearance.MouseDownBackColor = Color.White;
            //button.FlatAppearance.MouseOverBackColor = Color.White;

            button.FlatAppearance.BorderColor = this.BackColor;
            button.FlatAppearance.CheckedBackColor = this.BackColor;
            button.FlatAppearance.MouseDownBackColor = this.BackColor;
            button.FlatAppearance.MouseOverBackColor = this.BackColor;

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            //before close, calculate the TOTAL time spent
            if (KeepFocused.Tasks.paused != true)
            {
                File.AppendAllText(TaskFileName, "##log: task done without pause \r\n");
            }
            File.AppendAllText(TaskFileName, "##FINAL = [ " + KeepFocused.Tasks.totalMin.ToString() + "m " + KeepFocused.Tasks.totalSec.ToString() + "s ]:: Total:" + DateTime.Now.ToString("dd:MMM:yyyy hh:mm") + " \r\n\n\n############### closed here ###############\r\n\n");

            Application.Exit();
        }

        private void lblPlayPause_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                lblPlayPause.Image = global::KeepFocused.Properties.Resources.stop_Icon_White;
                startTimer();
                OpenTaskForm();
                timer1.Enabled = true;
            }
            else
            {
                /* 
                 * calculate the spent time based on 25 minutes
                 * @author Arthur Bernardes
                 *
                 **/

                string[] arr;
                arr = lblTimer.Text.Split(':');
                int mins = 25 - int.Parse(arr[0]);
                int secs = 60 - int.Parse(arr[1]);

                /*
                 * record a total time while the program it´s opened
                 * 
                 **/
                if (mins != 25 || mins != 24)
                    KeepFocused.Tasks.totalMin += mins;

                KeepFocused.Tasks.totalSec += secs;

                string totalDuration = null;

                totalDuration = mins.ToString() + "m " + secs.ToString() + "s";

                lblPlayPause.Image = global::KeepFocused.Properties.Resources.Play_Black_Small;
                timer1.Enabled = false;
                File.AppendAllText(TaskFileName, DateTime.Now.ToString(GlobalSettings.GetTimeFormatString()) + "[stop] [Duration = " + totalDuration + "] :: Task = " + KeepFocused.Tasks.message + "\r\n");
                KeepFocused.Tasks.paused = true;
            }
        }

        private void lblMoveHandler_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.SizeAll;
        }

        private void lblMoveHandler_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void ChangeTextColor(Color color)
        {
            foreach (Control c in this.Controls)
                if (c is Label)
                    c.ForeColor = color;
        }

        private void ChangeBackColor(Color color)
        {
            foreach (Control c in this.Controls)
                c.BackColor = color;
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {
            new frmInfo().ShowDialog();
        }

        private void OpenTaskForm()
        {
            Task taskForm = new Task();

            int maxLeftPosition = Screen.PrimaryScreen.WorkingArea.Width - (taskForm.Width + 20);
            int maxTopPosition = Screen.PrimaryScreen.WorkingArea.Height - (taskForm.Height + 20);

            if (this.Top + this.Height > maxTopPosition)
                taskForm.Top = this.Top - taskForm.Height - 30;
            else
                taskForm.Top = this.Top + 30;

            if (this.Left > maxLeftPosition)
                taskForm.Left = this.Right - taskForm.Width;
            else
                taskForm.Left = this.Left;

            taskForm.ShowDialog();
        }

        private void KeepFocusedForm_Move(object sender, EventArgs e)
        {
            Properties.Settings.Default.Left = this.Left;
            Properties.Settings.Default.Top = this.Top;
            Properties.Settings.Default.Save();
            GlobalSettings.Left = this.Left;
            GlobalSettings.Top = this.Top;
        }
    }
}
