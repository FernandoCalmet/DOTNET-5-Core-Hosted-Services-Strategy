using System.Threading.Tasks;

namespace HostedServiceStrategy.Contracts
{
    public interface INotification
    {
        Task ExecuteAsync();
    }
}