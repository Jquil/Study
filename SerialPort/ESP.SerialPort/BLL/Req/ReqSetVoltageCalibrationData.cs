using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Req
{
    public class ReqSetVoltageCalibrationData
    {
        /// <summary>
        /// 校准点
        /// </summary>
        public int Point { get; set; }


        /// <summary>
        /// 校准电压值
        /// </summary>
        public float Voltage { get; set; }
    }
}
