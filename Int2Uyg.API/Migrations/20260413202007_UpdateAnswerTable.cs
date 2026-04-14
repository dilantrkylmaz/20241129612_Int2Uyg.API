using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Int2Uyg.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAnswerTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResponseText",
                table: "Answers");

            migrationBuilder.AddColumn<int>(
                name: "SelectedOptionId",
                table: "Answers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SurveyId",
                table: "Answers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TextAnswer",
                table: "Answers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Answers_SelectedOptionId",
                table: "Answers",
                column: "SelectedOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_SurveyId",
                table: "Answers",
                column: "SurveyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_QuestionOptions_SelectedOptionId",
                table: "Answers",
                column: "SelectedOptionId",
                principalTable: "QuestionOptions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Surveys_SurveyId",
                table: "Answers",
                column: "SurveyId",
                principalTable: "Surveys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_QuestionOptions_SelectedOptionId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Surveys_SurveyId",
                table: "Answers");

            migrationBuilder.DropIndex(
                name: "IX_Answers_SelectedOptionId",
                table: "Answers");

            migrationBuilder.DropIndex(
                name: "IX_Answers_SurveyId",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "SelectedOptionId",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "SurveyId",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "TextAnswer",
                table: "Answers");

            migrationBuilder.AddColumn<string>(
                name: "ResponseText",
                table: "Answers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
