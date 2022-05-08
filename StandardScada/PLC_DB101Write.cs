using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardScada
{
 public  class PLC_DB101Write // Ghi dữ liệu xuống PLC
    {
        protected PLC_DB101Write()
        {

        }
        private static PLC_DB101Write _instance;
        public static PLC_DB101Write Instance() // tạo một PLC static mẫu
        {
            if (_instance == null)
            {
                _instance = new PLC_DB101Write();

            }
            return _instance;
        }

        

        // Control Panel
         public bool Stop_Control { get; set; }

         public bool Emergency_Control { get; set; }

         public bool Reset_Control { get; set; }

         public bool Auto_On_Control { get; set; }

        public bool Auto_Off_Control { get; set; }

        public bool Run_Control { get; set; }

        public byte End_Control { get; set; }

        // Valve
        public bool Valve1_Man_On_Control { get; set; }
        public bool Valve1_Man_Off_Control { get; set; }

        public bool Valve2_Man_On_Control { get; set; }
        public bool Valve2_Man_Off_Control { get; set; }

        public bool Valve3_Man_On_Control { get; set; }
        public bool Valve3_Man_Off_Control { get; set; }

        public bool Valve4_Man_On_Control { get; set; }
        public bool Valve4_Man_Off_Control { get; set; }

        public bool Valve5_Man_On_Control { get; set; }
        public bool Valve5_Man_Off_Control { get; set; }

        public bool Valve6_Man_On_Control { get; set; }
        public bool Valve6_Man_Off_Control { get; set; }

        public bool Valve7_Man_On_Control { get; set; }
        public bool Valve7_Man_Off_Control { get; set; }

        public bool Valve8_Man_On_Control { get; set; }
        public bool Valve8_Man_Off_Control { get; set; }

        public bool Valve9_Man_On_Control { get; set; }
        public bool Valve9_Man_Off_Control { get; set; }

        public bool Valve10_Man_On_Control { get; set; }
        public bool Valve10_Man_Off_Control { get; set; }

        public bool Valve11_Man_On_Control { get; set; }
        public bool Valve11_Man_Off_Control { get; set; }

        // Mix1
        public bool Mix1_Man_On_Control { get; set; }

        public bool Mix1_Man_Off_Control { get; set; }

        public int Mix1_SP { get; set; }

        // Mix2
        public bool Mix2_Man_On_Control { get; set; }

        public bool Mix2_Man_Off_Control { get; set; }

        public int Mix2_SP { get; set; }

        // Mix3
        public bool Mix3_Man_On_Control { get; set; }

        public bool Mix3_Man_Off_Control { get; set; }

        public int Mix3_SP { get; set; }

        // Mix4
        public bool Mix4_Man_On_Control { get; set; }

        public bool Mix4_Man_Off_Control { get; set; }

        public int Mix4_SP_U { get; set; }



        // Motor
        public bool Motor_Start_Man { get; set; }

        public bool Motor_Stop_Man { get; set; }

        public int Motor_SP_Tron { get; set; }

      





    }
}
