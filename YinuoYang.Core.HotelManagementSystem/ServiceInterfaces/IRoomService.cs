using System.Collections.Generic;
using System.Threading.Tasks;
using YinuoYang.Core.HotelManagementSystem.Models.Request;
using YinuoYang.Core.HotelManagementSystem.Models.Response;

namespace YinuoYang.Core.HotelManagementSystem.ServiceInterfaces
{
    public interface IRoomService
    {
        Task AddRoomAsync(RoomRequestModel roomRequest);
        Task UpdateRoomAsync(RoomRequestModel roomRequest);
        Task DeleteRoomAsync(int roomId);

        Task<IEnumerable<RoomResponseModel>> GetAllRoomsAsync();
        Task<RoomResponseModel> GetRoomByIdAsync(int id);
    }
}