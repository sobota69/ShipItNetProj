
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ShipItNetProj.Services;

public class Program
    {
        static void Main(string[] args)
        {
            var host = CreateHost(args);
        }

        static IHost CreateHost(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices(ConfigureServices)
                .Build();

    static void ConfigureServices(IServiceCollection services)
    {
        services.AddTransient<IMessageService, MessageService>();
        services.AddTransient<IMessageServiceWrapper, MessageServiceWrapper>();    
        }
    }
