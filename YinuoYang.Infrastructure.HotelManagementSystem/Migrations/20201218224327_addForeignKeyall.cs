using Microsoft.EntityFrameworkCore.Migrations;

namespace YinuoYang.Infrastructure.HotelManagementSystem.Migrations
{
    public partial class addForeignKeyall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Services_RoomNo",
                table: "Services",
                column: "RoomNo");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_RoomNo",
                table: "Customers",
                column: "RoomNo");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Rooms_RoomNo",
                table: "Customers",
                column: "RoomNo",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Rooms_RoomNo",
                table: "Services",
                column: "RoomNo",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Rooms_RoomNo",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_Rooms_RoomNo",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_RoomNo",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Customers_RoomNo",
                table: "Customers");
        }
    }
}
