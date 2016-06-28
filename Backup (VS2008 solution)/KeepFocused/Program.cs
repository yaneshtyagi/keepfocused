using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KeepFocused
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoadKeepFocusedSettings();
            Application.Run(new KeepFocusedForm());
        }

        static void LoadKeepFocusedSettings()
        {
            // Load settings for the app
            GlobalSettings.AlarmSoundFile = Properties.Settings.Default.AlarmSoundFile;
            GlobalSettings.TickingSoundFile = Properties.Settings.Default.TickingSoundFile;
            GlobalSettings.PlayAlarmSound = Properties.Settings.Default.PlayAlarmSound;
            GlobalSettings.PlayTickingSound = Properties.Settings.Default.PlayTickingSound;

        }

    }
}
