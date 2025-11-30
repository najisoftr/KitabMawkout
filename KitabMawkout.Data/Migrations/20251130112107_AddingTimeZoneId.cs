using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KitabMawkout.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingTimeZoneId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TimeZoneId",
                table: "MySettings",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeZoneId",
                table: "MySettings");
        }
    }
}
