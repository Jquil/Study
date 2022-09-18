using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SerialDivice
    {

        /// <summary>
        /// 设备ID
        /// </summary>
        public string DiviceId { get; set; }


        /// <summary>
        /// 串口设备
        /// </summary>
        public SerialPort Sp { get; set; }


        /// <summary>
        /// 读取数据完成
        /// </summary>
        public bool ReadDataFinish { get; set; }


        /// <summary>
        /// 接收到的数据
        /// </summary>
        public byte[] ReciveData { get; set; }
    }
}
