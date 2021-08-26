using System;

namespace ProxyExampleLib
{
    public class ProxyServer : IServer
    {
        private readonly RealServer _server;

        public ProxyServer(RealServer server)
        {
            _server = server;
        }

        public void ExecuteRequest()
        {
            _server.ExecuteRequest();
        }

        public void InputData(Client client)
        {
            _server.InputData(client);

            uint age;

            while (!uint.TryParse(client.Age, out age) || client.Name == string.Empty)
            {
                ShowMessage("Некорректные данные!");
                _server.InputData(client);
            }

            if (age < 18)
            {
                throw new Exception("Отказано в доступе! У нас тут 18+");
            }
        }

        public void ShowMessage(string text)
        {
            _server.ShowMessage(text);
        }
    }
}
