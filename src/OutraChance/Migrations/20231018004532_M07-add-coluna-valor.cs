using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OutraChance.Migrations
{
    public partial class M07addcolunavalor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Valor",
                table: "CaracteristicaAnuncios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Valor",
                table: "CaracteristicaAnuncios");
        }
    }
}
