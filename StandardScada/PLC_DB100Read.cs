using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardScada
{
 public  class PLC_DB100Read // Đọc dữ liệu từ PLC
    {
        protected PLC_DB100Read()
        {

        }
        private static PLC_DB100Read _instance;
        public static PLC_DB100Read Instance() // tạo một PLC static mẫu
        {
            if (_instance == null)
            {
                _instance = new PLC_DB100Read();

            }
            return _instance;
        }
        

        // status system
        public bool Auto_Status_System { get; set; } // đọc dữ liệu trạng thái Auto từ PLC

        public bool Man_Status_System { get; set; } // đọc dữ liệu trạng thái Man từ PLC

        public bool Run_Status_System { get; set; } // đọc dữ liệu trạng thái Run từ PLC

        public bool Emergency_Status_System { get; set; } // đọc dữ liệu trạng thái Emergency từ PLC

        public bool Stop_Status_System { get; set; } // đọc dữ liệu trạng thái stop từ PLC

        public bool Reset_Status_System { get; set; } // đọc dữ liệu trạng thái Reset từ PLC

        public bool Alarm_Status_System { get; set; } // đọc dữ liệu trạng thái Alarm từ PLC

        public byte End_Status_System { get; set; } // kết thúc dữ liệu

        // Sensor
        public bool Sensor1_Status_On { get; set; }
        public bool Sensor1_Status_Off { get; set; }

        public bool Sensor2_Status_On { get; set; }
        public bool Sensor2_Status_Off { get; set; }

        public bool Sensor3_Status_On { get; set; }
        public bool Sensor3_Status_Off { get; set; }

        public bool Sensor4_Status_On { get; set; }
        public bool Sensor4_Status_Off { get; set; }

        public bool Sensor5_Status_On { get; set; }
        public bool Sensor5_Status_Off { get; set; }

        public bool Sensor6_Status_On { get; set; }
        public bool Sensor6_Status_Off { get; set; }

        public bool Sensor7_Status_On { get; set; }
        public bool Sensor7_Status_Off { get; set; }

        public bool Sensor8_Status_On { get; set; }
        public bool Sensor8_Status_Off { get; set; }


        // Valve 
        public bool Valve1_Status_Open { get; set; } // trạng thái của valve 1
        public bool Valve1_Status_Close { get; set; }

        public bool Valve2_Status_Open { get; set; } // trạng thái của valve 2
        public bool Valve2_Status_Close { get; set; }

        public bool Valve3_Status_Open { get; set; } // trạng thái của valve 3
        public bool Valve3_Status_Close { get; set; }

        public bool Valve4_Status_Open { get; set; } // trạng thái của valve 4
        public bool Valve4_Status_Close { get; set; }

        public bool Valve5_Status_Open { get; set; } // trạng thái của valve 5
        public bool Valve5_Status_Close { get; set; }

        public bool Valve6_Status_Open { get; set; } // trạng thái của valve 6
        public bool Valve6_Status_Close { get; set; }

        public bool Valve7_Status_Open { get; set; } // trạng thái của valve 7
        public bool Valve7_Status_Close { get; set; }

        public bool Valve8_Status_Open { get; set; } // trạng thái của valve 8
        public bool Valve8_Status_Close { get; set; }

        public bool Valve9_Status_Open { get; set; } // trạng thái của valve 9
        public bool Valve9_Status_Close { get; set; }

        public bool Valve10_Status_Open { get; set; } // trạng thái của valve 10
        public bool Valve10_Status_Close { get; set; }

        public bool Valve11_Status_Open { get; set; } // trạng thái của valve 11
        public bool Valve11_Status_Close { get; set; }

        // Mix 1
        public double Mix1_Level { get; set; } // đọc mức chất lỏng có trong bình mix 1

        public bool Mix1_Start_Man { get; set; }

        public bool Mix1_Stop_Man { get; set; }

        public bool Mix1_Error { get; set; } // đọc xem mix 1 có đang bị lỗi

        public bool Mix1_Run { get; set; }  // đọc trạng thái hoạt động của mix 1

        public int Mix1_PV { get; set; } // đọc thời gian đang trộn của mix 1

        // Mix 2
        public double Mix2_Level { get; set; } 

        public bool Mix2_Start_Man { get; set; }

        public bool Mix2_Stop_Man { get; set; }

        public bool Mix2_Error { get; set; } 

        public bool Mix2_Run { get; set; }  

        public int Mix2_PV { get; set; } 


        // Mix 3
        public double Mix3_Level { get; set; } 

        public bool Mix3_Start_Man { get; set; }

        public bool Mix3_Stop_Man { get; set; }

        public bool Mix3_Error { get; set; } 

        public bool Mix3_Run { get; set; }  

        public int Mix3_PV { get; set; } 

        // Mix 4 
        public double Mix4_Level { get; set; } 

        public bool Mix4_Start_Man { get; set; }

        public bool Mix4_Stop_Man { get; set; }

        public bool Mix4_Error { get; set; } 

        public bool Mix4_Run { get; set; }

        public int Mix4_PV_U { get; set; } // thời gian ủ của mix4

        // Motor
        public bool Motor_Run { get; set; }

        public bool Motor_Error { get; set; }

        public bool Motor_Start_Man { get; set; }

        public bool Motor_Stop_Man { get; set; }

        public int Motor_PV_Tron { get; set; } // thời gian trộn của motor

       

       



    }
}
