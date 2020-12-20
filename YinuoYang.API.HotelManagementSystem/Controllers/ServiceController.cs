using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YinuoYang.Core.HotelManagementSystem.Models.Request;
using YinuoYang.Core.HotelManagementSystem.ServiceInterfaces;

namespace YinuoYang.API.HotelManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllServices()
        {
            var services = await _serviceService.GetAllServicesAsync();
            return Ok(services);
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CreateNewService(ServiceRequestModel serviceRequest)
        {
            await _serviceService.AddServiceAsync(serviceRequest);
            return Ok();
        }

        [HttpPut]
        [Route("")]
        public async Task<IActionResult> UpdateService(ServiceRequestModel serviceRequest)
        {
            await _serviceService.UpdateServiceAsync(serviceRequest);
            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteService(int id)
        {
            await _serviceService.DeleteServiceAsync(id);
            return Ok();
        }
    }
}
