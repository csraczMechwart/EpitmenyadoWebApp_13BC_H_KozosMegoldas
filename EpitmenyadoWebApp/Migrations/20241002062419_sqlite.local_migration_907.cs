using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EpitmenyadoWebApp.Migrations
{
    /// <inheritdoc />
    public partial class sqlitelocal_migration_907 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Epitmenyek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tulajdonos = table.Column<int>(type: "INTEGER", nullable: false),
                    Utca = table.Column<string>(type: "TEXT", nullable: false),
                    Hazszam = table.Column<string>(type: "TEXT", nullable: false),
                    Adosav = table.Column<char>(type: "TEXT", nullable: false),
                    Alapterulet = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Epitmenyek", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Epitmenyek");
        }
    }
}
