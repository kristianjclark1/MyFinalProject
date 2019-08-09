using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingLotApp.WebUI.Migrations
{
    public partial class BrandnewparkingSpace : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c58909e-108c-4169-a44a-d54d94a971bc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bbce34e-f2b9-44f8-8836-d07bb4601c4f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "544bf8d3-efe3-466a-aeee-aa357bc49244", "0d0e5a03-86cd-4471-b61f-9cae8130b38c", "Driver", "DRIVER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2d3dcb8f-c193-45b4-8fec-4206e9998d76", "539aa22e-a35e-4781-bea7-497c5e588a95", "ParkingSpace", "PARKINGSPACE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d3dcb8f-c193-45b4-8fec-4206e9998d76");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "544bf8d3-efe3-466a-aeee-aa357bc49244");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6bbce34e-f2b9-44f8-8836-d07bb4601c4f", "193c4c20-660f-4763-9576-c7928fe4653a", "Driver", "DRIVER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4c58909e-108c-4169-a44a-d54d94a971bc", "8d466d94-d8e0-45ad-b86d-788c7c909387", "ParkingSpace", "PARKINGSPACE" });
        }
    }
}
