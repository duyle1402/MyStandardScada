using SymbolFactoryDotNet;
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
    public partial class frManMotor1 : Form
    {
        public frManMotor1()
        {
            InitializeComponent();
        }

        private void frManMotor1_Load(object sender, EventArgs e)
        {
            if(PLC.Instance().PLC_Connected)
            {
                timerMan.Interval = 100;
                timerMan.Enabled = true;
              Show_Data_Time_txt(txtSPON, PLC_DB102_RetainWrite.Instance().SP_ON_Bom_DH);
              Show_Data_Time_txt(txtSPOFF, PLC_DB102_RetainWrite.Instance().SP_OFF_Bom_DH);

            }
        }

        private void btnAuto_MouseDown(object sender, MouseEventArgs e) // set hoặc reset bit auto/man
        {
            if(!PLC_DB101Write.Instance().Auto_Man_Bom_DH)
            {
                PLC.Instance().SetBit("DB101.DBX0.0");

            }
            else
            {
                PLC.Instance().ResetBit("DB101.DBX0.0");
            }
        }

        private void btnStart_MouseDown(object sender, MouseEventArgs e) // nhấn vào button start, set bit lên 1
        {
            PLC.Instance().SetBit("DB101.DBX0.1");
        }

        private void btnStart_MouseUp(object sender, MouseEventArgs e) // nhả nút start, reset bit về 0
        {
            PLC.Instance().ResetBit("DB101.DBX0.1");
        }

        private void btnStop_MouseDown(object sender, MouseEventArgs e) // nhấn nút stop, set bit stop lên 1
        {
            PLC.Instance().SetBit("DB101.DBX0.2");
        }

        private void btnStop_MouseUp(object sender, MouseEventArgs e) // nhả nút stop, reset bit stop về 0
        {
            PLC.Instance().ResetBit("DB101.DBX0.2");
        }

        private void ON_OFF_button(Button btn, bool Value)
        {
            if(Value)
            {
                btn.BackColor = Color.Green;
            }
            else
            {
                btn.BackColor = Color.Silver;
            }
        }
    private void timerMan_Tick(object sender, EventArgs e)
        {
            ON_OFF_button(btnAuto, PLC_DB101Write.Instance().Auto_Man_Bom_DH); // gọi hàm trạng thái button automan
            ON_OFF_button(btnStart, PLC_DB101Write.Instance().Start_Man_Bom_DH); // gọi hàm trạng thái button start
            ON_OFF_button(btnStop, PLC_DB101Write.Instance().Stop_Man_Bom_DH); // gọi hàm trạng thái button stop
            ON_OFF_ALARM(sdMotor1, PLC_DB100Read.Instance().output_Bom_DH, PLC_DB100Read.Instance().Error_Bom_DH); // gọi hàm trạng thái của bơm điều hoà
            Show_Data_Time_txt(txtPVON, PLC_DB100Read.Instance().PV_ON_Bom_DH); // show thời gian pv on
            Show_Data_Time_txt(txtPVOFF, PLC_DB100Read.Instance().PV_OFF_Bom_DH); // show thời gian pv off
            Show_Data_Double_txt(txtRunTime, PLC_DB100Read.Instance().Time_Run_Bom_DH); // show thời gian run time
            
        }


        private void ON_OFF_ALARM(StandardControl sd, bool Output, bool Error) // hàm hiển thị trạng thái của bơm

        {
            if (!Error) // không lỗi
            {
                if (Output) // ON
                {
                    sd.DiscreteValue1 = true;
                    sd.DiscreteValue2 = false;
                    sd.DiscreteValue3 = false;

                }
                else // OFF
                {
                    sd.DiscreteValue1 = false;
                    sd.DiscreteValue2 = true;
                    sd.DiscreteValue3 = false;
                }
            }
            else // có lỗi
            {
                sd.DiscreteValue1 = false;
                sd.DiscreteValue2 = false;
                sd.DiscreteValue3 = true;
            }
        }

        private void Write_Data_Time_txt( string Address, TextBox txt) //  hàm ghi dữ liệu từ txt xuống plc
        {
            if(txt.Text != "")
            {
                PLC.Instance().WriteTime(Address, int.Parse(txt.Text)*1000);
            }
           
        }
        private void Show_Data_Time_txt( TextBox txt, int Value) // hàm show data time
        {
            txt.Text = (Value / 1000).ToString();
        }
        private void Show_Data_Double_txt(TextBox txt, double Value) // hàm show data run time
        {
            txt.Text = Value.ToString("0.0000");
        }

        private void txtSPON_KeyDown(object sender, KeyEventArgs e) 
        {
            if(e.KeyCode == Keys.Enter)
            {
                Write_Data_Time_txt("DB102.DBD0", txtSPON);
            }
        }

        private void txtSPOFF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Write_Data_Time_txt("DB102.DBD4", txtSPOFF);
            }
        }

        private void frManMotor1_FormClosing(object sender, FormClosingEventArgs e) // giải phóng tài nguyên, dừng timmer
        {
            timerMan.Enabled = false;
        }
    }
}
