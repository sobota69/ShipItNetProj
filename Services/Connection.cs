using System;
using System.Data;

namespace ShipItNetProj.Services;
public interface IConnection
{
    string CreateOrGetConnection();
}

public class Connection(IConnectionProvider provider) : IConnection
{
    public string CreateOrGetConnection()
    {
        var connString = provider.GetConnectionString();
        return "Connection";
    }
}