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
    public partial class frAlarmPLC : Form
    {
        public frAlarmPLC()
        {
            InitializeComponent();
        }

        private void frAlarmPLC_Load(object sender, EventArgs e)
        {
            if(PLC.Instance().PLC_Connected) // Kiểm tra kết nối giữa plc và C# đã được chưa
            {
                lbAlarm.BackColor = Color.Green;
                lbAlarm.Text = "PLC Running!";
            }
            else
            {
                lbAlarm.BackColor = Color.Red;
                lbAlarm.Text = "PLC Stopping!";
            }
        }
    }
}
