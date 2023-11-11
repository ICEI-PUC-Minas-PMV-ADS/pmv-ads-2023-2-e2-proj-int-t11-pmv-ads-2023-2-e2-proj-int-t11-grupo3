using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OutraChance.Migrations
{
    public partial class M03tabelavalorescaracteristicas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CaracteristicaAnuncios_Caracteristica_CaracteristicaId",
                table: "CaracteristicaAnuncios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Caracteristica",
                table: "Caracteristica");

            migrationBuilder.RenameTable(
                name: "Caracteristica",
                newName: "Caracteristicas");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Anuncios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Caracteristicas",
                table: "Caracteristicas",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CaracteristicaValores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaracteristicaId = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaracteristicaValores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CaracteristicaValores_Caracteristicas_CaracteristicaId",
                        column: x => x.CaracteristicaId,
                        principalTable: "Caracteristicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CaracteristicaValores_CaracteristicaId",
                table: "CaracteristicaValores",
                column: "CaracteristicaId");

            migrationBuilder.AddForeignKey(
                name: "FK_CaracteristicaAnuncios_Caracteristicas_CaracteristicaId",
                table: "CaracteristicaAnuncios",
                column: "CaracteristicaId",
                principalTable: "Caracteristicas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CaracteristicaAnuncios_Caracteristicas_CaracteristicaId",
                table: "CaracteristicaAnuncios");

            migrationBuilder.DropTable(
                name: "CaracteristicaValores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Caracteristicas",
                table: "Caracteristicas");

            migrationBuilder.RenameTable(
                name: "Caracteristicas",
                newName: "Caracteristica");

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Anuncios",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Caracteristica",
                table: "Caracteristica",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CaracteristicaAnuncios_Caracteristica_CaracteristicaId",
                table: "CaracteristicaAnuncios",
                column: "CaracteristicaId",
                principalTable: "Caracteristica",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
