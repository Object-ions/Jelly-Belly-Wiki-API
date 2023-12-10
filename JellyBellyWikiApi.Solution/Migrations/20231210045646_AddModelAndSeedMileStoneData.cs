using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JellyBellyWikiApi.Migrations
{
    public partial class AddModelAndSeedMileStoneData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MileStones",
                columns: table => new
                {
                    MileStoneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MileStones", x => x.MileStoneId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "MileStones",
                columns: new[] { "MileStoneId", "Description", "Year" },
                values: new object[,]
                {
                    { 1, "Gustav Goelitz opens a candy business in Belleville, Illinois, laying the foundation for the company's future.", 1869 },
                    { 2, "The Goelitz family specializes in mellocremes, including candy corn.", 1898 },
                    { 3, "During World War II, amidst sugar rationing, the company introduces Mint Wafers.", 1940 },
                    { 4, "A significant breakthrough with the Goelitz Mini Jelly Beans, infused with flavor in both the center and the shell.", 1965 },
                    { 5, "The first Jelly Belly jelly beans are introduced with flavors like Root Beer, Green Apple, Licorice, Cream Soda, Lemon, Tangerine, Very Cherry, and Grape.", 1976 },
                    { 6, "The brand gains significant popularity, notably with President Ronald Reagan as a fan.", 1980 },
                    { 7, "The company begins printing the Jelly Belly name on every bean.", 1996 },
                    { 8, "The company is renamed to Jelly Belly Candy Company.", 2001 },
                    { 9, "Introduction of Bertie Bott's Every Flavor Beans from the Harry Potter series.", 2002 },
                    { 10, "Sales reach $125 million, indicating substantial growth.", 2004 },
                    { 11, "BeanBoozled jelly beans are introduced, featuring wild and wacky flavors.", 2008 },
                    { 12, "Draft Beer flavor, inspired by Hefeweizen ale, is introduced.", 2014 },
                    { 13, "Ferrara Candy Company announces an agreement to acquire Jelly Belly Candy Company.", 2023 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MileStones");
        }
    }
}
