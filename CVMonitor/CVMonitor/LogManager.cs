using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CVMonitorExample
{
    class LogManager
    {
        private static LogManager _logManager;
        private Timer _timer = new Timer();
        private DateTime writeDate = DateTime.Now;

        public static LogManager Instance
        {
            get
            {
                if (_logManager == null)
                    _logManager = new LogManager();
                return _logManager;
            }
        }

        public string LogPath { get; set; }
        public void StartTimer() // 10분 단위로 로그 파일 생성
        {
            _timer.Interval = 600000; // 10분
            _timer.Elapsed += _timer_Elapsed; // Elapsed 가 발생할때 마다 _timer_Elapsed 호출 
            _timer.Start();
            writeDate = DateTime.Now;
            //타이머가 시작될때 로그 생성
            LogPath = Path.Combine(SettingManager.Instance.DataPath, "Log", DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.ToString("HH_mm_ss") + ".log");
        }

        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            writeDate = DateTime.Now;
            //두번째 time elapsed부터는 아래에서 10분마다 로그생성
            LogPath = Path.Combine(SettingManager.Instance.DataPath, "Log", DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.ToString("HH_mm_ss") + ".log");
        }

        public void StopTimer()
        {
            _timer.Elapsed -= _timer_Elapsed;
            _timer.Stop();
        }

        public void AddLog(bool send, byte[] byteArray)
        {
            if(writeDate.Date != DateTime.Now.Date)
            {
                writeDate = DateTime.Now;
                LogPath = Path.Combine(SettingManager.Instance.DataPath, "Log", DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.ToString("HH_mm_ss") + ".log");
            }

            string directory = Path.GetDirectoryName(LogPath);
            DirectoryInfo directoryInfo = new DirectoryInfo(directory);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(LogPath, true))
            {
                string msg = ByteArrayToString(byteArray);
                file.WriteLine("[{0}] [{1}] [{2}]", DateTime.Now.ToString("HH:mm:ss.fff"), send? "Send":"Recv", msg);
            }
        }

        private string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
            {
                hex.AppendFormat("{0:X2}", b);
                hex.Append(" ");
            }
            return hex.ToString();
        }
    }
}
