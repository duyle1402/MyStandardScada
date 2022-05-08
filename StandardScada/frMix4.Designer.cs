namespace StandardScada
{
    partial class frMix4
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
            this.txtPVU = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSPU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerMan = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtPVU
            // 
            this.txtPVU.Location = new System.Drawing.Point(200, 81);
            this.txtPVU.Name = "txtPVU";
            this.txtPVU.Size = new System.Drawing.Size(81, 20);
            this.txtPVU.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = " Time Ủ";
            // 
            // txtSPU
            // 
            this.txtSPU.Location = new System.Drawing.Point(109, 81);
            this.txtSPU.Name = "txtSPU";
            this.txtSPU.Size = new System.Drawing.Size(81, 20);
            this.txtSPU.TabIndex = 21;
            this.txtSPU.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSPU_KeyDown);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "PV";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "SP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timerMan
            // 
            this.timerMan.Tick += new System.EventHandler(this.timerMan_Tick);
            // 
            // frMix4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPVU);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSPU);
            this.Name = "frMix4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mix4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frMix4_FormClosed);
            this.Load += new System.EventHandler(this.frMix4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPVU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSPU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerMan;
    }
}