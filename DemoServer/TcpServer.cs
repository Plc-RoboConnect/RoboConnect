using System.Net;
using System.Net.Sockets;
using System.Text;

namespace DemoServer;
public class TcpServer
{
    private readonly int _port;
    private TcpListener? _server;
    private string ip = "192.168.1.10";

    public TcpServer(int port)
    {
        _port = port;
    }

    public void Start()
    {
        _server = new TcpListener(IPAddress.Parse(ip), _port);
        _server.Start();
        Console.WriteLine($"Server has started on {ip} :{_port}.{Environment.NewLine}Waiting for a connection..");

        while (true)
        {
            Console.WriteLine("Waiting for a connection....");
            var client = _server.AcceptTcpClient();
            Console.WriteLine("Client connected");

            // Spawn a new thread for handling the client
            Thread clientThread = new Thread(HandleClient);
            clientThread.Start(client);
        }
    }

    private void HandleClient(object tcpClient)
    {
        using var client = (TcpClient)tcpClient;
        using var stream = client.GetStream();
        using var reader = new StreamReader(stream, Encoding.UTF8);
        using var writer = new StreamWriter(stream, Encoding.UTF8) { AutoFlush = true };
        
        string? message;
        while ((message = reader.ReadLine()) != null)
        {
            Console.WriteLine($"Received: {message}");
            var response = MessageProcessor.ProcessDobotCommand(message);
            writer.WriteLine(response);
        }
    }
}
