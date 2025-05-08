using HandShakeLib;

namespace HandShakeClient
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            await Task.Delay(1_000); // Wait for the server to start
            var client = new Client();
            var server = Activator.CreateInstance<IServer>(); // Get a reference to the running server... do it the right way

            server.ClientAccepted += (sender, connector) =>
            {
                Console.WriteLine("Client accepted");
                connector.NewMessage += (sender, message) =>
                {
                    Console.WriteLine($"New message: {message}");
                };

                var returnedServer = sender as IServer;
                var p1 = new Payload1()
                {
                    IntProperty = 36,
                    BoolProperty = true
                };
                returnedServer.SendMessage(p1);
                returnedServer.NewMessage += (sender, message) =>
                {
                    Console.WriteLine($"This is a Message for the server, put it's received within the client !!! FIX ME");
                };

                var p2 = new Payload1()
                {
                    IntProperty = 36,
                    BoolProperty = true
                };
                returnedServer.SendMessage(p2);
            };

            server.AcceptClient(client);

            await Task.Delay(120_000); // Wait for 2 minutes then nullify the server reference
            server = null;
            Console.ReadKey();
        }
    }
}