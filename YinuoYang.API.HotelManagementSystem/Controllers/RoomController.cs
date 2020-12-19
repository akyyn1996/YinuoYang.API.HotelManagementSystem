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
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllRoomTypes()
        {
            var roomTypes = await _roomService.GetAllRoomsAsync();
            return Ok(roomTypes);
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CreateNewRoomType(RoomRequestModel roomRequest)
        {
            await _roomService.AddRoomAsync(roomRequest);
            return Ok();
        }

        [HttpPut]
        [Route("")]
        public async Task<IActionResult> UpdateRoomType(RoomRequestModel roomRequest)
        {
            await _roomService.UpdateRoomAsync(roomRequest);
            return Ok();
        }

        [HttpDelete]
        [Route("id")]
        public async Task<IActionResult> DeleteRoom(int id)
        {
            await _roomService.DeleteRoomAsync(id);
            return Ok();
        }
    }
}
