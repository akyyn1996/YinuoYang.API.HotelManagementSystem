using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YinuoYang.Core.HotelManagementSystem.Entities;

namespace YinuoYang.Infrastructure.HotelManagementSystem.Data
{
    public class HotelManagementDbContext: DbContext
    {
        public HotelManagementDbContext(DbContextOptions<HotelManagementDbContext> options): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>(ConfigureRoom);
            modelBuilder.Entity<Roomtype>(ConfigureRoomtype);
            modelBuilder.Entity<Service>(ConfigureService);
            modelBuilder.Entity<Customer>(ConfigureCustomer);

        }

        private void ConfigureRoom(EntityTypeBuilder<Room> builder)
        {
            builder.ToTable("Rooms");

        }

        private void ConfigureRoomtype(EntityTypeBuilder<Roomtype> builder)
        {
            builder.ToTable("RoomTypes");
            builder.Property(m => m.Rtdesc).HasMaxLength(20);

        }
        private void ConfigureService(EntityTypeBuilder<Service> builder)
        {
            builder.ToTable("Services");
            builder.Property(m => m.Sdesc).HasMaxLength(50);
            builder.Property(m => m.ServiceDate).HasDefaultValueSql("getdate()");

        }

        private void ConfigureCustomer(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");
            builder.Property(m => m.CName).HasMaxLength(20);
            builder.Property(m => m.Address).HasMaxLength(100);
            builder.Property(m => m.Phone).HasMaxLength(20);
            builder.Property(m => m.Email).HasMaxLength(40);
            builder.Property(m => m.CheckIn).HasDefaultValueSql("getdate()");
        }


        public DbSet<Room> Rooms { get; set; }

        public DbSet<Roomtype> Roomtypes { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<Customer> Customers { get; set; }
    }
}