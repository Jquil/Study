using ConsoleApp1.Model;
using ConsoleApp1.Model.Base;
using Fleck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Service.IService
{
    public abstract class IBaseFunctionService
    {
        /// <summary>
        /// 处理入口
        /// </summary>
        /// <param name="req"></param>
        abstract public void Handle(IWebSocketConnection conn, BaseRequest req);
        
        /// <summary>
        /// 用户登入
        /// </summary>
        abstract protected void Login(IWebSocketConnection conn, User usr);

        /// <summary>
        /// 用户登出
        /// </summary>
        abstract protected void Logout(IWebSocketConnection conn, User usr);
    }
}
