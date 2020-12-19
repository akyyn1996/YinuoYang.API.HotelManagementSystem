using System.Collections.Generic;
using System.Threading.Tasks;
using YinuoYang.Core.HotelManagementSystem.Models.Request;
using YinuoYang.Core.HotelManagementSystem.Models.Response;
using YinuoYang.Core.HotelManagementSystem.ServiceInterfaces;

namespace YinuoYang.Infrastructure.HotelManagementSystem.Services
{
    public class RoomTypeService : IRoomTypeService
    {
        public Task AddRoomTypeAsync(RoomTypeRequestModel roomTypeRequest)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteRoomTypeAsync(int roomTypeId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<RoomTypeResponseModel>> GetAllRoomTypesAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateRoomTypeAsync(RoomTypeRequestModel roomTypeRequest)
        {
            throw new System.NotImplementedException();
        }
    }
}