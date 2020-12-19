using System.Collections.Generic;
using System.Threading.Tasks;
using YinuoYang.Core.HotelManagementSystem.Models.Request;
using YinuoYang.Core.HotelManagementSystem.Models.Response;

namespace YinuoYang.Core.HotelManagementSystem.ServiceInterfaces
{
    public interface IRoomTypeService
    {
        Task AddRoomTypeAsync(RoomTypeRequestModel roomTypeRequest);
        Task UpdateRoomTypeAsync(RoomTypeRequestModel roomTypeRequest);
        Task DeleteRoomTypeAsync(int roomTypeId);

        Task<IEnumerable<RoomTypeResponseModel>> GetAllRoomTypesAsync();
    }
}