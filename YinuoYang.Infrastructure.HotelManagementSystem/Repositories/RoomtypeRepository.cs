using YinuoYang.Core.HotelManagementSystem.Entities;
using YinuoYang.Core.HotelManagementSystem.RepositoryInterfaces;
using YinuoYang.Infrastructure.HotelManagementSystem.Data;

namespace YinuoYang.Infrastructure.HotelManagementSystem.Repositories
{
    public class RoomtypeRepository : EfRepository<Roomtype>, IRoomtypeRepository
    {
        public RoomtypeRepository(HotelManagementDbContext dbContext) : base(dbContext)
        {
        }

    }
}