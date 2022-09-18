using BLL.IBLL;
using BLL.Req;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL
{
    public class Calibration90703BLL : SerialPortBLL,ICalibration90703BLL
    {

        #region 函数发生器设置调光输出加载值
        public void DimmingOutputLoadValue(string diviceId, float value)
        {
            /**
             * 
             */
        }
        #endregion


        #region 让电子负载器进入,退出短路模式
        public void ElectronicLoadEnteAandExitShortCircuitMode(string diviceId, bool isEnter)
        {
            throw new NotImplementedException();
        }
        #endregion


        #region 函数发生器进入,退出校准模式
        public void EnterAndExitCalibrationMode(string diviceId, bool isEnter)
        {
            throw new NotImplementedException();
        }
        #endregion


        #region 获取函数发生器MCU数据
        public MCUData GetMCUData(string diviceId)
        {
            /**
             * 获取MCU的型号与版本
             */
            var data = new MCUData();
            return data;
        }
        #endregion


        #region 函数发生器输出DAC值
        public void OutputDac(string diviceId, float dac)
        {
            /**
             * 1. 函数发生器输出DAC值
             * 2. 线程延时1s
             */
            throw new NotImplementedException();
        }
        #endregion


        #region 函数发生器输出电压
        public void OutputVoltage(string diviceId, float voltage)
        {
            /**
             * 1. 函数发生器输出电压
             * 2. 线程延时1s
             */
            throw new NotImplementedException();
        }
        #endregion


        #region 电子负载拉载电流
        public void PullCurrent(string diviceId, float current)
        {
            /**
             * 1. 电子负载拉载电流
             * 2. 线程延时1s
             */
            throw new NotImplementedException();
        }
        #endregion


        #region 读取电子负载器电流值
        public float ReadElectronicLoadCurrent(string diviceId)
        {
            throw new NotImplementedException();
        }
        #endregion


        #region 读取电子负载器电压值
        public float ReadElectronicLoadVoltage(string diviceId)
        {
            throw new NotImplementedException();
        }
        #endregion


        #region 重启DC电源
        public void RestartDCPower(string diviceId)
        {
            /**
             * 1. 重启DC电源
             * 2. 线程延时1s
             */
            throw new NotImplementedException();
        }
        #endregion


        #region 保存校准电流数据
        public void SaveCurrentCalibrationData(string diviceId)
        {
            throw new NotImplementedException();
        }
        #endregion


        #region 保持校准电压数据
        public void SaveVoltageCalibrationData(string diviceId)
        {
            throw new NotImplementedException();
        }
        #endregion


        #region 设置校准电压数据
        public void SetCurrentCalibrationData(string diviceId, ReqSetCurrentCalibrationData req)
        {
            throw new NotImplementedException();
        }
        #endregion


        #region 设置函数发生器输出模式
        public void SetOutputMode(string deiviceId, bool isOn)
        {
            throw new NotImplementedException();
        }
        #endregion


        #region 设置校准电压数据
        public void SetVoltageCalibrationData(string diviceId, ReqSetVoltageCalibrationData req)
        {
            throw new NotImplementedException();
        }
        #endregion


        #region 打开关闭电子负载器
        public void TurnOnAndOffElectronicLoad(string diviceId, bool isOpen)
        {
            throw new NotImplementedException();
        }
        #endregion


        #region 使用万用表读取电压
        public float UseMultimeterReadVoltage(string diviceId)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
