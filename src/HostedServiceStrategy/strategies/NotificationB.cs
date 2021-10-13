using System;
using System.Threading.Tasks;
using HostedServiceStrategy.Contracts;

namespace HostedServiceStrategy.Strategies
{
    public class NotificationB : INotification
    {
        public NotificationB()
        {
            Console.WriteLine("...Notification B Sent...");
        }
        public async Task ExecuteAsync()
        {
            await Task.Run(() => Console.WriteLine("Notification B: Executing"));
        }
    }
}