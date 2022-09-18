using BLL.BLL;
using BLL.IBLL;
using BLL.Req;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        #region 入口函数
        static void Main(string[] args)
        {
            System.Console.ReadKey();
            /**
             * 校准：校准电压，校准电流
             * 1. 物理连接设备（万用表，电子负载，DC电源，函数发生器）后，建立软连接
             * 2. 获取函数发生器型号与版本
             * 3. 开始校准电压
             *   3.1 进入校准模式
             *   3.2 函数发生器输出DAC值，等待1s
             *   3.3 读取万用表电压
             *   3.4 写入电压校准点，电压值
             *   3.5 保存
             * 4.开始校准电流
             *   4.1 进入校准模式
             *   4.2 函数发生器输出10V电压，等待1s
             *   4.3 打开电子负载
             *   4.4 拉载0.02A，等待1s
             *   4.5 读取电子负载电流
             *   4.6 写入电流校准点，电流值
             *   4.7 保存，退出校准模式
             * 5. 重启DC电源
             * 6. 测试电压校准是否准确
             *   6.1 打开函数发生器输出模式
             *   6.2 函数发生器输出10V，等待1s
             *   6.3 读取万用表电压
             *   6.4 比对，判断是否在误差之内
             *   6.5 关闭函数发生器输出模式
             * 7. 测试电流校准是否准确
             *   7.1 打开函数发生器输出模式
             *   7.2 函数发生器输出10V，等待1s
             *   7.3 电子负载拉载0.2A，     等待1s,读取电压是否在规格之内
             *   7.4 让电子负载进入短路模式,等待1s,读取是否有电压
             *   7.5 电子负载拉载0.2A，     等待1s,读取电压是否在规格之内
             * 8. 测试函数发生器拉载功能
             *   8.1 打开函数发生器输出模式
             *   8.2 函数发生器输出0.02V，等待1s
             *   8.3 设置调光1mA
             *   8.4 读取万用表电压是否在规格之内
             * 9. 完成以上校准与测试，输出成功与失败
             */
        }
        #endregion


        #region 开始校准
        /// <summary>
        /// 开始校准
        /// </summary>
        void StartCalibration()
        {
            GetMCUData();
            CalibrationVoltage();
            CalibrationCurrent();
            RestartDCPower();
            TestCalibrationVoltageResult();
            TestCalibrationCurrentResult();
            TestPullLoadFunction();
        }
        #endregion


        #region 获取MCU数据
        void GetMCUData()
        {
            ICalibration90703BLL _BLL = new Calibration90703BLL();
            var data = _BLL.GetMCUData("");
        }
        #endregion


        #region 校准电压
        /// <summary>
        /// 校准电压
        /// </summary>
        void CalibrationVoltage() {
            ICalibration90703BLL _BLL = new Calibration90703BLL();
            _BLL.EnterAndExitCalibrationMode("",true);

            _BLL.OutputDac("",50f);
            _BLL.UseMultimeterReadVoltage("");
            _BLL.SetVoltageCalibrationData("",new ReqSetVoltageCalibrationData() {
                
            });

            _BLL.SaveVoltageCalibrationData("");
            _BLL.EnterAndExitCalibrationMode("", false);

        }
        #endregion


        #region 校准电流
        /// <summary>
        /// 校准电流
        /// </summary>
        void CalibrationCurrent()
        {
            ICalibration90703BLL _BLL = new Calibration90703BLL();
            _BLL.EnterAndExitCalibrationMode("", true);
            _BLL.SetOutputMode("",true);
            _BLL.TurnOnAndOffElectronicLoad("", true);

            _BLL.OutputVoltage("",10f);
            _BLL.PullCurrent("",0.02f);
            _BLL.ReadElectronicLoadCurrent("");

            _BLL.TurnOnAndOffElectronicLoad("", true);
            _BLL.SetOutputMode("", false);
            _BLL.SaveCurrentCalibrationData("");
            _BLL.EnterAndExitCalibrationMode("", false);
        }
        #endregion


        #region 重启DC电源
        /// <summary>
        /// 重启DC电源
        /// </summary>
        void RestartDCPower() {
            ICalibration90703BLL _BLL = new Calibration90703BLL();
            _BLL.RestartDCPower("");
        }
        #endregion


        #region 测试校准电压结果
        /// <summary>
        /// 测试校准电压结果
        /// </summary>
        void TestCalibrationVoltageResult()
        {
            ICalibration90703BLL _BLL = new Calibration90703BLL();

            _BLL.SetOutputMode("", true);

            _BLL.OutputVoltage("", 10f);
            _BLL.UseMultimeterReadVoltage("");

            _BLL.SetOutputMode("", false);
        }
        #endregion


        #region 测试校准电流结果
        /// <summary>
        /// 测试校准电流结果
        /// </summary>
        void TestCalibrationCurrentResult()
        {
            ICalibration90703BLL _BLL = new Calibration90703BLL();
            _BLL.SetOutputMode("",true);
            _BLL.TurnOnAndOffElectronicLoad("", true);

            _BLL.PullCurrent("", 0.02f);
            _BLL.ReadElectronicLoadVoltage("");
            _BLL.ElectronicLoadEnteAandExitShortCircuitMode("", true);
            _BLL.ReadElectronicLoadVoltage("");
            _BLL.ElectronicLoadEnteAandExitShortCircuitMode("", false);

            _BLL.TurnOnAndOffElectronicLoad("", false);
            _BLL.SetOutputMode("",false);
        }
        #endregion


        #region 测试函数发生器加载功能
        /// <summary>
        /// 测试函数发生器加载功能
        /// </summary>
        void TestPullLoadFunction()
        {
            ICalibration90703BLL _BLL = new Calibration90703BLL();
            _BLL.SetOutputMode("", true);
            _BLL.OutputVoltage("", 0.02f);
            _BLL.DimmingOutputLoadValue("", 1f);
            _BLL.UseMultimeterReadVoltage("");
            _BLL.SetOutputMode("", false);
        }
        #endregion
    }
}
