using System;
using System.Data;

namespace ShipItNetProj.Services;
public interface ISession
{
    string CreateOrGetSession();
}

public class Session(IConnection connection) : ISession
{
    public string CreateOrGetSession()
    {
        connection.CreateOrGetConnection();
        return "Session";
    }
}