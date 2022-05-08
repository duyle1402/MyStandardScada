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
    public partial class frMix1 : Form
    {
        public frMix1()
        {
            InitializeComponent();
        }

        private void frMix1_Load(object sender, EventArgs e)
        {
            if (PLC.Instance().PLC_Connected)
            {
                timerMan.Interval = 100;
                timerMan.Enabled = true;
                // show SP trộn
                Show_Data_Time_txt(txtSPMix1, PLC_DB101Write.Instance().Mix1_SP);

            }
        }


        private void timerMan_Tick(object sender, EventArgs e)
        {
           
            // show PV trộn
            Show_Data_Time_txt(txtPVMix1, PLC_DB100Read.Instance().Mix1_PV);

        }

        // ghi dữ liệu từ txt xuống plc
        private void txtSPMix1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               Write_Data_Time_txt("DB101.DBD8", txtSPMix1);  // ghi dữ liệu xuống SP của mix 1
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

        //private void Show_Data_Time_Nguoc_txt(TextBox txt, int Value , int SP) // hàm show data time
        //{
            
        //    txt.Text = ((SP - Value )/ 1000).ToString();
        //}

        private void Show_Data_Double_txt(TextBox txt, double Value) // hàm show data double
        {
            txt.Text = Value.ToString("0.0000");
        }






       
        private void frMix1_FormClosed(object sender, FormClosedEventArgs e) // giải phóng tài nguyên
        {
            timerMan.Enabled = false;
        }

       
    }
}
