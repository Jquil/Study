using BLL.Req;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IBLL
{
    public interface ICalibration90703BLL
    {
        /// <summary>
        /// 获取MCU数据
        /// </summary>
        /// <param name="diviceId"></param>
        /// <returns></returns>
        MCUData GetMCUData(string diviceId);


        /// <summary>
        /// 进入退出校准模式
        /// </summary>
        /// <param name="diviceId"></param>
        /// <param name="isEnter"></param>
        void EnterAndExitCalibrationMode(string diviceId,bool isEnter);


        /// <summary>
        /// 函数发生器输出DAC
        /// </summary>
        /// <param name="diviceId"></param>
        /// <param name="dac"></param>
        void OutputDac(string diviceId,float dac);


        /// <summary>
        /// 使用万用表读取电压
        /// </summary>
        /// <param name="diviceId"></param>
        /// <returns></returns>
        float UseMultimeterReadVoltage(string diviceId);


        /// <summary>
        /// 设置校准电压数据
        /// </summary>
        /// <param name="diviceId"></param>
        /// <param name="req"></param>
        void SetVoltageCalibrationData(string diviceId, ReqSetVoltageCalibrationData req);


        /// <summary>
        /// 保存校准电压数据
        /// </summary>
        /// <param name="diviceId"></param>
        void SaveVoltageCalibrationData(string diviceId);


        /// <summary>
        /// 设置函数发生器输出模式
        /// </summary>
        /// <param name="deiviceId"></param>
        /// <param name="isOn"></param>
        void SetOutputMode(string deiviceId, bool isOn);


        /// <summary>
        /// 函数发生器输出电压
        /// </summary>
        /// <param name="diviceId"></param>
        /// <param name="voltage"></param>
        void OutputVoltage(string diviceId,float voltage);


        /// <summary>
        /// 打开关闭电子负载器
        /// </summary>
        /// <param name="diviceId"></param>
        /// <param name="isOpen"></param>
        void TurnOnAndOffElectronicLoad(string diviceId,bool isOpen);


        /// <summary>
        /// 拉载电流
        /// </summary>
        /// <param name="diviceId"></param>
        /// <param name="current"></param>
        void PullCurrent(string diviceId,float current);


        /// <summary>
        /// 读取电子负载器电流
        /// </summary>
        /// <param name="diviceId"></param>
        /// <returns></returns>
        float ReadElectronicLoadCurrent(string diviceId);


        /// <summary>
        /// 设置校准电流数据
        /// </summary>
        /// <param name="diviceId"></param>
        /// <param name="req"></param>
        void SetCurrentCalibrationData(string diviceId,ReqSetCurrentCalibrationData req);


        /// <summary>
        /// 保存校准电流数据
        /// </summary>
        /// <param name="diviceId"></param>
        void SaveCurrentCalibrationData(string diviceId);


        /// <summary>
        /// 重启DC电源
        /// </summary>
        /// <param name="diviceId"></param>
        void RestartDCPower(string diviceId);


        /// <summary>
        /// 读取电子负载器电压
        /// </summary>
        /// <param name="diviceId"></param>
        /// <returns></returns>
        float ReadElectronicLoadVoltage(string diviceId);


        /// <summary>
        /// 电子负载器进入退出短路模式
        /// </summary>
        /// <param name="diviceId"></param>
        /// <param name="isEnter"></param>
        void ElectronicLoadEnteAandExitShortCircuitMode(string diviceId,bool isEnter);


        /// <summary>
        /// 设置调光输出加载值
        /// </summary>
        /// <param name="diviceId"></param>
        /// <param name="value"></param>
        void DimmingOutputLoadValue(string diviceId,float value);
    }
}
