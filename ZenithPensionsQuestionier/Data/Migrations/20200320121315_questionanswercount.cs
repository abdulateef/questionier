using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZenithPensionsQuestionier.Data.Migrations
{
    public partial class questionanswercount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuestionAnswerCount",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<long>(nullable: false),
                    Text = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    OptionA = table.Column<string>(nullable: true),
                    OptionACount = table.Column<int>(nullable: false),
                    OptionB = table.Column<string>(nullable: true),
                    OptionBCount = table.Column<int>(nullable: false),
                    OptionC = table.Column<string>(nullable: true),
                    OptionCCount = table.Column<int>(nullable: false),
                    OptionD = table.Column<string>(nullable: true),
                    OptionDCount = table.Column<int>(nullable: false),
                    OptionE = table.Column<string>(nullable: true),
                    OptionECount = table.Column<int>(nullable: false),
                    OptionF = table.Column<string>(nullable: true),
                    OptionFCount = table.Column<int>(nullable: false),
                    OptionG = table.Column<string>(nullable: true),
                    OptionGCount = table.Column<int>(nullable: false),
                    OptionH = table.Column<string>(nullable: true),
                    OptionHCount = table.Column<int>(nullable: false),
                    OptionI = table.Column<string>(nullable: true),
                    OptionICount = table.Column<int>(nullable: false),
                    OptionJ = table.Column<string>(nullable: true),
                    OptionJCount = table.Column<int>(nullable: false),
                    ResultDateTime = table.Column<DateTime>(nullable: false),
                    ResultDateTimeInString = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionAnswerCount", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionAnswerCount");
        }
    }
}
