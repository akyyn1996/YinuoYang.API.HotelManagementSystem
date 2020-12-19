using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace YinuoYang.Core.HotelManagementSystem.Entities
{
    public class Room
    {
        public int Id { get; set; }

        [ForeignKey("Roomtype")]
        public int? RTCode { get; set; }
        public bool? Status { get; set; }

        public Roomtype Roomtype { get; set; }
        public ICollection<Customer> Customers { get; set; }

        public ICollection<Service> Services { get; set; }
    }
}