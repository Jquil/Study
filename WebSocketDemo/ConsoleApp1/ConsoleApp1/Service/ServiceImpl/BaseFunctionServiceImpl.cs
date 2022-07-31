using ConsoleApp1.App;
using ConsoleApp1.Model;
using ConsoleApp1.Model.Base;
using ConsoleApp1.Service.IService;
using ConsoleApp1.Utils;
using Fleck;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace ConsoleApp1.Service.ServiceImpl
{
    class BaseFunctionServiceImpl : IBaseFunctionService
    {
        private Dictionary<int, MethodInfo> _Map = new Dictionary<int, MethodInfo>();

        public BaseFunctionServiceImpl()
        {
            _Map = new ReflectU().InitContainer(typeof(BaseFunctionServiceImpl),typeof(BaseCode));
        }

        public override void Handle(IWebSocketConnection conn,BaseRequest req)
        {
            try
            {
                MethodInfo m = _Map[req.Code];
                var p = JsonConvert.DeserializeObject(req.Message, m.GetParameters()[1].ParameterType);
                m.Invoke(this, new object[] { conn, p });
            }
            catch(Exception e)
            {
                Log.e(e.Message);
            }
        }

        protected override void Login(IWebSocketConnection conn, User usr)
        {
            var isLogin = WSManager.Get(usr.Id);
            if (isLogin != null)
            {
                BaseResponse resQuit = new BaseResponse()
                {
                    Code = (int)BaseCode.Quit
                };
                WSManager.Send(isLogin,resQuit);
                WSManager.Remove(usr.Id);
            }

            BaseResponse res = new BaseResponse()
            {
                Code = (int)BaseCode.Login
            };
            WSManager.Send(conn,res);
            WSManager.Add(conn, usr.Id);
        }

        protected override void Logout(IWebSocketConnection conn, User usr)
        {
            // TODO
        }
    }
}
