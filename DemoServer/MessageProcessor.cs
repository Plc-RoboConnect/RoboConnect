namespace DemoServer;

public static class MessageProcessor
{
    public static string ProcessMessage(string message)
    {
        return message switch
        {
            "Hi" => "Hello",
            "Time" => DateTime.Now.ToString(),
            _ => "UnknownCmd",
        };
    }

  public static string ProcessDobotCommand(string command)
  {
    var trimmedCommand = command.Replace(" ", string.Empty);
    return $"0,{{\"hey Calum\", 0.23}},{trimmedCommand};";

  }
}