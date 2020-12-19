using System;

namespace YinuoYang.Core.HotelManagementSystem.Models.Response
{
    public class ServiceResponseModel
    {
        public int Id { get; set; }

        public int? RoomNo { get; set; }
        public string Sdesc { get; set; }
        public decimal? amount { get; set; }
        public DateTime? ServiceDate { get; set; }
    }
}