using System.Collections.Generic;
using System.Threading.Tasks;
using YinuoYang.Core.HotelManagementSystem.Entities;

namespace YinuoYang.Core.HotelManagementSystem.RepositoryInterfaces
{
    public interface IServiceRepository : IAsyncRepository<Service>
    {
        Task<IEnumerable<Service>> GetServicesByCustomer(int customerId);
    }
}