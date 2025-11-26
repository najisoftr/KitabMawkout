using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KitabMawkout.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MySettings",
                columns: table => new
                {
                    MySettingsId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Longitude = table.Column<double>(type: "REAL", nullable: false),
                    Latitude = table.Column<double>(type: "REAL", nullable: false),
                    MyMadhab = table.Column<int>(type: "INTEGER", nullable: false),
                    MyCalculationMethode = table.Column<int>(type: "INTEGER", nullable: false),
                    DesMasjid = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MySettings", x => x.MySettingsId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MySettings");
        }
    }
}
