using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialTransmission
{
   public class ComClass
    {
        private string _portName;
        private int _baud;
        private float _stopbit;
        private int _databit;
        private string _paritybit;

        public string PortName { get => _portName; set => _portName = value; }//获取串口名
        public int BaudRate { get => _baud; set => _baud = value; }//波特率
        public float Stopbit { get => _stopbit; set => _stopbit = value; }//停止位
        public int Databit { get => _databit; set => _databit = value; }//数据位
        public string Paritybit { get => _paritybit; set => _paritybit = value; }//校验位
    }
}
