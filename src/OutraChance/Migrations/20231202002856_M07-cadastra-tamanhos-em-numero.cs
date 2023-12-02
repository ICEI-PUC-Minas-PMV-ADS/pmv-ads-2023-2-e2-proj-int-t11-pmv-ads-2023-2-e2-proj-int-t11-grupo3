using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OutraChance.Migrations
{
    public partial class M07cadastratamanhosemnumero : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CaracteristicaValores",
                columns: new[] { "Id", "CaracteristicaId", "Valor" },
                values: new object[,]
                {
                    { 21, 2, "34" },
                    { 22, 2, "35" },
                    { 23, 2, "36" },
                    { 24, 2, "37" },
                    { 25, 2, "38" },
                    { 26, 2, "39" },
                    { 27, 2, "40" },
                    { 28, 2, "41" },
                    { 29, 2, "42" },
                    { 30, 2, "43" },
                    { 31, 2, "44" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CaracteristicaValores",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "CaracteristicaValores",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "CaracteristicaValores",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "CaracteristicaValores",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "CaracteristicaValores",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "CaracteristicaValores",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "CaracteristicaValores",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "CaracteristicaValores",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "CaracteristicaValores",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "CaracteristicaValores",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "CaracteristicaValores",
                keyColumn: "Id",
                keyValue: 31);
        }
    }
}
