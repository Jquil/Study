using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model.Base
{
    public class BaseRequest
    {
        /// <summary>
        /// 请求代码
        /// </summary>
        public int Code { get; set; }


        /// <summary>
        /// 消息
        /// </summary>
        public string Message { get; set; }

    }
}
