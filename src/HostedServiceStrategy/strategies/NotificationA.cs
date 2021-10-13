using System;
using System.Threading.Tasks;
using HostedServiceStrategy.Contracts;

namespace HostedServiceStrategy.Strategies
{
    public class NotificationA : INotification
    {
        public NotificationA()
        {
            Console.WriteLine("...Notification A Sent...");
        }
        public async Task ExecuteAsync()
        {
            await Task.Run(() => Console.WriteLine("Notification A: Executing"));
        }
    }
}