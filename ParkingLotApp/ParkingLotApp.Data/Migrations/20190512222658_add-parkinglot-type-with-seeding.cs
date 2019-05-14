using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingLotApp.Data.Migrations
{
    public partial class addparkinglottypewithseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ParkingLotTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingLotTypes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ParkingLotTypes",
                columns: new[] { "Id", "Description" },
                values: new object[] { 1, "Parking Garage" });

            migrationBuilder.InsertData(
                table: "ParkingLotTypes",
                columns: new[] { "Id", "Description" },
                values: new object[] { 2, "On Street" });

            migrationBuilder.InsertData(
                table: "ParkingLotTypes",
                columns: new[] { "Id", "Description" },
                values: new object[] { 3, "Business" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParkingLotTypes");
        }
    }
}
