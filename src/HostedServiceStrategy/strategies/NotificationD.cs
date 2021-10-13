using System;
using System.Threading.Tasks;
using HostedServiceStrategy.Contracts;

namespace HostedServiceStrategy.Strategies
{
    public class NotificationD : INotification
    {
        private readonly IStarPrinter _starPrinter;
        public NotificationD(IStarPrinter starPrinter)
        {
            Console.WriteLine("...Notification D Sent...");
            _starPrinter = starPrinter;
        }
        public async Task ExecuteAsync()
        {
            await Task.Run(() => _starPrinter.Print());
        }
    }
}