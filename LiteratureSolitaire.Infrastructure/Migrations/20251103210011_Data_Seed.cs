using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LiteratureSolitaire.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Data_Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Димитър Талев" },
                    { 2, "Алеко Константинов" },
                    { 3, "Станислав Стратиев" },
                    { 4, "Иван Вазов" },
                    { 5, "Никола Вапцаров" },
                    { 6, "Йордан Радичков" },
                    { 7, "Христо Ботев" },
                    { 8, "Елин Пелин" },
                    { 9, "Христо Смирненски" },
                    { 10, "Емилиян Станев" },
                    { 11, "Пейо Яворов" },
                    { 12, "Пенчо Славейков" },
                    { 13, "Димчо Дебелянов" },
                    { 14, "Христо Фотев" },
                    { 15, "Петя Дубарова" },
                    { 16, "Атанас Далчев" },
                    { 17, "Йордан Йовков" },
                    { 18, "Виктор Пасков" },
                    { 19, "Елисавета Багряна" },
                    { 20, "Борис Христов" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Роман" },
                    { 2, "Фейлетон" },
                    { 3, "Сатирична комедия на абсурда" },
                    { 4, "Ода" },
                    { 5, "Поема" },
                    { 6, "Разказ" },
                    { 7, "Сатира, Алегория" },
                    { 8, "Повест" },
                    { 9, "Пантеистичнo стихотворение" },
                    { 10, "Поема" },
                    { 11, "Лирическа миниатюра" },
                    { 12, "Елегия" }
                });

            migrationBuilder.InsertData(
                table: "LiteraryDirections",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Реализъм" },
                    { 2, "Романтизъм" },
                    { 3, "Магически реализъм" },
                    { 4, "Социален реализъм" },
                    { 5, "Индивидуализъм" },
                    { 6, "Символизъм" },
                    { 7, "Диаболизъм" },
                    { 8, "Екзистенциализъм" },
                    { 9, "Модернизъм" }
                });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "AuthorId", "Characters", "GenreId", "LiteraryDirectionId", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Стоян Глаушев, Султана, Лазар, Катерина, Рафе Клинче, Климент Бенков, Божана, Стойка Нунева, Аврам Немтур", 1, 1, "Железният светилник" },
                    { 2, 2, "Бай Ганьо, Гочоолу, Дочоолу, Данко Харсъзина, Гуньо Адвокатина/Гуньо Келеперчиков", 2, 1, "Бай Ганьо журналист" },
                    { 3, 3, "Бяла Врана, Жена с проблем, Жена символ, Директор на театър, бай Цончо, Йовчо, Цончето, Печо, баба Кера, Извънземното, Георги", 3, 1, "Балкански синдром" },
                    { 4, 4, "Паисий, лирически говорител", 4, 2, "Паисий" },
                    { 5, 5, "Лирически говорител, историята", 5, 1, "История" },
                    { 6, 6, "хлебарките, космическият удваник, трите врани, каракачанката, въшкарчето, глиганът, Апостола, папунякът, щъркелът, лисицата, Емилиян Станев, Григор Вачков, Методи Андонов", 1, 3, "Ноев ковчег" },
                    { 7, 7, "Соломон, лирически говорител", 5, 1, "Борба" },
                    { 8, 8, "Андрешко, съдия-изпълнител, повествователят", 6, 4, "Андрешко" },
                    { 9, 9, "Дяволът, плебеят", 7, 1, "Приказка за стълбата" },
                    { 10, 7, "Лирически герой/Аз, либето", 5, 2, "До моето първо либе" },
                    { 11, 4, "Лирически говорител, загиналите воини, България", 5, 1, "Новото гробище над Сливница" },
                    { 12, 10, "Иво Обретенович, Елисавета, Никола Козичката, полковникът", 8, 1, "Крадецът на праскови" },
                    { 13, 4, "лирически Аз, природата", 9, 1, "При Рилския манастир" },
                    { 14, 11, "лирически говорител, Ваньо селянчето", 10, 6, "Градушка" },
                    { 15, 12, "лирически говорител, белостволите буки", 11, 5, "Спи езерото" },
                    { 16, 13, "лирически Аз/влюбеният мъж, обречената жена", 12, 6, "Аз искам да те помня така" },
                    { 17, 14, "лирически Аз/влюбеният мъж, обичаната жена", 5, 1, "Колко си хубава!" },
                    { 18, 15, "влюбената девойка/лирическият говорител, обичаният", 5, 1, "Посвещение" },
                    { 19, 8, "Монката, дядо Захари", 6, 4, "Спасова могила" },
                    { 20, 16, "лирическият Аз, Господ", 5, 7, "Молитва" },
                    { 21, 5, "лирическият Аз, Животът", 5, 8, "Вяра" },
                    { 22, 8, "Лазар Дъбака, дядо Корчан, Христина", 6, 4, "Ветрената мелница" },
                    { 23, 17, "Сали Яшар, Джапар, Шакире", 6, 1, "Песента на колелетата" },
                    { 24, 18, "Виктор Георг/дядо Георги, Божения, Марсен, Франета, Ванда", 8, 9, "Баладa за Георг Хених" },
                    { 25, 11, "лирическият Аз", 5, 6, "Две души" },
                    { 26, 19, "потомката - лирическият Аз", 5, 6, "Потомка" },
                    { 27, 20, "лирическият говорител/Аз", 10, 8, "Честен кръст" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "LiteraryDirections",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LiteraryDirections",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LiteraryDirections",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LiteraryDirections",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LiteraryDirections",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LiteraryDirections",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LiteraryDirections",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "LiteraryDirections",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "LiteraryDirections",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
