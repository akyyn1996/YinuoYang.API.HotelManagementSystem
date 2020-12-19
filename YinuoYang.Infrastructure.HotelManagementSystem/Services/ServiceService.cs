using System.Collections.Generic;
using System.Threading.Tasks;
using YinuoYang.Core.HotelManagementSystem.Models.Request;
using YinuoYang.Core.HotelManagementSystem.Models.Response;
using YinuoYang.Core.HotelManagementSystem.ServiceInterfaces;

namespace YinuoYang.Infrastructure.HotelManagementSystem.Services
{
    public class ServiceService : IServiceService
    {
        public Task AddServiceAsync(ServiceRequestModel serviceRequest)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteServiceAsync(int serviceId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<ServiceResponseModel>> GetAllServicesAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateServiceAsync(ServiceRequestModel serviceRequest)
        {
            throw new System.NotImplementedException();
        }
    }
}