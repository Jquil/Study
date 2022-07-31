using ConsoleApp1.Service.IService;
using ConsoleApp1.Service.ServiceImpl;
using Fleck;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            IWSService service = new WSServiceImpl();
            var server = new WebSocketServer($"ws://{config["IP"]}:{config["Port"]}");
            server.Start(socket =>
            {
                socket.OnOpen = () => service.OnOpen(socket);
                socket.OnClose = () => service.OnClose(socket);
                socket.OnMessage = (message) => service.OnMessage(socket,message);
            });
            Console.ReadKey();
        }
    }
}
