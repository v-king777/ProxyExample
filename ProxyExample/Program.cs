using System;
using ProxyExampleLib;

namespace ProxyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();

            // var server = new RealServer();
            var server = new ProxyServer(new RealServer());

            server.ShowMessage("Добро пожаловать на сервер!");

            try
            {
                server.InputData(client);
                client.SendRequest(server);
            }
            catch (Exception ex)
            {
                server.ShowMessage(ex.Message);
                return;
            }

            server.ShowMessage("Запрос выполнен!");
        }
    }
}
