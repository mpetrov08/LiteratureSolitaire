using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LiteratureSolitaire.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedAdditionalCardsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdditionalCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Additional Card Indetifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "User Id"),
                    WorkId = table.Column<int>(type: "int", nullable: false, comment: "Work Id"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Type of the card"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Content of the card")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdditionalCards_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdditionalCards_Works_WorkId",
                        column: x => x.WorkId,
                        principalTable: "Works",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalCards_UserId",
                table: "AdditionalCards",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalCards_WorkId",
                table: "AdditionalCards",
                column: "WorkId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalCards");
        }
    }
}
