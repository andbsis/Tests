namespace HandShakeLib
{
    public interface IConnector
    {
        event EventHandler<object> NewMessage;

        void SendMessage(object message);
    }
}