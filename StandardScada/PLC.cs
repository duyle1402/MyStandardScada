using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S7.Net;
namespace StandardScada
{
 public  class PLC
    { 
        Plc _plc = new Plc(CpuType.S71500, Properties.Settings.Default.IPPLC, 0, 0); // tạo kết nối plc
        public bool PLC_Connected = false;
        protected PLC()
        {

        }
            private static PLC _instance;
            public static PLC Instance() // tạo một PLC static mẫu
            {
                    if(_instance == null)
                 {
                         _instance = new PLC();

                   }
            return _instance;
             }

        public bool Open() // Chương trình con Open cho PLC
        {
            if (_plc.Open() == ErrorCode.NoError)
            {
                PLC_Connected = true;
                return true;
            }
            else
            {
                PLC_Connected = false;
                return false;
            }
        }
        public void Close() // Chương trình con Close cho PLC
        {
            PLC_Connected = false;
            _plc.Close();
        }

        public void SetBit(String Address) // Chương trình setbit
        {
            if(PLC_Connected)
            {
                _plc.Write(Address, 1);
            }
        }

        public void ResetBit(String Address) // Chương trình reset bit
        {
            if (PLC_Connected)
            {
                _plc.Write(Address, 0);
            }
        }

        public void WriteInt(string Address, short Value) // Ghi giá trị Int , kiểu dữ liệu C# là Short
        {
            if(PLC_Connected)
            {
                _plc.Write(Address, Value);
            }
        }

        public void WriteDInt(string Address, int Value) // Ghi giá trị DInt , kiểu dữ liệu C# là int
        {
            if (PLC_Connected)
            {
                _plc.Write(Address, Value);
            }
        }

        public void WriteTime(string Address, int Value) // Ghi giá trị Time , kiểu dữ liệu C# là int
        {
            if (PLC_Connected)
            {
                _plc.Write(Address, Value);
            }
        }
        public void WriteReal(string Address, double Value) // Ghi giá trị Real , kiểu dữ liệu C# là Double
        {
            if (PLC_Connected)
            {
                _plc.Write(Address, Value.ConvertToUInt());
            }
        }

        public void ReadClass(object cl, int DB) // chương trình con Đọc toàn bộ Class từ PLC lên
        {
            if (PLC_Connected)
            {
                _plc.ReadClass(cl, DB);
            }
        }




    }
}
