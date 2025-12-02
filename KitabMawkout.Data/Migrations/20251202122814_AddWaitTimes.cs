using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KitabMawkout.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddWaitTimes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AsrWait",
                table: "MySettings",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DohrWait",
                table: "MySettings",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FadjWait",
                table: "MySettings",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IshabWait",
                table: "MySettings",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MoghrebWait",
                table: "MySettings",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AsrWait",
                table: "MySettings");

            migrationBuilder.DropColumn(
                name: "DohrWait",
                table: "MySettings");

            migrationBuilder.DropColumn(
                name: "FadjWait",
                table: "MySettings");

            migrationBuilder.DropColumn(
                name: "IshabWait",
                table: "MySettings");

            migrationBuilder.DropColumn(
                name: "MoghrebWait",
                table: "MySettings");
        }
    }
}
