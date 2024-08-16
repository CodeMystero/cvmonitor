namespace CVMonitorExample
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonStartGathering = new System.Windows.Forms.Button();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageGraphV = new System.Windows.Forms.TabPage();
            this.chartV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageGraphA = new System.Windows.Forms.TabPage();
            this.chartA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageGrid = new System.Windows.Forms.TabPage();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.current0DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.current1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voltage0DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voltage1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridViewDataDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageError = new System.Windows.Forms.TabPage();
            this.dataGridViewDeviceLog = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIPAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridViewDataDeviceLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.dataGridViewComm = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridViewDataCommBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageCalibration = new System.Windows.Forms.TabPage();
            this.labelInterval = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelZeroCurrent = new System.Windows.Forms.Label();
            this.labelHighCurrent = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnZeroCurrent = new System.Windows.Forms.Button();
            this.btnHighCurrent = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxHighCurrent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSensor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCheckVersion = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSetTime = new System.Windows.Forms.Button();
            this.buttonCheckTime = new System.Windows.Forms.Button();
            this.buttonCheckIP = new System.Windows.Forms.Button();
            this.buttonIPSetting = new System.Windows.Forms.Button();
            this.textBoxSetIP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonLogData = new System.Windows.Forms.Button();
            this.buttonStopGathering = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonScaleApply = new System.Windows.Forms.Button();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.buttonLimit = new System.Windows.Forms.Button();
            this.comboBoxSamplingTime = new System.Windows.Forms.ComboBox();
            this.comboBoxSensor = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageGraphV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartV)).BeginInit();
            this.tabPageGraphA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartA)).BeginInit();
            this.tabPageGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDataDataBindingSource)).BeginInit();
            this.tabPageError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeviceLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDataDeviceLogBindingSource)).BeginInit();
            this.tabPageLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDataCommBindingSource)).BeginInit();
            this.tabPageCalibration.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1160, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(1163, 82);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(107, 34);
            this.buttonConnect.TabIndex = 3;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Enabled = false;
            this.buttonDisconnect.Location = new System.Drawing.Point(1275, 82);
            this.buttonDisconnect.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(110, 34);
            this.buttonDisconnect.TabIndex = 4;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(1293, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStartGathering
            // 
            this.buttonStartGathering.Enabled = false;
            this.buttonStartGathering.Location = new System.Drawing.Point(1163, 428);
            this.buttonStartGathering.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonStartGathering.Name = "buttonStartGathering";
            this.buttonStartGathering.Size = new System.Drawing.Size(107, 34);
            this.buttonStartGathering.TabIndex = 11;
            this.buttonStartGathering.Text = "Start";
            this.buttonStartGathering.UseVisualStyleBackColor = true;
            this.buttonStartGathering.Click += new System.EventHandler(this.buttonStartGathering_Click);
            // 
            // textBoxPort
            // 
            this.textBoxPort.Enabled = false;
            this.textBoxPort.Location = new System.Drawing.Point(1298, 46);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(86, 28);
            this.textBoxPort.TabIndex = 12;
            this.textBoxPort.Text = "5000";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(1163, 46);
            this.textBoxIP.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(127, 28);
            this.textBoxIP.TabIndex = 13;
            this.textBoxIP.Text = "192.168.1.128";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageGraphV);
            this.tabControl1.Controls.Add(this.tabPageGraphA);
            this.tabControl1.Controls.Add(this.tabPageGrid);
            this.tabControl1.Controls.Add(this.tabPageError);
            this.tabControl1.Controls.Add(this.tabPageLog);
            this.tabControl1.Controls.Add(this.tabPageCalibration);
            this.tabControl1.Location = new System.Drawing.Point(17, 18);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1128, 646);
            this.tabControl1.TabIndex = 14;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageGraphV
            // 
            this.tabPageGraphV.Controls.Add(this.chartV);
            this.tabPageGraphV.Location = new System.Drawing.Point(4, 28);
            this.tabPageGraphV.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPageGraphV.Name = "tabPageGraphV";
            this.tabPageGraphV.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPageGraphV.Size = new System.Drawing.Size(1120, 614);
            this.tabPageGraphV.TabIndex = 4;
            this.tabPageGraphV.Text = "Graph V";
            this.tabPageGraphV.UseVisualStyleBackColor = true;
            // 
            // chartV
            // 
            this.chartV.BackColor = System.Drawing.Color.Empty;
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            chartArea1.Name = "ChartArea1";
            this.chartV.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chartV.Legends.Add(legend1);
            this.chartV.Location = new System.Drawing.Point(8, 12);
            this.chartV.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chartV.Name = "chartV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.LegendText = "CH 1";
            series1.Name = "series3";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.LegendText = "CH 2";
            series2.Name = "series4";
            this.chartV.Series.Add(series1);
            this.chartV.Series.Add(series2);
            this.chartV.Size = new System.Drawing.Size(1100, 552);
            this.chartV.TabIndex = 17;
            this.chartV.Text = "chart2";
            // 
            // tabPageGraphA
            // 
            this.tabPageGraphA.Controls.Add(this.chartA);
            this.tabPageGraphA.Location = new System.Drawing.Point(4, 28);
            this.tabPageGraphA.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPageGraphA.Name = "tabPageGraphA";
            this.tabPageGraphA.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPageGraphA.Size = new System.Drawing.Size(1120, 614);
            this.tabPageGraphA.TabIndex = 5;
            this.tabPageGraphA.Text = "Graph A";
            this.tabPageGraphA.UseVisualStyleBackColor = true;
            // 
            // chartA
            // 
            this.chartA.BackColor = System.Drawing.Color.Empty;
            chartArea2.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            chartArea2.Name = "ChartArea1";
            this.chartA.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.chartA.Legends.Add(legend2);
            this.chartA.Location = new System.Drawing.Point(8, 12);
            this.chartA.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chartA.Name = "chartA";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.LegendText = "CH 1";
            series3.Name = "series1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.LegendText = "CH 2";
            series4.Name = "series2";
            this.chartA.Series.Add(series3);
            this.chartA.Series.Add(series4);
            this.chartA.Size = new System.Drawing.Size(1100, 552);
            this.chartA.TabIndex = 17;
            this.chartA.Text = "chart3";
            // 
            // tabPageGrid
            // 
            this.tabPageGrid.Controls.Add(this.dataGridViewData);
            this.tabPageGrid.Location = new System.Drawing.Point(4, 28);
            this.tabPageGrid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPageGrid.Name = "tabPageGrid";
            this.tabPageGrid.Size = new System.Drawing.Size(1120, 614);
            this.tabPageGrid.TabIndex = 6;
            this.tabPageGrid.Text = "Grid";
            this.tabPageGrid.UseVisualStyleBackColor = true;
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AutoGenerateColumns = false;
            this.dataGridViewData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.current0DataGridViewTextBoxColumn,
            this.current1DataGridViewTextBoxColumn,
            this.voltage0DataGridViewTextBoxColumn,
            this.voltage1DataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn});
            this.dataGridViewData.DataSource = this.gridViewDataDataBindingSource;
            this.dataGridViewData.Location = new System.Drawing.Point(8, 12);
            this.dataGridViewData.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.RowHeadersWidth = 62;
            this.dataGridViewData.RowTemplate.Height = 23;
            this.dataGridViewData.Size = new System.Drawing.Size(1105, 556);
            this.dataGridViewData.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "DateTime";
            this.dataGridViewTextBoxColumn13.HeaderText = "DateTime";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // current0DataGridViewTextBoxColumn
            // 
            this.current0DataGridViewTextBoxColumn.DataPropertyName = "Current0";
            this.current0DataGridViewTextBoxColumn.HeaderText = "Current CH 0";
            this.current0DataGridViewTextBoxColumn.MinimumWidth = 10;
            this.current0DataGridViewTextBoxColumn.Name = "current0DataGridViewTextBoxColumn";
            // 
            // current1DataGridViewTextBoxColumn
            // 
            this.current1DataGridViewTextBoxColumn.DataPropertyName = "Current1";
            this.current1DataGridViewTextBoxColumn.HeaderText = "Current CH 1";
            this.current1DataGridViewTextBoxColumn.MinimumWidth = 10;
            this.current1DataGridViewTextBoxColumn.Name = "current1DataGridViewTextBoxColumn";
            // 
            // voltage0DataGridViewTextBoxColumn
            // 
            this.voltage0DataGridViewTextBoxColumn.DataPropertyName = "Voltage0";
            this.voltage0DataGridViewTextBoxColumn.HeaderText = "Voltage CH 0";
            this.voltage0DataGridViewTextBoxColumn.MinimumWidth = 10;
            this.voltage0DataGridViewTextBoxColumn.Name = "voltage0DataGridViewTextBoxColumn";
            // 
            // voltage1DataGridViewTextBoxColumn
            // 
            this.voltage1DataGridViewTextBoxColumn.DataPropertyName = "Voltage1";
            this.voltage1DataGridViewTextBoxColumn.HeaderText = "Voltage CH 1";
            this.voltage1DataGridViewTextBoxColumn.MinimumWidth = 10;
            this.voltage1DataGridViewTextBoxColumn.Name = "voltage1DataGridViewTextBoxColumn";
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "Result";
            this.resultDataGridViewTextBoxColumn.HeaderText = "Result";
            this.resultDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            // 
            // gridViewDataDataBindingSource
            // 
            this.gridViewDataDataBindingSource.DataSource = typeof(CVMonitorExample.GridViewDataData);
            // 
            // tabPageError
            // 
            this.tabPageError.Controls.Add(this.dataGridViewDeviceLog);
            this.tabPageError.Location = new System.Drawing.Point(4, 28);
            this.tabPageError.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPageError.Name = "tabPageError";
            this.tabPageError.Size = new System.Drawing.Size(1120, 614);
            this.tabPageError.TabIndex = 7;
            this.tabPageError.Text = "Error";
            this.tabPageError.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDeviceLog
            // 
            this.dataGridViewDeviceLog.AutoGenerateColumns = false;
            this.dataGridViewDeviceLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDeviceLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeviceLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.clientIPAddressDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn12,
            this.errorCodeDataGridViewTextBoxColumn});
            this.dataGridViewDeviceLog.DataSource = this.gridViewDataDeviceLogBindingSource;
            this.dataGridViewDeviceLog.Location = new System.Drawing.Point(13, 4);
            this.dataGridViewDeviceLog.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridViewDeviceLog.Name = "dataGridViewDeviceLog";
            this.dataGridViewDeviceLog.RowHeadersWidth = 62;
            this.dataGridViewDeviceLog.RowTemplate.Height = 23;
            this.dataGridViewDeviceLog.Size = new System.Drawing.Size(1100, 555);
            this.dataGridViewDeviceLog.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "DateTime";
            this.dataGridViewTextBoxColumn11.HeaderText = "DateTime";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // clientIPAddressDataGridViewTextBoxColumn
            // 
            this.clientIPAddressDataGridViewTextBoxColumn.DataPropertyName = "ClientIPAddress";
            this.clientIPAddressDataGridViewTextBoxColumn.HeaderText = "ClientIPAddress";
            this.clientIPAddressDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.clientIPAddressDataGridViewTextBoxColumn.Name = "clientIPAddressDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "strCode";
            this.dataGridViewTextBoxColumn12.HeaderText = "strCode";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // errorCodeDataGridViewTextBoxColumn
            // 
            this.errorCodeDataGridViewTextBoxColumn.DataPropertyName = "ErrorCode";
            this.errorCodeDataGridViewTextBoxColumn.HeaderText = "ErrorCode";
            this.errorCodeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.errorCodeDataGridViewTextBoxColumn.Name = "errorCodeDataGridViewTextBoxColumn";
            // 
            // gridViewDataDeviceLogBindingSource
            // 
            this.gridViewDataDeviceLogBindingSource.DataSource = typeof(CVMonitorExample.GridViewDataDeviceLog);
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.dataGridViewComm);
            this.tabPageLog.Location = new System.Drawing.Point(4, 28);
            this.tabPageLog.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPageLog.Size = new System.Drawing.Size(1120, 614);
            this.tabPageLog.TabIndex = 0;
            this.tabPageLog.Text = "Log";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // dataGridViewComm
            // 
            this.dataGridViewComm.AutoGenerateColumns = false;
            this.dataGridViewComm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewComm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dataGridViewComm.DataSource = this.gridViewDataCommBindingSource;
            this.dataGridViewComm.Location = new System.Drawing.Point(5, 4);
            this.dataGridViewComm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridViewComm.Name = "dataGridViewComm";
            this.dataGridViewComm.RowHeadersWidth = 62;
            this.dataGridViewComm.RowTemplate.Height = 23;
            this.dataGridViewComm.Size = new System.Drawing.Size(1108, 564);
            this.dataGridViewComm.TabIndex = 31;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DateTime";
            this.dataGridViewTextBoxColumn8.HeaderText = "DateTime";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DataFlow";
            this.dataGridViewTextBoxColumn9.HeaderText = "DataFlow";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Message";
            this.dataGridViewTextBoxColumn10.HeaderText = "Message";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // gridViewDataCommBindingSource
            // 
            this.gridViewDataCommBindingSource.DataSource = typeof(CVMonitorExample.GridViewDataComm);
            // 
            // tabPageCalibration
            // 
            this.tabPageCalibration.Controls.Add(this.labelInterval);
            this.tabPageCalibration.Controls.Add(this.label13);
            this.tabPageCalibration.Controls.Add(this.labelZeroCurrent);
            this.tabPageCalibration.Controls.Add(this.labelHighCurrent);
            this.tabPageCalibration.Controls.Add(this.label11);
            this.tabPageCalibration.Controls.Add(this.label10);
            this.tabPageCalibration.Controls.Add(this.btnZeroCurrent);
            this.tabPageCalibration.Controls.Add(this.btnHighCurrent);
            this.tabPageCalibration.Controls.Add(this.label9);
            this.tabPageCalibration.Controls.Add(this.textBoxHighCurrent);
            this.tabPageCalibration.Controls.Add(this.label8);
            this.tabPageCalibration.Controls.Add(this.textBoxSensor);
            this.tabPageCalibration.Controls.Add(this.label6);
            this.tabPageCalibration.Location = new System.Drawing.Point(4, 28);
            this.tabPageCalibration.Name = "tabPageCalibration";
            this.tabPageCalibration.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCalibration.Size = new System.Drawing.Size(1120, 614);
            this.tabPageCalibration.TabIndex = 8;
            this.tabPageCalibration.Text = "Calibration";
            this.tabPageCalibration.UseVisualStyleBackColor = true;
            // 
            // labelInterval
            // 
            this.labelInterval.Location = new System.Drawing.Point(182, 274);
            this.labelInterval.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(145, 32);
            this.labelInterval.TabIndex = 30;
            this.labelInterval.Text = "0";
            this.labelInterval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(28, 274);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 32);
            this.label13.TabIndex = 29;
            this.label13.Text = "Interval";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelZeroCurrent
            // 
            this.labelZeroCurrent.Location = new System.Drawing.Point(182, 230);
            this.labelZeroCurrent.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelZeroCurrent.Name = "labelZeroCurrent";
            this.labelZeroCurrent.Size = new System.Drawing.Size(145, 32);
            this.labelZeroCurrent.TabIndex = 28;
            this.labelZeroCurrent.Text = "0";
            this.labelZeroCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHighCurrent
            // 
            this.labelHighCurrent.Location = new System.Drawing.Point(182, 178);
            this.labelHighCurrent.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelHighCurrent.Name = "labelHighCurrent";
            this.labelHighCurrent.Size = new System.Drawing.Size(145, 32);
            this.labelHighCurrent.TabIndex = 27;
            this.labelHighCurrent.Text = "0";
            this.labelHighCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(28, 230);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 32);
            this.label11.TabIndex = 26;
            this.label11.Text = "Zero Current";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(28, 178);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 32);
            this.label10.TabIndex = 25;
            this.label10.Text = "High Current";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnZeroCurrent
            // 
            this.btnZeroCurrent.Enabled = false;
            this.btnZeroCurrent.Location = new System.Drawing.Point(168, 94);
            this.btnZeroCurrent.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnZeroCurrent.Name = "btnZeroCurrent";
            this.btnZeroCurrent.Size = new System.Drawing.Size(107, 32);
            this.btnZeroCurrent.TabIndex = 23;
            this.btnZeroCurrent.Text = "Capture";
            this.btnZeroCurrent.UseVisualStyleBackColor = true;
            this.btnZeroCurrent.Click += new System.EventHandler(this.btnZeroCurrent_Click);
            // 
            // btnHighCurrent
            // 
            this.btnHighCurrent.Enabled = false;
            this.btnHighCurrent.Location = new System.Drawing.Point(243, 52);
            this.btnHighCurrent.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnHighCurrent.Name = "btnHighCurrent";
            this.btnHighCurrent.Size = new System.Drawing.Size(107, 28);
            this.btnHighCurrent.TabIndex = 22;
            this.btnHighCurrent.Text = "Capture";
            this.btnHighCurrent.UseVisualStyleBackColor = true;
            this.btnHighCurrent.Click += new System.EventHandler(this.btnHighCurrent_Click);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(15, 94);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 32);
            this.label9.TabIndex = 20;
            this.label9.Text = "Zero Current(A)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxHighCurrent
            // 
            this.textBoxHighCurrent.Enabled = false;
            this.textBoxHighCurrent.Location = new System.Drawing.Point(168, 52);
            this.textBoxHighCurrent.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxHighCurrent.Name = "textBoxHighCurrent";
            this.textBoxHighCurrent.Size = new System.Drawing.Size(67, 28);
            this.textBoxHighCurrent.TabIndex = 19;
            this.textBoxHighCurrent.Text = "10";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(15, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 32);
            this.label8.TabIndex = 18;
            this.label8.Text = "High Current(A)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSensor
            // 
            this.textBoxSensor.Enabled = false;
            this.textBoxSensor.Location = new System.Drawing.Point(168, 21);
            this.textBoxSensor.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxSensor.Name = "textBoxSensor";
            this.textBoxSensor.Size = new System.Drawing.Size(67, 28);
            this.textBoxSensor.TabIndex = 17;
            this.textBoxSensor.Text = "10";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(15, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 32);
            this.label6.TabIndex = 16;
            this.label6.Text = "Sensor(A)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCheckVersion
            // 
            this.buttonCheckVersion.Enabled = false;
            this.buttonCheckVersion.Location = new System.Drawing.Point(1163, 208);
            this.buttonCheckVersion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonCheckVersion.Name = "buttonCheckVersion";
            this.buttonCheckVersion.Size = new System.Drawing.Size(223, 34);
            this.buttonCheckVersion.TabIndex = 32;
            this.buttonCheckVersion.Text = "Version Request";
            this.buttonCheckVersion.UseVisualStyleBackColor = true;
            this.buttonCheckVersion.Click += new System.EventHandler(this.buttonCheckVersion_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(1160, 356);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 32);
            this.label7.TabIndex = 28;
            this.label7.Text = "Sampling Time";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSetTime
            // 
            this.buttonSetTime.Enabled = false;
            this.buttonSetTime.Location = new System.Drawing.Point(1295, 387);
            this.buttonSetTime.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonSetTime.Name = "buttonSetTime";
            this.buttonSetTime.Size = new System.Drawing.Size(90, 34);
            this.buttonSetTime.TabIndex = 26;
            this.buttonSetTime.Text = "Apply";
            this.buttonSetTime.UseVisualStyleBackColor = true;
            this.buttonSetTime.Click += new System.EventHandler(this.buttonSetTime_Click);
            // 
            // buttonCheckTime
            // 
            this.buttonCheckTime.Enabled = false;
            this.buttonCheckTime.Location = new System.Drawing.Point(1163, 166);
            this.buttonCheckTime.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonCheckTime.Name = "buttonCheckTime";
            this.buttonCheckTime.Size = new System.Drawing.Size(223, 34);
            this.buttonCheckTime.TabIndex = 22;
            this.buttonCheckTime.Text = "Sampling Time Request";
            this.buttonCheckTime.UseVisualStyleBackColor = true;
            this.buttonCheckTime.Click += new System.EventHandler(this.buttonCheckTime_Click);
            // 
            // buttonCheckIP
            // 
            this.buttonCheckIP.Enabled = false;
            this.buttonCheckIP.Location = new System.Drawing.Point(1163, 124);
            this.buttonCheckIP.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonCheckIP.Name = "buttonCheckIP";
            this.buttonCheckIP.Size = new System.Drawing.Size(223, 34);
            this.buttonCheckIP.TabIndex = 19;
            this.buttonCheckIP.Text = "IP adress Request";
            this.buttonCheckIP.UseVisualStyleBackColor = true;
            this.buttonCheckIP.Click += new System.EventHandler(this.buttonCheckIP_Click);
            // 
            // buttonIPSetting
            // 
            this.buttonIPSetting.Enabled = false;
            this.buttonIPSetting.Location = new System.Drawing.Point(1295, 320);
            this.buttonIPSetting.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonIPSetting.Name = "buttonIPSetting";
            this.buttonIPSetting.Size = new System.Drawing.Size(90, 34);
            this.buttonIPSetting.TabIndex = 16;
            this.buttonIPSetting.Text = "Apply";
            this.buttonIPSetting.UseVisualStyleBackColor = true;
            this.buttonIPSetting.Click += new System.EventHandler(this.buttonIPSetting_Click);
            // 
            // textBoxSetIP
            // 
            this.textBoxSetIP.Enabled = false;
            this.textBoxSetIP.Location = new System.Drawing.Point(1163, 324);
            this.textBoxSetIP.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxSetIP.Name = "textBoxSetIP";
            this.textBoxSetIP.Size = new System.Drawing.Size(126, 28);
            this.textBoxSetIP.TabIndex = 15;
            this.textBoxSetIP.Text = "192.168.0.128";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(1160, 291);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 32);
            this.label5.TabIndex = 14;
            this.label5.Text = "IP";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLogData
            // 
            this.buttonLogData.Enabled = false;
            this.buttonLogData.Location = new System.Drawing.Point(1163, 250);
            this.buttonLogData.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonLogData.Name = "buttonLogData";
            this.buttonLogData.Size = new System.Drawing.Size(223, 34);
            this.buttonLogData.TabIndex = 12;
            this.buttonLogData.Text = "Log Data Request";
            this.buttonLogData.UseVisualStyleBackColor = true;
            this.buttonLogData.Click += new System.EventHandler(this.buttonLogData_Click);
            // 
            // buttonStopGathering
            // 
            this.buttonStopGathering.Enabled = false;
            this.buttonStopGathering.Location = new System.Drawing.Point(1275, 428);
            this.buttonStopGathering.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonStopGathering.Name = "buttonStopGathering";
            this.buttonStopGathering.Size = new System.Drawing.Size(110, 34);
            this.buttonStopGathering.TabIndex = 15;
            this.buttonStopGathering.Text = "Stop";
            this.buttonStopGathering.UseVisualStyleBackColor = true;
            this.buttonStopGathering.Click += new System.EventHandler(this.buttonStopGathering_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 32);
            this.label3.TabIndex = 33;
            this.label3.Text = "Min";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonScaleApply);
            this.groupBox1.Controls.Add(this.textBoxMax);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxMin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(1163, 554);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 100);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Graph Y Scale";
            // 
            // buttonScaleApply
            // 
            this.buttonScaleApply.Enabled = false;
            this.buttonScaleApply.Location = new System.Drawing.Point(148, 24);
            this.buttonScaleApply.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonScaleApply.Name = "buttonScaleApply";
            this.buttonScaleApply.Size = new System.Drawing.Size(65, 68);
            this.buttonScaleApply.TabIndex = 35;
            this.buttonScaleApply.Text = "Apply";
            this.buttonScaleApply.UseVisualStyleBackColor = true;
            this.buttonScaleApply.Click += new System.EventHandler(this.buttonScaleApply_Click);
            // 
            // textBoxMax
            // 
            this.textBoxMax.Enabled = false;
            this.textBoxMax.Location = new System.Drawing.Point(70, 64);
            this.textBoxMax.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(69, 28);
            this.textBoxMax.TabIndex = 36;
            this.textBoxMax.Text = "50.000";
            this.textBoxMax.TextChanged += new System.EventHandler(this.textBoxMax_TextChanged);
            this.textBoxMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMax_KeyPress);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 32);
            this.label4.TabIndex = 35;
            this.label4.Text = "Max";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxMin
            // 
            this.textBoxMin.Enabled = false;
            this.textBoxMin.Location = new System.Drawing.Point(70, 28);
            this.textBoxMin.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(69, 28);
            this.textBoxMin.TabIndex = 35;
            this.textBoxMin.Text = "0.000";
            this.textBoxMin.TextChanged += new System.EventHandler(this.textBoxMin_TextChanged);
            this.textBoxMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMin_KeyPress);
            // 
            // buttonLimit
            // 
            this.buttonLimit.Location = new System.Drawing.Point(1163, 512);
            this.buttonLimit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonLimit.Name = "buttonLimit";
            this.buttonLimit.Size = new System.Drawing.Size(223, 34);
            this.buttonLimit.TabIndex = 35;
            this.buttonLimit.Text = "Limit Setting";
            this.buttonLimit.UseVisualStyleBackColor = true;
            this.buttonLimit.Click += new System.EventHandler(this.buttonLimit_Click);
            // 
            // comboBoxSamplingTime
            // 
            this.comboBoxSamplingTime.Enabled = false;
            this.comboBoxSamplingTime.FormattingEnabled = true;
            this.comboBoxSamplingTime.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "5",
            "8",
            "10",
            "20",
            "25",
            "40",
            "50",
            "100",
            "200"});
            this.comboBoxSamplingTime.Location = new System.Drawing.Point(1163, 390);
            this.comboBoxSamplingTime.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBoxSamplingTime.Name = "comboBoxSamplingTime";
            this.comboBoxSamplingTime.Size = new System.Drawing.Size(127, 26);
            this.comboBoxSamplingTime.TabIndex = 36;
            // 
            // comboBoxSensor
            // 
            this.comboBoxSensor.Enabled = false;
            this.comboBoxSensor.FormattingEnabled = true;
            this.comboBoxSensor.Items.AddRange(new object[] {
            "Off",
            "On"});
            this.comboBoxSensor.Location = new System.Drawing.Point(1275, 471);
            this.comboBoxSensor.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBoxSensor.Name = "comboBoxSensor";
            this.comboBoxSensor.Size = new System.Drawing.Size(109, 26);
            this.comboBoxSensor.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(1160, 471);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 32);
            this.label12.TabIndex = 37;
            this.label12.Text = "Sensor";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 682);
            this.Controls.Add(this.comboBoxSensor);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxSamplingTime);
            this.Controls.Add(this.buttonLimit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCheckVersion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLogData);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.buttonStopGathering);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonStartGathering);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonSetTime);
            this.Controls.Add(this.buttonIPSetting);
            this.Controls.Add(this.textBoxSetIP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonCheckTime);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonCheckIP);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainForm";
            this.Text = "CV Monitor";
            this.tabControl1.ResumeLayout(false);
            this.tabPageGraphV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartV)).EndInit();
            this.tabPageGraphA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartA)).EndInit();
            this.tabPageGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDataDataBindingSource)).EndInit();
            this.tabPageError.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeviceLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDataDeviceLogBindingSource)).EndInit();
            this.tabPageLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDataCommBindingSource)).EndInit();
            this.tabPageCalibration.ResumeLayout(false);
            this.tabPageCalibration.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonStartGathering;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageLog;
        private System.Windows.Forms.Button buttonIPSetting;
        private System.Windows.Forms.TextBox textBoxSetIP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonStopGathering;
        private System.Windows.Forms.Button buttonCheckIP;
        private System.Windows.Forms.Button buttonCheckTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonSetTime;
        private System.Windows.Forms.Button buttonCheckVersion;
        private System.Windows.Forms.DataGridView dataGridViewComm;
        private System.Windows.Forms.Button buttonLogData;
        private System.Windows.Forms.DataGridView dataGridViewDeviceLog;
        private System.Windows.Forms.BindingSource gridViewDataCommBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFlowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gridViewDataDeviceLogBindingSource;
        private System.Windows.Forms.BindingSource gridViewDataDataBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TabPage tabPageGraphV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartV;
        private System.Windows.Forms.TabPage tabPageGraphA;
        private System.Windows.Forms.TabPage tabPageGrid;
        private System.Windows.Forms.TabPage tabPageError;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartA;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonScaleApply;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.Button buttonLimit;
        private System.Windows.Forms.ComboBox comboBoxSamplingTime;
        private System.Windows.Forms.TabPage tabPageCalibration;
        private System.Windows.Forms.TextBox textBoxSensor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxHighCurrent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnHighCurrent;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnZeroCurrent;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelZeroCurrent;
        private System.Windows.Forms.Label labelHighCurrent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIPAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn current0DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn current1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voltage0DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voltage1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBoxSensor;
        private System.Windows.Forms.Label label12;
    }
}

