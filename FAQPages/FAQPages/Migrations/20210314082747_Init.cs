using Microsoft.EntityFrameworkCore.Migrations;

namespace FAQPages.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    TopicId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.TopicId);
                });

            migrationBuilder.CreateTable(
                name: "FAQs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TopicId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAQs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FAQs_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FAQs_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "TopicId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { "gen", "General" },
                    { "hist", "History" },
                    { "tech", "Technology" }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "TopicId", "Name" },
                values: new object[,]
                {
                    { "boot", "Bootstrap" },
                    { "cs", "C#" },
                    { "js", "JavaScript" },
                    { "academia", "Academia" }
                });

            migrationBuilder.InsertData(
                table: "FAQs",
                columns: new[] { "Id", "Answer", "CategoryId", "Question", "TopicId" },
                values: new object[,]
                {
                    { 1, "In 2011", "hist", "When was Bootstrap released", "boot" },
                    { 7, "A CSS framwork for creating responsive web applications for multiple screen sizes", "gen", "What is Bootstrap?", "boot" },
                    { 3, "In 2002", "hist", "When was C# first released?", "cs" },
                    { 6, "A general purpose object-oriented language that uses concise java-like syntax", "gen", "What is C#?", "cs" },
                    { 4, "In 1995", "hist", "When was JavaScript first released?", "js" },
                    { 5, "JavaScript is a general purpose scripting language that executes in the browser", "gen", "What is JavaScript", "js" },
                    { 8, "A general purpose scripting language that executes in a web browser", "gen", "What is JavaScript?", "js" },
                    { 2, "In 387 BC, Classical Athens", "hist", "When did Plato found the Academy?", "academia" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FAQs_CategoryId",
                table: "FAQs",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FAQs_TopicId",
                table: "FAQs",
                column: "TopicId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FAQs");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Topics");
        }
    }
}
