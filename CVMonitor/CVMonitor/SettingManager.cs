using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CVMonitorExample
{
    class SettingManager
    {
        private static SettingManager _settingManager;

        public static SettingManager Instance
        {
            get
            {
                if (_settingManager == null)
                    _settingManager = new SettingManager();
                return _settingManager;
            }
        }

        public string IPAddress { get; set; }
        public int SamplingTime { get; set; }
        public List<Limit> Limits { get; set; }
        public string DataPath { get; set; }
        public int DeletePeriod { get; set; }
        public int Sensor { get; set; } 
        public int HightCurrent { get; set; }
        public float HightCurrentValue { get; set; }
        public float ZeroCurrentValue { get; set; }
        public float Interval { get; set; }

        private void InitializSettings()
        {
            IPAddress = "192.168.0.128";
            SamplingTime = 50;
            DataPath = Environment.CurrentDirectory +"\\Data";
            DeletePeriod = 1;

            Sensor = 0;
            HightCurrent = 0;
            HightCurrentValue = 0;
            ZeroCurrentValue = 0;
            Interval = 0;

            Limits = new List<Limit>();
            Channel channel = Channel.Current_0;
            for (int i = 0; i < 4; i++)
            {
                Limit limit = new Limit(channel + i, 0, 10);
                Limits.Add(limit);
            }
            SaveSettings();
            _settingManager = this;
        }
        public void LoadSettings()
        {
            if (!IniManager.CheckIniExists())
            {
                InitializSettings();
            }

            IPAddress = IniManager.ReadIni("Basic", "IPAddress");
            SamplingTime = int.Parse(IniManager.ReadIni("Basic", "SamplingTime"));
            DataPath = IniManager.ReadIni("Basic", "DataPath");
            DeletePeriod = int.Parse(IniManager.ReadIni("Basic", "DeletePeriod"));

            try
            {
                Sensor = int.Parse(IniManager.ReadIni("Basic", "Sensor"));
            }
            catch
            {
                Sensor = 0;
            }

            try
            {
                HightCurrent = int.Parse(IniManager.ReadIni("Basic", "HightCurrent"));
            }
            catch
            {
                HightCurrent = 0;
            }
            try
            {
                HightCurrentValue = float.Parse(IniManager.ReadIni("Basic", "HightCurrentValue"));
            }
            catch
            {
                HightCurrentValue = 0;
            }
            try
            {
                ZeroCurrentValue = float.Parse(IniManager.ReadIni("Basic", "ZeroCurrentValue"));
            }
            catch
            {
                ZeroCurrentValue = 0;
            }
            try
            {
                Interval = float.Parse(IniManager.ReadIni("Basic", "Interval"));
            }
            catch
            {
                Interval = 0;
            }
            
            Limits = new List<Limit>();

            for (int i = 0; i < 4; i++)
            {
                try
                {
                    Channel channel = Channel.Current_0;

                    float upperLimit = int.Parse(IniManager.ReadIni("UpperLimit", (channel + i).ToString()));
                    float lowerLimit = int.Parse(IniManager.ReadIni("LowerLimit", (channel + i).ToString()));
                    Limit limit = new Limit(channel + i, lowerLimit, upperLimit);
                    Limits.Add(limit);
                }
                catch
                {
                    Channel channel = Channel.Current_0;
                    Limit limit = new Limit(channel + i, 0, 10);
                    Limits.Add(limit);
                }
            }
        }

        public void SaveSettings()
        {
            IniManager.WriteIni("Basic", "IPAddress", IPAddress);
            IniManager.WriteIni("Basic", "SamplingTime", SamplingTime.ToString());
            IniManager.WriteIni("Basic", "DataPath", DataPath);
            IniManager.WriteIni("Basic", "DeletePeriod", DeletePeriod.ToString());

            IniManager.WriteIni("Basic", "Sensor", Sensor.ToString());
            IniManager.WriteIni("Basic", "HightCurrent", HightCurrent.ToString());
            IniManager.WriteIni("Basic", "HightCurrentValue", HightCurrentValue.ToString());
            IniManager.WriteIni("Basic", "ZeroCurrentValue", ZeroCurrentValue.ToString());
            IniManager.WriteIni("Basic", "Interval", Interval.ToString());

            for (int i = 0; i < Limits.Count; i++)
            {
                IniManager.WriteIni("UpperLimit", Limits[i].Channel.ToString(), Limits[i].UpperLimit.ToString());
                IniManager.WriteIni("LowerLimit", Limits[i].Channel.ToString(), Limits[i].LowerLimit.ToString());
            }
        }
    }

    public static class IniManager
    {
        private static string _filePath = Environment.CurrentDirectory + "\\Config" + "\\Config.ini";

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        public static bool CheckIniExists()
        {
            FileInfo fi = new FileInfo(_filePath);
            return fi.Exists;
        }

        public static void WriteIni(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, _filePath);
        }

        public static string ReadIni(string section, string key)
        {
            StringBuilder temp = new StringBuilder(200);
            int i = GetPrivateProfileString(section, key, "", temp, 200, _filePath);
            return temp.ToString();
        }
    }
}
