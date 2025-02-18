namespace DemoServer;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Server starting...");
        var server = new TcpServer(5000);
        server.Start();
    }
}
