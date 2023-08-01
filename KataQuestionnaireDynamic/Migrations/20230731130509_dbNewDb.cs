using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KataQuestionnaireDynamic.Migrations
{
    public partial class dbNewDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Options_Questions_OptionId",
                table: "Options");

            migrationBuilder.RenameColumn(
                name: "OptionId",
                table: "Options",
                newName: "QuestionModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Options_OptionId",
                table: "Options",
                newName: "IX_Options_QuestionModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Options_Questions_QuestionModelId",
                table: "Options",
                column: "QuestionModelId",
                principalTable: "Questions",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Options_Questions_QuestionModelId",
                table: "Options");

            migrationBuilder.RenameColumn(
                name: "QuestionModelId",
                table: "Options",
                newName: "OptionId");

            migrationBuilder.RenameIndex(
                name: "IX_Options_QuestionModelId",
                table: "Options",
                newName: "IX_Options_OptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Options_Questions_OptionId",
                table: "Options",
                column: "OptionId",
                principalTable: "Questions",
                principalColumn: "Id");
        }
    }
}
