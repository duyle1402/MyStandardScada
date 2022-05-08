using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace StandardScada
{
    public partial class frLogin : Form
    {
        string User = "";
        string PassWord = "";
        public frLogin()
        {
            InitializeComponent();
        }

      
        private void Show()
        {
            frMain _Show = new frMain();
            _Show.ShowDialog();

        }

        private void frLogin_Load(object sender, EventArgs e) 
        {
            if(Properties.Settings.Default.Remember)
            {
                cbRemember.Checked = true;
                txtUser.Text = Properties.Settings.Default.User;
                txtPassWord.Text = Properties.Settings.Default.PassWord;
            }
            else
            {
                cbRemember.Checked = false;
                txtUser.Text = "";
                txtPassWord.Text = "";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User = Properties.Settings.Default.User;
            PassWord = Properties.Settings.Default.PassWord;
            if (User.Equals(txtUser.Text) && PassWord.Equals(txtPassWord.Text)) // kiểm tra id và pass
            {
                if (cbRemember.Checked) // check đc check
                {
                    Properties.Settings.Default.Remember = true;
                }
                else // ngược lại
                {
                    Properties.Settings.Default.Remember = false;
                }
                Properties.Settings.Default.Save();

                Thread _Thread = new Thread(new ThreadStart(Show));
                _Thread.Start();
                this.Close(); // Đóng form Login
            }
            else
            {
                MessageBox.Show("Login Error!");
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            User = Properties.Settings.Default.User;
            PassWord = Properties.Settings.Default.PassWord;

            if (btnChange.Text == "Change")
            {
                if (User.Equals(txtUser.Text) && PassWord.Equals(txtPassWord.Text))
                {
                    MessageBox.Show("Vui lòng nhập User PassWord mới");
                    lbUser.Text = "NewID";
                    lbPassWord.Text = "New Pass";
                    txtUser.Text = "";
                    txtPassWord.Text = "";
                    btnChange.Text = "Save";
                }
                else
                {
                    MessageBox.Show("Error, Vui lòng nhập ID và Pass cũ", "Thay đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else // save
            {
                Properties.Settings.Default.User = txtUser.Text;
                Properties.Settings.Default.PassWord = txtPassWord.Text;
                Properties.Settings.Default.Save();
                lbUser.Text = "User";
                lbPassWord.Text = "Key";
                txtUser.Text = "";
                txtPassWord.Text = "";
                btnChange.Text = "Change";

                MessageBox.Show("Lưu thành công!");

            }
        }

       

       

        private void iconExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
