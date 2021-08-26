namespace ProxyExampleLib
{
    public class Client
    {
        public string Name { get; set; }

        public string Age { get; set; }

        public void SendRequest(IServer server)
        {
            server.ExecuteRequest();
        }
    }
}
