using HandShakeLib;

namespace HandShakeServer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var server = new Server();
            server.OnNewClientAcceptRequest += (sender, client) =>
            {
                Console.WriteLine("New Client Acceptance request");
                server.AcceptClient(client);
            };
            server.NewMessage += (sender, message) =>
            {
                // Handle the new message from the client
                // perform type checking and cast to the appropriate type
                // extract the properties and do something with them
                // if the message contains a BoolProperty AND it's true, delay 125_000 milliseconds before send a message back to the client
                // otherwise, send a message back to the client immediately

                Console.WriteLine($"New message: {message}");
                var client = sender as IConnector;
                var response = new object(); // Create a response of some Type, based on the message received
                client.SendMessage(response);
            };
            server.Start();
            Console.ReadKey();
        }
    }
}