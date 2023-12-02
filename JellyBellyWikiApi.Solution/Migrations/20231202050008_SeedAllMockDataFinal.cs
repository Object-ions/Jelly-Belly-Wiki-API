using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JellyBellyWikiApi.Migrations
{
    public partial class SeedAllMockDataFinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "Combination", "Name" },
                values: new object[,]
                {
                    { 2, "Green Apple + Green Apple + Cinnamon = Apple Pie", "Apple Pie" },
                    { 3, "Top Banana + Top Banana + Buttered Popcorn = Banana Bread", "Banana Bread" },
                    { 4, "Top Banana + Cream Soda + Coconut = Banana Cream Pie", "Banana Cream Pie" },
                    { 5, "Berry Blu + Sunkist Lemon = Berry Lemonade", "Berry Lemonade" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 5);
        }
    }
}
