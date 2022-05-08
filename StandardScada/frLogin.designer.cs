namespace StandardScada
{
    partial class frLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frLogin));
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.cbRemember = new System.Windows.Forms.CheckBox();
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.btnChange = new FontAwesome.Sharp.IconButton();
            this.lbUser = new FontAwesome.Sharp.IconButton();
            this.lbPassWord = new FontAwesome.Sharp.IconButton();
            this.iconExit = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(392, 168);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(179, 31);
            this.txtUser.TabIndex = 0;
            // 
            // txtPassWord
            // 
            this.txtPassWord.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWord.Location = new System.Drawing.Point(392, 214);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(179, 31);
            this.txtPassWord.TabIndex = 1;
            // 
            // cbRemember
            // 
            this.cbRemember.AutoSize = true;
            this.cbRemember.Location = new System.Drawing.Point(393, 256);
            this.cbRemember.Name = "cbRemember";
            this.cbRemember.Size = new System.Drawing.Size(77, 17);
            this.cbRemember.TabIndex = 8;
            this.cbRemember.Text = "Remember";
            this.cbRemember.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnLogin.IconColor = System.Drawing.Color.White;
            this.btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogin.IconSize = 34;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnLogin.Location = new System.Drawing.Point(449, 278);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(132, 42);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.Black;
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnChange.IconColor = System.Drawing.Color.White;
            this.btnChange.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChange.IconSize = 34;
            this.btnChange.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnChange.Location = new System.Drawing.Point(297, 279);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(149, 40);
            this.btnChange.TabIndex = 11;
            this.btnChange.Text = "Change";
            this.btnChange.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lbUser
            // 
            this.lbUser.BackColor = System.Drawing.Color.Black;
            this.lbUser.FlatAppearance.BorderSize = 0;
            this.lbUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.ForeColor = System.Drawing.Color.White;
            this.lbUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.lbUser.IconColor = System.Drawing.Color.White;
            this.lbUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.lbUser.IconSize = 34;
            this.lbUser.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbUser.Location = new System.Drawing.Point(227, 168);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(157, 42);
            this.lbUser.TabIndex = 12;
            this.lbUser.Text = "User";
            this.lbUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbUser.UseVisualStyleBackColor = false;
            // 
            // lbPassWord
            // 
            this.lbPassWord.BackColor = System.Drawing.Color.Black;
            this.lbPassWord.FlatAppearance.BorderSize = 0;
            this.lbPassWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassWord.ForeColor = System.Drawing.Color.White;
            this.lbPassWord.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.lbPassWord.IconColor = System.Drawing.Color.White;
            this.lbPassWord.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.lbPassWord.IconSize = 34;
            this.lbPassWord.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbPassWord.Location = new System.Drawing.Point(227, 211);
            this.lbPassWord.Name = "lbPassWord";
            this.lbPassWord.Size = new System.Drawing.Size(157, 42);
            this.lbPassWord.TabIndex = 13;
            this.lbPassWord.Text = "Key";
            this.lbPassWord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbPassWord.UseVisualStyleBackColor = false;
            // 
            // iconExit
            // 
            this.iconExit.BackColor = System.Drawing.Color.Black;
            this.iconExit.FlatAppearance.BorderSize = 0;
            this.iconExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconExit.ForeColor = System.Drawing.Color.White;
            this.iconExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iconExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconExit.IconSize = 34;
            this.iconExit.Location = new System.Drawing.Point(555, -1);
            this.iconExit.Name = "iconExit";
            this.iconExit.Size = new System.Drawing.Size(38, 28);
            this.iconExit.TabIndex = 16;
            this.iconExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconExit.UseVisualStyleBackColor = false;
            this.iconExit.Click += new System.EventHandler(this.iconExit_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 220;
            this.iconPictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("iconPictureBox1.InitialImage")));
            this.iconPictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(220, 361);
            this.iconPictureBox1.TabIndex = 17;
            this.iconPictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pictureBox2.Image = global::StandardScada.Properties.Resources._1200px_Logo_hcmut_svg;
            this.pictureBox2.Location = new System.Drawing.Point(21, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(168, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Black;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 34;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.iconButton1.Location = new System.Drawing.Point(30, 27);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(168, 40);
            this.iconButton1.TabIndex = 19;
            this.iconButton1.Text = "SCADA";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Black;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Connectdevelop;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 34;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.iconButton2.Location = new System.Drawing.Point(236, 111);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(287, 40);
            this.iconButton2.TabIndex = 20;
            this.iconButton2.Text = "Login to your Account";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.Black;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Copyright;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 23;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.iconButton3.Location = new System.Drawing.Point(28, 324);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(163, 34);
            this.iconButton3.TabIndex = 21;
            this.iconButton3.Text = "Copyright by duy le";
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.Black;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 23;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.iconButton4.Location = new System.Drawing.Point(61, 178);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(101, 34);
            this.iconButton4.TabIndex = 22;
            this.iconButton4.Text = "LVTN";
            this.iconButton4.UseVisualStyleBackColor = false;
            // 
            // frLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.ControlBox = false;
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.iconExit);
            this.Controls.Add(this.lbPassWord);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cbRemember);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.CheckBox cbRemember;
        private FontAwesome.Sharp.IconButton btnLogin;
        private FontAwesome.Sharp.IconButton btnChange;
        private FontAwesome.Sharp.IconButton lbUser;
        private FontAwesome.Sharp.IconButton lbPassWord;
        private FontAwesome.Sharp.IconButton iconExit;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
    }
}