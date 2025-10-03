namespace ShipItNetProj.Services;
public interface IConnectionProvider
{
    string GetConnectionString();
}

public class ConnectionProvider() : IConnectionProvider
{
    public string GetConnectionString()
    {
        return "ConnectionString";
    }
}