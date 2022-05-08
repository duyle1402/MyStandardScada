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
    public partial class frEquipment : Form
    {
        public frEquipment()
        {
            InitializeComponent();
        }

        private void frEquipment_Load(object sender, EventArgs e)
        {
            // Form này chứa thông tin về thời gian chạy của thiết bị, mục đích để quản lý tập trung dù trong hàm main đã có đầy đủ
            //Show_TimeRun(lbCA, PLC_DB100Read.Instance().Time_Run_Bom_CA);
            //Show_TimeRun(lbDH, PLC_DB100Read.Instance().Time_Run_Bom_DH);
        }
        private void Show_TimeRun(Label lb, double Value)
        {
            lb.Text = Value.ToString("0.00");
        }
    }
}
