using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IBLL
{
    public interface IModBusRTUBLL
    {
        /// <summary>
        /// 读取保存寄存器
        /// </summary>
        /// <param name="slaveAddress">从站地址</param>
        /// <param name="startAddress">寄存器起地址</param>
        /// <param name="endAddress">寄存器始地址</param>
        /// <returns></returns>
        string ReadHoldingRegister(int slaveAddress, int startAddress,int endAddress,DataType dt);


        /// <summary>
        /// 预置单寄存器
        /// </summary>
        void PresetSingleRegister();


        /// <summary>
        /// 预置多寄存器
        /// </summary>
        void PresetMultipleRegisters();


        /// <summary>
        /// CRC校验
        /// </summary>
        void CRCCheck();
    }
}
