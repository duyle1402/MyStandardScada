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
    public partial class frMotor : Form
    {
        public frMotor()
        {
            InitializeComponent();
        }

        private void frMotor_Load(object sender, EventArgs e)
        {
            if (PLC.Instance().PLC_Connected)
            {
                timerMan.Interval = 100;
                timerMan.Enabled = true;
                // show SP trộn
                Show_Data_Time_txt(txtSPTron, PLC_DB101Write.Instance().Motor_SP_Tron);
                
            }
        }


        private void timerMan_Tick(object sender, EventArgs e)
        {
            // show PV trộn
            Show_Data_Time_txt(txtPVTron, PLC_DB100Read.Instance().Motor_PV_Tron);
           
        }

        private void txtSPTron_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Write_Data_Time_txt("DB101.DBD32", txtSPTron);  // ghi dữ liệu xuống SP trộn của motor
            }
        }

        



        private void Write_Data_Time_txt(string Address, TextBox txt) //  hàm ghi dữ liệu từ txt xuống plc
        {
            if (txt.Text != "")
            {
                PLC.Instance().WriteTime(Address, int.Parse(txt.Text) * 1000);
            }

        }

        private void Show_Data_Time_txt(TextBox txt, int Value) // hàm show data time
        {
            txt.Text = (Value / 1000).ToString();
        }
        private void Show_Data_Double_txt(TextBox txt, double Value) // hàm show data double
        {
            txt.Text = Value.ToString("0.0000");
        }

        // giải phóng tài nguyên
        private void frMotor_FormClosed(object sender, FormClosedEventArgs e)
        {
            timerMan.Enabled = false;
        }

       
    }
}
