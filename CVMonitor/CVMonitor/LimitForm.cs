using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVMonitorExample
{
    public partial class LimitForm : Form
    {
        public LimitForm()
        {
            InitializeComponent();
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            dataGridViewLimit.RowHeadersVisible = false;
            dataGridViewLimit.DataSource = SettingManager.Instance.Limits;
        }

        private void dataGridViewLimit_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SettingManager.Instance.SaveSettings();
        }
    }
}
