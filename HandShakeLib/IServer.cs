namespace HandShakeLib
{
    public interface IServer : IConnector
    {
        event EventHandler<IConnector> ClientAccepted;

        internal event EventHandler<IConnector> OnNewClientAcceptRequest;

        internal void Start();

        internal void Stop();

        void AcceptClient(IConnector client);
    }
}