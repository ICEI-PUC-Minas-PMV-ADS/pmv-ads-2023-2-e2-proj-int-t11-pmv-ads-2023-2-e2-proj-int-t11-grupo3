using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OutraChance.Migrations
{
    public partial class M04preenchetabelacracteristicasvalores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Caracteristicas",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Cor" },
                    { 2, "Tamanho" },
                    { 3, "Departamento" },
                    { 4, "Genero" }
                });

            migrationBuilder.InsertData(
                table: "CaracteristicaValores",
                columns: new[] { "Id", "CaracteristicaId", "Valor" },
                values: new object[,]
                {
                    { 1, 1, "Azul" },
                    { 2, 1, "Amarelo" },
                    { 3, 1, "Vermelho" },
                    { 4, 1, "Verde" },
                    { 5, 1, "Laranja" },
                    { 6, 1, "Lilás" },
                    { 8, 1, "Branco" },
                    { 9, 1, "Preto" },
                    { 10, 2, "PP" },
                    { 11, 2, "P" },
                    { 12, 2, "M" },
                    { 13, 2, "G" },
                    { 14, 2, "GG" },
                    { 15, 3, "Calças" },
                    { 16, 3, "Blusas" },
                    { 17, 3, "Calçados" },
                    { 18, 3, "Shorts" },
                    { 19, 4, "Masculino" },
                    { 20, 4, "Feminino" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CaracteristicaValores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CaracteristicaValores",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CaracteristicaValores",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CaracteristicaValores",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CaracteristicaValores",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CaracteristicaValores",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CaracteristicaValores",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CaracteristicaValores",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CaracteristicaValores",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CaracteristicaValores",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CaracteristicaValores",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CaracteristicaValores",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CaracteristicaValores",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CaracteristicaValores",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CaracteristicaValores",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CaracteristicaValores",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CaracteristicaValores",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CaracteristicaValores",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CaracteristicaValores",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Caracteristicas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Caracteristicas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Caracteristicas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Caracteristicas",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
