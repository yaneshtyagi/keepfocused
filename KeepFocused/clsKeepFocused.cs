using System;
using System.Collections.Generic;
using System.Text;

namespace KeepFocused
{
    static class GlobalSettings
    {

        private static bool m_PlayAlarmSound = Properties.Settings.Default.PlayAlarmSound;
        private static bool m_PlayTickingSound = Properties.Settings.Default.PlayTickingSound;
        private static string m_AlarmSoundFile = Properties.Settings.Default.AlarmSoundFile;
        private static string m_TickingSoundFile = Properties.Settings.Default.TickingSoundFile;
        private static string m_SessionTime = Properties.Settings.Default.SessionTime;
        private static string m_BreakTime = Properties.Settings.Default.BreakTime;
        private static int  m_Left = Properties.Settings.Default.Left;
        private static int  m_Top = Properties.Settings.Default.Top;
        private static bool m_HourFormat24Hr = Properties.Settings.Default.HourFormat24Hr;

        public static bool HourFormat24Hr {
            get { return GlobalSettings.m_HourFormat24Hr; }
            set { GlobalSettings.m_HourFormat24Hr = value; }
        }
        

        public static bool PlayAlarmSound
        {
            get { return m_PlayAlarmSound;  }
            set { m_PlayAlarmSound = value; } 
        }

        public static bool PlayTickingSound
        {
            get { return m_PlayTickingSound; }
            set { m_PlayTickingSound = value; }
        }

        public static string TickingSoundFile
        {
            get { return m_TickingSoundFile; }
            set { m_TickingSoundFile = value; }
        }

        public static string AlarmSoundFile
        {
            get { return m_AlarmSoundFile; }
            set { m_AlarmSoundFile = value; }
        }

        public static string SessionTime
        {
            get { return m_SessionTime; }
            set { m_SessionTime = value; }
        }

        public static string BreakTime
        {
            get { return m_BreakTime; }
            set { m_BreakTime = value; }
        }

        public static int Left
        {
            get { return m_Left; }
            set { m_Left = value; }
        }

        public static int Top
        {
            get { return m_Top; }
            set { m_Top = value; }
        }

        public static string GetTimeFormatString() {
            if (m_HourFormat24Hr) {
                return "dd:MMM:yyyy HH:mm";
            }
            else {
                return "dd:MMM:yyyy hh:mm";
            }
        }
    }
}
