using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardScada
{
 public  class PLC_DB102_RetainWrite
    {
        protected PLC_DB102_RetainWrite()
        {

        }
        private static PLC_DB102_RetainWrite _instance;
        public static PLC_DB102_RetainWrite Instance() // tạo một PLC static mẫu
        {
            if (_instance == null)
            {
                _instance = new PLC_DB102_RetainWrite();

            }
            return _instance;
        }
        

        public int SP_Delay { get; set; } // Ghi thời gian setpoint on xuống PLC

        //public int _OFF { get; set; } //  Ghi thời gian setpoint off  xuống PLC

    }
}
