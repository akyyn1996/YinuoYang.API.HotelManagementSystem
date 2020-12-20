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
    public class RoomtypeController : ControllerBase
    {
        private readonly IRoomTypeService _roomTypeService;

        public RoomtypeController(IRoomTypeService roomTypeService)
        {
            _roomTypeService = roomTypeService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllRoomTypes()
        {
            var roomTypes = await _roomTypeService.GetAllRoomTypesAsync();
            return Ok(roomTypes);
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CreateNewRoomType(RoomTypeRequestModel roomTypeRequest)
        {
            await _roomTypeService.AddRoomTypeAsync(roomTypeRequest);
            return Ok();
        }

        [HttpPut]
        [Route("")]
        public async Task<IActionResult> UpdateRoomType(RoomTypeRequestModel roomTypeRequest)
        {
            await _roomTypeService.UpdateRoomTypeAsync(roomTypeRequest);
            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteRoomType(int id)
        {
            await _roomTypeService.DeleteRoomTypeAsync(id);
            return Ok();
        }

    }
}
