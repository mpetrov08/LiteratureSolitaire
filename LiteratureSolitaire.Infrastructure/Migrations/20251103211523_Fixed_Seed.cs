using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LiteratureSolitaire.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Fixed_Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Стихотворение");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "\"Железният светилник\"");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "\"Бай Ганьо журналист\"");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 3,
                column: "Title",
                value: "\"Балкански синдром\"");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "\"Паисий\"");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 5,
                column: "Title",
                value: "\"История\"");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 6,
                column: "Title",
                value: "\"Ноев ковчег\"");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 7,
                column: "Title",
                value: "\"Борба\"");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 8,
                column: "Title",
                value: "\"Андрешко\"");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 9,
                column: "Title",
                value: "\"Приказка за стълбата\"");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 10,
                column: "Title",
                value: "\"До моето първо либе\"");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 11,
                column: "Title",
                value: "\"Новото гробище над Сливница\"");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 12,
                column: "Title",
                value: "\"Крадецът на праскови\"");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 13,
                column: "Title",
                value: "\"При Рилския манастир\"");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 14,
                column: "Title",
                value: "\"Градушка\"");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 15,
                column: "Title",
                value: "\"Спи езерото\"");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 16,
                column: "Title",
                value: "\"Аз искам да те помня така\"");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 17,
                column: "Title",
                value: "\"Колко си хубава!\"");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 18,
                column: "Title",
                value: "\"Посвещение\"");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 19,
                column: "Title",
                value: "\"Спасова могила\"");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 20,
                column: "Title",
                value: "\"Молитва\"");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 21,
                column: "Title",
                value: "\"Вяра\"");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 22,
                column: "Title",
                value: "\"Ветрената мелница\"");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 23,
                column: "Title",
                value: "\"Песента на колелетата\"");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 24,
                column: "Title",
                value: "\"Баладa за Георг Хених\"");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 25,
                column: "Title",
                value: "\"Две души\"");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 26,
                column: "Title",
                value: "\"Потомка\"");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 27,
                column: "Title",
                value: "\"Честен кръст\"");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Поема");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "Железният светилник");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "Бай Ганьо журналист");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 3,
                column: "Title",
                value: "Балкански синдром");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "Паисий");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 5,
                column: "Title",
                value: "История");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 6,
                column: "Title",
                value: "Ноев ковчег");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 7,
                column: "Title",
                value: "Борба");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 8,
                column: "Title",
                value: "Андрешко");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 9,
                column: "Title",
                value: "Приказка за стълбата");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 10,
                column: "Title",
                value: "До моето първо либе");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 11,
                column: "Title",
                value: "Новото гробище над Сливница");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 12,
                column: "Title",
                value: "Крадецът на праскови");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 13,
                column: "Title",
                value: "При Рилския манастир");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 14,
                column: "Title",
                value: "Градушка");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 15,
                column: "Title",
                value: "Спи езерото");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 16,
                column: "Title",
                value: "Аз искам да те помня така");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 17,
                column: "Title",
                value: "Колко си хубава!");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 18,
                column: "Title",
                value: "Посвещение");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 19,
                column: "Title",
                value: "Спасова могила");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 20,
                column: "Title",
                value: "Молитва");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 21,
                column: "Title",
                value: "Вяра");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 22,
                column: "Title",
                value: "Ветрената мелница");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 23,
                column: "Title",
                value: "Песента на колелетата");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 24,
                column: "Title",
                value: "Баладa за Георг Хених");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 25,
                column: "Title",
                value: "Две души");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 26,
                column: "Title",
                value: "Потомка");

            migrationBuilder.UpdateData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 27,
                column: "Title",
                value: "Честен кръст");
        }
    }
}
