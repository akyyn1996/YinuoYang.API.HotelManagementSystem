using System.ComponentModel.DataAnnotations;

namespace YinuoYang.Core.HotelManagementSystem.Models.Request
{
    public class RoomRequestModel
    {
        public int Id { get; set; }

        
        public int? RTCode { get; set; }
        public bool? Status { get; set; }

    }
}