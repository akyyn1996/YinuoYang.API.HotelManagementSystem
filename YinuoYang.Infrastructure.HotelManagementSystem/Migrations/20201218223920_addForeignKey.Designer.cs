﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YinuoYang.Infrastructure.HotelManagementSystem.Data;

namespace YinuoYang.Infrastructure.HotelManagementSystem.Migrations
{
    [DbContext(typeof(HotelManagementDbContext))]
    [Migration("20201218223920_addForeignKey")]
    partial class addForeignKey
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("YinuoYang.Core.HotelManagementSystem.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal?>("Advance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("BookingDays")
                        .HasColumnType("int");

                    b.Property<string>("CName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime?>("CheckIn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Email")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("RoomNo")
                        .HasColumnType("int");

                    b.Property<int?>("TotalPersons")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("YinuoYang.Core.HotelManagementSystem.Entities.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("RTCode")
                        .HasColumnType("int");

                    b.Property<bool?>("Type")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("RTCode");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("YinuoYang.Core.HotelManagementSystem.Entities.Roomtype", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal?>("Rent")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Rtdesc")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("RoomTypes");
                });

            modelBuilder.Entity("YinuoYang.Core.HotelManagementSystem.Entities.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("RoomNo")
                        .HasColumnType("int");

                    b.Property<string>("Sdesc")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("ServiceDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<decimal?>("amount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("YinuoYang.Core.HotelManagementSystem.Entities.Room", b =>
                {
                    b.HasOne("YinuoYang.Core.HotelManagementSystem.Entities.Roomtype", "Roomtype")
                        .WithMany("Rooms")
                        .HasForeignKey("RTCode");

                    b.Navigation("Roomtype");
                });

            modelBuilder.Entity("YinuoYang.Core.HotelManagementSystem.Entities.Roomtype", b =>
                {
                    b.Navigation("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}
