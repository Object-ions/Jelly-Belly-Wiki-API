using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JellyBellyWikiApi.Migrations
{
    public partial class ChangeNamingRecipeToCombination : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.CreateTable(
                name: "Combinations",
                columns: table => new
                {
                    CombinationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tag = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Combinations", x => x.CombinationId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Combinations",
                columns: new[] { "CombinationId", "Name", "Tag" },
                values: new object[,]
                {
                    { 1, "Cherry Turnover", "[\"Very Cherry \\u002B Very Cherry \\u002B Coconut \\u002B Buttered Popcorn \\u002B Cherry Turnover\"]" },
                    { 2, "Apple Pie", "[\"Green Apple \\u002B Green Apple \\u002B Cinnamon\"]" },
                    { 3, "Banana Bread", "[\"Top Banana \\u002B Top Banana \\u002B Buttered Popcorn\"]" },
                    { 4, "Banana Cream Pie", "[\"Top Banana \\u002B A\\u0026W\\u00AE Cream Soda \\u002B Coconut\"]" },
                    { 5, "Banana Split", "[\"Top Banana \\u002B Chocolate Pudding \\u002B Crushed Pineapple \\u002B Strawberry Jam \\u002B Very Cherry \\u002B French Vanilla\"]" },
                    { 6, "Bananas Foster", "[\"Top Banana \\u002B Top Banana \\u002B Top Banana \\u002B Buttered Popcorn \\u002B French Vanilla\"]" },
                    { 7, "Berry Lemonade", "[\"Berry Blu \\u002B SUNKIST\\u00AE Lemon\"]" },
                    { 8, "Blueberry Cheesecake", "[\"Blueberry \\u002B Strawberry Cheesecake \\u002B French Vanilla \\u002B A\\u0026W\\u00AE Cream Soda\"]" },
                    { 9, "Blueberry Muffin", "[\"Blueberry \\u002B Blueberry \\u002B Buttered Popcorn\"]" },
                    { 10, "Blueberry Pancakes", "[\"Blueberry \\u002B Caramel Corn \\u002B French Vanilla \\u002B Toasted Marshmallow \\u002B Toasted Marshmallow\"]" },
                    { 11, "Café Mocha", "[\"Cappuccino \\u002B Cappuccino \\u002B Chocolate Pudding \\u002B French Vanilla\"]" },
                    { 12, "Candy Apple", "[\"Green Apple \\u002B Green Apple \\u002B Cinnamon\"]" },
                    { 13, "Cherry Cola", "[\"Very Cherry \\u002B Very Cherry \\u002B Dr Pepper\\u00AE\"]" },
                    { 14, "Cherry Turnover", "[\"Very Cherry \\u002B Very Cherry \\u002B Coconut \\u002B Buttered Popcorn\"]" },
                    { 15, "Chocolate Covered Cherries", "[\"Very Cherry \\u002B Very Cherry \\u002B Chocolate Pudding\"]" },
                    { 16, "Chocolate Dipped Banana", "[\"Top Banana \\u002B Chocolate Pudding\"]" },
                    { 17, "Chocolate Dipped Strawberries", "[\"Strawberry Daiquiri \\u002B Strawberry Daiquiri \\u002B Chocolate Pudding\"]" },
                    { 18, "Chocolate Macaroons", "[\"Chocolate Pudding \\u002B Coconut\"]" },
                    { 19, "Chocolate Popcorn", "[\"Chocolate Pudding \\u002B Buttered Popcorn\"]" },
                    { 20, "Cinnamon Bubble Gum", "[\"Cinnamon \\u002B Bubble Gum\"]" },
                    { 21, "Cinnamon Popcorn", "[\"Buttered Popcorn \\u002B Buttered Popcorn \\u002B Sizzling Cinnamon\"]" },
                    { 22, "Coffee Cake", "[\"Cappuccino \\u002B Buttered Popcorn \\u002B French Vanilla\"]" },
                    { 23, "Cola", "[\"Lime \\u002B Cinnamon\"]" },
                    { 24, "Fruit Punch", "[\"Island Punch \\u002B SUNKIST\\u00AE Orange \\u002B Very Cherry\"]" },
                    { 25, "Fruit Salad", "[\"Kiwi \\u002B Strawberry Jam \\u002B Blueberry \\u002B Cantaloupe\"]" },
                    { 26, "Ginger Beer", "[\"Draft Beer \\u002B Draft Beer \\u002B Ginger Ale\"]" },
                    { 27, "Green Apple Bubble Gum", "[\"Green Apple \\u002B Bubble Gum \\u002B Bubble Gum\"]" },
                    { 28, "Hot Apple Cider", "[\"Red Apple \\u002B Red Apple \\u002B Cinnamon\"]" },
                    { 29, "Hot Chocolate", "[\"Toasted Marshmallow \\u002B Chocolate Pudding\"]" },
                    { 30, "Hot Fudge Sundae", "[\"French Vanilla \\u002B French Vanilla \\u002B Chocolate Pudding \\u002B A\\u0026W\\u00AE Cream Soda \\u002B Very Cherry\"]" },
                    { 31, "Iced Vanilla Latte", "[\"French Vanilla \\u002B Cappuccino\"]" },
                    { 32, "Italian Biscotti", "[\"Licorice \\u002B Buttered Popcorn \\u002B Buttered Popcorn\"]" },
                    { 33, "Key Lime Pie", "[\"Lemon Lime \\u002B Toasted Marshmallow\"]" },
                    { 34, "Lemon Squares", "[\"Lemon \\u002B Lemon \\u002B Vanilla \\u002B Coconut\"]" },
                    { 35, "Mango Pineapple Salsa", "[\"Mango \\u002B Crushed Pineapple \\u002B Chili Mango\"]" },
                    { 36, "Mango Tango Salsa", "[\"Mango \\u002B Lemon Lime \\u002B Chili Mango\"]" },
                    { 37, "Michelada", "[\"Draft Beer \\u002B Draft Beer \\u002B Lemon Lime \\u002B Tabasco\\u00AE\"]" },
                    { 38, "Mud Pie", "[\"Chocolate Pudding \\u002B Chocolate Pudding \\u002B Very Cherry\"]" },
                    { 39, "Peach Bellini Drink", "[\"Orange Sherbet \\u002B Orange Sherbet \\u002B A\\u0026W\\u00AE Cream Soda\"]" },
                    { 40, "Peaches and Cream", "[\"Peach \\u002B A\\u0026W\\u00AE Cream Soda\"]" },
                    { 41, "Pink Lemonade", "[\"Cotton Candy \\u002B SUNKIST\\u00AE Lemon\"]" },
                    { 42, "Plum Pudding", "[\"Plum \\u002B Plum \\u002B French Vanilla\"]" },
                    { 43, "Plum Sorbet", "[\"Plum \\u002B Plum \\u002B SUNKIST\\u00AE Lemon \\u002B Green Apple\"]" },
                    { 44, "Plum Tart", "[\"Plum \\u002B Plum \\u002B Cinnamon \\u002B A\\u0026W\\u00AE Cream Soda\"]" },
                    { 45, "Pumpkin Spice Latte", "[\"Pumpkin Pie \\u002B Pumpkin Pie \\u002B French Vanilla \\u002B Cappuccino\"]" },
                    { 46, "Rainbow Sherbet", "[\"Raspberry \\u002B Lemon Lime \\u002B Orange Sherbet\"]" },
                    { 47, "Raspberry Crème Brûlée", "[\"French Vanilla \\u002B Raspberry \\u002B Toasted Marshmallow\"]" },
                    { 48, "Root Beer Float", "[\"A\\u0026W\\u00AE Root Beer \\u002B A\\u0026W\\u00AE Root Beer \\u002B A\\u0026W\\u00AE Cream Soda\"]" },
                    { 49, "S'mores", "[\"Caramel Corn \\u002B Toasted Marshmallow \\u002B Toasted Marshmallow \\u002B Chocolate Pudding\"]" },
                    { 50, "Strawberry-Kiwi Refresher", "[\"Kiwi \\u002B Strawberry Daiquiri\"]" },
                    { 51, "Strawberry Shortcake", "[\"Strawberry Jam \\u002B French Vanilla\"]" },
                    { 52, "Sweet Fried Bananas", "[\"Top Banana \\u002B Top Banana \\u002B Cinnamon \\u002B Buttered Popcorn\"]" },
                    { 53, "Tequila Sunrise", "[\"Margarita \\u002B Margarita \\u002B SUNKIST\\u00AE Orange \\u002B Very Cherry\"]" },
                    { 54, "Tiramisu", "[\"Cappuccino \\u002B Cappuccino \\u002B A\\u0026W\\u00AE Cream Soda \\u002B Chocolate Pudding\"]" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Combinations");

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Combination = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.RecipeId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "Combination", "Name" },
                values: new object[,]
                {
                    { 1, "[\"Very Cherry \\u002B Very Cherry \\u002B Coconut \\u002B Buttered Popcorn \\u002B Cherry Turnover\"]", "Cherry Turnover" },
                    { 2, "[\"Green Apple \\u002B Green Apple \\u002B Cinnamon\"]", "Apple Pie" },
                    { 3, "[\"Top Banana \\u002B Top Banana \\u002B Buttered Popcorn\"]", "Banana Bread" },
                    { 4, "[\"Top Banana \\u002B A\\u0026W\\u00AE Cream Soda \\u002B Coconut\"]", "Banana Cream Pie" },
                    { 5, "[\"Top Banana \\u002B Chocolate Pudding \\u002B Crushed Pineapple \\u002B Strawberry Jam \\u002B Very Cherry \\u002B French Vanilla\"]", "Banana Split" },
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
    }
}
