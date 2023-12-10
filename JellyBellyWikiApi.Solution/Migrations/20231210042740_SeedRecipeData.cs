using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JellyBellyWikiApi.Migrations
{
    public partial class SeedRecipeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2,
                column: "Combination",
                value: "[\"Green Apple \\u002B Green Apple \\u002B Cinnamon\"]");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 3,
                column: "Combination",
                value: "[\"Top Banana \\u002B Top Banana \\u002B Buttered Popcorn\"]");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 4,
                column: "Combination",
                value: "[\"Top Banana \\u002B A\\u0026W\\u00AE Cream Soda \\u002B Coconut\"]");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 5,
                columns: new[] { "Combination", "Name" },
                values: new object[] { "[\"Top Banana \\u002B Chocolate Pudding \\u002B Crushed Pineapple \\u002B Strawberry Jam \\u002B Very Cherry \\u002B French Vanilla\"]", "Banana Split" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "Combination", "Name" },
                values: new object[,]
                {
                    { 6, "[\"Top Banana \\u002B Top Banana \\u002B Top Banana \\u002B Buttered Popcorn \\u002B French Vanilla\"]", "Bananas Foster" },
                    { 7, "[\"Berry Blu \\u002B SUNKIST\\u00AE Lemon\"]", "Berry Lemonade" },
                    { 8, "[\"Blueberry \\u002B Strawberry Cheesecake \\u002B French Vanilla \\u002B A\\u0026W\\u00AE Cream Soda\"]", "Blueberry Cheesecake" },
                    { 9, "[\"Blueberry \\u002B Blueberry \\u002B Buttered Popcorn\"]", "Blueberry Muffin" },
                    { 10, "[\"Blueberry \\u002B Caramel Corn \\u002B French Vanilla \\u002B Toasted Marshmallow \\u002B Toasted Marshmallow\"]", "Blueberry Pancakes" },
                    { 11, "[\"Cappuccino \\u002B Cappuccino \\u002B Chocolate Pudding \\u002B French Vanilla\"]", "Café Mocha" },
                    { 12, "[\"Green Apple \\u002B Green Apple \\u002B Cinnamon\"]", "Candy Apple" },
                    { 13, "[\"Very Cherry \\u002B Very Cherry \\u002B Dr Pepper\\u00AE\"]", "Cherry Cola" },
                    { 14, "[\"Very Cherry \\u002B Very Cherry \\u002B Coconut \\u002B Buttered Popcorn\"]", "Cherry Turnover" },
                    { 15, "[\"Very Cherry \\u002B Very Cherry \\u002B Chocolate Pudding\"]", "Chocolate Covered Cherries" },
                    { 16, "[\"Top Banana \\u002B Chocolate Pudding\"]", "Chocolate Dipped Banana" },
                    { 17, "[\"Strawberry Daiquiri \\u002B Strawberry Daiquiri \\u002B Chocolate Pudding\"]", "Chocolate Dipped Strawberries" },
                    { 18, "[\"Chocolate Pudding \\u002B Coconut\"]", "Chocolate Macaroons" },
                    { 19, "[\"Chocolate Pudding \\u002B Buttered Popcorn\"]", "Chocolate Popcorn" },
                    { 20, "[\"Cinnamon \\u002B Bubble Gum\"]", "Cinnamon Bubble Gum" },
                    { 21, "[\"Buttered Popcorn \\u002B Buttered Popcorn \\u002B Sizzling Cinnamon\"]", "Cinnamon Popcorn" },
                    { 22, "[\"Cappuccino \\u002B Buttered Popcorn \\u002B French Vanilla\"]", "Coffee Cake" },
                    { 23, "[\"Lime \\u002B Cinnamon\"]", "Cola" },
                    { 24, "[\"Island Punch \\u002B SUNKIST\\u00AE Orange \\u002B Very Cherry\"]", "Fruit Punch" },
                    { 25, "[\"Kiwi \\u002B Strawberry Jam \\u002B Blueberry \\u002B Cantaloupe\"]", "Fruit Salad" },
                    { 26, "[\"Draft Beer \\u002B Draft Beer \\u002B Ginger Ale\"]", "Ginger Beer" },
                    { 27, "[\"Green Apple \\u002B Bubble Gum \\u002B Bubble Gum\"]", "Green Apple Bubble Gum" },
                    { 28, "[\"Red Apple \\u002B Red Apple \\u002B Cinnamon\"]", "Hot Apple Cider" },
                    { 29, "[\"Toasted Marshmallow \\u002B Chocolate Pudding\"]", "Hot Chocolate" },
                    { 30, "[\"French Vanilla \\u002B French Vanilla \\u002B Chocolate Pudding \\u002B A\\u0026W\\u00AE Cream Soda \\u002B Very Cherry\"]", "Hot Fudge Sundae" },
                    { 31, "[\"French Vanilla \\u002B Cappuccino\"]", "Iced Vanilla Latte" },
                    { 32, "[\"Licorice \\u002B Buttered Popcorn \\u002B Buttered Popcorn\"]", "Italian Biscotti" },
                    { 33, "[\"Lemon Lime \\u002B Toasted Marshmallow\"]", "Key Lime Pie" },
                    { 34, "[\"Lemon \\u002B Lemon \\u002B Vanilla \\u002B Coconut\"]", "Lemon Squares" },
                    { 35, "[\"Mango \\u002B Crushed Pineapple \\u002B Chili Mango\"]", "Mango Pineapple Salsa" },
                    { 36, "[\"Mango \\u002B Lemon Lime \\u002B Chili Mango\"]", "Mango Tango Salsa" },
                    { 37, "[\"Draft Beer \\u002B Draft Beer \\u002B Lemon Lime \\u002B Tabasco\\u00AE\"]", "Michelada" },
                    { 38, "[\"Chocolate Pudding \\u002B Chocolate Pudding \\u002B Very Cherry\"]", "Mud Pie" },
                    { 39, "[\"Orange Sherbet \\u002B Orange Sherbet \\u002B A\\u0026W\\u00AE Cream Soda\"]", "Peach Bellini Drink" },
                    { 40, "[\"Peach \\u002B A\\u0026W\\u00AE Cream Soda\"]", "Peaches and Cream" },
                    { 41, "[\"Cotton Candy \\u002B SUNKIST\\u00AE Lemon\"]", "Pink Lemonade" },
                    { 42, "[\"Plum \\u002B Plum \\u002B French Vanilla\"]", "Plum Pudding" },
                    { 43, "[\"Plum \\u002B Plum \\u002B SUNKIST\\u00AE Lemon \\u002B Green Apple\"]", "Plum Sorbet" },
                    { 44, "[\"Plum \\u002B Plum \\u002B Cinnamon \\u002B A\\u0026W\\u00AE Cream Soda\"]", "Plum Tart" },
                    { 45, "[\"Pumpkin Pie \\u002B Pumpkin Pie \\u002B French Vanilla \\u002B Cappuccino\"]", "Pumpkin Spice Latte" },
                    { 46, "[\"Raspberry \\u002B Lemon Lime \\u002B Orange Sherbet\"]", "Rainbow Sherbet" },
                    { 47, "[\"French Vanilla \\u002B Raspberry \\u002B Toasted Marshmallow\"]", "Raspberry Crème Brûlée" },
                    { 48, "[\"A\\u0026W\\u00AE Root Beer \\u002B A\\u0026W\\u00AE Root Beer \\u002B A\\u0026W\\u00AE Cream Soda\"]", "Root Beer Float" },
                    { 49, "[\"Caramel Corn \\u002B Toasted Marshmallow \\u002B Toasted Marshmallow \\u002B Chocolate Pudding\"]", "S'mores" },
                    { 50, "[\"Kiwi \\u002B Strawberry Daiquiri\"]", "Strawberry-Kiwi Refresher" },
                    { 51, "[\"Strawberry Jam \\u002B French Vanilla\"]", "Strawberry Shortcake" },
                    { 52, "[\"Top Banana \\u002B Top Banana \\u002B Cinnamon \\u002B Buttered Popcorn\"]", "Sweet Fried Bananas" },
                    { 53, "[\"Margarita \\u002B Margarita \\u002B SUNKIST\\u00AE Orange \\u002B Very Cherry\"]", "Tequila Sunrise" },
                    { 54, "[\"Cappuccino \\u002B Cappuccino \\u002B A\\u0026W\\u00AE Cream Soda \\u002B Chocolate Pudding\"]", "Tiramisu" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 54);

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
                columns: new[] { "Combination", "Name" },
                values: new object[] { "[\"Berry Blu \\u002B Sunkist Lemon \\u002B Berry Lemonade\"]", "Berry Lemonade" });
        }
    }
}
