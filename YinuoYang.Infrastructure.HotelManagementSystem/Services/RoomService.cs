using System.Collections.Generic;
using System.Threading.Tasks;
using YinuoYang.Core.HotelManagementSystem.Entities;
using YinuoYang.Core.HotelManagementSystem.Models.Request;
using YinuoYang.Core.HotelManagementSystem.Models.Response;
using YinuoYang.Core.HotelManagementSystem.RepositoryInterfaces;
using YinuoYang.Core.HotelManagementSystem.ServiceInterfaces;

namespace YinuoYang.Infrastructure.HotelManagementSystem.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;

        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }
        public async Task AddRoomAsync(RoomRequestModel roomRequest)
        {
            var room = new Room
            {
                Id = roomRequest.Id,
                RTCode = roomRequest.RTCode,
                Status = roomRequest.Status
            };

            await _roomRepository.AddAsync(room);
        }

        public async Task DeleteRoomAsync(int roomId)
        {
            var roomType = await _roomRepository.GetByIdAsync(roomId);
            await _roomRepository.DeleteAsync(roomType);
        }

        public async Task<IEnumerable<RoomResponseModel>> GetAllRoomsAsync()
        {
            var rooms = await _roomRepository.ListAllAsync();
            var response = new List<RoomResponseModel>();
            foreach (var room in rooms)
            {
                response.Add(new RoomResponseModel
                {
                    Id = room.Id,
                    RTCode = room.RTCode,
                    Status = room.Status
                });
            }

            return response;
        }

        public async Task UpdateRoomAsync(RoomRequestModel roomRequest)
        {
            var room = new Room
            {
                Id = roomRequest.Id,
                RTCode = roomRequest.RTCode,
                Status = roomRequest.Status
            };

            await _roomRepository.UpdateAsync(room);
        }
    }
}