using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace YinuoYang.Core.HotelManagementSystem.Entities
{
    public class Service
    {
        public int Id { get; set; }
        [ForeignKey("Room")]
        public int? RoomNo { get; set; }
        public string Sdesc { get; set; }
        public decimal? amount { get; set; }
        public DateTime? ServiceDate { get; set; }

        public Room Room { get; set; }

    }
}