using Fleck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Service.IService
{
    public interface IWSService
    {
        /// <summary>
        /// 打开连接
        /// </summary>
        /// <param name="conn"></param>
        void OnOpen(IWebSocketConnection conn);

        /// <summary>
        /// 关闭连接
        /// </summary>
        /// <param name="conn"></param>
        void OnClose(IWebSocketConnection conn);

        /// <summary>
        /// 接收消息
        /// </summary>
        /// <param name="conn"></param>
        void OnMessage(IWebSocketConnection conn,string message);
    }
}
