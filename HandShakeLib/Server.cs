using HandShakeLib;

namespace HandShakeServer
{
    public class Server : IServer
    {
        public event EventHandler<IConnector>? ClientAccepted;

        public event EventHandler<IConnector>? OnNewClientAcceptRequest;

        public event EventHandler<object>? NewMessage;

        public void SendMessage(object message)
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void AcceptClient(IConnector client)
        {
            throw new NotImplementedException();
        }
    }
}