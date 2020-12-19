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

    }
}