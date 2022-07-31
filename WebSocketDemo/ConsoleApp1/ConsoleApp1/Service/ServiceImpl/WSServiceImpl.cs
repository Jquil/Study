using ConsoleApp1.Model.Base;
using ConsoleApp1.Service.IService;
using Fleck;
using Newtonsoft.Json;

namespace ConsoleApp1.Service.ServiceImpl
{
    public class WSServiceImpl : IWSService
    {
        private readonly IBaseFunctionService _BFS;

        public WSServiceImpl()
        {
            _BFS = new BaseFunctionServiceImpl();
        }

        public void OnClose(IWebSocketConnection conn)
        {
            // TODO
        }

        public void OnMessage(IWebSocketConnection conn, string message)
        {
            BaseRequest req = JsonConvert.DeserializeObject<BaseRequest>(message);
            _BFS.Handle(conn,req);
        }

        public void OnOpen(IWebSocketConnection conn)
        {
            // TODO
        }
    }
}
