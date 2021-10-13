using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using HostedServiceStrategy.Strategies;
using HostedServiceStrategy.Contracts;

namespace HostedServiceStrategy
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var builder = new HostBuilder()
            .ConfigureServices((hostContext, services) =>
            {
                services.AddOptions();
                services.AddSingleton<IStarPrinter, TriangleStarPrinter>();
                services.AddHostedService<NotificationServiceContext>();
                services.AddScoped<NotificationA>();
                services.AddScoped<NotificationB>();
                services.AddScoped<NotificationC>();
                services.AddScoped<NotificationD>();
            });
            await builder.RunConsoleAsync();
        }
    }
}
