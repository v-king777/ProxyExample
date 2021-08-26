using System;
using System.Windows.Forms;

namespace ProxyExampleLib
{
    public class WinFormServer : IServer
    {
        public void ExecuteRequest()
        {
            MessageBox.Show("Идёт обработка запроса . . .");
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
            MessageBox.Show(text);
        }
    }
}
