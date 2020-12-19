using System;

namespace YinuoYang.Core.HotelManagementSystem.Models.Response
{
    public class CustomerResponseModel
    {
        public int Id { get; set; }
        public string CName { get; set; }
        public string Phone { get; set; }
        public DateTime? CheckIn { get; set; }
        public int? BookingDays { get; set; }
    }
}