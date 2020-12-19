using System.Collections.Generic;
using System.Threading.Tasks;
using YinuoYang.Core.HotelManagementSystem.Entities;
using YinuoYang.Core.HotelManagementSystem.Models.Request;
using YinuoYang.Core.HotelManagementSystem.Models.Response;

namespace YinuoYang.Core.HotelManagementSystem.ServiceInterfaces
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerResponseModel>> GetAllCustomersAsync();

        Task<CustomerDetailResponseModel> GetCustomerDetailAsync(int id);

        Task AddCustomerAsync(CustomerRequestModel customerRequest);
        Task UpdateCustomerAsync(CustomerRequestModel customerRequest);
        Task DeleteCustomerAsync(int roomTypeId);

        Task<RoomResponseModel> GetRoomForCustomerAsync(int customerId);

        Task<IEnumerable<ServiceResponseModel>> GetServicesForCustomerAsync(int customerId);

    }
}