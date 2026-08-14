using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LiteratureSolitaire.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreInformationUrlToAuthors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MoreInformationUrl",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "MoreInformationUrl",
                value: "https://dictionarylit-bg.eu/%D0%94%D0%B8%D0%BC%D0%B8%D1%82%D1%8A%D1%80-%D0%A2%D0%B0%D0%BB%D0%B5%D0%B2?sa=1");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "MoreInformationUrl",
                value: "https://dictionarylit-bg.eu/%D0%90%D0%BB%D0%B5%D0%BA%D0%BE-%D0%98%D0%B2%D0%B0%D0%BD%D0%B8%D1%86%D0%BE%D0%B2-%D0%9A%D0%BE%D0%BD%D1%81%D1%82%D0%B0%D0%BD%D1%82%D0%B8%D0%BD%D0%BE%D0%B2?sa=1");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "MoreInformationUrl",
                value: "https://dictionarylit-bg.eu/%D0%A1%D1%82%D0%B0%D0%BD%D0%B8%D1%81%D0%BB%D0%B0%D0%B2-%D0%A1%D1%82%D1%80%D0%B0%D1%82%D0%B8%D0%B5%D0%B2?sa=1");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "MoreInformationUrl",
                value: "https://dictionarylit-bg.eu/%D0%98%D0%B2%D0%B0%D0%BD-%D0%9C%D0%B8%D0%BD%D1%87%D0%BE%D0%B2-%D0%92%D0%B0%D0%B7%D0%BE%D0%B2?sa=1");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "MoreInformationUrl",
                value: "https://dictionarylit-bg.eu/%D0%9D%D0%B8%D0%BA%D0%BE%D0%BB%D0%B0-%D0%99%D0%BE%D0%BD%D0%BA%D0%BE%D0%B2-%D0%92%D0%B0%D0%BF%D1%86%D0%B0%D1%80%D0%BE%D0%B2?sa=1");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                column: "MoreInformationUrl",
                value: "https://dictionarylit-bg.eu/%D0%99%D0%BE%D1%80%D0%B4%D0%B0%D0%BD-%D0%94%D0%B8%D0%BC%D0%B8%D1%82%D1%80%D0%BE%D0%B2-%D0%A0%D0%B0%D0%B4%D0%B8%D1%87%D0%BA%D0%BE%D0%B2?sa=1#biblio");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                column: "MoreInformationUrl",
                value: "https://muzeibotev.com/bg/hristo-botev/letopis");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                column: "MoreInformationUrl",
                value: "https://dictionarylit-bg.eu/%D0%95%D0%BB%D0%B8%D0%BD-%D0%9F%D0%B5%D0%BB%D0%B8%D0%BD,");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                column: "MoreInformationUrl",
                value: "https://dictionarylit-bg.eu/%D0%A5%D1%80%D0%B8%D1%81%D1%82%D0%BE-%D0%A1%D0%BC%D0%B8%D1%80%D0%BD%D0%B5%D0%BD%D1%81%D0%BA%D0%B8?sa=1");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                column: "MoreInformationUrl",
                value: "https://dictionarylit-bg.eu/%D0%95%D0%BC%D0%B8%D0%BB%D0%B8%D1%8F%D0%BD-%D0%A1%D1%82%D0%B0%D0%BD%D0%B5%D0%B2?sa=1");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11,
                column: "MoreInformationUrl",
                value: "https://dictionarylit-bg.eu/%D0%9F%D0%B5%D0%B9%D0%BE-%D0%AF%D0%B2%D0%BE%D1%80%D0%BE%D0%B2?sa=1");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12,
                column: "MoreInformationUrl",
                value: "https://dictionarylit-bg.eu/%D0%9F%D0%B5%D0%BD%D1%87%D0%BE-%D0%9F%D0%B5%D1%82%D0%BA%D0%BE%D0%B2-%D0%A1%D0%BB%D0%B0%D0%B2%D0%B5%D0%B9%D0%BA%D0%BE%D0%B2?sa=1");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13,
                column: "MoreInformationUrl",
                value: "https://dictionarylit-bg.eu/%D0%94%D0%B8%D0%BC%D1%87%D0%BE-%D0%92%D0%B5%D0%BB%D0%B5%D0%B2-%D0%94%D0%B5%D0%B1%D0%B5%D0%BB%D1%8F%D0%BD%D0%BE%D0%B2?sa=1");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14,
                column: "MoreInformationUrl",
                value: "https://dictionarylit-bg.eu/%D0%A5%D1%80%D0%B8%D1%81%D1%82%D0%BE-%D0%9A%D0%BE%D0%BD%D1%81%D1%82%D0%B0%D0%BD%D1%82%D0%B8%D0%BD%D0%BE%D0%B2-%D0%A4%D0%BE%D1%82%D0%B5%D0%B2?sa=1");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15,
                column: "MoreInformationUrl",
                value: "https://dictionarylit-bg.eu/%D0%9F%D0%B5%D1%82%D1%8F-%D0%A1%D1%82%D0%B0%D0%B9%D0%BA%D0%BE%D0%B2%D0%B0-%D0%94%D1%83%D0%B1%D0%B0%D1%80%D0%BE%D0%B2%D0%B0?sa=1");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16,
                column: "MoreInformationUrl",
                value: "https://dictionarylit-bg.eu/%D0%90%D1%82%D0%B0%D0%BD%D0%B0%D1%81-%D0%A5%D1%80%D0%B8%D1%81%D1%82%D0%BE%D0%B2-%D0%94%D0%B0%D0%BB%D1%87%D0%B5%D0%B2?sa=1");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17,
                column: "MoreInformationUrl",
                value: "https://dictionarylit-bg.eu/%D0%99%D0%BE%D1%80%D0%B4%D0%B0%D0%BD-%D0%A1%D1%82%D0%B5%D1%84%D0%B0%D0%BD%D0%BE%D0%B2-%D0%99%D0%BE%D0%B2%D0%BA%D0%BE%D0%B2?sa=1");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18,
                column: "MoreInformationUrl",
                value: "https://dictionarylit-bg.eu/%D0%92%D0%B8%D0%BA%D1%82%D0%BE%D1%80-%D0%9C%D0%B0%D1%80%D0%B8%D0%BD%D0%BE%D0%B2-%D0%9F%D0%B0%D1%81%D0%BA%D0%BE%D0%B2?sa=1");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19,
                column: "MoreInformationUrl",
                value: "https://dictionarylit-bg.eu/%D0%95%D0%BB%D0%B8%D1%81%D0%B0%D0%B2%D0%B5%D1%82%D0%B0-%D0%91%D0%B0%D0%B3%D1%80%D1%8F%D0%BD%D0%B0?sa=1");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 20,
                column: "MoreInformationUrl",
                value: "https://dictionarylit-bg.eu/%D0%91%D0%BE%D1%80%D0%B8%D1%81-%D0%9A%D0%B8%D1%80%D0%B8%D0%BB%D0%BE%D0%B2-%D0%A5%D1%80%D0%B8%D1%81%D1%82%D0%BE%D0%B2?sa=1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MoreInformationUrl",
                table: "Authors");
        }
    }
}
