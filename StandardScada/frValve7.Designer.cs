namespace StandardScada
{
    partial class frValve7
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
            this.btnOff = new System.Windows.Forms.Button();
            this.btnOn = new System.Windows.Forms.Button();
            this.btnMan = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOff
            // 
            this.btnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOff.Location = new System.Drawing.Point(171, 117);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(75, 23);
            this.btnOff.TabIndex = 23;
            this.btnOff.Text = "Off";
            this.btnOff.UseVisualStyleBackColor = true;
            // 
            // btnOn
            // 
            this.btnOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOn.Location = new System.Drawing.Point(53, 117);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(75, 23);
            this.btnOn.TabIndex = 22;
            this.btnOn.Text = "On";
            this.btnOn.UseVisualStyleBackColor = true;
            // 
            // btnMan
            // 
            this.btnMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMan.Location = new System.Drawing.Point(171, 50);
            this.btnMan.Name = "btnMan";
            this.btnMan.Size = new System.Drawing.Size(75, 23);
            this.btnMan.TabIndex = 21;
            this.btnMan.Text = "Man";
            this.btnMan.UseVisualStyleBackColor = true;
            // 
            // btnAuto
            // 
            this.btnAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuto.Location = new System.Drawing.Point(53, 50);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(75, 23);
            this.btnAuto.TabIndex = 20;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = true;
            // 
            // frValve7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(298, 190);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.btnMan);
            this.Controls.Add(this.btnAuto);
            this.Name = "frValve7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valve7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Button btnMan;
        private System.Windows.Forms.Button btnAuto;
    }
}