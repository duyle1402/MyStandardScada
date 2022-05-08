namespace StandardScada
{
    partial class frMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMain));
            this.mn1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.communicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eqToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alarmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pLCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ss1 = new System.Windows.Forms.StatusStrip();
            this.tsPLCStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsD = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsVersionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.sdMotorDH = new SymbolFactoryDotNet.StandardControl();
            this.sdMotorCA = new SymbolFactoryDotNet.StandardControl();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mn1.SuspendLayout();
            this.ss1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sdMotorDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdMotorCA)).BeginInit();
            this.SuspendLayout();
            // 
            // mn1
            // 
            this.mn1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.analysisToolStripMenuItem,
            this.SystemToolStripMenuItem,
            this.alarmToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mn1.Location = new System.Drawing.Point(0, 0);
            this.mn1.Name = "mn1";
            this.mn1.Size = new System.Drawing.Size(1284, 24);
            this.mn1.TabIndex = 0;
            this.mn1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveASToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::StandardScada.Properties.Resources.save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveASToolStripMenuItem
            // 
            this.saveASToolStripMenuItem.Image = global::StandardScada.Properties.Resources.save;
            this.saveASToolStripMenuItem.Name = "saveASToolStripMenuItem";
            this.saveASToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveASToolStripMenuItem.Text = "Save As";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::StandardScada.Properties.Resources.button_cancel;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.communicationToolStripMenuItem,
            this.parametersToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // communicationToolStripMenuItem
            // 
            this.communicationToolStripMenuItem.Image = global::StandardScada.Properties.Resources.network_2;
            this.communicationToolStripMenuItem.Name = "communicationToolStripMenuItem";
            this.communicationToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.communicationToolStripMenuItem.Text = "Communication";
            this.communicationToolStripMenuItem.Click += new System.EventHandler(this.communicationToolStripMenuItem_Click);
            // 
            // parametersToolStripMenuItem
            // 
            this.parametersToolStripMenuItem.Image = global::StandardScada.Properties.Resources.update;
            this.parametersToolStripMenuItem.Name = "parametersToolStripMenuItem";
            this.parametersToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.parametersToolStripMenuItem.Text = "Parameters";
            this.parametersToolStripMenuItem.Click += new System.EventHandler(this.parametersToolStripMenuItem_Click);
            // 
            // analysisToolStripMenuItem
            // 
            this.analysisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chartToolStripMenuItem,
            this.eqToolStripMenuItem,
            this.historyToolStripMenuItem1,
            this.statusToolStripMenuItem});
            this.analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            this.analysisToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.analysisToolStripMenuItem.Text = "Analysis";
            // 
            // chartToolStripMenuItem
            // 
            this.chartToolStripMenuItem.Image = global::StandardScada.Properties.Resources.analyze;
            this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            this.chartToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.chartToolStripMenuItem.Text = "Chart";
            this.chartToolStripMenuItem.Click += new System.EventHandler(this.chartToolStripMenuItem_Click);
            // 
            // eqToolStripMenuItem
            // 
            this.eqToolStripMenuItem.Image = global::StandardScada.Properties.Resources.disk1;
            this.eqToolStripMenuItem.Name = "eqToolStripMenuItem";
            this.eqToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eqToolStripMenuItem.Text = "Time Run";
            this.eqToolStripMenuItem.Click += new System.EventHandler(this.eqToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem1
            // 
            this.historyToolStripMenuItem1.Image = global::StandardScada.Properties.Resources.document_notes;
            this.historyToolStripMenuItem1.Name = "historyToolStripMenuItem1";
            this.historyToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.historyToolStripMenuItem1.Text = "History";
            this.historyToolStripMenuItem1.Click += new System.EventHandler(this.historyToolStripMenuItem1_Click);
            // 
            // SystemToolStripMenuItem
            // 
            this.SystemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem1,
            this.autoToolStripMenuItem,
            this.runToolStripMenuItem});
            this.SystemToolStripMenuItem.Name = "SystemToolStripMenuItem";
            this.SystemToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.SystemToolStripMenuItem.Text = "System";
            // 
            // systemToolStripMenuItem1
            // 
            this.systemToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.systemToolStripMenuItem1.Image = global::StandardScada.Properties.Resources.hosting;
            this.systemToolStripMenuItem1.Name = "systemToolStripMenuItem1";
            this.systemToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.systemToolStripMenuItem1.Text = "System";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Image = global::StandardScada.Properties.Resources.login;
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Image = global::StandardScada.Properties.Resources.logout;
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // autoToolStripMenuItem
            // 
            this.autoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onToolStripMenuItem,
            this.offToolStripMenuItem});
            this.autoToolStripMenuItem.Name = "autoToolStripMenuItem";
            this.autoToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.autoToolStripMenuItem.Text = "Auto";
            // 
            // onToolStripMenuItem
            // 
            this.onToolStripMenuItem.Image = global::StandardScada.Properties.Resources.camera_test;
            this.onToolStripMenuItem.Name = "onToolStripMenuItem";
            this.onToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.onToolStripMenuItem.Text = "On";
            // 
            // offToolStripMenuItem
            // 
            this.offToolStripMenuItem.Image = global::StandardScada.Properties.Resources.button_cancel;
            this.offToolStripMenuItem.Name = "offToolStripMenuItem";
            this.offToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.offToolStripMenuItem.Text = "Off";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.runToolStripMenuItem.Text = "Run";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Image = global::StandardScada.Properties.Resources.camera_test;
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Image = global::StandardScada.Properties.Resources.exit;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            // 
            // alarmToolStripMenuItem
            // 
            this.alarmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sQLToolStripMenuItem,
            this.pLCToolStripMenuItem});
            this.alarmToolStripMenuItem.Name = "alarmToolStripMenuItem";
            this.alarmToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.alarmToolStripMenuItem.Text = "Alarm";
            // 
            // sQLToolStripMenuItem
            // 
            this.sQLToolStripMenuItem.Image = global::StandardScada.Properties.Resources.server;
            this.sQLToolStripMenuItem.Name = "sQLToolStripMenuItem";
            this.sQLToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.sQLToolStripMenuItem.Text = "SQL";
            this.sQLToolStripMenuItem.Click += new System.EventHandler(this.sQLToolStripMenuItem_Click);
            // 
            // pLCToolStripMenuItem
            // 
            this.pLCToolStripMenuItem.Image = global::StandardScada.Properties.Resources.machine;
            this.pLCToolStripMenuItem.Name = "pLCToolStripMenuItem";
            this.pLCToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.pLCToolStripMenuItem.Text = "PLC";
            this.pLCToolStripMenuItem.Click += new System.EventHandler(this.pLCToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.documentsToolStripMenuItem,
            this.standardToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::StandardScada.Properties.Resources.help;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // documentsToolStripMenuItem
            // 
            this.documentsToolStripMenuItem.Image = global::StandardScada.Properties.Resources.document_notes;
            this.documentsToolStripMenuItem.Name = "documentsToolStripMenuItem";
            this.documentsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.documentsToolStripMenuItem.Text = "Documents";
            this.documentsToolStripMenuItem.Click += new System.EventHandler(this.documentsToolStripMenuItem_Click);
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.standardToolStripMenuItem.Text = "Standard";
            this.standardToolStripMenuItem.Click += new System.EventHandler(this.standardToolStripMenuItem_Click);
            // 
            // ss1
            // 
            this.ss1.BackColor = System.Drawing.Color.Aqua;
            this.ss1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPLCStatus,
            this.tsD,
            this.tsVersionStatus,
            this.toolStripStatusLabel1});
            this.ss1.Location = new System.Drawing.Point(0, 669);
            this.ss1.Name = "ss1";
            this.ss1.Size = new System.Drawing.Size(1284, 22);
            this.ss1.TabIndex = 1;
            this.ss1.Text = "statusStrip1";
            // 
            // tsPLCStatus
            // 
            this.tsPLCStatus.AutoSize = false;
            this.tsPLCStatus.BackColor = System.Drawing.Color.Aqua;
            this.tsPLCStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsPLCStatus.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsPLCStatus.Name = "tsPLCStatus";
            this.tsPLCStatus.Size = new System.Drawing.Size(250, 17);
            this.tsPLCStatus.Text = "PLC Stop";
            // 
            // tsD
            // 
            this.tsD.AutoSize = false;
            this.tsD.BackColor = System.Drawing.Color.Aqua;
            this.tsD.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.tsD.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsD.Name = "tsD";
            this.tsD.Size = new System.Drawing.Size(250, 17);
            this.tsD.Text = "Admin";
            // 
            // tsVersionStatus
            // 
            this.tsVersionStatus.AutoSize = false;
            this.tsVersionStatus.BackColor = System.Drawing.Color.Aqua;
            this.tsVersionStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.tsVersionStatus.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsVersionStatus.Name = "tsVersionStatus";
            this.tsVersionStatus.Size = new System.Drawing.Size(250, 17);
            this.tsVersionStatus.Text = "Version: 2020.09.02";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(84, 17);
            this.toolStripStatusLabel1.Text = "duy le HCMUT";
            // 
            // timerMain
            // 
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // sdMotorDH
            // 
            this.sdMotorDH.AnalogIntValue1 = ((short)(0));
            this.sdMotorDH.AnalogValue1 = 0D;
            this.sdMotorDH.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.sdMotorDH.BackColor = System.Drawing.Color.Transparent;
            this.sdMotorDH.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.sdMotorDH.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(64))))), "Band1"));
            this.sdMotorDH.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Silver, "Band2"));
            this.sdMotorDH.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Red, "Band3"));
            this.sdMotorDH.BlinkColor = System.Drawing.Color.Red;
            this.sdMotorDH.Category = "1PMP.cat2";
            this.sdMotorDH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sdMotorDH.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("sdMotorDH.DebugData"));
            this.sdMotorDH.FillColor = System.Drawing.Color.Silver;
            this.sdMotorDH.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Shaded;
            this.sdMotorDH.Location = new System.Drawing.Point(76, 78);
            this.sdMotorDH.Name = "sdMotorDH";
            this.sdMotorDH.Size = new System.Drawing.Size(161, 121);
            this.sdMotorDH.SymbolHandle = ((long)(1852304797));
            this.sdMotorDH.TabIndex = 2;
            this.sdMotorDH.Click += new System.EventHandler(this.sdMotor1_Click);
            // 
            // sdMotorCA
            // 
            this.sdMotorCA.AnalogIntValue1 = ((short)(0));
            this.sdMotorCA.AnalogValue1 = 0D;
            this.sdMotorCA.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.sdMotorCA.BackColor = System.Drawing.Color.Transparent;
            this.sdMotorCA.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.sdMotorCA.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(64))))), "Band1"));
            this.sdMotorCA.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Silver, "Band2"));
            this.sdMotorCA.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Red, "Band3"));
            this.sdMotorCA.BlinkColor = System.Drawing.Color.Red;
            this.sdMotorCA.Category = "1PMP.cat2";
            this.sdMotorCA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sdMotorCA.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("sdMotorCA.DebugData"));
            this.sdMotorCA.FillColor = System.Drawing.Color.Silver;
            this.sdMotorCA.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Shaded;
            this.sdMotorCA.Location = new System.Drawing.Point(337, 78);
            this.sdMotorCA.Name = "sdMotorCA";
            this.sdMotorCA.Size = new System.Drawing.Size(161, 121);
            this.sdMotorCA.SymbolHandle = ((long)(1852304797));
            this.sdMotorCA.TabIndex = 3;
            this.sdMotorCA.Click += new System.EventHandler(this.sdMotorCA_Click);
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.statusToolStripMenuItem.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "PS 102";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(388, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "PS 103";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "1234";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(388, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "1234";
            // 
            // frMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1284, 691);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sdMotorCA);
            this.Controls.Add(this.sdMotorDH);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.mn1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mn1;
            this.MaximizeBox = false;
            this.Name = "frMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StandardScada";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frMain_FormClosing);
            this.Load += new System.EventHandler(this.frMain_Load);
            this.mn1.ResumeLayout(false);
            this.mn1.PerformLayout();
            this.ss1.ResumeLayout(false);
            this.ss1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sdMotorDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdMotorCA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mn1;
        private System.Windows.Forms.StatusStrip ss1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem communicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alarmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eqToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pLCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tsPLCStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsD;
        private System.Windows.Forms.ToolStripStatusLabel tsVersionStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentsToolStripMenuItem;
        private System.Windows.Forms.Timer timerMain;
        private SymbolFactoryDotNet.StandardControl sdMotorDH;
        private SymbolFactoryDotNet.StandardControl sdMotorCA;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

