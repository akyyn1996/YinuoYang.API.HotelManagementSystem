using System.Collections.Generic;
using System.Threading.Tasks;
using YinuoYang.Core.HotelManagementSystem.Entities;

namespace YinuoYang.Core.HotelManagementSystem.RepositoryInterfaces
{
    public interface IRoomRepository : IAsyncRepository<Room>
    {
        Task<IEnumerable<Room>> GetRoomsByCustomer(int customerId);
    }
}