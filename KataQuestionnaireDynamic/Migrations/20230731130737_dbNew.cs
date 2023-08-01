using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KataQuestionnaireDynamic.Migrations
{
    public partial class dbNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Questionnaires_QuestionModelId",
                table: "Questions");

            migrationBuilder.RenameColumn(
                name: "QuestionModelId",
                table: "Questions",
                newName: "FormularModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Questions_QuestionModelId",
                table: "Questions",
                newName: "IX_Questions_FormularModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Questionnaires_FormularModelId",
                table: "Questions",
                column: "FormularModelId",
                principalTable: "Questionnaires",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Questionnaires_FormularModelId",
                table: "Questions");

            migrationBuilder.RenameColumn(
                name: "FormularModelId",
                table: "Questions",
                newName: "QuestionModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Questions_FormularModelId",
                table: "Questions",
                newName: "IX_Questions_QuestionModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Questionnaires_QuestionModelId",
                table: "Questions",
                column: "QuestionModelId",
                principalTable: "Questionnaires",
                principalColumn: "Id");
        }
    }
}
