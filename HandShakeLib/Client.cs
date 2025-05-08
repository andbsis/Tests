using HandShakeLib;

namespace HandShakeClient
{
    public class Client : IConnector
    {
        public event EventHandler<object>? NewMessage;

        public void SendMessage(object message)
        {
            throw new NotImplementedException();
        }
    }
}