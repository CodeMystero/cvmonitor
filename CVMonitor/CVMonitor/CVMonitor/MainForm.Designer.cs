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
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridViewDataDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageError = new System.Windows.Forms.TabPage();
            this.dataGridViewDeviceLog = new System.Windows.Forms.DataGridView();
            this.dateTimeDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridViewDataDeviceLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.dataGridViewComm = new System.Windows.Forms.DataGridView();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFlowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridViewDataCommBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonScaleApply = new System.Windows.Forms.Button();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.buttonLimit = new System.Windows.Forms.Button();
            this.comboBoxSamplingTime = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(812, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(814, 55);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 3;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Enabled = false;
            this.buttonDisconnect.Location = new System.Drawing.Point(893, 55);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(77, 23);
            this.buttonDisconnect.TabIndex = 4;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(905, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStartGathering
            // 
            this.buttonStartGathering.Enabled = false;
            this.buttonStartGathering.Location = new System.Drawing.Point(814, 285);
            this.buttonStartGathering.Name = "buttonStartGathering";
            this.buttonStartGathering.Size = new System.Drawing.Size(75, 23);
            this.buttonStartGathering.TabIndex = 11;
            this.buttonStartGathering.Text = "Start";
            this.buttonStartGathering.UseVisualStyleBackColor = true;
            this.buttonStartGathering.Click += new System.EventHandler(this.buttonStartGathering_Click);
            // 
            // textBoxPort
            // 
            this.textBoxPort.Enabled = false;
            this.textBoxPort.Location = new System.Drawing.Point(909, 31);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(61, 21);
            this.textBoxPort.TabIndex = 12;
            this.textBoxPort.Text = "5000";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(814, 31);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(90, 21);
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
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(790, 431);
            this.tabControl1.TabIndex = 14;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageGraphV
            // 
            this.tabPageGraphV.Controls.Add(this.chartV);
            this.tabPageGraphV.Location = new System.Drawing.Point(4, 22);
            this.tabPageGraphV.Name = "tabPageGraphV";
            this.tabPageGraphV.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGraphV.Size = new System.Drawing.Size(782, 405);
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
            this.chartV.Location = new System.Drawing.Point(6, 8);
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
            this.chartV.Size = new System.Drawing.Size(770, 368);
            this.chartV.TabIndex = 17;
            this.chartV.Text = "chart2";
            // 
            // tabPageGraphA
            // 
            this.tabPageGraphA.Controls.Add(this.chartA);
            this.tabPageGraphA.Location = new System.Drawing.Point(4, 22);
            this.tabPageGraphA.Name = "tabPageGraphA";
            this.tabPageGraphA.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGraphA.Size = new System.Drawing.Size(782, 405);
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
            this.chartA.Location = new System.Drawing.Point(6, 8);
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
            this.chartA.Size = new System.Drawing.Size(770, 368);
            this.chartA.TabIndex = 17;
            this.chartA.Text = "chart3";
            // 
            // tabPageGrid
            // 
            this.tabPageGrid.Controls.Add(this.dataGridViewData);
            this.tabPageGrid.Location = new System.Drawing.Point(4, 22);
            this.tabPageGrid.Name = "tabPageGrid";
            this.tabPageGrid.Size = new System.Drawing.Size(782, 405);
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
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.Result});
            this.dataGridViewData.DataSource = this.gridViewDataDataBindingSource;
            this.dataGridViewData.Location = new System.Drawing.Point(6, 8);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.RowHeadersWidth = 62;
            this.dataGridViewData.RowTemplate.Height = 23;
            this.dataGridViewData.Size = new System.Drawing.Size(773, 371);
            this.dataGridViewData.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DateTime";
            this.dataGridViewTextBoxColumn3.HeaderText = "DateTime";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Current0";
            this.dataGridViewTextBoxColumn4.HeaderText = "Current CH 0";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Current1";
            this.dataGridViewTextBoxColumn5.HeaderText = "Current CH 1";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Voltage0";
            this.dataGridViewTextBoxColumn6.HeaderText = "Voltage CH 0";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Voltage1";
            this.dataGridViewTextBoxColumn7.HeaderText = "Voltage CH 1";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Result
            // 
            this.Result.DataPropertyName = "Result";
            this.Result.HeaderText = "Result";
            this.Result.MinimumWidth = 8;
            this.Result.Name = "Result";
            // 
            // gridViewDataDataBindingSource
            // 
            this.gridViewDataDataBindingSource.DataSource = typeof(CVMonitorExample.GridViewDataData);
            // 
            // tabPageError
            // 
            this.tabPageError.Controls.Add(this.dataGridViewDeviceLog);
            this.tabPageError.Location = new System.Drawing.Point(4, 22);
            this.tabPageError.Name = "tabPageError";
            this.tabPageError.Size = new System.Drawing.Size(782, 405);
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
            this.dateTimeDataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn1,
            this.strCodeDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewDeviceLog.DataSource = this.gridViewDataDeviceLogBindingSource;
            this.dataGridViewDeviceLog.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewDeviceLog.Name = "dataGridViewDeviceLog";
            this.dataGridViewDeviceLog.RowHeadersWidth = 62;
            this.dataGridViewDeviceLog.RowTemplate.Height = 23;
            this.dataGridViewDeviceLog.Size = new System.Drawing.Size(770, 370);
            this.dataGridViewDeviceLog.TabIndex = 32;
            // 
            // dateTimeDataGridViewTextBoxColumn3
            // 
            this.dateTimeDataGridViewTextBoxColumn3.DataPropertyName = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn3.HeaderText = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dateTimeDataGridViewTextBoxColumn3.Name = "dateTimeDataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ClientIPAddress";
            this.dataGridViewTextBoxColumn1.HeaderText = "ClientIPAddress";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // strCodeDataGridViewTextBoxColumn
            // 
            this.strCodeDataGridViewTextBoxColumn.DataPropertyName = "strCode";
            this.strCodeDataGridViewTextBoxColumn.HeaderText = "strCode";
            this.strCodeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.strCodeDataGridViewTextBoxColumn.Name = "strCodeDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ErrorCode";
            this.dataGridViewTextBoxColumn2.HeaderText = "ErrorCode";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // gridViewDataDeviceLogBindingSource
            // 
            this.gridViewDataDeviceLogBindingSource.DataSource = typeof(CVMonitorExample.GridViewDataDeviceLog);
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.dataGridViewComm);
            this.tabPageLog.Location = new System.Drawing.Point(4, 22);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLog.Size = new System.Drawing.Size(782, 405);
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
            this.dateTimeDataGridViewTextBoxColumn,
            this.dataFlowDataGridViewTextBoxColumn,
            this.messageDataGridViewTextBoxColumn});
            this.dataGridViewComm.DataSource = this.gridViewDataCommBindingSource;
            this.dataGridViewComm.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewComm.Name = "dataGridViewComm";
            this.dataGridViewComm.RowHeadersWidth = 62;
            this.dataGridViewComm.RowTemplate.Height = 23;
            this.dataGridViewComm.Size = new System.Drawing.Size(776, 376);
            this.dataGridViewComm.TabIndex = 31;
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.FillWeight = 60F;
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            // 
            // dataFlowDataGridViewTextBoxColumn
            // 
            this.dataFlowDataGridViewTextBoxColumn.DataPropertyName = "DataFlow";
            this.dataFlowDataGridViewTextBoxColumn.FillWeight = 30F;
            this.dataFlowDataGridViewTextBoxColumn.HeaderText = "DataFlow";
            this.dataFlowDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dataFlowDataGridViewTextBoxColumn.Name = "dataFlowDataGridViewTextBoxColumn";
            // 
            // messageDataGridViewTextBoxColumn
            // 
            this.messageDataGridViewTextBoxColumn.DataPropertyName = "Message";
            this.messageDataGridViewTextBoxColumn.FillWeight = 200F;
            this.messageDataGridViewTextBoxColumn.HeaderText = "Message";
            this.messageDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
            // 
            // gridViewDataCommBindingSource
            // 
            this.gridViewDataCommBindingSource.DataSource = typeof(CVMonitorExample.GridViewDataComm);
            // 
            // buttonCheckVersion
            // 
            this.buttonCheckVersion.Enabled = false;
            this.buttonCheckVersion.Location = new System.Drawing.Point(814, 139);
            this.buttonCheckVersion.Name = "buttonCheckVersion";
            this.buttonCheckVersion.Size = new System.Drawing.Size(156, 23);
            this.buttonCheckVersion.TabIndex = 32;
            this.buttonCheckVersion.Text = "Version Request";
            this.buttonCheckVersion.UseVisualStyleBackColor = true;
            this.buttonCheckVersion.Click += new System.EventHandler(this.buttonCheckVersion_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(812, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = "Sampling Time";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSetTime
            // 
            this.buttonSetTime.Enabled = false;
            this.buttonSetTime.Location = new System.Drawing.Point(907, 258);
            this.buttonSetTime.Name = "buttonSetTime";
            this.buttonSetTime.Size = new System.Drawing.Size(63, 23);
            this.buttonSetTime.TabIndex = 26;
            this.buttonSetTime.Text = "Apply";
            this.buttonSetTime.UseVisualStyleBackColor = true;
            this.buttonSetTime.Click += new System.EventHandler(this.buttonSetTime_Click);
            // 
            // buttonCheckTime
            // 
            this.buttonCheckTime.Enabled = false;
            this.buttonCheckTime.Location = new System.Drawing.Point(814, 111);
            this.buttonCheckTime.Name = "buttonCheckTime";
            this.buttonCheckTime.Size = new System.Drawing.Size(156, 23);
            this.buttonCheckTime.TabIndex = 22;
            this.buttonCheckTime.Text = "Sampling Time Request";
            this.buttonCheckTime.UseVisualStyleBackColor = true;
            this.buttonCheckTime.Click += new System.EventHandler(this.buttonCheckTime_Click);
            // 
            // buttonCheckIP
            // 
            this.buttonCheckIP.Enabled = false;
            this.buttonCheckIP.Location = new System.Drawing.Point(814, 83);
            this.buttonCheckIP.Name = "buttonCheckIP";
            this.buttonCheckIP.Size = new System.Drawing.Size(156, 23);
            this.buttonCheckIP.TabIndex = 19;
            this.buttonCheckIP.Text = "IP adress Request";
            this.buttonCheckIP.UseVisualStyleBackColor = true;
            this.buttonCheckIP.Click += new System.EventHandler(this.buttonCheckIP_Click);
            // 
            // buttonIPSetting
            // 
            this.buttonIPSetting.Enabled = false;
            this.buttonIPSetting.Location = new System.Drawing.Point(907, 213);
            this.buttonIPSetting.Name = "buttonIPSetting";
            this.buttonIPSetting.Size = new System.Drawing.Size(63, 23);
            this.buttonIPSetting.TabIndex = 16;
            this.buttonIPSetting.Text = "Apply";
            this.buttonIPSetting.UseVisualStyleBackColor = true;
            this.buttonIPSetting.Click += new System.EventHandler(this.buttonIPSetting_Click);
            // 
            // textBoxSetIP
            // 
            this.textBoxSetIP.Enabled = false;
            this.textBoxSetIP.Location = new System.Drawing.Point(814, 216);
            this.textBoxSetIP.Name = "textBoxSetIP";
            this.textBoxSetIP.Size = new System.Drawing.Size(89, 21);
            this.textBoxSetIP.TabIndex = 15;
            this.textBoxSetIP.Text = "192.168.0.128";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(812, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "IP";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLogData
            // 
            this.buttonLogData.Enabled = false;
            this.buttonLogData.Location = new System.Drawing.Point(814, 167);
            this.buttonLogData.Name = "buttonLogData";
            this.buttonLogData.Size = new System.Drawing.Size(156, 23);
            this.buttonLogData.TabIndex = 12;
            this.buttonLogData.Text = "Log Data Request";
            this.buttonLogData.UseVisualStyleBackColor = true;
            this.buttonLogData.Click += new System.EventHandler(this.buttonLogData_Click);
            // 
            // buttonStopGathering
            // 
            this.buttonStopGathering.Enabled = false;
            this.buttonStopGathering.Location = new System.Drawing.Point(893, 285);
            this.buttonStopGathering.Name = "buttonStopGathering";
            this.buttonStopGathering.Size = new System.Drawing.Size(77, 23);
            this.buttonStopGathering.TabIndex = 15;
            this.buttonStopGathering.Text = "Stop";
            this.buttonStopGathering.UseVisualStyleBackColor = true;
            this.buttonStopGathering.Click += new System.EventHandler(this.buttonStopGathering_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 600000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(5, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 21);
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
            this.groupBox1.Location = new System.Drawing.Point(814, 369);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(156, 67);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Graph Y Scale";
            // 
            // buttonScaleApply
            // 
            this.buttonScaleApply.Enabled = false;
            this.buttonScaleApply.Location = new System.Drawing.Point(104, 16);
            this.buttonScaleApply.Name = "buttonScaleApply";
            this.buttonScaleApply.Size = new System.Drawing.Size(46, 45);
            this.buttonScaleApply.TabIndex = 35;
            this.buttonScaleApply.Text = "Apply";
            this.buttonScaleApply.UseVisualStyleBackColor = true;
            this.buttonScaleApply.Click += new System.EventHandler(this.buttonScaleApply_Click);
            // 
            // textBoxMax
            // 
            this.textBoxMax.Enabled = false;
            this.textBoxMax.Location = new System.Drawing.Point(49, 43);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(50, 21);
            this.textBoxMax.TabIndex = 36;
            this.textBoxMax.Text = "50.000";
            this.textBoxMax.TextChanged += new System.EventHandler(this.textBoxMax_TextChanged);
            this.textBoxMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMax_KeyPress);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(5, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 21);
            this.label4.TabIndex = 35;
            this.label4.Text = "Max";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxMin
            // 
            this.textBoxMin.Enabled = false;
            this.textBoxMin.Location = new System.Drawing.Point(49, 19);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(50, 21);
            this.textBoxMin.TabIndex = 35;
            this.textBoxMin.Text = "0.000";
            this.textBoxMin.TextChanged += new System.EventHandler(this.textBoxMin_TextChanged);
            this.textBoxMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMin_KeyPress);
            // 
            // buttonLimit
            // 
            this.buttonLimit.Location = new System.Drawing.Point(814, 341);
            this.buttonLimit.Name = "buttonLimit";
            this.buttonLimit.Size = new System.Drawing.Size(156, 23);
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
            this.comboBoxSamplingTime.Location = new System.Drawing.Point(814, 260);
            this.comboBoxSamplingTime.Name = "comboBoxSamplingTime";
            this.comboBoxSamplingTime.Size = new System.Drawing.Size(90, 20);
            this.comboBoxSamplingTime.TabIndex = 36;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.comboBox1.Location = new System.Drawing.Point(893, 314);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(77, 20);
            this.comboBox1.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(812, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 21);
            this.label6.TabIndex = 38;
            this.label6.Text = "Sensor";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 455);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
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
        private System.Windows.Forms.Timer timer1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonScaleApply;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.Button buttonLimit;
        private System.Windows.Forms.ComboBox comboBoxSamplingTime;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
    }
}

