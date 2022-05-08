namespace StandardScada
{
    partial class frManMotorCA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frManMotorCA));
            this.btnAuto = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtSPON = new System.Windows.Forms.TextBox();
            this.txtSPOFF = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sdMotor1 = new SymbolFactoryDotNet.StandardControl();
            this.txtPVON = new System.Windows.Forms.TextBox();
            this.txtPVOFF = new System.Windows.Forms.TextBox();
            this.txtRunTime = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.timerMan = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sdMotor1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(14, 44);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(83, 33);
            this.btnAuto.TabIndex = 0;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAuto_MouseDown);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(14, 80);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(83, 33);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnStart_MouseDown);
            this.btnStart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStart_MouseUp);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(14, 117);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(83, 33);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnStop_MouseDown);
            this.btnStop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStop_MouseUp);
            // 
            // txtSPON
            // 
            this.txtSPON.Location = new System.Drawing.Point(14, 155);
            this.txtSPON.Multiline = true;
            this.txtSPON.Name = "txtSPON";
            this.txtSPON.Size = new System.Drawing.Size(83, 22);
            this.txtSPON.TabIndex = 3;
            this.txtSPON.Text = "****";
            this.txtSPON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSPON.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSPON_KeyDown);
            // 
            // txtSPOFF
            // 
            this.txtSPOFF.Location = new System.Drawing.Point(14, 183);
            this.txtSPOFF.Multiline = true;
            this.txtSPOFF.Name = "txtSPOFF";
            this.txtSPOFF.Size = new System.Drawing.Size(83, 22);
            this.txtSPOFF.TabIndex = 4;
            this.txtSPOFF.Text = "****";
            this.txtSPOFF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSPOFF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSPOFF_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(103, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 167);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(80, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Time Run";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(106, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Error";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "PV OFF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "PV ON";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Output";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sp OFF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "SP ON";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stop Man";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Man";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auto/ Man";
            // 
            // sdMotor1
            // 
            this.sdMotor1.AnalogIntValue1 = ((short)(0));
            this.sdMotor1.AnalogValue1 = 0D;
            this.sdMotor1.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.sdMotor1.BackColor = System.Drawing.Color.Transparent;
            this.sdMotor1.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.sdMotor1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(64))))), "Band1"));
            this.sdMotor1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(80D, 80, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Silver, "Band2"));
            this.sdMotor1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Red, "Band3"));
            this.sdMotor1.BlinkColor = System.Drawing.Color.Red;
            this.sdMotor1.Category = "1PMP.cat2";
            this.sdMotor1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sdMotor1.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("sdMotor1.DebugData"));
            this.sdMotor1.FillColor = System.Drawing.Color.Silver;
            this.sdMotor1.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Shaded;
            this.sdMotor1.Location = new System.Drawing.Point(268, 28);
            this.sdMotor1.Name = "sdMotor1";
            this.sdMotor1.Size = new System.Drawing.Size(114, 92);
            this.sdMotor1.SymbolHandle = ((long)(1852304797));
            this.sdMotor1.TabIndex = 6;
            // 
            // txtPVON
            // 
            this.txtPVON.Location = new System.Drawing.Point(268, 121);
            this.txtPVON.Multiline = true;
            this.txtPVON.Name = "txtPVON";
            this.txtPVON.Size = new System.Drawing.Size(83, 19);
            this.txtPVON.TabIndex = 7;
            this.txtPVON.Text = "****";
            this.txtPVON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPVOFF
            // 
            this.txtPVOFF.Location = new System.Drawing.Point(268, 154);
            this.txtPVOFF.Multiline = true;
            this.txtPVOFF.Name = "txtPVOFF";
            this.txtPVOFF.Size = new System.Drawing.Size(83, 19);
            this.txtPVOFF.TabIndex = 8;
            this.txtPVOFF.Text = "****";
            this.txtPVOFF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRunTime
            // 
            this.txtRunTime.Location = new System.Drawing.Point(268, 183);
            this.txtRunTime.Multiline = true;
            this.txtRunTime.Name = "txtRunTime";
            this.txtRunTime.Size = new System.Drawing.Size(83, 19);
            this.txtRunTime.TabIndex = 9;
            this.txtRunTime.Text = "****";
            this.txtRunTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Teal;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(103, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 26);
            this.label11.TabIndex = 10;
            this.label11.Text = "Bơm Cao Áp";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerMan
            // 
            this.timerMan.Tick += new System.EventHandler(this.timerMan_Tick);
            // 
            // frManMotorCA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(393, 222);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtRunTime);
            this.Controls.Add(this.txtPVOFF);
            this.Controls.Add(this.txtPVON);
            this.Controls.Add(this.sdMotor1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSPOFF);
            this.Controls.Add(this.txtSPON);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnAuto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frManMotorCA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManMotorCA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frManMotor1_FormClosing);
            this.Load += new System.EventHandler(this.frManMotor1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sdMotor1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAuto;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtSPON;
        private System.Windows.Forms.TextBox txtSPOFF;
        private System.Windows.Forms.GroupBox groupBox1;
        private SymbolFactoryDotNet.StandardControl sdMotor1;
        private System.Windows.Forms.TextBox txtPVON;
        private System.Windows.Forms.TextBox txtPVOFF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRunTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer timerMan;
    }
}