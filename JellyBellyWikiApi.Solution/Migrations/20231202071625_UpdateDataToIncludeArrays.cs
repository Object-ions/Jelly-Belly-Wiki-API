using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JellyBellyWikiApi.Migrations
{
    public partial class UpdateDataToIncludeArrays : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 1,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% or less of the following: Natural and Artificial Flavors, Color Added, Vegetable and Fruit Juice (Color), Beeswax, Carnauba Wax, Confectioner\\u0027s Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 2,
                column: "Ingredients",
                value: "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% or less of the following: Natural and Artificial Flavors, Color Added, Vegetable and Fruit Juice (Color), Beeswax, Carnauba Wax, Confectioner\\u0027s Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 3,
                column: "Ingredients",
                value: "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% or less of the following: Citric Acid. Natural and Artificial Flavor. Color Added. Blue 1, Beeswax. Carnauba Wax. Confectioner\\u0027s Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 4,
                column: "Ingredients",
                value: "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Blueberry Juice From Puree\",\"Contains 2% or less of the following: Citric Acid. Natural and Artificial Flavor. Color Added. Blue 1 Lake. Beeswax. Carnauba Wax. Confectioner\\u0027s Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 5,
                column: "Ingredients",
                value: "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% or less of the following: Artificial Flavor. Color Added. Red 40 Lake. Red 40. Yellow 5 Lake. Beeswax. Carnauba Wax. Confectioner\\u0027s Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                column: "Combination",
                value: "[\"Very Cherry \\u002B Very Cherry \\u002B Coconut \\u002B Buttered Popcorn \\u002B Cherry Turnover\"]");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2,
                column: "Combination",
                value: "[\"Green Apple \\u002B Green Apple \\u002B Cinnamon \\u002B Apple Pie\"]");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 3,
                column: "Combination",
                value: "[\"Top Banana \\u002B Top Banana \\u002B Buttered Popcorn \\u002B Banana Bread\"]");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 4,
                column: "Combination",
                value: "[\"Top Banana \\u002B Cream Soda \\u002B Coconut \\u002B Banana Cream Pie\"]");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 5,
                column: "Combination",
                value: "[\"Berry Blu \\u002B Sunkist Lemon \\u002B Berry Lemonade\"]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 1,
                column: "Ingredients",
                value: "Sugar, Corn Syrup, Modified Food Starch, Contains 2% or less of the following: Natural and Artificial Flavors, Color Added, Beeswax, Carnauba Wax, Confectioner's Glaze.");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 2,
                column: "Ingredients",
                value: "Sugar, Corn Syrup, Modified Food Starch, Contains 2% or less of the following: Natural and Artificial Flavors, Color Added, Vegetable and Fruit Juice (Color), Beeswax, Carnauba Wax, Confectioner's Glaze.");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 3,
                column: "Ingredients",
                value: "Sugar, Corn Syrup, Modified Food Starch, Contains 2% or less of the following: Citric Acid, Natural and Artificial Flavor, Color Added, Blue 1, Beeswax, Carnauba Wax, Confectioner's Glaze.");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 4,
                column: "Ingredients",
                value: "Sugar, Corn Syrup, Modified Food Starch, Blueberry Juice From Puree, Contains 2% or less of the following: Citric Acid, Natural and Artificial Flavor, Color Added, Blue 1 Lake, Beeswax, Carnauba Wax, Confectioner's Glaze.");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 5,
                column: "Ingredients",
                value: "Sugar, Corn Syrup, Modified Food Starch, Contains 2% or less of the following: Artificial Flavor, Color Added, Red 40 Lake, Red 40, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner's Glaze.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                column: "Combination",
                value: "Very Cherry + Very Cherry + Coconut + Buttered Popcorn = Cherry Turnover");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2,
                column: "Combination",
                value: "Green Apple + Green Apple + Cinnamon = Apple Pie");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 3,
                column: "Combination",
                value: "Top Banana + Top Banana + Buttered Popcorn = Banana Bread");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 4,
                column: "Combination",
                value: "Top Banana + Cream Soda + Coconut = Banana Cream Pie");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 5,
                column: "Combination",
                value: "Berry Blu + Sunkist Lemon = Berry Lemonade");
        }
    }
}
