using System;
using System.Threading;

namespace ProxyExampleLib
{
    public class RealServer : IServer
    {
        public void ExecuteRequest()
        {
            Console.WriteLine("Идёт обработка запроса . . .");
            Thread.Sleep(1000);
        }

        public void InputData(Client client)
        {
            Console.Write("Введите имя: ");
            client.Name = Console.ReadLine();

            Console.Write("Введите возраст: ");
            client.Age = Console.ReadLine();
        }

        public void ShowMessage(string text)
        {
            Console.WriteLine(text);
        }
    }
}
