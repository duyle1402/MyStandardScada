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
    public partial class frParameter : Form
    {
        public frParameter()
        {
            InitializeComponent();
        }

       
        private void frParameter_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Đã lưu thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
