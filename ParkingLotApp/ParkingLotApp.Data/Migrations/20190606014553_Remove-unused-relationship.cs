using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingLotApp.Data.Migrations
{
    public partial class Removeunusedrelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_parkingLots_AspNetUsers_AppUserId",
                table: "parkingLots");

            migrationBuilder.DropIndex(
                name: "IX_parkingLots_AppUserId",
                table: "parkingLots");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5006367a-2fc2-42d5-9d1e-a3d2874547ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f914d34b-3798-4322-89bf-fab84e57c0db");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "parkingLots");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dff3f7d6-a5af-4fe7-9392-453be05fa9a5", "e28b8298-4b9d-4d20-bfeb-848de5cbdb72", "Driver", "DRIVER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "05b529dc-b77a-496a-9831-23ede57d772a", "69a32fb1-3da5-49e0-bd9e-b66a6fe99358", "ParkingSpace", "PARKINGSPACE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05b529dc-b77a-496a-9831-23ede57d772a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dff3f7d6-a5af-4fe7-9392-453be05fa9a5");

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "parkingLots",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5006367a-2fc2-42d5-9d1e-a3d2874547ba", "aa969528-afc9-406e-a70c-ce07d71fec49", "Driver", "DRIVER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f914d34b-3798-4322-89bf-fab84e57c0db", "826d9ac2-042f-487d-a50e-53d316852a12", "ParkingSpace", "PARKINGSPACE" });

            migrationBuilder.CreateIndex(
                name: "IX_parkingLots_AppUserId",
                table: "parkingLots",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_parkingLots_AspNetUsers_AppUserId",
                table: "parkingLots",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
