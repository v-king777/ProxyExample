namespace ProxyExampleLib
{
    public interface IServer
    {
        void ExecuteRequest();

        void ShowMessage(string text);

        void InputData(Client client);
    }
}
