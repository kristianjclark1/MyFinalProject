using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingLotApp.Data.Migrations
{
    public partial class addedleaserelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReserveParkingSpaces",
                columns: table => new
                {
                    AppUserId = table.Column<string>(nullable: false),
                    ParkingSpaceId = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Fare = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReserveParkingSpaces", x => new { x.ParkingSpaceId, x.AppUserId });
                    table.ForeignKey(
                        name: "FK_ReserveParkingSpaces_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReserveParkingSpaces_parkingLots_ParkingSpaceId",
                        column: x => x.ParkingSpaceId,
                        principalTable: "parkingLots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReserveParkingSpaces_AppUserId",
                table: "ReserveParkingSpaces",
                column: "AppUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReserveParkingSpaces");
        }
    }
}
