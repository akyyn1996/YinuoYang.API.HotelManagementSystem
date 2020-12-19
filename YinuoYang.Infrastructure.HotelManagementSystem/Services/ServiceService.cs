using System.Collections.Generic;
using System.Threading.Tasks;
using YinuoYang.Core.HotelManagementSystem.Entities;
using YinuoYang.Core.HotelManagementSystem.Models.Request;
using YinuoYang.Core.HotelManagementSystem.Models.Response;
using YinuoYang.Core.HotelManagementSystem.RepositoryInterfaces;
using YinuoYang.Core.HotelManagementSystem.ServiceInterfaces;

namespace YinuoYang.Infrastructure.HotelManagementSystem.Services
{
    public class ServiceService : IServiceService
    {
        private readonly IServiceRepository _serviceRepository;

        public ServiceService(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        public async Task AddServiceAsync(ServiceRequestModel serviceRequest)
        {
            var service = new Service
            {
                amount = serviceRequest.amount,
                Id = serviceRequest.Id,
                RoomNo = serviceRequest.RoomNo,
                Sdesc = serviceRequest.Sdesc,
                ServiceDate = serviceRequest.ServiceDate
            };

            await _serviceRepository.AddAsync(service);
        }

        public async Task DeleteServiceAsync(int serviceId)
        {
            var service = await _serviceRepository.GetByIdAsync(serviceId);
            await _serviceRepository.DeleteAsync(service);
        }

        public async Task<IEnumerable<ServiceResponseModel>> GetAllServicesAsync()
        {
            var services = await _serviceRepository.ListAllAsync();
            var response = new List<ServiceResponseModel>();
            foreach (var service in services)
            {
                response.Add(new ServiceResponseModel
                {
                    amount = service.amount,
                    Id = service.Id,
                    RoomNo = service.RoomNo,
                    Sdesc = service.Sdesc,
                    ServiceDate = service.ServiceDate
                });
            }

            return response;
        }

        public async Task UpdateServiceAsync(ServiceRequestModel serviceRequest)
        {
            var service = new Service
            {
                amount = serviceRequest.amount,
                Id = serviceRequest.Id,
                RoomNo = serviceRequest.RoomNo,
                Sdesc = serviceRequest.Sdesc,
                ServiceDate = serviceRequest.ServiceDate
            };

            await _serviceRepository.UpdateAsync(service);
        }
    }
}