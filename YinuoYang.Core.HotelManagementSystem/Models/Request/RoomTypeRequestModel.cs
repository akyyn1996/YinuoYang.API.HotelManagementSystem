using System.ComponentModel.DataAnnotations;

namespace YinuoYang.Core.HotelManagementSystem.Models.Request
{
    public class RoomTypeRequestModel
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Rtdesc { get; set; }
        public decimal? Rent { get; set; }
    }
}