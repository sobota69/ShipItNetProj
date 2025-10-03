using System;

namespace ShipItNetProj.Services;
public interface IMessageService
{
    string SendMessage(string message);
}

public class MessageService : IMessageService
{
    public string SendMessage(string message)
    {
        Console.WriteLine($"Message: {message}");
        return "OK";
    }
}