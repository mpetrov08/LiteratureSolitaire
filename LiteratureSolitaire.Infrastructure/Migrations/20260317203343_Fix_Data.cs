using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LiteratureSolitaire.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Fix_Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 14,
                column: "LiteraryDirectionId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 26,
                column: "LiteraryDirectionId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Characters", "LiteraryDirectionId" },
                values: new object[] { "поетът - лирическият говорител/Аз", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 14,
                column: "LiteraryDirectionId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 26,
                column: "LiteraryDirectionId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Characters", "LiteraryDirectionId" },
                values: new object[] { "лирическият говорител/Аз", 8 });
        }
    }
}
