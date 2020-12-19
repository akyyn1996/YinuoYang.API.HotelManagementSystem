using System.Collections.Generic;
using System.Threading.Tasks;
using YinuoYang.Core.HotelManagementSystem.Models.Request;
using YinuoYang.Core.HotelManagementSystem.Models.Response;
using YinuoYang.Core.HotelManagementSystem.ServiceInterfaces;

namespace YinuoYang.Infrastructure.HotelManagementSystem.Services
{
    public class RoomService : IRoomService
    {
        public Task AddRoomAsync(RoomRequestModel roomRequest)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteRoomAsync(int roomId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<RoomResponseModel>> GetAllRoomsAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateRoomAsync(RoomRequestModel roomRequest)
        {
            throw new System.NotImplementedException();
        }
    }
}