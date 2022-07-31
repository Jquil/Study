using ConsoleApp1.Model.Base;
using Fleck;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.App
{
    public class WSManager
    {

        private static Dictionary<string, IWebSocketConnection> _AllConnection = new Dictionary<string, IWebSocketConnection>();


        /// <summary>
        /// 添加连接
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="key"></param>
        public static void Add(IWebSocketConnection conn,string key) {
            _AllConnection.Add(key, conn);
        }


        /// <summary>
        /// 移除连接
        /// </summary>
        /// <param name="key"></param>
        public static void Remove(string key)
        {
            _AllConnection.Remove(key);
        }


        /// <summary>
        /// 获取连接
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static IWebSocketConnection Get(string key) {
            if (_AllConnection.ContainsKey(key))
                return _AllConnection[key];
            return null;
        }


        /// <summary>
        /// 发送消息
        /// </summary>
        public static void Send(IWebSocketConnection conn,BaseResponse res)
        {
            conn.Send(JsonConvert.SerializeObject(res));
        }
    }
}
