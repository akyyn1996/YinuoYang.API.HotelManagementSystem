using System.Collections.Generic;
using System.Threading.Tasks;
using YinuoYang.Core.HotelManagementSystem.Entities;
using YinuoYang.Core.HotelManagementSystem.Models.Request;
using YinuoYang.Core.HotelManagementSystem.Models.Response;
using YinuoYang.Core.HotelManagementSystem.RepositoryInterfaces;
using YinuoYang.Core.HotelManagementSystem.ServiceInterfaces;

namespace YinuoYang.Infrastructure.HotelManagementSystem.Services
{
    public class RoomTypeService : IRoomTypeService
    {
        private readonly IRoomtypeRepository _roomtypeRepository;

        public RoomTypeService(IRoomtypeRepository roomtypeRepository)
        {
            _roomtypeRepository = roomtypeRepository;
        }
        public async Task AddRoomTypeAsync(RoomTypeRequestModel roomTypeRequest)
        {
            var roomType = new Roomtype
            {
                Id = roomTypeRequest.Id,
                Rent = roomTypeRequest.Rent,
                Rtdesc = roomTypeRequest.Rtdesc
            };
            await _roomtypeRepository.AddAsync(roomType);

        }

        public async Task DeleteRoomTypeAsync(int roomTypeId)
        {
            var roomType = await _roomtypeRepository.GetByIdAsync(roomTypeId);
            await _roomtypeRepository.DeleteAsync(roomType);

        }

        public async Task<IEnumerable<RoomTypeResponseModel>> GetAllRoomTypesAsync()
        {
            var roomTypes = await _roomtypeRepository.ListAllAsync();
            var response = new List<RoomTypeResponseModel>();
            foreach (var roomtype in roomTypes)
            {
                response.Add(new RoomTypeResponseModel
                {
                    Id = roomtype.Id,
                    Rent = roomtype.Rent,
                    Rtdesc = roomtype.Rtdesc
                });
            }

            return response;

        }

        public async Task UpdateRoomTypeAsync(RoomTypeRequestModel roomTypeRequest)
        {

            var roomType = new Roomtype
            {
                Id = roomTypeRequest.Id,
                Rent = roomTypeRequest.Rent,
                Rtdesc = roomTypeRequest.Rtdesc
            };
            await _roomtypeRepository.UpdateAsync(roomType);
        }
    }
}