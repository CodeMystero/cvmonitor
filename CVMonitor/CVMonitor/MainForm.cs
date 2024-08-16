using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CVMonitorExample
{
    public partial class MainForm : Form
    {
        private string _csvFileName;

        private BoardComm _boardComm;

        private BindingSource _bindingSourceComm;
        private BindingSource _bindingSourceDeviceLog;
        private BindingSource _bindingSourceData;

        private delegate void AddReceiveDataDelegate(ReceiveProtocol receive);
        private delegate void EnableControlDelegate(bool enable);
        private AddReceiveDataDelegate _addReceiveData;
        private EnableControlDelegate _enableControl;

        private MainFormFactory _factory;
        private ManagerFactory _managerFactory;

        private List<GridViewDataComm> _gridViewDataComms =                 new List<GridViewDataComm>();
        private List<GridViewDataDeviceLog> _gridViewDataDeviceLogs =       new List<GridViewDataDeviceLog>();
        private List<GridViewDataData> _gridViewDataDatas =                 new List<GridViewDataData>();
        private List<GridViewDataData> _csvDatas =                          new List<GridViewDataData>();

        private List<float> _gatheringDatas1 =                              new List<float>();
        private List<float> _gatheringDatas2 =                              new List<float>();
        private List<float> _gatheringDatas3 =                              new List<float>();
        private List<float> _gatheringDatas4 =                              new List<float>();

        private DateTime _writeDate =                                       DateTime.Now;
        private System.Timers.Timer _timer =                                new System.Timers.Timer();

        public MainForm()
        {
            InitializeComponent();
            _factory = new MainFormFactory();
            _managerFactory = new ManagerFactory();

            InitializeComm();
            InitializeDirectory();
            InitializeSetting();
            InitializeDelegate();
            InitializeControl();
            InitializeTimer();
        }


        //디렉토리 생성 메서드 리팩토링
        private void InitializeDirectory()
        {
            string[] directories = {
                Path.Combine(Environment.CurrentDirectory, "Config"),
                Path.Combine(Environment.CurrentDirectory, "Data"),
                Path.Combine(Environment.CurrentDirectory, "Data", "Log"),
                Path.Combine(Environment.CurrentDirectory, "Data", "CSV"),
                Path.Combine(Environment.CurrentDirectory, "Data", "Error"),
                Path.Combine(Environment.CurrentDirectory, "Data", "Event")
            };

            foreach (var dir in directories)
            {
                CreateDirectoryIfNotExists(dir);
            }
        }

        private void CreateDirectoryIfNotExists(string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
        }

        private void InitializeSetting()
        {
            SettingManager.Instance.LoadSettings();
        }

        private void InitializeDelegate()
        {
            _addReceiveData = new AddReceiveDataDelegate(ReceiveDataDisplay);
            _enableControl = new EnableControlDelegate(EnableControl);
        }


        // InitializeCurrentAixs, VolatageAixs 리팩토링
        private void InitializeAxis(Chart chart, double xMin, double xMax, double yMin, double yMax)
        {
            var chartArea =                         chart.ChartAreas[0];
            chartArea.AxisX.Minimum =               xMin;
            chartArea.AxisX.Maximum =               xMax;
            chartArea.AxisY.Minimum =               yMin;
            chartArea.AxisY.Maximum =               yMax;
            chartArea.RecalculateAxesScale();
        }

        private void InitializeControl()
        {
            SetupTextBoxAndComboBox();

            // 차트를 초기화 하는 부분
            InitializeAxis(chartV, 0, 500, 0, 50);
            InitializeAxis(chartA, 0, 500, 0, 50);

            _bindingSourceComm = _factory.CreateBindingSource(_gridViewDataComms);
            _bindingSourceDeviceLog = _factory.CreateBindingSource(_gridViewDataDeviceLogs);
            _bindingSourceData = _factory.CreateBindingSource(_gridViewDataDatas);

            _bindingSourceComm.DataSource = _gridViewDataComms;
            dataGridViewComm.DataSource = _bindingSourceComm;

            SetupDataGridView(dataGridViewComm, "yyyy/MM/dd HH:mm:ss.fff");

            _bindingSourceDeviceLog.DataSource = _gridViewDataDeviceLogs;
            dataGridViewDeviceLog.DataSource = _bindingSourceDeviceLog;

            SetupDataGridView(dataGridViewDeviceLog, "yyyy/MM/dd HH:mm:ss");

            _bindingSourceData.DataSource = _gridViewDataDatas;
            dataGridViewData.DataSource = _bindingSourceData;

            SetupDataGridView(dataGridViewData, "yyyy/MM/dd HH:mm:ss", "N2", "N3");

            if (dataGridViewData.VirtualMode)
                dataGridViewData.CellValueNeeded += DataGridViewData_CellValueNeeded;
        }

        private void SetupTextBoxAndComboBox()
        {
            textBoxIP.Text = SettingManager.Instance.IPAddress;
            comboBoxSamplingTime.Text = SettingManager.Instance.SamplingTime.ToString();
            comboBoxSensor.SelectedIndex = 0;
        }

        private void SetupDataGridView(DataGridView dataGridView, string format, string currentFormat = "N2", string voltageFormat = "N3")
        {
            dataGridView.RowHeadersVisible = false;
            dataGridView.Columns[0].DefaultCellStyle.Format = format;

            if (dataGridView.Columns.Count > 1)
            {
                dataGridView.Columns[1].DefaultCellStyle.Format = currentFormat;
            }

            if (dataGridView.Columns.Count > 2)
            {
                dataGridView.Columns[2].DefaultCellStyle.Format = currentFormat;
            }

            if (dataGridView.Columns.Count > 3)
            {
                dataGridView.Columns[3].DefaultCellStyle.Format = voltageFormat;
            }

            if (dataGridView.Columns.Count > 4)
            {
                dataGridView.Columns[4].DefaultCellStyle.Format = voltageFormat;
            }
        }


        private void InitializeComm()
        {
            _boardComm =                                    _factory.CreateBoardComm();
            _boardComm.OnCallbackMethod +=                  OnCallbackMethod;
            _boardComm.OnCallbackConnectMethod +=           OnCallbackConnectMethod;
            _boardComm.OnCallbackWriteMethod +=             OnCallbackWriteMethod;

        }

        private void InitializeTimer()
        {
            TimeSpan timeOrg = new TimeSpan(0, 0, 1, 0);
            double interval = timeOrg.TotalSeconds * 1000;
            _timer = _factory.CreateTimer(interval, _timer_Elapsed);

        }

        private void InitializeCSVPath()
        {
            string fileName = DateTime.Now.ToString("HH_mm_ss") + ".csv";
            _writeDate = DateTime.Now;
            _csvFileName = Path.Combine(SettingManager.Instance.DataPath, "CSV", DateTime.Now.ToString("yyyy-MM-dd"), fileName);
        }

        private void EnableControl(bool enable)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(_enableControl, enable);
            }
            else
            {
                buttonConnect.Enabled =             !enable;
                buttonDisconnect.Enabled =          enable;
                buttonStartGathering.Enabled =      enable;
                buttonLogData.Enabled =             enable;
                buttonCheckIP.Enabled =             enable;
                buttonCheckTime.Enabled =           enable;
                buttonCheckVersion.Enabled =        enable;
                buttonSetTime.Enabled =             enable;
                buttonIPSetting.Enabled =           enable;
                textBoxSetIP.Enabled =              enable;
                comboBoxSamplingTime.Enabled =      enable;
                textBoxMin.Enabled =                enable;
                textBoxMax.Enabled =                enable;
                buttonScaleApply.Enabled =          enable;
                textBoxSensor.Enabled =             enable;
                textBoxHighCurrent.Enabled =        enable;
                btnHighCurrent.Enabled =            enable;
                btnZeroCurrent.Enabled =            enable;
                comboBoxSensor.Enabled =            enable;
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            string ip = string.Concat(textBoxIP.Text.Where(c => !Char.IsWhiteSpace(c)));
            int port = int.Parse(textBoxPort.Text);
            _boardComm.Connect(ip, port);
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            buttonStopGathering_Click(sender, e);
            _boardComm.Disconnect();
            EnableControl(false);
        }

        public void OnCallbackConnectMethod()
        {
            EnableControl(true);
        }

        public void OnCallbackWriteMethod()
        {

        }

        // 비동기 데이터 수신할때마다 콜백되는 함수 
        public void OnCallbackMethod(ReceiveProtocol receive)
        {
            ReceiveDataDisplay(receive);
        }


        // 수신된 데이터에 따라 UI처리
        private void ReceiveDataDisplay(ReceiveProtocol receive)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(_addReceiveData, receive);
            }
            else
            {
                if (receive is ReceiveProtocol_IP)
                {
                    ReceiveProtocol_IP receiveProtocol_IP = (ReceiveProtocol_IP)receive;
                    string msg = string.Format("[Check IP Address Response] IP Address : [{0}]", receiveProtocol_IP.IPAddress.ToString());
                    AddGridViewComm(receiveProtocol_IP.DateTime, false, msg);
                }
                else if (receive is ReceiveProtocol_TimeAndSamplingTime)
                {
                    ReceiveProtocol_TimeAndSamplingTime receiveProtocol_TimeAndSamplingTime = receive as ReceiveProtocol_TimeAndSamplingTime;
                    string msg = string.Format("[Check Time & Sampling Time Response] Device Time : [{0}] Sampling Time : [{1}]", receiveProtocol_TimeAndSamplingTime.DeviceTime.ToString("yyyy-MM-dd HH:mm:ss")
                        , receiveProtocol_TimeAndSamplingTime.SamplingTime.ToString());
                    AddGridViewComm(receiveProtocol_TimeAndSamplingTime.DateTime, false, msg);
                }
                else if (receive is ReceiveProtocol_Version)
                {
                    ReceiveProtocol_Version receiveProtocol_Version = receive as ReceiveProtocol_Version;
                    string msg = string.Format("[Check Version Response] Version : [{0}] Sequence Number : [{1}]", receiveProtocol_Version.VersionTime.ToString("yyyy-MM-dd")
                        , receiveProtocol_Version.SequenceNumber.ToString());
                    AddGridViewComm(receiveProtocol_Version.DateTime, false, msg);
                }
                else if (receive is ReceiveProtocol_GatheringData)
                {
                    ReceiveProtocol_GatheringData receiveProtocol_GatheringData = receive as ReceiveProtocol_GatheringData;
                    AddGridViewData(receiveProtocol_GatheringData);
                }
                else if (receive is ReceiveProtocol_GatheringData_Response)
                {
                    ReceiveProtocol_GatheringData_Response receiveProtocol_GatheringData_Response = receive as ReceiveProtocol_GatheringData_Response;
                    string msg = string.Empty;
                    if (receiveProtocol_GatheringData_Response.IsRun)
                    {
                        msg = string.Format("[Gathering Start Response]", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    }
                    else
                    {
                        msg = string.Format("[Gathering Stop Response]", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    }
                    
                    AddGridViewComm(DateTime.Now, false, msg);

                    //_receiveList.Add(new GridViewData(receiveProtocol_GatheringData_Response.DateTime, DataFlow.Receive, receive.ToString()));
                    //dataGridView1.DataSource = _receiveList;
                    //dataGridView1.Update();
                }
                else if (receive is ReceiveProtocol_LogData)
                {
                    ReceiveProtocol_LogData receiveProtocol_LogData = receive as ReceiveProtocol_LogData;
                    AddGridViewDeviceLog(receiveProtocol_LogData);
                    string msg = string.Format("[Log Data Response] Count : [{0}]", receiveProtocol_LogData.Datas.Count, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    AddGridViewComm(DateTime.Now, false, msg);
                }
            }
        }

        private void AddGridViewComm(DateTime dateTime, bool send, string msg)
        {
            DataFlow dataFlow;
            
            if (send)
            {
                dataFlow = DataFlow.Send;
            }
            else
            {
                dataFlow = DataFlow.Receive;
            }

            _bindingSourceComm.Add(new GridViewDataComm(dateTime, dataFlow, msg));

            string path = Path.Combine(SettingManager.Instance.DataPath, "Event", "EventLog_" + DateTime.Now.ToString("yyyy-MM-dd") + ".log");
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, true))
            {
                file.WriteLine("[{0}] [{1}] [{2}]", dateTime, dataFlow.ToString(), msg);
            }
        }

        private void AddGridViewDeviceLog(ReceiveProtocol_LogData receiveProtocol_LogData)
        {
            //_bindingSourceDeviceLog.Clear();
            for (int i = 0; i < receiveProtocol_LogData.Datas.Count; i++)
            {
                DeviceLog deviceLog = receiveProtocol_LogData.Datas[i];
                GridViewDataDeviceLog gridViewDataDeviceLog = new GridViewDataDeviceLog(deviceLog.DateTime, deviceLog.ClientIPAddress.ToString(),
                    deviceLog.ErrorCode);
                _bindingSourceDeviceLog.Add(gridViewDataDeviceLog);

                string path = Path.Combine(SettingManager.Instance.DataPath, "Error", "ErrorLog_" + DateTime.Now.ToString("yyyy-MM-dd") + ".log");
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, true))
                {
                    file.WriteLine("[{0}] [{1}] [{2}] [{3}]", gridViewDataDeviceLog.DateTime, gridViewDataDeviceLog.ClientIPAddress, 
                        gridViewDataDeviceLog.strCode, gridViewDataDeviceLog.ErrorCode);
                }
            }

            
        }

        private void AddGridViewData(ReceiveProtocol_GatheringData receiveProtocol_GatheringData)
        {
            if(_writeDate.Date != DateTime.Now.Date) // 시간이 다르면 새로운 파일 만듬
            {
                string fileName = DateTime.Now.ToString("HH_mm_ss") + ".csv";
                _csvFileName = Path.Combine(SettingManager.Instance.DataPath, "CSV", DateTime.Now.ToString("yyyy-MM-dd"), fileName);
                _writeDate = DateTime.Now;
            }
            
            string directory = Path.GetDirectoryName(_csvFileName);
            DirectoryInfo directoryInfo = new DirectoryInfo(directory);
            if (!directoryInfo.Exists) // 파일 존재하는지 확인 후 없으면 새로운 파일 만들기 
            {
                directoryInfo.Create();
            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(_csvFileName, true)) //파일 열기 StreamWrite(파일, true -> 이어쓰기|false -> 처음부터)
            {
                List<string> csvList = new List<string>();

                //file.WriteLine("Time, Current CH 0, Current CH 1, Voltage CH 0, Voltage CH 1");

                for (int i = 0; i < receiveProtocol_GatheringData.DataCount; i++)
                {
                    if(comboBoxSensor.SelectedIndex == 1) //문자열 on:1 off:2 로 구성 돼 있음 
                    {
                        float ch0 = (float)((receiveProtocol_GatheringData.Datas[i][0] - SettingManager.Instance.ZeroCurrentValue) * SettingManager.Instance.Sensor / SettingManager.Instance.Interval);
                        //sensor랑 Interval값이 뭔지 모르겠음 0으로 세팅 돼 있음 
                        float ch1 = (float)((receiveProtocol_GatheringData.Datas[i][1] - SettingManager.Instance.ZeroCurrentValue) * SettingManager.Instance.Sensor / SettingManager.Instance.Interval);
                        _gatheringDatas1.Add(ch0);
                        _gatheringDatas2.Add(ch1);
                    }
                    else
                    {
                        _gatheringDatas1.Add(receiveProtocol_GatheringData.Datas[i][0]);
                        _gatheringDatas2.Add(receiveProtocol_GatheringData.Datas[i][1]);
                    }
                    
                    _gatheringDatas3.Add(receiveProtocol_GatheringData.Datas[i][2]);
                    _gatheringDatas4.Add(receiveProtocol_GatheringData.Datas[i][3]);

                    List<Limit> limits = SettingManager.Instance.Limits;

                    string result = "OK";

                    if (limits[0].LowerLimit <= _gatheringDatas1[i] && _gatheringDatas1[i] <= limits[0].UpperLimit &&
                        limits[1].LowerLimit <= _gatheringDatas2[i] && _gatheringDatas2[i] <= limits[1].UpperLimit &&
                        limits[2].LowerLimit <= _gatheringDatas3[i] && _gatheringDatas3[i] <= limits[2].UpperLimit &&
                        limits[3].LowerLimit <= _gatheringDatas4[i] && _gatheringDatas4[i] <= limits[3].UpperLimit)
                        result = "OK";
                    else
                        result = "NG";

                    GridViewDataData gridViewDataData = new GridViewDataData(receiveProtocol_GatheringData.DateTime, _gatheringDatas1[i], _gatheringDatas2[i],
                        _gatheringDatas3[i], _gatheringDatas4[i], result);

                    if (_bindingSourceData.Count == 500)
                    {
                        _bindingSourceData.RemoveAt(0);
                        _gatheringDatas1.RemoveAt(0);
                        _gatheringDatas2.RemoveAt(0);
                        _gatheringDatas3.RemoveAt(0);
                        _gatheringDatas4.RemoveAt(0);
                    }

                    //Console.WriteLine("CH0 " + receiveProtocol_GatheringData.Datas[i][0].ToString());
                    //Console.WriteLine("CH1 " + receiveProtocol_GatheringData.Datas[i][1].ToString());
                    //Console.WriteLine("CH2 " + receiveProtocol_GatheringData.Datas[i][2].ToString());
                    //Console.WriteLine("CH3 " + receiveProtocol_GatheringData.Datas[i][3].ToString());

                    csvList.Add(gridViewDataData.ToString());
                    //_csvDatas.Add(gridViewDataData);
                    _bindingSourceData.Add(gridViewDataData);
                }

                chartA.Series[0].Points.DataBindY(_gatheringDatas1);
                chartA.Series[1].Points.DataBindY(_gatheringDatas2);
                chartV.Series[0].Points.DataBindY(_gatheringDatas3);
                chartV.Series[1].Points.DataBindY(_gatheringDatas4);
                
                for (int i = 0; i < csvList.Count; i++)
                {
                    file.WriteLine("{0}", csvList[i]);
                }
            }
        }

        private void buttonCheckIP_Click(object sender, EventArgs e)
        {
            _boardComm.CheckIPAddress();
            string msg = string.Format("[Check IP Address Request]");
            AddGridViewComm(DateTime.Now, false, msg);
        }


        private void buttonCheckTime_Click(object sender, EventArgs e)
        {
            _boardComm.CheckTimeAndSamplingTime();
            string msg = string.Format("[Check Time & Sampling Time Request]");
            AddGridViewComm(DateTime.Now, true, msg);
        }

        private void buttonCheckVersion_Click(object sender, EventArgs e)
        {
            _boardComm.CheckVersion();
            string msg = string.Format("[Check Version Request]");
            AddGridViewComm(DateTime.Now, true, msg);
        }

        private void buttonIPSetting_Click(object sender, EventArgs e)
        {
            string ip = textBoxSetIP.Text;
            IPAddress iPAddress;
            bool result = IPAddress.TryParse(ip, out iPAddress);
            if (result)
            {
                string msg = string.Format("[Set IP Address] IP Address : [{0}]", iPAddress);
                AddGridViewComm(DateTime.Now, true, msg);
                _boardComm.SetIP(iPAddress);

                SettingManager.Instance.IPAddress = ip;
                SettingManager.Instance.SaveSettings();
            }
        }

        private void buttonSetTime_Click(object sender, EventArgs e)
        {
            int samplingTime = Convert.ToInt32(comboBoxSamplingTime.Text);
            string msg = string.Format("[Set Time & Sampling Time] Device Time : [{0}] Sampling Time : [{1}]", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                samplingTime.ToString());
            AddGridViewComm(DateTime.Now, true, msg);
            _boardComm.SetTimeAndSamplingTime(DateTime.Now, samplingTime); // 장치에 샘플링 시간 전송 
            SettingManager.Instance.SamplingTime = samplingTime;
            SettingManager.Instance.SaveSettings();
        }

        private void buttonLogData_Click(object sender, EventArgs e)
        {
            _boardComm.ReceiveLogData();
            string msg = string.Format("[Log Data Request]", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            AddGridViewComm(DateTime.Now, true, msg);
        }

        private void buttonStartGathering_Click(object sender, EventArgs e)
        {
            ClearGridData();
            ClearChartPoints();
            InitializeCSVPath();
            _timer.Start();
            _boardComm.StartGathering();
            buttonStartGathering.Enabled = false;
            buttonStopGathering.Enabled = true;
            string msg = string.Format("[Gathering Start]", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            AddGridViewComm(DateTime.Now, true, msg);
        }

        private void buttonStopGathering_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            _boardComm.StopGathering();
            buttonStartGathering.Enabled = true;
            buttonStopGathering.Enabled = false;
            string msg = string.Format("[Gathering Stop]", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            AddGridViewComm(DateTime.Now, true, msg);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(tabControl1.SelectedIndex != 2)
            //{
            //    if (_gatheringRun)
            //    {
            //        buttonStopGathering_Click(sender, e);
            //    }
            //}
        }

        private void ClearChartPoints()
        {
            chartV.Series[0].Points.Clear();
            chartV.Series[1].Points.Clear();
            chartA.Series[0].Points.Clear();
            chartA.Series[1].Points.Clear();
        }

        private void ClearGridData()
        {
            _gatheringDatas1.Clear();
            _gatheringDatas2.Clear();
            _gatheringDatas3.Clear();
            _gatheringDatas4.Clear();
            _bindingSourceData.Clear();
        }

        private void _timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            string fileName = DateTime.Now.ToString("HH_mm_ss") + ".csv";
            _csvFileName = Path.Combine(SettingManager.Instance.DataPath, "CSV", DateTime.Now.ToString("yyyy-MM-dd"), fileName);
            _writeDate = DateTime.Now;
            _csvDatas.Clear();
            Console.WriteLine(_csvFileName);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //WriteCSVFile();

            string fileName = DateTime.Now.ToString("HH_mm_ss") + ".csv";
            _csvFileName = Path.Combine(SettingManager.Instance.DataPath, "CSV", DateTime.Now.ToString("yyyy-MM-dd"), fileName);
            _writeDate = DateTime.Now;
            _csvDatas.Clear();
            Console.WriteLine(_csvFileName);
        }

        private void DataGridViewData_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (e.RowIndex == dataGridViewData.RowCount - 1 || _csvDatas.Count <= e.RowIndex) return;
            
            GridViewDataData gridViewDataData = _csvDatas[e.RowIndex];

            switch (this.dataGridViewData.Columns[e.ColumnIndex].Name)
            {
                case "DateTime":
                    e.Value = gridViewDataData.DateTime;
                    break;
                case "Current CH 0":
                    e.Value = gridViewDataData.Current0;
                    break;
                case "Current CH 1":
                        e.Value = gridViewDataData.Current1;
                    break;
                case "Voltage CH 0":
                        e.Value = gridViewDataData.Voltage0;
                    break;
                case "Voltage CH 1":
                        e.Value = gridViewDataData.Voltage1;
                    break;
            }
        }

        private void buttonScaleApply_Click(object sender, EventArgs e)
        {
            try
            {
                double min = Math.Truncate(Convert.ToDouble(textBoxMin.Text));
                double max = Math.Truncate(Convert.ToDouble(textBoxMax.Text));
                
                switch (tabControl1.SelectedIndex)
                {
                    case 0:
                        InitializeAxis(chartV, 0, 500, min, max);
                        break;
                    case 1:
                        InitializeAxis(chartA, 0, 500, min, max);
                        break;
                }
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void buttonLimit_Click(object sender, EventArgs e)
        {
            LimitForm limitForm = new LimitForm();
            limitForm.ShowDialog();
        }

        private void textBoxMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == '.' || e.KeyChar == '-'))
            {
                e.Handled = true;
            }
            if(e.KeyChar == '.' && textBoxMin.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void textBoxMax_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && textBoxMax.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void textBoxMin_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double min = Math.Round(Convert.ToDouble(textBoxMin.Text), 3);
                textBoxMin.Text = min.ToString("F3");
            }
            catch
            {

            }
        }

        private void textBoxMax_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double max = Math.Round(Convert.ToDouble(textBoxMax.Text), 3);
                textBoxMax.Text = max.ToString("F3");
            }
            catch
            {

            }
        }

        private void btnHighCurrent_Click(object sender, EventArgs e)
        {   // 검증 textBoxSensor가 비어 있으면 MessageBox띄움
            if(string.IsNullOrEmpty(textBoxHighCurrent.Text) || string.IsNullOrEmpty(textBoxSensor.Text))
            {
                MessageBox.Show("값이 비어있습니다.");
                return;
            }
            //데이터 Current CH0 값이 비어 있는지 확인
            if (_gatheringDatas1.Count == 0)
                return;
            //텍스트 박스에 있는 Sensor값 및 HighCurrent Value 값을 저장
            SettingManager.Instance.Sensor = Convert.ToInt32(textBoxSensor.Text); 
            SettingManager.Instance.HightCurrent = Convert.ToInt32(textBoxHighCurrent.Text); 
            
            //_gatheringData1의 첫 번째 값을 소수점 셋째 자리까지 반올림하여 저장 
            SettingManager.Instance.HightCurrentValue = (float)Math.Round(_gatheringDatas1[0], 3);
            
            // labelHighCurrent 새값으로 UI갱신 
            labelHighCurrent.Text = SettingManager.Instance.HightCurrentValue.ToString();
        }

        private void btnZeroCurrent_Click(object sender, EventArgs e)
        {
            ///Test 용
            //SettingManager.Instance.ZeroCurrentValue = (float)2.214;
            ///
            
            SettingManager.Instance.ZeroCurrentValue = (float)Math.Round(_gatheringDatas1[0], 3);
            labelZeroCurrent.Text = SettingManager.Instance.ZeroCurrentValue.ToString();

            float m = (float)Math.Round((SettingManager.Instance.ZeroCurrentValue - SettingManager.Instance.HightCurrentValue) / (0 - SettingManager.Instance.HightCurrent), 3);
            float y = SettingManager.Instance.HightCurrentValue - m * SettingManager.Instance.HightCurrent;
            float value = (float)Math.Round(m * SettingManager.Instance.Sensor + y, 3);
            SettingManager.Instance.Interval = (float)Math.Round(SettingManager.Instance.ZeroCurrentValue - value, 3);
            labelInterval.Text = SettingManager.Instance.Interval.ToString();
            SettingManager.Instance.SaveSettings();
        }


    }
}
