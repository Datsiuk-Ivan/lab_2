using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab02.Data.Migrations
{
    /// <inheritdoc />
    public partial class ImproveDataModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "Valid");

            migrationBuilder.CreateIndex(
                name: "IX_MonitoringPoints_Code",
                table: "MonitoringPoints",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_Name",
                table: "Locations",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instruments_SerialNumber",
                table: "Instruments",
                column: "SerialNumber",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_MonitoringPoints_Code",
                table: "MonitoringPoints");

            migrationBuilder.DropIndex(
                name: "IX_Locations_Name",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Instruments_SerialNumber",
                table: "Instruments");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Measurements");
        }
    }
}
