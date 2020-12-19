using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace YinuoYang.Core.HotelManagementSystem.Entities
{
    [Table("Roomtype")]
    public class Roomtype
    {
        public int Id { get; set; }

        public string Rtdesc { get; set; }

        public decimal? Rent { get; set; }

        public ICollection<Room> Rooms { get; set; }
        
    }
}