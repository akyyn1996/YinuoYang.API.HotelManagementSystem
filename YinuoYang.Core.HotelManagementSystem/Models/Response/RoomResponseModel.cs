using YinuoYang.Core.HotelManagementSystem.Entities;

namespace YinuoYang.Core.HotelManagementSystem.Models.Response
{
    public class RoomResponseModel
    {
        public int Id { get; set; }

        public int? RTCode { get; set; }
        public bool? Status { get; set; }

        public Roomtype Roomtype { get; set; }
    }
}