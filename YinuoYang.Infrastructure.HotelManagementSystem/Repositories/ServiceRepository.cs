using System.Collections.Generic;
using System.Threading.Tasks;
using YinuoYang.Core.HotelManagementSystem.Entities;
using YinuoYang.Core.HotelManagementSystem.RepositoryInterfaces;
using YinuoYang.Infrastructure.HotelManagementSystem.Data;

namespace YinuoYang.Infrastructure.HotelManagementSystem.Repositories
{
    public class ServiceRepository : EfRepository<Room>, IRoomRepository
    {
        public ServiceRepository(HotelManagementDbContext dbContext) : base(dbContext)
        {
        }

        public Task<IEnumerable<Room>> GetRoomsByCustomer(int customerId)
        {
            throw new System.NotImplementedException();
        }
    }
}