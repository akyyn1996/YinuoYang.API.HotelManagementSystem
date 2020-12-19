using System;
using System.ComponentModel.DataAnnotations;

namespace YinuoYang.Core.HotelManagementSystem.Models.Request
{
    public class ServiceRequestModel
    {
        public int Id { get; set; }

        public int? RoomNo { get; set; }

        [StringLength(50)]
        public string Sdesc { get; set; }
        [Range(0, 500000000)]
        public decimal? amount { get; set; }

        public DateTime? ServiceDate { get; set; }
    }
}