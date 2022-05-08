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
    public partial class frAlarmSQL : Form
    {
        public frAlarmSQL()
        {
            InitializeComponent();
        }

        private void frAlarmSQL_Load(object sender, EventArgs e)
        {
            if (SQL.Instance().SQL_Connected) // Kiểm tra kết nối giữa SQL và C# đã được chưa
            {
                lbAlarm.BackColor = Color.Green;
                lbAlarm.Text = "SQL Running!";
            }
            else
            {
                lbAlarm.BackColor = Color.Red;
                lbAlarm.Text = "SQL Stopping!";
            }
        }
    }
}
