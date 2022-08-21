using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksApi.Migrations
{
    public partial class SeedUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5,
                column: "ParkMgmt",
                value: "National Park");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6,
                column: "ParkMgmt",
                value: "National Park");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 11,
                column: "ParkMgmt",
                value: "National Park");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5,
                column: "ParkMgmt",
                value: "National Parks");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6,
                column: "ParkMgmt",
                value: "National Parks");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 11,
                column: "ParkMgmt",
                value: "National Parks");
        }
    }
}
