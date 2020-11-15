using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppPeliculas.Migrations
{
    public partial class add_PapelActor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PapelActor",
                table: "PeliculasActores",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PapelActor",
                table: "PeliculasActores");
        }
    }
}
