using System;
using System.Threading.Tasks;
using HostedServiceStrategy.Contracts;

namespace HostedServiceStrategy.Strategies
{
    public class NotificationC : INotification
    {
        public NotificationC()
        {
            Console.WriteLine("...Notification C Sent...");
        }
        public async Task ExecuteAsync()
        {
            await Task.Run(() => Console.WriteLine("Notification C: Executing"));
        }
    }
}