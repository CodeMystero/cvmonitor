using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using CVMonitorExample.Properties;

namespace CVMonitorExample
{
    class FileManager
    {
        private static FileManager _fileManager;
        private Timer _deleteTimer = new Timer();


        // 싱글톤 패톤 구현 -> 클래스의 인스턴스가 단 하나만 생성되도록 보장하는 디자인 패턴
        public static FileManager Instance
        {
            get
            {
                if (_fileManager == null)
                    _fileManager = new FileManager();
                return _fileManager;
            }
        }

        public void StartTimer()
        {
            _deleteTimer.Interval = 60000;
            _deleteTimer.Elapsed += _deleteTimer_Elapsed;
            _deleteTimer.Start();
        }

        private void _deleteTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            DeleteProcess();
        }

        public void StopTimer()
        {
            _deleteTimer.Elapsed -= _deleteTimer_Elapsed;
            _deleteTimer.Stop();
        }

        // elapsed마다 해당경로의 파일및 폴더를 삭제
        private void DeleteProcess()
        {
            StopTimer();
            DeleteFolder(Path.Combine(SettingManager.Instance.DataPath, "Log"));
            DeleteFolder(Path.Combine(SettingManager.Instance.DataPath, "CSV"));
            DeleteFile(Path.Combine(SettingManager.Instance.DataPath, "Error"));
            DeleteFile(Path.Combine(SettingManager.Instance.DataPath, "Event"));
            StartTimer();
        }

        private void DeleteFolder(string path)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(path);
                if (di.Exists) //만약 그 경로가 존재 한다면, 
                {
                    DateTime Time = DateTime.Now;
                    DirectoryInfo[] directoryInfos = di.GetDirectories();
                    //현재시간으로 부터 하루 전 의 날짜를 date에 저장
                    string date = Time.AddDays(-SettingManager.Instance.DeletePeriod).ToString("yyyyMMdd");
                    //directoryInfos안에 있는 날짜 중 date(하루이전의 날짜)와 비교해서 date와 같거나 그 이 전의 directory를 foldes에 저장
                    var folders = directoryInfos.Where(o => date.CompareTo(o.CreationTime.ToString("yyyyMMdd")) >= 0);
                    //folders에 있는 directory에서 날짜가 지금 날짜와 다르다면 전부 삭제
                    foreach (var directory in folders)
                    {
                        if (directory.CreationTime.Date != DateTime.Now.Date)
                            directory.Delete(true);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        
        // 위와 같은 방법으로 DeletePeriod안에 만들어진것만 제외하고 전부 파일 삭제 하는 메서드 
        private void DeleteFile(string path)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(path);
                if (di.Exists)
                {
                    DateTime Time = DateTime.Now;
                    FileInfo[] fileInfos = di.GetFiles("*.*", SearchOption.AllDirectories);
                    string date = Time.AddDays(-SettingManager.Instance.DeletePeriod).ToString("yyyyMMdd");
                    var files = fileInfos.Where(o => date.CompareTo(o.CreationTime.ToString("yyyyMMdd")) > 0);

                    if (files.Count() > 0)
                    {
                        List<Task> tasks =
                            (from file in files
                             select new Action(() =>
                             {
                                 try
                                 {
                                     if (file.CreationTime.Day != DateTime.Now.Day)
                                     {
                                         file.Delete();
                                     }
                                 }
                                 catch (Exception ex)
                                 {
                                     System.Windows.Forms.MessageBox.Show(ex.Message);
                                 }
                             })
                    into action
                             select Task.Factory.StartNew(action)).ToList();
                        tasks.ForEach(file => file.Wait());

                        tasks.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
