using System;

namespace ShipItNetProj.Services;
public interface IMessageServiceWrapper
{
    string SendMessage(string message);
}

public class MessageServiceWrapper(ISession session, IMessageService messageService) : IMessageServiceWrapper
{
    public string SendMessage(string message)
    {
        session.CreateOrGetSession();
        return messageService.SendMessage(message);
    }
}