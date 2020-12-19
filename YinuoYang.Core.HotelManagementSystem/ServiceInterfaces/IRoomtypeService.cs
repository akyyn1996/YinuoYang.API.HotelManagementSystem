using System.Threading.Tasks;
using YinuoYang.Core.HotelManagementSystem.Models.Request;

namespace YinuoYang.Core.HotelManagementSystem.ServiceInterfaces
{
    public interface IRoomtypeService
    {
        Task AddRoomType(RoomTypeRequestModel reviewRequest);
        Task UpdateRoomType(RoomTypeRequestModel reviewRequest);
        Task DeleteRoomType(int roomTypeId);
    }
}