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
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }


        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CreateNewCustomerAsync(CustomerRequestModel customerRequest)
        {
            await _customerService.AddCustomerAsync(customerRequest);
            return Ok();
        }

        [HttpPut]
        [Route("")]
        public async Task<IActionResult> UpdateCustomerAsync(CustomerRequestModel customerRequest)
        {
            await _customerService.UpdateCustomerAsync(customerRequest);
            return Ok();
        }

        [HttpDelete]
        [Route("")]
        public async Task<IActionResult> DeleteCustomerAsync(int customerId)
        {
            await _customerService.DeleteCustomerAsync(customerId);
            return Ok();
        }


        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllCustomerAsync()
        {
            var customers = await _customerService.GetAllCustomersAsync();
            return Ok(customers);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetCustomerByIdAsync(int id)
        {
            var customers = await _customerService.GetCustomerDetailAsync(id);
            return Ok(customers);
        }



    }
}
