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
    public partial class frHistoryStatus : Form
    {
        public frHistoryStatus()
        {
            InitializeComponent();
        }

        private void frHistory_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e) // nhấn search để hiển thị
        {
            SQL.Instance().Query_Status(monthCalendar1.SelectionRange.Start, monthCalendar1.SelectionRange.End); // gọi hàm truy xuất dữ liệu và đưa ngày tháng bắt đầu và kết thúc vào
            dgv1.DataSource = SQL.Instance().dt_Status; // đưa dữ liệu vào dgv để hiển thị

           
        }
    }
}
