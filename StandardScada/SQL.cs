using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace StandardScada
{
 public class SQL
    {
        public DataTable dt_Data = new DataTable(); // tạo một bảng để lưu dữ liệu data lấy ra từ database
        public DataTable dt_Status = new DataTable();
        SqlConnection con = new SqlConnection(Properties.Settings.Default.SQL); // hàm kiểm tra kết nối 
        public bool SQL_Connected = false;
        protected SQL()
        {

        }
        private static SQL _instance;
        public static SQL Instance() // tạo một SQL static mẫu
        {
            if (_instance == null)
            {
                _instance = new SQL();

            }
            return _instance;
        }
        public void TestConnection()
        {
            try // cố gắng bắt lỗi
            {
                con.Open();
                SQL_Connected = true;
                con.Close();

            }
            catch
            {
                SQL_Connected = false;
            }

        }

        public void Insert_Data() // insert data đối tượng vào sql server
        {
            if (SQL_Connected)
            {
                con.Open(); // mở cổng kết nối
                string sql = "INSERT INTO SCADA_DATA_TABLE(TIMEDATE,MIX1_LEVEL,MIX2_LEVEL,MIX3_LEVEL,MIX4_LEVEL)" +
                               " VALUES(@TIMEDATE,@MIX1_LEVEL,@MIX2_LEVEL,@MIX3_LEVEL,@MIX4_LEVEL)";
                using (SqlCommand com = new SqlCommand(sql, con))
                {

                   

                    // insert data vào SQL
                    com.Parameters.AddWithValue("TIMEDATE", DateTime.Now);
                    com.Parameters.AddWithValue("MIX1_LEVEL", PLC_DB100Read.Instance().Mix1_Level);
                    com.Parameters.AddWithValue("MIX2_LEVEL", PLC_DB100Read.Instance().Mix2_Level);
                    com.Parameters.AddWithValue("MIX3_LEVEL", PLC_DB100Read.Instance().Mix3_Level);
                    com.Parameters.AddWithValue("MIX4_LEVEL", PLC_DB100Read.Instance().Mix4_Level);

                    com.ExecuteNonQuery();
                }

                con.Close();
            }



        }
        public void Insert_Status() // insert trạng thái của đối tượng vào sql server
        {

            if (SQL_Connected)
            {
                con.Open(); // mở cổng kết nối
                string sql = "INSERT INTO SCADA_STATUS_TABLE(TIMEDATE,VALVE1_ON_OFF,VALVE2_ON_OFF,VALVE3_ON_OFF,VALVE4_ON_OFF,VALVE5_ON_OFF,VALVE6_ON_OFF,VALVE7_ON_OFF,VALVE8_ON_OFF,VALVE9_ON_OFF,VALVE10_ON_OFF,VALVE11_ON_OFF,MIX1_ON_OFF,MIX2_ON_OFF,MIX3_ON_OFF,MIX4_ON_OFF,MOTOR_ON_OFF,STOP_ON_OFF,EMERGENCY_ON_OFF)" +
                               " VALUES(@TIMEDATE,@VALVE1_ON_OFF,@VALVE2_ON_OFF,@VALVE3_ON_OFF,@VALVE4_ON_OFF,@VALVE5_ON_OFF,@VALVE6_ON_OFF,@VALVE7_ON_OFF,@VALVE8_ON_OFF,@VALVE9_ON_OFF,@VALVE10_ON_OFF,@VALVE11_ON_OFF,@MIX1_ON_OFF,@MIX2_ON_OFF,@MIX3_ON_OFF,@MIX4_ON_OFF,@MOTOR_ON_OFF,@STOP_ON_OFF,@EMERGENCY_ON_OFF)";
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                   

                    // insert giá trị status vào SQL
                    com.Parameters.AddWithValue("TIMEDATE", DateTime.Now);
                    com.Parameters.AddWithValue("VALVE1_ON_OFF", PLC_DB100Read.Instance().Valve1_Status_Open);
                    com.Parameters.AddWithValue("VALVE2_ON_OFF", PLC_DB100Read.Instance().Valve2_Status_Open);
                    com.Parameters.AddWithValue("VALVE3_ON_OFF", PLC_DB100Read.Instance().Valve3_Status_Open);
                    com.Parameters.AddWithValue("VALVE4_ON_OFF", PLC_DB100Read.Instance().Valve4_Status_Open);
                    com.Parameters.AddWithValue("VALVE5_ON_OFF", PLC_DB100Read.Instance().Valve5_Status_Open);
                    com.Parameters.AddWithValue("VALVE6_ON_OFF", PLC_DB100Read.Instance().Valve6_Status_Open);
                    com.Parameters.AddWithValue("VALVE7_ON_OFF", PLC_DB100Read.Instance().Valve7_Status_Open);
                    com.Parameters.AddWithValue("VALVE8_ON_OFF", PLC_DB100Read.Instance().Valve8_Status_Open);
                    com.Parameters.AddWithValue("VALVE9_ON_OFF", PLC_DB100Read.Instance().Valve9_Status_Open);
                    com.Parameters.AddWithValue("VALVE10_ON_OFF", PLC_DB100Read.Instance().Valve10_Status_Open);
                    com.Parameters.AddWithValue("VALVE11_ON_OFF", PLC_DB100Read.Instance().Valve11_Status_Open);
                    com.Parameters.AddWithValue("MIX1_ON_OFF", PLC_DB100Read.Instance().Mix1_Run);
                    com.Parameters.AddWithValue("MIX2_ON_OFF", PLC_DB100Read.Instance().Mix2_Run);
                    com.Parameters.AddWithValue("MIX3_ON_OFF", PLC_DB100Read.Instance().Mix3_Run);
                    com.Parameters.AddWithValue("MIX4_ON_OFF", PLC_DB100Read.Instance().Mix4_Run);
                    com.Parameters.AddWithValue("MOTOR_ON_OFF", PLC_DB100Read.Instance().Motor_Run);
                    com.Parameters.AddWithValue("STOP_ON_OFF", PLC_DB100Read.Instance().Stop_Status_System);
                    com.Parameters.AddWithValue("EMERGENCY_ON_OFF", PLC_DB100Read.Instance().Emergency_Status_System);


                    com.ExecuteNonQuery();
                }

                con.Close();
            }
          }



        public void Query_Data(DateTime BeginDate, DateTime EndDate) // gọi/ truy vấn dữ liệu data
        {
            if (SQL_Connected)
            {
                con.Open();
                string sql = "SELECT * from SCADA_DATA_TABLE WHERE CONVERT(DATE, TIMEDATE) BETWEEN @BeginDate AND @EndDate"; // lấy toàn bộ bảng data và chọn ngày để hiển thị dữ liệu
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.CommandType = CommandType.Text;
                    com.Parameters.AddWithValue("BeginDate", BeginDate);
                    com.Parameters.AddWithValue("EndDate", EndDate);

                    SqlDataAdapter da = new SqlDataAdapter(com); // tạo một sql dataadapter
                    dt_Data.Clear(); // clear bảng trc khi đưa dữ liệu vào
                    da.Fill(dt_Data); // đưa giữ liệu vào
                }

                con.Close();
            }
          
        }

        public void Query_Status(DateTime BeginDate, DateTime EndDate) // gọi/ truy vấn trạng thái
        {
            if (SQL_Connected)
            {
                con.Open();
                string sql = "SELECT * from SCADA_STATUS_TABLE WHERE CONVERT(DATE, TIMEDATE) BETWEEN @BeginDate AND @EndDate"; // lấy toàn bộ bảng trạng thái
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.CommandType = CommandType.Text;
                    com.Parameters.AddWithValue("BeginDate", BeginDate);
                    com.Parameters.AddWithValue("EndDate", EndDate);

                    SqlDataAdapter da = new SqlDataAdapter(com); // tạo một sql dataadapter
                    dt_Status.Clear(); // clear bảng trc khi đưa dữ liệu vào
                    da.Fill(dt_Status); // đưa giữ liệu vào
                }

                con.Close();

            }    
        }



    }  
}
