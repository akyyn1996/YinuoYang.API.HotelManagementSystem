using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using YinuoYang.Core.HotelManagementSystem.Entities;
using YinuoYang.Core.HotelManagementSystem.RepositoryInterfaces;
using YinuoYang.Infrastructure.HotelManagementSystem.Data;

namespace YinuoYang.Infrastructure.HotelManagementSystem.Repositories
{
    public class RoomRepository : EfRepository<Room>, IRoomRepository
    {
        public RoomRepository(HotelManagementDbContext dbContext) : base(dbContext)
        {
        }

        public override async Task<Room> GetByIdAsync(int id)
        {
            var room = await _dbContext.Rooms
                .Include(m => m.Roomtype).Include(m => m.Services)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (room == null) return null;

            return room;
        }
        public Task<IEnumerable<Room>> GetRoomsByCustomer(int customerId)
        {
            throw new System.NotImplementedException();
        }
    }
}