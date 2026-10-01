using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LiteratureSolitaire.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixedQuestionPassagesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "QuestionPassages",
                columns: new[] { "PassageId", "QuestionId" },
                values: new object[,]
                {
                    { 1, 69 },
                    { 2, 69 },
                    { 1, 70 },
                    { 2, 70 },
                    { 1, 71 },
                    { 2, 71 },
                    { 3, 73 },
                    { 4, 73 },
                    { 3, 74 },
                    { 4, 74 },
                    { 3, 75 },
                    { 4, 75 },
                    { 5, 77 },
                    { 6, 77 },
                    { 5, 78 },
                    { 6, 78 },
                    { 5, 79 },
                    { 6, 79 },
                    { 7, 81 },
                    { 8, 81 },
                    { 7, 82 },
                    { 8, 82 },
                    { 7, 83 },
                    { 8, 83 },
                    { 9, 85 },
                    { 10, 85 },
                    { 9, 86 },
                    { 10, 86 },
                    { 9, 87 },
                    { 10, 87 },
                    { 11, 89 },
                    { 12, 89 },
                    { 11, 90 },
                    { 12, 90 },
                    { 11, 91 },
                    { 12, 91 },
                    { 13, 93 },
                    { 14, 93 },
                    { 13, 94 },
                    { 14, 94 },
                    { 13, 95 },
                    { 14, 95 },
                    { 15, 97 },
                    { 16, 97 },
                    { 15, 98 },
                    { 16, 98 },
                    { 15, 99 },
                    { 16, 99 },
                    { 17, 101 },
                    { 18, 101 },
                    { 17, 102 },
                    { 18, 102 },
                    { 17, 103 },
                    { 18, 103 },
                    { 19, 105 },
                    { 20, 105 },
                    { 19, 106 },
                    { 20, 106 },
                    { 19, 107 },
                    { 20, 107 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 1, 69 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 2, 69 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 1, 70 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 2, 70 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 1, 71 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 2, 71 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 3, 73 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 4, 73 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 3, 74 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 4, 74 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 3, 75 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 4, 75 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 5, 77 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 6, 77 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 5, 78 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 6, 78 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 5, 79 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 6, 79 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 7, 81 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 8, 81 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 7, 82 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 8, 82 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 7, 83 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 8, 83 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 9, 85 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 10, 85 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 9, 86 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 10, 86 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 9, 87 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 10, 87 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 11, 89 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 12, 89 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 11, 90 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 12, 90 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 11, 91 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 12, 91 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 13, 93 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 14, 93 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 13, 94 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 14, 94 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 13, 95 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 14, 95 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 15, 97 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 16, 97 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 15, 98 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 16, 98 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 15, 99 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 16, 99 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 17, 101 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 18, 101 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 17, 102 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 18, 102 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 17, 103 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 18, 103 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 19, 105 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 20, 105 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 19, 106 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 20, 106 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 19, 107 });

            migrationBuilder.DeleteData(
                table: "QuestionPassages",
                keyColumns: new[] { "PassageId", "QuestionId" },
                keyValues: new object[] { 20, 107 });
        }
    }
}
