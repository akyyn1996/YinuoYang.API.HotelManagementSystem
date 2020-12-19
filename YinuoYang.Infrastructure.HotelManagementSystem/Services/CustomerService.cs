using System.Collections.Generic;
using System.Threading.Tasks;
using YinuoYang.Core.HotelManagementSystem.Models.Request;
using YinuoYang.Core.HotelManagementSystem.Models.Response;
using YinuoYang.Core.HotelManagementSystem.ServiceInterfaces;

namespace YinuoYang.Infrastructure.HotelManagementSystem.Services
{
    public class CustomerService : ICustomerService
    {
        public Task AddCustomerAsync(CustomerRequestModel customerRequest)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteCustomerAsync(int roomTypeId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<CustomerResponseModel>> GetAllCustomersAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<CustomerDetailResponseModel> GetCustomerDetailAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<RoomResponseModel> GetRoomForCustomerAsync(int customerId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<ServiceResponseModel>> GetServicesForCustomerAsync(int customerId)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateCustomerAsync(CustomerRequestModel customerRequest)
        {
            throw new System.NotImplementedException();
        }
    }
}