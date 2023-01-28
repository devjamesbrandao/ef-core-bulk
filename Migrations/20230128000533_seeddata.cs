using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreBulk.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "Id", "ClassificacaoCampeonatoBrasileiro", "Nome" },
                values: new object[,]
                {
                    { 1, 1, "Corinthians" },
                    { 2, 20, "Flamengo" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
