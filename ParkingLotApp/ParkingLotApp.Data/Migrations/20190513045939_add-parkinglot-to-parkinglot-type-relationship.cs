using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingLotApp.Data.Migrations
{
    public partial class addparkinglottoparkinglottyperelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParkingLotTypeId",
                table: "parkingLots",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_parkingLots_ParkingLotTypeId",
                table: "parkingLots",
                column: "ParkingLotTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_parkingLots_ParkingLotTypes_ParkingLotTypeId",
                table: "parkingLots",
                column: "ParkingLotTypeId",
                principalTable: "ParkingLotTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_parkingLots_ParkingLotTypes_ParkingLotTypeId",
                table: "parkingLots");

            migrationBuilder.DropIndex(
                name: "IX_parkingLots_ParkingLotTypeId",
                table: "parkingLots");

            migrationBuilder.DropColumn(
                name: "ParkingLotTypeId",
                table: "parkingLots");
        }
    }
}
