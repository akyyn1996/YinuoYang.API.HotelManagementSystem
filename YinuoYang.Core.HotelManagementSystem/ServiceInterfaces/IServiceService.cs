using System.Collections.Generic;
using System.Threading.Tasks;
using YinuoYang.Core.HotelManagementSystem.Models.Request;
using YinuoYang.Core.HotelManagementSystem.Models.Response;

namespace YinuoYang.Core.HotelManagementSystem.ServiceInterfaces
{
    public interface IServiceService
    {
        Task AddServiceAsync(ServiceRequestModel serviceRequest);
        Task UpdateServiceAsync(ServiceRequestModel serviceRequest);
        Task DeleteServiceAsync(int serviceId);

        Task<IEnumerable<ServiceResponseModel>> GetAllServicesAsync();
    }
}