using System;
using System.ComponentModel.DataAnnotations;

namespace YinuoYang.Core.HotelManagementSystem.Models.Request
{
    public class CustomerRequestModel
    {
        //don`t need id in the request or not?
        public int Id { get; set; }
        public int? RoomNo { get; set; }
        
        [Required]
        public string CName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime? CheckIn { get; set; }
        public int? TotalPersons { get; set; }
        public int? BookingDays { get; set; }
        public decimal? Advance { get; set; }
    }
}