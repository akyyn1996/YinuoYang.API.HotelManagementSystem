using Microsoft.EntityFrameworkCore.Migrations;

namespace YinuoYang.Infrastructure.HotelManagementSystem.Migrations
{
    public partial class addForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RTCode",
                table: "Rooms",
                column: "RTCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_RoomTypes_RTCode",
                table: "Rooms",
                column: "RTCode",
                principalTable: "RoomTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_RoomTypes_RTCode",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_RTCode",
                table: "Rooms");
        }
    }
}
