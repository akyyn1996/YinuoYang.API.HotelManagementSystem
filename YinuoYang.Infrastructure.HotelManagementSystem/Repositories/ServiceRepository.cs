using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YinuoYang.Core.HotelManagementSystem.Entities;
using YinuoYang.Core.HotelManagementSystem.RepositoryInterfaces;
using YinuoYang.Infrastructure.HotelManagementSystem.Data;

namespace YinuoYang.Infrastructure.HotelManagementSystem.Repositories
{
    public class ServiceRepository : EfRepository<Service>, IServiceRepository
    {
        public ServiceRepository(HotelManagementDbContext dbContext) : base(dbContext)
        {
        }


        public async Task<IEnumerable<Service>> GetServicesByCustomer(int roomId)
        {
            var services = await _dbContext.Services.Where(s => s.RoomNo == roomId).ToListAsync();
            return services;
        }
    }
}