namespace CVMonitorExample
{
    partial class LimitForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewLimit = new System.Windows.Forms.DataGridView();
            this.channelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowerLimitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upperLimitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLimit
            // 
            this.dataGridViewLimit.AutoGenerateColumns = false;
            this.dataGridViewLimit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLimit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLimit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.channelDataGridViewTextBoxColumn,
            this.lowerLimitDataGridViewTextBoxColumn,
            this.upperLimitDataGridViewTextBoxColumn});
            this.dataGridViewLimit.DataSource = this.limitBindingSource;
            this.dataGridViewLimit.Location = new System.Drawing.Point(9, 9);
            this.dataGridViewLimit.Name = "dataGridViewLimit";
            this.dataGridViewLimit.RowHeadersWidth = 62;
            this.dataGridViewLimit.RowTemplate.Height = 23;
            this.dataGridViewLimit.Size = new System.Drawing.Size(292, 124);
            this.dataGridViewLimit.TabIndex = 32;
            this.dataGridViewLimit.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLimit_CellEndEdit);
            // 
            // channelDataGridViewTextBoxColumn
            // 
            this.channelDataGridViewTextBoxColumn.DataPropertyName = "Channel";
            this.channelDataGridViewTextBoxColumn.HeaderText = "Channel";
            this.channelDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.channelDataGridViewTextBoxColumn.Name = "channelDataGridViewTextBoxColumn";
            // 
            // lowerLimitDataGridViewTextBoxColumn
            // 
            this.lowerLimitDataGridViewTextBoxColumn.DataPropertyName = "LowerLimit";
            this.lowerLimitDataGridViewTextBoxColumn.HeaderText = "Lower Limit";
            this.lowerLimitDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lowerLimitDataGridViewTextBoxColumn.Name = "lowerLimitDataGridViewTextBoxColumn";
            // 
            // upperLimitDataGridViewTextBoxColumn
            // 
            this.upperLimitDataGridViewTextBoxColumn.DataPropertyName = "UpperLimit";
            this.upperLimitDataGridViewTextBoxColumn.HeaderText = "Upper Limit";
            this.upperLimitDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.upperLimitDataGridViewTextBoxColumn.Name = "upperLimitDataGridViewTextBoxColumn";
            // 
            // limitBindingSource
            // 
            this.limitBindingSource.DataSource = typeof(CVMonitorExample.Limit);
            // 
            // LimitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 138);
            this.Controls.Add(this.dataGridViewLimit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LimitForm";
            this.Text = "LimitForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLimit;
        private System.Windows.Forms.BindingSource limitBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn channelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowerLimitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn upperLimitDataGridViewTextBoxColumn;
    }
}