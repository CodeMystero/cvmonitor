using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVMonitorExample
{
    public class MainFormFactory
    {
        public BoardComm CreateBoardComm()
        {
            var boardComm = new BoardComm();

            return boardComm;
        }

        public BindingSource CreateBindingSource(object dataSource = null)
        {
            var bindingSource = new BindingSource();

            if (dataSource != null)
            {
                bindingSource.DataSource = dataSource;
            }
            return bindingSource;
        }

        public System.Timers.Timer CreateTimer(double interval, System.Timers.ElapsedEventHandler elapsedEventHandler)
        {
            var timer = new System.Timers.Timer(interval);
            timer.Elapsed += elapsedEventHandler;
            return timer;
        }
    }
}
