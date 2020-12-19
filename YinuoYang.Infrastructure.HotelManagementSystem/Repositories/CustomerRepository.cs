using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using YinuoYang.Core.HotelManagementSystem.Entities;
using YinuoYang.Core.HotelManagementSystem.RepositoryInterfaces;
using YinuoYang.Infrastructure.HotelManagementSystem.Data;

namespace YinuoYang.Infrastructure.HotelManagementSystem.Repositories
{
    public class CustomerRepository: EfRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(HotelManagementDbContext dbContext) : base(dbContext)
        {
        }


        public override async Task<Customer> GetByIdAsync(int id)
        {
            var customer = await _dbContext.Customers
                .Include(m => m.Room).ThenInclude(m => m.Services)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null) return null;

            return customer;
        }
    }
}