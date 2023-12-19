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
                if (di.Exists)
                {
                    DateTime Time = DateTime.Now;
                    DirectoryInfo[] directoryInfos = di.GetDirectories();
                    string date = Time.AddDays(-SettingManager.Instance.DeletePeriod).ToString("yyyyMMdd");
                    var folders = directoryInfos.Where(o => date.CompareTo(o.CreationTime.ToString("yyyyMMdd")) >= 0);

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
