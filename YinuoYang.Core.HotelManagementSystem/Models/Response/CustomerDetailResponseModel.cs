using System;
using System.Collections.Generic;
using YinuoYang.Core.HotelManagementSystem.Entities;

namespace YinuoYang.Core.HotelManagementSystem.Models.Response
{
    public class CustomerDetailResponseModel
    {
        public int Id { get; set; }
        public int? RoomNo { get; set; }
        public string CName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime? CheckIn { get; set; }
        public int? TotalPersons { get; set; }
        public int? BookingDays { get; set; }
        public decimal? Advance { get; set; }

        public RoomResponseModel Room { get; set; }

        public ICollection<Service> Services { get; set; }
    }
}