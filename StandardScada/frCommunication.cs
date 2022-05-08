using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandardScada
{
    public partial class frCommunication : Form
    {
        public frCommunication()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e) // close
        {
            this.Close();
        }

        private void frCommunication_Load(object sender, EventArgs e)
        {   
            // Địa chỉ IP PLC
            txtPLCIP.Text = Properties.Settings.Default.IPPLC;
            // SQL
            txtSQL.Text = Properties.Settings.Default.SQL;
            // Excel
            txtExcel.Text = Properties.Settings.Default.Excel;
            // Update
            txtUpdate.Text = Properties.Settings.Default.Update.ToString();
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Địa chỉ IP PLC
            Properties.Settings.Default.IPPLC = txtPLCIP.Text;
            // SQL
             Properties.Settings.Default.SQL = txtSQL.Text;
            // Excel
             Properties.Settings.Default.Excel = txtExcel.Text;
            // Update
            Properties.Settings.Default.Update = int.Parse(txtUpdate.Text);
            // Thông báo
            MessageBox.Show("Lưu thành công, Vui lòng Reset lại chương trình!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if(txtAdmin.Text.Equals("duy123")) // Enable các tag nếu nhập mật khẩu đúng
            {
                txtExcel.Enabled = true;
                txtPLCIP.Enabled = true;
                txtSQL.Enabled = true;
                txtUpdate.Enabled = true;
                // Đổi màu và cho phép điều chỉnh
                txtExcel.BackColor = Color.White;
                txtPLCIP.BackColor = Color.White;
                txtSQL.BackColor = Color.White;
                txtUpdate.BackColor = Color.White;


            }
        }
    }
}
