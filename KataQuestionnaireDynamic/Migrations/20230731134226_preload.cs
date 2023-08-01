using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KataQuestionnaireDynamic.Migrations
{
    public partial class preload : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "FormularModelId", "Question", "Type" },
                values: new object[] { 2, null, "Je sais nager ?", "Checkbox" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "FormularModelId", "Question", "Type" },
                values: new object[] { 5, null, "Quelle est la couleur du cheval blanc d'Henri IV ?", "Input_Text" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "FormularModelId", "Question", "Type" },
                values: new object[] { 6, null, "Quel est mon langage préféré ?", "Select_List" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
