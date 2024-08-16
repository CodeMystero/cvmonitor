using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVMonitorExample
{
    internal class ManagerFactory
    {
        public LogManager CreateLogManager()
        {
            return LogManager.Instance;
        }

        public FileManager CreateFileManager()
        {
            return FileManager.Instance;
        }

    }
}
