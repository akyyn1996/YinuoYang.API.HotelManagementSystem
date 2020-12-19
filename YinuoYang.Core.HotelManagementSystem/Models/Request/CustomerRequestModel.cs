using System;
using System.ComponentModel.DataAnnotations;

namespace YinuoYang.Core.HotelManagementSystem.Models.Request
{
    public class CustomerRequestModel
    {

        public int Id { get; set; }
        public int? RoomNo { get; set; }
        
        [Required]
        [StringLength(20)]
        public string CName { get; set; }

        [StringLength(200)]

        public string Address { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(40)]
        [EmailAddress]
        public string Email { get; set; }
        public DateTime? CheckIn { get; set; }
        public int? TotalPersons { get; set; }
        public int? BookingDays { get; set; }

        [Range(0, 500000000)]
        public decimal? Advance { get; set; }
    }
}