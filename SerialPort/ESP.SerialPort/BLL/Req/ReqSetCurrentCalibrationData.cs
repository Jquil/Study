using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Req
{
    public class ReqSetCurrentCalibrationData
    {
        /// <summary>
        /// 校准点
        /// </summary>
        public int Point { get; set; }

        /// <summary>
        /// 电流
        /// </summary>
        public float Current { get; set; }
    }
}
