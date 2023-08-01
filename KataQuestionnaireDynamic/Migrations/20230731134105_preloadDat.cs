using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KataQuestionnaireDynamic.Migrations
{
    public partial class preloadDat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "FormularModelId", "Question", "Type" },
                values: new object[] { 1, null, "J'aime les fraises ?", "Checkbox" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
