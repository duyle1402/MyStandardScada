namespace StandardScada
{
    partial class frExcel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frExcel));
            this.btnExport = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIMEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALVE1ONOFFDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vALVE2ONOFFDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vALVE3ONOFFDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vALVE4ONOFFDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vALVE5ONOFFDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vALVE6ONOFFDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vALVE7ONOFFDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vALVE8ONOFFDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vALVE9ONOFFDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vALVE10ONOFFDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vALVE11ONOFFDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mIX1ONOFFDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mIX2ONOFFDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mIX3ONOFFDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mIX4ONOFFDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mOTORONOFFDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sTOPONOFFDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.eMERGENCYONOFFDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sCADASTATUSTABLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCADA_LVDataSet = new StandardScada.SCADA_LVDataSet();
            this.sCADA_STATUS_TABLETableAdapter = new StandardScada.SCADA_LVDataSetTableAdapters.SCADA_STATUS_TABLETableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCADASTATUSTABLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCADA_LVDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Teal;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.Black;
            this.btnExport.Location = new System.Drawing.Point(665, 335);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(97, 57);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "&Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Teal;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.tIMEDATEDataGridViewTextBoxColumn,
            this.vALVE1ONOFFDataGridViewCheckBoxColumn,
            this.vALVE2ONOFFDataGridViewCheckBoxColumn,
            this.vALVE3ONOFFDataGridViewCheckBoxColumn,
            this.vALVE4ONOFFDataGridViewCheckBoxColumn,
            this.vALVE5ONOFFDataGridViewCheckBoxColumn,
            this.vALVE6ONOFFDataGridViewCheckBoxColumn,
            this.vALVE7ONOFFDataGridViewCheckBoxColumn,
            this.vALVE8ONOFFDataGridViewCheckBoxColumn,
            this.vALVE9ONOFFDataGridViewCheckBoxColumn,
            this.vALVE10ONOFFDataGridViewCheckBoxColumn,
            this.vALVE11ONOFFDataGridViewCheckBoxColumn,
            this.mIX1ONOFFDataGridViewCheckBoxColumn,
            this.mIX2ONOFFDataGridViewCheckBoxColumn,
            this.mIX3ONOFFDataGridViewCheckBoxColumn,
            this.mIX4ONOFFDataGridViewCheckBoxColumn,
            this.mOTORONOFFDataGridViewCheckBoxColumn,
            this.sTOPONOFFDataGridViewCheckBoxColumn,
            this.eMERGENCYONOFFDataGridViewCheckBoxColumn});
            this.dataGridView.DataSource = this.sCADASTATUSTABLEBindingSource;
            this.dataGridView.GridColor = System.Drawing.Color.Black;
            this.dataGridView.Location = new System.Drawing.Point(12, 69);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(647, 323);
            this.dataGridView.TabIndex = 2;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tIMEDATEDataGridViewTextBoxColumn
            // 
            this.tIMEDATEDataGridViewTextBoxColumn.DataPropertyName = "TIMEDATE";
            this.tIMEDATEDataGridViewTextBoxColumn.HeaderText = "TIMEDATE";
            this.tIMEDATEDataGridViewTextBoxColumn.Name = "tIMEDATEDataGridViewTextBoxColumn";
            // 
            // vALVE1ONOFFDataGridViewCheckBoxColumn
            // 
            this.vALVE1ONOFFDataGridViewCheckBoxColumn.DataPropertyName = "VALVE1_ON_OFF";
            this.vALVE1ONOFFDataGridViewCheckBoxColumn.HeaderText = "VALVE1_ON_OFF";
            this.vALVE1ONOFFDataGridViewCheckBoxColumn.Name = "vALVE1ONOFFDataGridViewCheckBoxColumn";
            // 
            // vALVE2ONOFFDataGridViewCheckBoxColumn
            // 
            this.vALVE2ONOFFDataGridViewCheckBoxColumn.DataPropertyName = "VALVE2_ON_OFF";
            this.vALVE2ONOFFDataGridViewCheckBoxColumn.HeaderText = "VALVE2_ON_OFF";
            this.vALVE2ONOFFDataGridViewCheckBoxColumn.Name = "vALVE2ONOFFDataGridViewCheckBoxColumn";
            // 
            // vALVE3ONOFFDataGridViewCheckBoxColumn
            // 
            this.vALVE3ONOFFDataGridViewCheckBoxColumn.DataPropertyName = "VALVE3_ON_OFF";
            this.vALVE3ONOFFDataGridViewCheckBoxColumn.HeaderText = "VALVE3_ON_OFF";
            this.vALVE3ONOFFDataGridViewCheckBoxColumn.Name = "vALVE3ONOFFDataGridViewCheckBoxColumn";
            // 
            // vALVE4ONOFFDataGridViewCheckBoxColumn
            // 
            this.vALVE4ONOFFDataGridViewCheckBoxColumn.DataPropertyName = "VALVE4_ON_OFF";
            this.vALVE4ONOFFDataGridViewCheckBoxColumn.HeaderText = "VALVE4_ON_OFF";
            this.vALVE4ONOFFDataGridViewCheckBoxColumn.Name = "vALVE4ONOFFDataGridViewCheckBoxColumn";
            // 
            // vALVE5ONOFFDataGridViewCheckBoxColumn
            // 
            this.vALVE5ONOFFDataGridViewCheckBoxColumn.DataPropertyName = "VALVE5_ON_OFF";
            this.vALVE5ONOFFDataGridViewCheckBoxColumn.HeaderText = "VALVE5_ON_OFF";
            this.vALVE5ONOFFDataGridViewCheckBoxColumn.Name = "vALVE5ONOFFDataGridViewCheckBoxColumn";
            // 
            // vALVE6ONOFFDataGridViewCheckBoxColumn
            // 
            this.vALVE6ONOFFDataGridViewCheckBoxColumn.DataPropertyName = "VALVE6_ON_OFF";
            this.vALVE6ONOFFDataGridViewCheckBoxColumn.HeaderText = "VALVE6_ON_OFF";
            this.vALVE6ONOFFDataGridViewCheckBoxColumn.Name = "vALVE6ONOFFDataGridViewCheckBoxColumn";
            // 
            // vALVE7ONOFFDataGridViewCheckBoxColumn
            // 
            this.vALVE7ONOFFDataGridViewCheckBoxColumn.DataPropertyName = "VALVE7_ON_OFF";
            this.vALVE7ONOFFDataGridViewCheckBoxColumn.HeaderText = "VALVE7_ON_OFF";
            this.vALVE7ONOFFDataGridViewCheckBoxColumn.Name = "vALVE7ONOFFDataGridViewCheckBoxColumn";
            // 
            // vALVE8ONOFFDataGridViewCheckBoxColumn
            // 
            this.vALVE8ONOFFDataGridViewCheckBoxColumn.DataPropertyName = "VALVE8_ON_OFF";
            this.vALVE8ONOFFDataGridViewCheckBoxColumn.HeaderText = "VALVE8_ON_OFF";
            this.vALVE8ONOFFDataGridViewCheckBoxColumn.Name = "vALVE8ONOFFDataGridViewCheckBoxColumn";
            // 
            // vALVE9ONOFFDataGridViewCheckBoxColumn
            // 
            this.vALVE9ONOFFDataGridViewCheckBoxColumn.DataPropertyName = "VALVE9_ON_OFF";
            this.vALVE9ONOFFDataGridViewCheckBoxColumn.HeaderText = "VALVE9_ON_OFF";
            this.vALVE9ONOFFDataGridViewCheckBoxColumn.Name = "vALVE9ONOFFDataGridViewCheckBoxColumn";
            // 
            // vALVE10ONOFFDataGridViewCheckBoxColumn
            // 
            this.vALVE10ONOFFDataGridViewCheckBoxColumn.DataPropertyName = "VALVE10_ON_OFF";
            this.vALVE10ONOFFDataGridViewCheckBoxColumn.HeaderText = "VALVE10_ON_OFF";
            this.vALVE10ONOFFDataGridViewCheckBoxColumn.Name = "vALVE10ONOFFDataGridViewCheckBoxColumn";
            // 
            // vALVE11ONOFFDataGridViewCheckBoxColumn
            // 
            this.vALVE11ONOFFDataGridViewCheckBoxColumn.DataPropertyName = "VALVE11_ON_OFF";
            this.vALVE11ONOFFDataGridViewCheckBoxColumn.HeaderText = "VALVE11_ON_OFF";
            this.vALVE11ONOFFDataGridViewCheckBoxColumn.Name = "vALVE11ONOFFDataGridViewCheckBoxColumn";
            // 
            // mIX1ONOFFDataGridViewCheckBoxColumn
            // 
            this.mIX1ONOFFDataGridViewCheckBoxColumn.DataPropertyName = "MIX1_ON_OFF";
            this.mIX1ONOFFDataGridViewCheckBoxColumn.HeaderText = "MIX1_ON_OFF";
            this.mIX1ONOFFDataGridViewCheckBoxColumn.Name = "mIX1ONOFFDataGridViewCheckBoxColumn";
            // 
            // mIX2ONOFFDataGridViewCheckBoxColumn
            // 
            this.mIX2ONOFFDataGridViewCheckBoxColumn.DataPropertyName = "MIX2_ON_OFF";
            this.mIX2ONOFFDataGridViewCheckBoxColumn.HeaderText = "MIX2_ON_OFF";
            this.mIX2ONOFFDataGridViewCheckBoxColumn.Name = "mIX2ONOFFDataGridViewCheckBoxColumn";
            // 
            // mIX3ONOFFDataGridViewCheckBoxColumn
            // 
            this.mIX3ONOFFDataGridViewCheckBoxColumn.DataPropertyName = "MIX3_ON_OFF";
            this.mIX3ONOFFDataGridViewCheckBoxColumn.HeaderText = "MIX3_ON_OFF";
            this.mIX3ONOFFDataGridViewCheckBoxColumn.Name = "mIX3ONOFFDataGridViewCheckBoxColumn";
            // 
            // mIX4ONOFFDataGridViewCheckBoxColumn
            // 
            this.mIX4ONOFFDataGridViewCheckBoxColumn.DataPropertyName = "MIX4_ON_OFF";
            this.mIX4ONOFFDataGridViewCheckBoxColumn.HeaderText = "MIX4_ON_OFF";
            this.mIX4ONOFFDataGridViewCheckBoxColumn.Name = "mIX4ONOFFDataGridViewCheckBoxColumn";
            // 
            // mOTORONOFFDataGridViewCheckBoxColumn
            // 
            this.mOTORONOFFDataGridViewCheckBoxColumn.DataPropertyName = "MOTOR_ON_OFF";
            this.mOTORONOFFDataGridViewCheckBoxColumn.HeaderText = "MOTOR_ON_OFF";
            this.mOTORONOFFDataGridViewCheckBoxColumn.Name = "mOTORONOFFDataGridViewCheckBoxColumn";
            // 
            // sTOPONOFFDataGridViewCheckBoxColumn
            // 
            this.sTOPONOFFDataGridViewCheckBoxColumn.DataPropertyName = "STOP_ON_OFF";
            this.sTOPONOFFDataGridViewCheckBoxColumn.HeaderText = "STOP_ON_OFF";
            this.sTOPONOFFDataGridViewCheckBoxColumn.Name = "sTOPONOFFDataGridViewCheckBoxColumn";
            // 
            // eMERGENCYONOFFDataGridViewCheckBoxColumn
            // 
            this.eMERGENCYONOFFDataGridViewCheckBoxColumn.DataPropertyName = "EMERGENCY_ON_OFF";
            this.eMERGENCYONOFFDataGridViewCheckBoxColumn.HeaderText = "EMERGENCY_ON_OFF";
            this.eMERGENCYONOFFDataGridViewCheckBoxColumn.Name = "eMERGENCYONOFFDataGridViewCheckBoxColumn";
            // 
            // sCADASTATUSTABLEBindingSource
            // 
            this.sCADASTATUSTABLEBindingSource.DataMember = "SCADA_STATUS_TABLE";
            this.sCADASTATUSTABLEBindingSource.DataSource = this.sCADA_LVDataSet;
            // 
            // sCADA_LVDataSet
            // 
            this.sCADA_LVDataSet.DataSetName = "SCADA_LVDataSet";
            this.sCADA_LVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sCADA_STATUS_TABLETableAdapter
            // 
            this.sCADA_STATUS_TABLETableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "Excel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(764, 395);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnExport);
            this.ForeColor = System.Drawing.Color.ForestGreen;
            this.Name = "frExcel";
            this.Text = "frExcel";
            this.Load += new System.EventHandler(this.frExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCADASTATUSTABLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCADA_LVDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dataGridView;
        private SCADA_LVDataSet sCADA_LVDataSet;
        private System.Windows.Forms.BindingSource sCADASTATUSTABLEBindingSource;
        private SCADA_LVDataSetTableAdapters.SCADA_STATUS_TABLETableAdapter sCADA_STATUS_TABLETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIMEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vALVE1ONOFFDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vALVE2ONOFFDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vALVE3ONOFFDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vALVE4ONOFFDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vALVE5ONOFFDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vALVE6ONOFFDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vALVE7ONOFFDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vALVE8ONOFFDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vALVE9ONOFFDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vALVE10ONOFFDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vALVE11ONOFFDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn mIX1ONOFFDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn mIX2ONOFFDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn mIX3ONOFFDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn mIX4ONOFFDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn mOTORONOFFDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sTOPONOFFDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eMERGENCYONOFFDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}