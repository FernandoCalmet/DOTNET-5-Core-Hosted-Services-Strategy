using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using HostedServiceStrategy.Utils;
using HostedServiceStrategy.Contracts;

namespace HostedServiceStrategy.Context
{
    public class NotificationServiceContext : BackgroundService
    {
        private IServiceScopeFactory _serviceScopeFactory;
        public NotificationServiceContext(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
           var type = DriverQueue.TryDequeue();
            while (type != null)
            {
                using (var scope = _serviceScopeFactory.CreateScope())
                {
                    INotification cmd = scope.ServiceProvider.GetRequiredService(type) as INotification;

                    if (cmd != null)
                    {
                        await cmd.ExecuteAsync();
                    }
                    await Task.Delay(3000);
                }
                type = DriverQueue.TryDequeue();
            };
        }
    }
}