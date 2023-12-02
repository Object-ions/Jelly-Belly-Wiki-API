using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JellyBellyWikiApi.Migrations
{
    public partial class SeedMockWithFacts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mixes",
                table: "Beans");

            migrationBuilder.CreateTable(
                name: "Facts",
                columns: table => new
                {
                    FactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facts", x => x.FactId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Facts",
                columns: new[] { "FactId", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "Jelly Belly beans gained national attention when they were featured in the White House during the 1980s. President Ronald Reagan was a big fan of Jelly Belly beans, and they became known as the 'President's candy.'.", "Presidential Favorite" },
                    { 2, "Jelly Belly is known for its extensive flavor selection, with over 100 different flavors available. Some of the more unusual flavors include Buttered Popcorn, Dr. Pepper, and even Harry Potter-themed flavors like Bertie Bott's Every Flavor Beans.", "Over 100 Flavors" },
                    { 3, "Jelly Belly beans have been used to create intricate pieces of art. Artists and enthusiasts have used the beans to make mosaics, portraits, and sculptures.", "Bean Art" },
                    { 4, "The Very Cherry flavor was one of the first flavors created by Jelly Belly, and it remains one of the most popular to this day.", "First Flavor" },
                    { 5, "Making Jelly Belly beans is a complex process. It involves several stages, including creating the flavor centers, adding the candy shell, and polishing the beans to achieve their signature shine.", "Behind the Scenes" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Facts");

            migrationBuilder.AddColumn<string>(
                name: "Mixes",
                table: "Beans",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 1,
                column: "Mixes",
                value: "");
        }
    }
}
