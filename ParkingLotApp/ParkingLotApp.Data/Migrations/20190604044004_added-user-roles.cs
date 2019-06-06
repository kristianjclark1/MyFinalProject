using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingLotApp.Data.Migrations
{
    public partial class addeduserroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5006367a-2fc2-42d5-9d1e-a3d2874547ba", "aa969528-afc9-406e-a70c-ce07d71fec49", "Driver", "DRIVER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f914d34b-3798-4322-89bf-fab84e57c0db", "826d9ac2-042f-487d-a50e-53d316852a12", "ParkingSpace", "PARKINGSPACE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5006367a-2fc2-42d5-9d1e-a3d2874547ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f914d34b-3798-4322-89bf-fab84e57c0db");
        }
    }
}
