using BLL.Req;
using Model;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IBLL
{
    public interface ISerialPortBLL
    {

        /// <summary>
        /// 打开/关闭串口
        /// </summary>
        /// <param name="diviceId"></param>
        /// <param name="req"></param>
        /// <param name="isOpen"></param>
        void OpenAndCloseSerialPort(string diviceId, ReqOpenSerialPort req,bool isOpen = true);


        /// <summary>
        /// 写入Byte数据进串口
        /// </summary>
        /// <param name="diviceId"></param>
        /// <param name="data"></param>
        /// <param name="returnData"></param>
        /// <returns></returns>
        byte[] WriteData2SerialPort(string diviceId,byte[] data,bool returnData = false, int waitTime = 200);


        /// <summary>
        /// 写入ASCII数据进串口
        /// </summary>
        /// <param name="diviceId"></param>
        /// <param name="data"></param>
        /// <param name="returnData"></param>
        /// <returns></returns>
        byte[] WriteData2SerialPort(string diviceId, string data,bool returnData = false, int waitTime = 200);


        /// <summary>
        /// 串口数据监听
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ReceiveDataListener(object sender, SerialDataReceivedEventArgs e);


        /// <summary>
        /// 获取设备连接状态
        /// </summary>
        /// <param name="diviceId"></param>
        /// <param name="isUseViSaConnect">使用Visa进行连接</param>
        /// <returns></returns>
        bool GetDiviceConnectStatus(string diviceId,bool isUseViSaConnect = false);



        /// <summary>
        /// 使用ViSa连接与关闭设备
        /// </summary>
        /// <param name="diviceId"></param>
        /// <param name="resourceName"></param>
        void UseViSaOpenAndCloseDivice(string diviceId, string resourceName);
    }
}
