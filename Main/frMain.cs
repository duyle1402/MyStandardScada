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
            frHistory _frShow = new frHistory();
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

        private void timerMain_Tick(object sender, EventArgs e) // timer cập nhật trạng thái từ PLC mỗi 1s
        {
            counter_Status++;
            counter_Data++;
            PLC.Instance().ReadClass(PLC_DB100Read.Instance(), 100); // đọc DB100
            PLC.Instance().ReadClass(PLC_DB101Write.Instance(), 101); // đọc DB101
            PLC.Instance().ReadClass(PLC_DB102_RetainWrite.Instance(), 102); // đọc DB102

            if(counter_Status >= 10) // cập nhật dữ liệu trạng thái lên database
            {
                counter_Status = 0;
                SQL.Instance().Insert_Status(); // gọi hàm insert status
            }

            if (counter_Data*10 >= Properties.Settings.Default.Update ) // cập nhật dữ liệu data lên database, có thể thay đổi thời gian cập nhật trong communicatuon
            {
                counter_Data = 0;
                SQL.Instance().Insert_Data(); // gọi hàm insert Data
            }




            ON_OFF_ALARM(sdMotorCA, PLC_DB100Read.Instance().output_Bom_CA, PLC_DB100Read.Instance().Error_Bom_CA); // trạng thái motorCA
            ON_OFF_ALARM(sdMotorDH, PLC_DB100Read.Instance().output_Bom_DH, PLC_DB100Read.Instance().Error_Bom_DH); // trạng thái motorDH
            

        }

        private void ON_OFF_ALARM(StandardControl sd, bool Output, bool Error) // hàm hiển thị trạng thái motor

        {
            if(!Error) // không lỗi
            {
                if(Output) // ON
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

        private void sdMotor1_Click(object sender, EventArgs e) // click vào motor1
        {
            frManMotorDH _frShow = new frManMotorDH();
            _frShow.ShowDialog();
        }
        private void sdMotorCA_Click(object sender, EventArgs e) // click vào motor CA
        {
            frManMotorCA _frshow = new frManMotorCA();
            _frshow.ShowDialog();
        }
    }
    }

