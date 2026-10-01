using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LiteratureSolitaire.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixedExamSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Content",
                value: "В коя от думите е допусната правописна грешка? Двата нови спектакъла(А) на Народния(Б) театър, представящи модерни за театралното изкуство идеи(В), предизвикаха широк одзвук(Г) сред зрителите.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 37,
                column: "Content",
                value: "В коя от подчертаните думи е допусната граматична грешка? Госпожо Иванова, бихте ли ни разказала(А) повече за писателя(Б), чиито(В) романи са преведени на английски, немски и френски език(Г)?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 40,
                column: "Content",
                value: "В коя от подчертаните думи е допусната граматична грешка? В изявлението му(А) пред медиите режисьорът сподели, че камерният(Б) спектакъл с двамата известни актьори(В) жъне успехи на българските и световните(Г) театрални сцени.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 45,
                column: "Content",
                value: "В коя от подчертаните думи е допусната граматична грешка? В Министерство(А) на външните работи българският и гръцкият министър(Б) са провели разговори, на които(В) са присъствали не само официални лица. Господин Петров, Вие бяхте ли поканен(Г)?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 51,
                column: "Content",
                value: "В коя от позициите, означени с букви, е допусната пунктуационна грешка? Човек разбира,(А) кое е истински важно в живота,(Б) когато осъзнае,(В) че най-ценните неща не могат да се купят,(Г) защото са безплатни.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 57,
                column: "Content",
                value: "В коя от позициите, означени с букви, е допусната пунктуационна грешка? Психолозите съветват, че за да живеем спокойно и щастливо,(А) трябва да спрем да се оплакваме,(Б) макар за много хора,(В) това да е почти невъзможно,(Г) тъй като все ще намерят повод да недоволстват.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 67,
                column: "Content",
                value: "В коя от позициите, означени с букви, е допусната пунктуационна грешка? Докато обмислях(А) къде да прекарам лятната си отпуска(Б) осъзнах, че пътешествията надалеч ще ми помогнат да се преборя със страховете си,(В) ще ме научат на търпение(Г) и ще ме накарат по-внимателно да преценявам непознати ситуации.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 70,
                column: "Content",
                value: "Кое от твърденията съответства по смисъл на цитираното изречение от Текст 1? \"Несъмнено потреблението на видеосъдържание има и своята тъмна страна.\"");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Content",
                value: "В коя от подчертаните думи е допусната правописна грешка? Двата нови спектакъла (");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 37,
                column: "Content",
                value: "В коя от подчертаните думи е допусната граматична грешка? Госпожо Иванова, бихте ли ни разказала (");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 40,
                column: "Content",
                value: "В коя от подчертаните думи е допусната граматична грешка? В изявлението му (");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 45,
                column: "Content",
                value: "В коя от подчертаните думи е допусната граматична грешка?\r\n В Министерство (");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 51,
                column: "Content",
                value: "В коя от позициите, означени с букви, е допусната пунктуационна грешка? Човек разбира, (");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 57,
                column: "Content",
                value: "В коя от позициите, означени с букви, е допусната пунктуационна грешка? Психолозите съветват, че за да живеем спокойно и щастливо, (");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 67,
                column: "Content",
                value: "В коя от позициите, означени с букви, е допусната пунктуационна грешка? Докато обмислях (");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 70,
                column: "Content",
                value: "Кое от твърденията съответства по смисъл на цитираното изречение от Текст 1? Несъмнено потреблението на видеосъдържание има и своята тъмна страна.");
        }
    }
}
