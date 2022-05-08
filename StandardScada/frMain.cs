using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SymbolFactoryDotNet;
using System.Threading;

namespace StandardScada
{
    public partial class frMain : Form
    {

        int counter_Status = 0; // counter là biến để xác định thời gian cập nhật dữ liệu lên database, ở đây trạng thái bơm là 1s, cập nhật data thì từ 3-5 phút
        int counter_Data = 0;
        public frMain()
        {
            InitializeComponent();
        }
        
        private void frMain_Load(object sender, EventArgs e)
        {
            SQL.Instance().TestConnection();

        }
        #region  Menu

        private void frMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void communicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frCommunication _frShow = new frCommunication();
            _frShow.ShowDialog();
        }

        private void parametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frParameter _frShow = new frParameter();
            _frShow.ShowDialog();
        }

        private void eqToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frEquipment _frShow = new frEquipment();
            _frShow.ShowDialog();
        }

        private void chartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frChart _frShow = new frChart();
            _frShow.ShowDialog();
            
        }

        private void historyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frHistoryStatus _frShow = new frHistoryStatus();
            _frShow.ShowDialog();
        }

        private void dataMenuItem_Click(object sender, EventArgs e)
        {
            frHistoryData _frShow = new frHistoryData();
            _frShow.ShowDialog();
        }
        
        private void sQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frAlarmSQL _frShow = new frAlarmSQL();
            _frShow.ShowDialog();
        }

        private void pLCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frAlarmPLC _frShow = new frAlarmPLC();
            _frShow.ShowDialog();
        }

        private void documentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frDocuments _frShow = new frDocuments();
            _frShow.ShowDialog();
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frStandard _frShow = new frStandard();
            _frShow.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frAbout _frShow = new frAbout();
            _frShow.ShowDialog();
        }
        #endregion

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PLC.Instance().Open())
            {

                MessageBox.Show("Kết nối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                tsPLCStatus.Text = "PLC Running";
                timerMain.Interval = 100;
                timerMain.Enabled = true;
            }
            else
            {
                
                MessageBox.Show("Kết nối không thành công!Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                
                tsPLCStatus.Text = "PLC Stop";
            }
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã ngắt kết nối PLC", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            PLC.Instance().Close();
       
            tsPLCStatus.Text = "PLC Stop";
            timerMain.Enabled = false;
        }

        // Dừng hệ thống hoạt động 

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PLC.Instance().Open())
            {
                PLC.Instance().ResetBit("DB101.DBX0.5");
                PLC.Instance().ResetBit("DB101.DBX0.0");
                MessageBox.Show("Đã dừng hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thao tác không thành công, vui lòng kiểm tra lại các kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        // Run hệ thống hoạt động, set bit Run chạy
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(PLC.Instance().Open())
            {
                PLC.Instance().SetBit("DB101.DBX0.5");
                MessageBox.Show("Hệ thống đang chạy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thao tác không thành công, vui lòng kiểm tra lại các kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        
        // kích hoạt chế độ Auto
        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PLC.Instance().Open())
            {
                PLC.Instance().SetBit("DB101.DBX0.3");
                PLC.Instance().ResetBit("DB101.DBX0.4");
                MessageBox.Show("Chế độ Auto đã hoạt động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thao tác không thành công, vui lòng kiểm tra lại các kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        // dừng chế độ Auto
        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PLC.Instance().Open())
            {
                PLC.Instance().SetBit("DB101.DBX0.4");
                PLC.Instance().ResetBit("DB101.DBX0.3");
                MessageBox.Show("Chế độ Auto đã dừng hoạt động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thao tác không thành công, vui lòng kiểm tra lại các kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // dừng hệ thống , nhấn nút Stop

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (PLC.Instance().Open())
            {
                PLC.Instance().SetBit("DB101.DBX0.0");

                
                MessageBox.Show("Hệ thống hoạt động hết chu trình sẽ dừng lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thao tác không thành công, vui lòng kiểm tra lại các kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // Khẩn cấp emergency
        private void btnEmergency_Click(object sender, EventArgs e)
        {
            if (PLC.Instance().Open())
            {
                PLC.Instance().SetBit("DB101.DBX0.1");
                PLC.Instance().ResetBit("DB101.DBX0.5");

                MessageBox.Show("Hệ thống đã dừng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thao tác không thành công, vui lòng kiểm tra lại các kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // reset lại hệ thống
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (PLC.Instance().Open())
            {
                PLC.Instance().ResetBit("DB101.DBX0.1");
                
                MessageBox.Show("Đã Reset hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thao tác không thành công, vui lòng kiểm tra lại các kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




        private void timerMain_Tick(object sender, EventArgs e) // timer cập nhật trạng thái từ PLC mỗi 1s
        {
            counter_Status++;
            counter_Data++;
            PLC.Instance().ReadClass(PLC_DB100Read.Instance(), 100); // đọc DB100
            PLC.Instance().ReadClass(PLC_DB101Write.Instance(), 101); // đọc DB101
            //PLC.Instance().ReadClass(PLC_DB102_RetainWrite.Instance(), 102); // đọc DB102

            if(counter_Status >= 10) // cập nhật dữ liệu trạng thái lên database
            {
                counter_Status = 0;
                SQL.Instance().Insert_Status(); // gọi hàm insert status
            }

            if (counter_Data >= Properties.Settings.Default.Update *1000/ timerMain.Interval ) // cập nhật dữ liệu data lên database, có thể thay đổi thời gian cập nhật trong communication
            {
                counter_Data = 0;
                SQL.Instance().Insert_Data(); // gọi hàm insert Data
            }

            // Hiển thị trạng thái của hệ thống
            // Status System
            ON_OFF(sdRun_Light, PLC_DB100Read.Instance().Run_Status_System); // hiển thị trạng thái đèn Run 
            ON_OFF(sdAuto_Light, PLC_DB100Read.Instance().Auto_Status_System);
            ON_OFF(sdMan_Light, PLC_DB100Read.Instance().Man_Status_System);
                   
            ON_OFF(sdEmergency_Light, PLC_DB100Read.Instance().Emergency_Status_System);
            ON_OFF(sdStop_Light, PLC_DB100Read.Instance().Stop_Status_System);
            ON_OFF(sdReset_Light, PLC_DB100Read.Instance().Reset_Status_System);
            ON_OFF(sdAlarm_Light, PLC_DB100Read.Instance().Alarm_Status_System);
            // Sensor
            ON_OFF(sdSensor1, PLC_DB100Read.Instance().Sensor1_Status_On); // hiển thị trạng thái sensor 1
            ON_OFF(sdSensor2, PLC_DB100Read.Instance().Sensor2_Status_On);
            ON_OFF(sdSensor3, PLC_DB100Read.Instance().Sensor3_Status_On);
            ON_OFF(sdSensor4, PLC_DB100Read.Instance().Sensor4_Status_On);
            ON_OFF(sdSensor5, PLC_DB100Read.Instance().Sensor5_Status_On);
            ON_OFF(sdSensor6, PLC_DB100Read.Instance().Sensor6_Status_On);
            ON_OFF(sdSensor7, PLC_DB100Read.Instance().Sensor7_Status_On);
            ON_OFF(sdSensor8, PLC_DB100Read.Instance().Sensor8_Status_On);
            // Valve
            ON_OFF(sdValve1, PLC_DB100Read.Instance().Valve1_Status_Open); // hiển thị trạng thái valve 1
            ON_OFF(sdValve2, PLC_DB100Read.Instance().Valve2_Status_Open);
            ON_OFF(sdValve3, PLC_DB100Read.Instance().Valve3_Status_Open);
            ON_OFF(sdValve4, PLC_DB100Read.Instance().Valve4_Status_Open);
            ON_OFF(sdValve5, PLC_DB100Read.Instance().Valve5_Status_Open);
            ON_OFF(sdValve6, PLC_DB100Read.Instance().Valve6_Status_Open);
            ON_OFF(sdValve7, PLC_DB100Read.Instance().Valve7_Status_Open);
            ON_OFF(sdValve8, PLC_DB100Read.Instance().Valve8_Status_Open);
            ON_OFF(sdValve9, PLC_DB100Read.Instance().Valve9_Status_Open);
            ON_OFF(sdValve10, PLC_DB100Read.Instance().Valve10_Status_Open);
            ON_OFF(sdValve11, PLC_DB100Read.Instance().Valve11_Status_Open);
            // Motor
            ON_OFF(sdMotor, PLC_DB100Read.Instance().Motor_Run); // hiển thị trạng thái motor
            // Mix
            ON_OFF(sdMix1, PLC_DB100Read.Instance().Mix1_Run); // hiển thị trạng thái mix 1
            ON_OFF(sdMix2, PLC_DB100Read.Instance().Mix2_Run);
            ON_OFF(sdMix3, PLC_DB100Read.Instance().Mix3_Run);
            ON_OFF(sdMix4, PLC_DB100Read.Instance().Mix4_Run);
            

            

            // show level
            Show_Data_Double_txt(txtMix1, PLC_DB100Read.Instance().Mix1_Level);

            Show_Data_Double_txt(txtMix2, PLC_DB100Read.Instance().Mix2_Level);

            Show_Data_Double_txt(txtMix3, PLC_DB100Read.Instance().Mix3_Level);

            Show_Data_Double_txt(txtMix4, PLC_DB100Read.Instance().Mix4_Level);

        }
        // các chương trình con để hiển thị dữ liệu và trạng thái
        private void ON_OFF(StandardControl sd, bool Output) // hàm hiển thị trạng thái motor

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

        private void Show_Data_Time_txt(TextBox txt, int Value) // hàm show data time
        {
            txt.Text = (Value / 1000).ToString();
        }
        private void Show_Data_Double_txt(TextBox txt, double Value) // hàm show data double
        {
            txt.Text = Value.ToString("0.0000");
        }



        //private void sdMotor1_Click(object sender, EventArgs e) // click vào motor DH
        //{
        //    frManMotorDH _frShow = new frManMotorDH();
        //    _frShow.ShowDialog();
        //}
        //private void sdMotorCA_Click(object sender, EventArgs e) // click vào motor CA
        //{
        //    frManMotorCA _frshow = new frManMotorCA();
        //    _frshow.ShowDialog();
        //}

        private void sdValve1_Click(object sender, EventArgs e)
        {
            frValve1 _frshow = new frValve1();
            _frshow.ShowDialog();
        }

        private void sdValve2_Click(object sender, EventArgs e)
        {
            frValve2 _frshow = new frValve2();
            _frshow.ShowDialog();
        }

        private void sdValve3_Click(object sender, EventArgs e)
        {
            frValve3 _frshow = new frValve3();
            _frshow.ShowDialog();
        }

        private void sdValve4_Click(object sender, EventArgs e)
        {
            frValve4 _frshow = new frValve4();
            _frshow.ShowDialog();
        }

        private void sdValve5_Click(object sender, EventArgs e)
        {
            frValve5 _frshow = new frValve5();
            _frshow.ShowDialog();
        }

        private void sdValve6_Click(object sender, EventArgs e)
        {
            frValve6 _frshow = new frValve6();
            _frshow.ShowDialog();
        }

        private void sdValve7_Click(object sender, EventArgs e)
        {
            frValve7 _frshow = new frValve7();
            _frshow.ShowDialog();
        }

        private void sdValve8_Click(object sender, EventArgs e)
        {
            frValve8 _frshow = new frValve8();
            _frshow.ShowDialog();
        }

        private void sdValve9_Click(object sender, EventArgs e)
        {
            frValve9 _frshow = new frValve9();
            _frshow.ShowDialog();
        }

        private void sdValve10_Click(object sender, EventArgs e)
        {
            frValve10 _frshow = new frValve10();
            _frshow.ShowDialog();
        }

        private void sdValve11_Click(object sender, EventArgs e)
        {
            frValve11 _frshow = new frValve11();
            _frshow.ShowDialog();
        }

        private void sdMix1_Click(object sender, EventArgs e)
        {
            frMix1 _frshow = new frMix1();
            _frshow.ShowDialog();
        }

        private void sdMix2_Click(object sender, EventArgs e)
        {
            frMix2 _frshow = new frMix2();
            _frshow.ShowDialog();
        }

        private void sdMix3_Click(object sender, EventArgs e)
        {
            frMix3 _frshow = new frMix3();
            _frshow.ShowDialog();
        }

        private void sdMix4_Click(object sender, EventArgs e)
        {
            frMix4 _frshow = new frMix4();
            _frshow.ShowDialog();
        }

        private void sdMotor_Click(object sender, EventArgs e)
        {
            frMotor _frshow = new frMotor();
            _frshow.ShowDialog();
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frExcel _frshow = new frExcel();
            _frshow.ShowDialog();
        }
    }
    }

