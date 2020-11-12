using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppPeliculas.Migrations
{
    public partial class addatributePelicula : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Cartelera",
                table: "Peliculas",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cartelera",
                table: "Peliculas");
        }
    }
}
