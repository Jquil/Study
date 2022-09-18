using BLL.IBLL;
using BLL.Req;
using Model;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL
{
    public class SerialPortBLL : ISerialPortBLL
    {
        #region 属性成员
        /// <summary>
        /// 连接的设备{ DiviceID:SerialDivice }
        /// </summary>
        private static Dictionary<string, SerialDivice> _Divices = new Dictionary<string, SerialDivice>();


        /// <summary>
        /// 设备使用的端口{ Port:DiviceID }
        /// </summary>
        private static Dictionary<string, string> _DivicePortPairs = new Dictionary<string, string>();
        #endregion


        #region 打开关闭串口
        public void OpenAndCloseSerialPort(string diviceId, ReqOpenSerialPort req, bool isOpen = true)
        {
            if (isOpen)
            {

            }
            else
            {

            }
        }
        #endregion


        #region 写入byte数据进串口设备
        public byte[] WriteData2SerialPort(string diviceId, byte[] data, bool returnData = false,int waitTime = 200)
        {
            _Divices[diviceId].Sp.Write(data,0,data.Length);
            if (!returnData)
            {
                return null;
            }
            else
            {
                WaitRead(waitTime);
                return _Divices[diviceId].ReciveData;
            }
        }
        #endregion


        #region 写入ASCII数据进串口设备
        public byte[] WriteData2SerialPort(string diviceId, string data, bool returnData = false, int waitTime = 200)
        {
            _Divices[diviceId].Sp.Write(data);
            if (!returnData)
            {
                return null;
            }
            else
            {

                WaitRead(waitTime);
                return _Divices[diviceId].ReciveData;
            }
        }
        #endregion


        #region 串口数据监听
        public void ReceiveDataListener(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            byte[] data = new byte[sp.BytesToRead];
            sp.Read(data, 0, data.Length);

            var diviceId = _DivicePortPairs[sp.PortName];
            _Divices[diviceId].ReadDataFinish = true;
            _Divices[diviceId].ReciveData = data;
        }
        #endregion


        #region 等待读取
        private void WaitRead(int time)
        {
            
        }
        #endregion


        #region 获取设备连接状态
        public bool GetDiviceConnectStatus(string diviceId, bool isUseViSaConnect = false)
        {
            throw new NotImplementedException();
        }
        #endregion


        #region 使用ViSA连接与关闭设备
        public void UseViSaOpenAndCloseDivice(string diviceId, string resourceName)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
