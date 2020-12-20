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
        public async Task<IActionResult> GetAllRooms()
        {
            var rooms = await _roomService.GetAllRoomsAsync();
            return Ok(rooms);
        }

        [HttpGet]
        [Route("available")]
        public async Task<IActionResult> GetAvailableRooms()
        {
            var rooms = await _roomService.GetAvailableRoomsAsync();
            return Ok(rooms);
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CreateNewRoom(RoomRequestModel roomRequest)
        {
            await _roomService.AddRoomAsync(roomRequest);
            return Ok();
        }

        [HttpPut]
        [Route("")]
        public async Task<IActionResult> UpdateRoom(RoomRequestModel roomRequest)
        {
            await _roomService.UpdateRoomAsync(roomRequest);
            return Ok();
        }

        [HttpPut]
        [Route("leave/{id}")]
        public async Task<IActionResult> UpdateRoom(int id)
        {
            await _roomService.SetRoomOccupiedByIdAsync(id);
            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteRoom(int id)
        {
            await _roomService.DeleteRoomAsync(id);
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetRoomById(int id)
        {
            var room = await _roomService.GetRoomByIdAsync(id);
            return Ok(room);
        }
    }
}
