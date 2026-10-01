using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LiteratureSolitaire.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedPassageTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Passages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Passage Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false, comment: "Passage Number"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Passage Text Content"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Path to the Passage Image"),
                    ExamSessionId = table.Column<int>(type: "int", nullable: false, comment: "Passage`s Exam Session")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Passages_ExamSessions_ExamSessionId",
                        column: x => x.ExamSessionId,
                        principalTable: "ExamSessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestionPassages",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false, comment: "Question Id"),
                    PassageId = table.Column<int>(type: "int", nullable: false, comment: "Passage Id")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionPassages", x => new { x.QuestionId, x.PassageId });
                    table.ForeignKey(
                        name: "FK_QuestionPassages_Passages_PassageId",
                        column: x => x.PassageId,
                        principalTable: "Passages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionPassages_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Passages_ExamSessionId",
                table: "Passages",
                column: "ExamSessionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionPassages_PassageId",
                table: "QuestionPassages",
                column: "PassageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionPassages");

            migrationBuilder.DropTable(
                name: "Passages");
        }
    }
}
