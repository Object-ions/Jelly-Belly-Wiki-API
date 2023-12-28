using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JellyBellyWikiApi.Migrations
{
    public partial class UpdateIngredientsSterialized : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IngredientsSerialized",
                table: "Beans",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 1,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Citric Acid\",\"Sodium Lactate\",\"Natural \\u0026 Artificial Flavor\",\"Color Added\",\"Yellow 5\",\"Blue 1\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Citric Acid, Sodium Lactate, Natural & Artificial Flavor, Color Added, Yellow 5, Blue 1, Beeswax, Carnauba Wax, Confectioner'S Glaze" });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 2,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Natural And Artificial Flavors\",\"Color Added\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Natural And Artificial Flavors, Color Added, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 3,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Natural \\u0026 Artificial Flavors\",\"Color Added\",\"Vegetable \\u0026 Fruit Juice (Color)\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Natural & Artificial Flavors, Color Added, Vegetable & Fruit Juice (Color), Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 4,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Cane Sugar\",\"Tapioca Syrup\",\"Modified Food Starch\",\"Sour Cherry Juice From Concentrate\",\"Blueberry Juice From Blueberry Puree\",\"Pomegranate Juice From Concentrate\",\"Acai Puree\",\"Natural Flavors\",\"Acerola (Barbados) Cherry Juice\",\"Cranberry Puree\",\"Citric Acid\",\"Apple (Color)\",\"Confectioner\\u0027S Glaze\",\"Beeswax\",\"Grape Concentrate (Color)\",\"Carrot (Color)\",\"Carnauba Wax\",\"Black Currant (Color)\",\"Hibiscus (Color)\",\"Color Added.\"]", "Cane Sugar, Tapioca Syrup, Modified Food Starch, Sour Cherry Juice From Concentrate, Blueberry Juice From Blueberry Puree, Pomegranate Juice From Concentrate, Acai Puree, Natural Flavors, Acerola (Barbados) Cherry Juice, Cranberry Puree, Citric Acid, Apple (Color), Confectioner'S Glaze, Beeswax, Grape Concentrate (Color), Carrot (Color), Carnauba Wax, Black Currant (Color), Hibiscus (Color), Color Added." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 5,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Strawberry Puree\",\"Chocolate Liquor\",\"Cocoa Butter\",\"Cocoa Powder\",\"Citric Acid\",\"Ground Cinnamon\",\"Tapioca Dextrin\",\"Natural And Artificial Flavor\",\"Color Added\",\"Red 40 Lake\",\"Yellow 5 \\u0026 6 Lake\",\"Red 40\",\"Blue 1 \\u0026 2 Lake\",\"Blue 1\",\"Yellow 5\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze\",\"Salt.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Strawberry Puree, Chocolate Liquor, Cocoa Butter, Cocoa Powder, Citric Acid, Ground Cinnamon, Tapioca Dextrin, Natural And Artificial Flavor, Color Added, Red 40 Lake, Yellow 5 & 6 Lake, Red 40, Blue 1 & 2 Lake, Blue 1, Yellow 5, Beeswax, Carnauba Wax, Confectioner'S Glaze, Salt." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 6,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Cane Sugar\",\"Tapioca Syrup\",\"Modified Food Starch\",\"Sour Cherry Juice From Concentrate\",\"Blueberry Juice From Blueberry Puree\",\"Pomegranate Juice From Concentrate\",\"Acai Puree\",\"Natural Flavors\",\"Acerola (Barbados) Cherry Juice\",\"Cranberry Puree\",\"Citric Acid\",\"Apple (Color)\",\"Confectioner\\u0027S Glaze\",\"Beeswax\",\"Grape Concentrate (Color)\",\"Carrot (Color)\",\"Carnauba Wax\",\"Black Currant (Color)\",\"Hibiscus (Color)\",\"Color Added.\"]", "Cane Sugar, Tapioca Syrup, Modified Food Starch, Sour Cherry Juice From Concentrate, Blueberry Juice From Blueberry Puree, Pomegranate Juice From Concentrate, Acai Puree, Natural Flavors, Acerola (Barbados) Cherry Juice, Cranberry Puree, Citric Acid, Apple (Color), Confectioner'S Glaze, Beeswax, Grape Concentrate (Color), Carrot (Color), Carnauba Wax, Black Currant (Color), Hibiscus (Color), Color Added." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 7,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Blueberry Juice From Puree\",\"Contains 2% Or Less Of The Following:\",\"Citric Acid\",\"Natural \\u0026 Artificial Flavor\",\"Color Added\",\"Blue 1 Lake\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Blueberry Juice From Puree, Contains 2% Or Less Of The Following:, Citric Acid, Natural & Artificial Flavor, Color Added, Blue 1 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 8,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Artificial Flavor\",\"Color Added\",\"Red 40 Lake\",\"Red 40\",\"Yellow 5 Lake\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Artificial Flavor, Color Added, Red 40 Lake, Red 40, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 9,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Natural And Artificial Flavors\",\"Color Added\",\"Yellow 5\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze\",\"Salt.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Natural And Artificial Flavors, Color Added, Yellow 5, Beeswax, Carnauba Wax, Confectioner'S Glaze, Salt." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 10,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Cantaloupe Juice From Cantaloupe Powder\",\"Contains 2% Or Less Of The Following:\",\"Natural And Artificial Flavors\",\"Color Added\",\"Yellow 6 Lake\",\"Yellow 6\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Cantaloupe Juice From Cantaloupe Powder, Contains 2% Or Less Of The Following:, Natural And Artificial Flavors, Color Added, Yellow 6 Lake, Yellow 6, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 11,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Natural And Artificial Flavors\",\"Coffee\",\"Color Added\",\"Vegetable And Fruit Juice (Color)\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Natural And Artificial Flavors, Coffee, Color Added, Vegetable And Fruit Juice (Color), Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 12,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Natural And Artificial Flavors\",\"Color Added\",\"Yellow 6\",\"Yellow 5 \\u0026 6 Lake\",\"Blue 2 Lake\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze\",\"Salt.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Natural And Artificial Flavors, Color Added, Yellow 6, Yellow 5 & 6 Lake, Blue 2 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze, Salt." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 13,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Blueberry Juice From Puree\",\"Contains 2% Or Less Of The Following:\",\"Citric Acid\",\"Natural \\u0026 Artificial Flavor\",\"Color Added\",\"Blue 1 Lake\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Blueberry Juice From Puree, Contains 2% Or Less Of The Following:, Citric Acid, Natural & Artificial Flavor, Color Added, Blue 1 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 14,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Strawberry Puree\",\"Chocolate Liquor\",\"Cocoa Butter\",\"Cocoa Powder\",\"Citric Acid\",\"Ground Cinnamon\",\"Tapioca Dextrin\",\"Natural And Artificial Flavor\",\"Color Added\",\"Red 40 Lake\",\"Yellow 5 \\u0026 6 Lake\",\"Red 40\",\"Blue 1 \\u0026 2 Lake\",\"Blue 1\",\"Yellow 5\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze\",\"Salt.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Strawberry Puree, Chocolate Liquor, Cocoa Butter, Cocoa Powder, Citric Acid, Ground Cinnamon, Tapioca Dextrin, Natural And Artificial Flavor, Color Added, Red 40 Lake, Yellow 5 & 6 Lake, Red 40, Blue 1 & 2 Lake, Blue 1, Yellow 5, Beeswax, Carnauba Wax, Confectioner'S Glaze, Salt." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 15,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Cocoa Powder\",\"Chocolate Liquor\",\"Cocoa Butter\",\"Natural And Artificial Flavor\",\"Color Added\",\"Red 40 Lake\",\"Yellow 5 Lake\",\"Blue 2 Lake\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Cocoa Powder, Chocolate Liquor, Cocoa Butter, Natural And Artificial Flavor, Color Added, Red 40 Lake, Yellow 5 Lake, Blue 2 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 16,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Artificial Flavor\",\"Color Added\",\"Red 40\",\"Red 40 Lake\",\"Turmeric (Color)\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Artificial Flavor, Color Added, Red 40, Red 40 Lake, Turmeric (Color), Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 17,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Apple Juice Concentrate\",\"Citric Acid\",\"Cocoa Powder\",\"Natural \\u0026 Artificial Flavors\",\"Color Added\",\"Red 40 Lake\",\"Yellow 5 \\u0026 6 Lake\",\"Blue 1 \\u0026 2 Lake\",\"Red 40\",\"Vegetable And Fruit Juice (Color)\",\"Tapioca Dextrin\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze\",\"Ground Cinnamon\",\"Salt.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Apple Juice Concentrate, Citric Acid, Cocoa Powder, Natural & Artificial Flavors, Color Added, Red 40 Lake, Yellow 5 & 6 Lake, Blue 1 & 2 Lake, Red 40, Vegetable And Fruit Juice (Color), Tapioca Dextrin, Beeswax, Carnauba Wax, Confectioner'S Glaze, Ground Cinnamon, Salt." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 18,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Coconut\",\"Artificial Flavor\",\"Color Added\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Coconut, Artificial Flavor, Color Added, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 19,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Citric Acid\",\"Natural And Artificial Flavor\",\"Color Added\",\"Red 40\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Citric Acid, Natural And Artificial Flavor, Color Added, Red 40, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 20,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Cranberry Puree\",\"Natural Flavor\",\"Color Added\",\"Red 40 Lake\",\"Blue 2 Lake\",\"Turmeric (Color)\",\"Citric Acid\",\"Confectioner\\u0027S Glaze\",\"Beeswax\",\"Carnauba Wax.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Cranberry Puree, Natural Flavor, Color Added, Red 40 Lake, Blue 2 Lake, Turmeric (Color), Citric Acid, Confectioner'S Glaze, Beeswax, Carnauba Wax." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 21,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Cranberry Puree\",\"Raspberry Puree\",\"Grape Juice Concentrate\",\"Mango Juice Concentrate\",\"Strawberry Juice Concentrate\",\"Kiwi Juice Concentrate\",\"Lemon Puree\",\"Cherry Juice Concentrate\",\"Cranberry Juice Concentrate\",\"Natural Flavors\",\"Citric Acid\",\"Color Added\",\"Grape Concentrate (Color)\",\"Turmeric (Color)\",\"Apple (Color)\",\"Hibiscus (Color)\",\"Black Currant (Color)\",\"Carrot (Color)\",\"Confectioner\\u0027S Glaze\",\"Beeswax\",\"Carnauba Wax.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Cranberry Puree, Raspberry Puree, Grape Juice Concentrate, Mango Juice Concentrate, Strawberry Juice Concentrate, Kiwi Juice Concentrate, Lemon Puree, Cherry Juice Concentrate, Cranberry Juice Concentrate, Natural Flavors, Citric Acid, Color Added, Grape Concentrate (Color), Turmeric (Color), Apple (Color), Hibiscus (Color), Black Currant (Color), Carrot (Color), Confectioner'S Glaze, Beeswax, Carnauba Wax." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 22,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Pineapple Juice From Concentrate\",\"Contains 2% Or Less Of The Following:\",\"Citric Acid\",\"Artificial Flavor\",\"Color Added\",\"Yellow 5\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Pineapple Juice From Concentrate, Contains 2% Or Less Of The Following:, Citric Acid, Artificial Flavor, Color Added, Yellow 5, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 23,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"IngredientsSerialized: Srn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Sodium Citrate\",\"Phosphoric Acid\",\"Natural And Artificial Flavor\",\"Color Added\",\"Red 40 Lake\",\"Blue 2 Lake\",\"Red 40\",\"Yellow 5 Lake\",\"Vegetable \\u0026 Fruit Juice (Color)\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze\",\"Caffeine.\"]", "IngredientsSerialized: Srn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Sodium Citrate, Phosphoric Acid, Natural And Artificial Flavor, Color Added, Red 40 Lake, Blue 2 Lake, Red 40, Yellow 5 Lake, Vegetable & Fruit Juice (Color), Beeswax, Carnauba Wax, Confectioner'S Glaze, Caffeine." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 24,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Vanilla Beans\",\"Natural And Artificial Flavors\",\"Color Added\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Vanilla Beans, Natural And Artificial Flavors, Color Added, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 25,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Natural \\u0026 Artificial Flavors\",\"Color Added\",\"Blue 1 Lake\",\"Yellow 5 Lake\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze\",\"Tapioca Dextrin.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Natural & Artificial Flavors, Color Added, Blue 1 Lake, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze, Tapioca Dextrin." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 26,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Apple Juice Concentrate\",\"Citric Acid\",\"Cocoa Powder\",\"Natural \\u0026 Artificial Flavors\",\"Color Added\",\"Red 40 Lake\",\"Yellow 5 \\u0026 6 Lake\",\"Blue 1 \\u0026 2 Lake\",\"Red 40\",\"Vegetable And Fruit Juice (Color)\",\"Tapioca Dextrin\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze\",\"Ground Cinnamon\",\"Salt.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Apple Juice Concentrate, Citric Acid, Cocoa Powder, Natural & Artificial Flavors, Color Added, Red 40 Lake, Yellow 5 & 6 Lake, Blue 1 & 2 Lake, Red 40, Vegetable And Fruit Juice (Color), Tapioca Dextrin, Beeswax, Carnauba Wax, Confectioner'S Glaze, Ground Cinnamon, Salt." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 27,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Citric Acid\",\"Sodium Lactate\",\"Tartaric Acid\",\"Grape Juice Concentrate\",\"Acacia Gum\",\"Natural \\u0026 Artificial Flavor\",\"Color Added\",\"Red 40\",\"Blue 1\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Citric Acid, Sodium Lactate, Tartaric Acid, Grape Juice Concentrate, Acacia Gum, Natural & Artificial Flavor, Color Added, Red 40, Blue 1, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 28,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Apple Juice From Concentrate\",\"Contains 2% Or Less Of The Following:\",\"Citric Acid\",\"Artificial Flavor\",\"Color Added\",\"Yellow 5\",\"Blue 1\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Apple Juice From Concentrate, Contains 2% Or Less Of The Following:, Citric Acid, Artificial Flavor, Color Added, Yellow 5, Blue 1, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 29,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Passion Fruit Juice From Concentrate\",\"Contains 2% Or Less Of The Following:\",\"Citric Acid\",\"Natural \\u0026 Artificial Flavor\",\"Color Added\",\"Blue 1 \\u0026 2 Lake\",\"Blue 1 \\u0026 2\",\"Red 40 Lake\",\"Red 40\",\"Yellow 5 Lake\",\"Yellow 5\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Passion Fruit Juice From Concentrate, Contains 2% Or Less Of The Following:, Citric Acid, Natural & Artificial Flavor, Color Added, Blue 1 & 2 Lake, Blue 1 & 2, Red 40 Lake, Red 40, Yellow 5 Lake, Yellow 5, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 30,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Citric Acid\",\"Natural \\u0026 Artificial Flavor\",\"Color Added\",\"Blue 1\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Citric Acid, Natural & Artificial Flavor, Color Added, Blue 1, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 31,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Blueberry Juice From Puree\",\"Contains 2% Or Less Of The Following:\",\"Citric Acid\",\"Natural \\u0026 Artificial Flavor\",\"Color Added\",\"Blue 1 Lake\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Blueberry Juice From Puree, Contains 2% Or Less Of The Following:, Citric Acid, Natural & Artificial Flavor, Color Added, Blue 1 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 32,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Artificial Flavor\",\"Color Added\",\"Red 40 Lake\",\"Red 40\",\"Yellow 5 Lake\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Artificial Flavor, Color Added, Red 40 Lake, Red 40, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 33,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Natural \\u0026 Artificial Flavors\",\"Citric Acid\",\"Color Added\",\"Maltodextrin\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Natural & Artificial Flavors, Citric Acid, Color Added, Maltodextrin, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 34,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Natural And Artificial Flavors\",\"Color Added\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Natural And Artificial Flavors, Color Added, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 35,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Natural And Artificial Flavors\",\"Citric Acid\",\"Color Added\",\"Yellow 5\",\"Red 40\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Natural And Artificial Flavors, Citric Acid, Color Added, Yellow 5, Red 40, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 36,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Citric Acid\",\"Sodium Lactate\",\"Tartaric Acid\",\"Grape Juice Concentrate\",\"Gum Arabic\",\"Natural \\u0026 Artificial Flavor\",\"Vegetable \\u0026 Fruit Juice (Color)\",\"Color Added\",\"Red 40\",\"Blue 1\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Citric Acid, Sodium Lactate, Tartaric Acid, Grape Juice Concentrate, Gum Arabic, Natural & Artificial Flavor, Vegetable & Fruit Juice (Color), Color Added, Red 40, Blue 1, Beeswax, Carnauba Wax, Confectioner'S Glaze" });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 37,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Orange Juice From Orange Puree\",\"2% Or Less Of The Following:\",\"Citric Acid\",\"Sodium Lactate\",\"Natural Flavor\",\"Color Added\",\"Yellow 6\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Orange Juice From Orange Puree, 2% Or Less Of The Following:, Citric Acid, Sodium Lactate, Natural Flavor, Color Added, Yellow 6, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 38,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Apple Juice From Concentrate\",\"Contains 2% Or Less Of The Following:\",\"Citric Acid\",\"Fumaric Acid\",\"Sodium Lactate\",\"Sodium Citrate\",\"Artificial Flavor\",\"Color Added\",\"Yellow 5\",\"Yellow 5 Lake\",\"Blue 1\",\"Blue 1 Lake\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Apple Juice From Concentrate, Contains 2% Or Less Of The Following:, Citric Acid, Fumaric Acid, Sodium Lactate, Sodium Citrate, Artificial Flavor, Color Added, Yellow 5, Yellow 5 Lake, Blue 1, Blue 1 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 39,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Lemon Juice From Puree\",\"Contains 2% Or Less Of The Following:\",\"Citric Acid\",\"Fumaric Acid\",\"Sodium Lactate\",\"Sodium Citrate\",\"Natural Flavor\",\"Color Added\",\"Yellow 5\",\"Yellow 5 Lake\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Lemon Juice From Puree, Contains 2% Or Less Of The Following:, Citric Acid, Fumaric Acid, Sodium Lactate, Sodium Citrate, Natural Flavor, Color Added, Yellow 5, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 40,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Cherry Juice From Concentrate\",\"Contains 2% Or Less Of The Following:\",\"Citric Acid\",\"Artificial Flavor\",\"Color Added\",\"Red 40\",\"Red 40 Lake\",\"Turmeric (Color)\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Cherry Juice From Concentrate, Contains 2% Or Less Of The Following:, Citric Acid, Artificial Flavor, Color Added, Red 40, Red 40 Lake, Turmeric (Color), Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 41,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Glucose Syrup\",\"Modified Cornstarch\",\"Pear Juice Concentrate\",\"Flavouring\",\"Acidity Regulator (E330)\",\"Glazing Agents (E901\",\"E903\",\"E904)\",\"Colours (E100\",\"E171)\",\"Fruit And Vegetable Concentrates (Carrot\",\"Pumpkin\",\"Spirulina\",\"Apple\",\"Hibiscus)\",\"Tapioca Dextrin.\"]", "Sugar, Glucose Syrup, Modified Cornstarch, Pear Juice Concentrate, Flavouring, Acidity Regulator (E330), Glazing Agents (E901, E903, E904), Colours (E100, E171), Fruit And Vegetable Concentrates (Carrot, Pumpkin, Spirulina, Apple, Hibiscus), Tapioca Dextrin." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 42,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Kiwi Juice From Concentrate\",\"Contains 2% Or Less Of The Following:\",\"Natural And Artificial Flavor\",\"Color Added\",\"Yellow 5\",\"Blue 1\",\"Citric Acid\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Kiwi Juice From Concentrate, Contains 2% Or Less Of The Following:, Natural And Artificial Flavor, Color Added, Yellow 5, Blue 1, Citric Acid, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 43,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Cranberry Puree\",\"Raspberry Puree\",\"Grape Juice Concentrate\",\"Mango Juice Concentrate\",\"Strawberry Juice Concentrate\",\"Kiwi Juice Concentrate\",\"Lemon Puree\",\"Cherry Juice Concentrate\",\"Cranberry Juice Concentrate\",\"Natural Flavors\",\"Citric Acid\",\"Color Added\",\"Grape Concentrate (Color)\",\"Turmeric (Color)\",\"Apple (Color)\",\"Hibiscus (Color)\",\"Black Currant (Color)\",\"Carrot (Color)\",\"Confectioner\\u0027S Glaze\",\"Beeswax\",\"Carnauba Wax.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Cranberry Puree, Raspberry Puree, Grape Juice Concentrate, Mango Juice Concentrate, Strawberry Juice Concentrate, Kiwi Juice Concentrate, Lemon Puree, Cherry Juice Concentrate, Cranberry Juice Concentrate, Natural Flavors, Citric Acid, Color Added, Grape Concentrate (Color), Turmeric (Color), Apple (Color), Hibiscus (Color), Black Currant (Color), Carrot (Color), Confectioner'S Glaze, Beeswax, Carnauba Wax." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 44,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Lemon Juice From Puree\",\"2% Or Less Of The Following:\",\"Sodium Lactate\",\"Citric Acid\",\"Natural Flavor\",\"Color Added\",\"Yellow 5\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Lemon Juice From Puree, 2% Or Less Of The Following:, Sodium Lactate, Citric Acid, Natural Flavor, Color Added, Yellow 5, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 45,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugars (Sugar\",\"Corn Syrup\",\"Orange Puree)\",\"Modified Corn Starch\",\"Citric Acid\",\"Flavors\",\"Titanium Dioxide\",\"Shellac\",\"Sodium Citrate\",\"Beeswax\",\"Carnauba Wax\",\"Tartrazine\",\"Sunset Yellow Fcf\",\"Allura Red.\"]", "Sugars (Sugar, Corn Syrup, Orange Puree), Modified Corn Starch, Citric Acid, Flavors, Titanium Dioxide, Shellac, Sodium Citrate, Beeswax, Carnauba Wax, Tartrazine, Sunset Yellow Fcf, Allura Red." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 46,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Mango Juice From Puree\",\"Mango Juice From Concentrate\",\"Contains 2% Or Less Of The Following:\",\"Citric Acid\",\"Sodium Lactate\",\"Sodium Citrate\",\"Natural \\u0026 Artificial Flavor\",\"Color Added\",\"Yellow 5 Lake\",\"Yellow 5\",\"Blue 1 Lake\",\"Blue 1\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Mango Juice From Puree, Mango Juice From Concentrate, Contains 2% Or Less Of The Following:, Citric Acid, Sodium Lactate, Sodium Citrate, Natural & Artificial Flavor, Color Added, Yellow 5 Lake, Yellow 5, Blue 1 Lake, Blue 1, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 47,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Cranberry Puree\",\"Raspberry Puree\",\"Grape Juice Concentrate\",\"Mango Juice Concentrate\",\"Strawberry Juice Concentrate\",\"Kiwi Juice Concentrate\",\"Lemon Puree\",\"Cherry Juice Concentrate\",\"Cranberry Juice Concentrate\",\"Natural Flavors\",\"Citric Acid\",\"Color Added\",\"Grape Concentrate (Color)\",\"Turmeric (Color)\",\"Apple (Color)\",\"Hibiscus (Color)\",\"Black Currant (Color)\",\"Carrot (Color)\",\"Confectioner\\u0027S Glaze\",\"Beeswax\",\"Carnauba Wax.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Cranberry Puree, Raspberry Puree, Grape Juice Concentrate, Mango Juice Concentrate, Strawberry Juice Concentrate, Kiwi Juice Concentrate, Lemon Puree, Cherry Juice Concentrate, Cranberry Juice Concentrate, Natural Flavors, Citric Acid, Color Added, Grape Concentrate (Color), Turmeric (Color), Apple (Color), Hibiscus (Color), Black Currant (Color), Carrot (Color), Confectioner'S Glaze, Beeswax, Carnauba Wax." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 48,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Fruit And Vegetable Juice (Color)\",\"Citric Acid\",\"Confectioner\\u0027S Glaze\",\"Beeswax\",\"Carnauba Wax\",\"Natural And Artificial Flavors\",\"Salt\",\"Color Added\",\"Yellow 5 Lake.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Fruit And Vegetable Juice (Color), Citric Acid, Confectioner'S Glaze, Beeswax, Carnauba Wax, Natural And Artificial Flavors, Salt, Color Added, Yellow 5 Lake." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 49,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Lemon Juice From Puree\",\"Contains 2% Or Less Of The Following:\",\"Natural And Artificial Flavors\",\"Citric Acid\",\"Sodium Citrate\",\"Color Added\",\"Yellow 5\",\"Blue 1\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Lemon Juice From Puree, Contains 2% Or Less Of The Following:, Natural And Artificial Flavors, Citric Acid, Sodium Citrate, Color Added, Yellow 5, Blue 1, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 50,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Spirulina Extract (Color)\",\"Turmeric (Color)\",\"Confectioner\\u0027S Glaze\",\"Beeswax\",\"Carnauba Wax\",\"Natural And Artificial Flavors\",\"Salt\",\"Color Added.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Spirulina Extract (Color), Turmeric (Color), Confectioner'S Glaze, Beeswax, Carnauba Wax, Natural And Artificial Flavors, Salt, Color Added." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 51,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Orange Puree\",\"Natural \\u0026 Artificial Flavors\",\"Citric Acid\",\"Sodium Lactate\",\"Color Added\",\"Yellow 6\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Orange Puree, Natural & Artificial Flavors, Citric Acid, Sodium Lactate, Color Added, Yellow 6, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 52,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Cocoa Powder\",\"Dark Chocolate (Sugar\",\"Chocolate Liquor\",\"Cocoa Butter)\",\"Natural \\u0026 Artificial Flavors\",\"Color Added\",\"Yellow 5 Lake\",\"Blue 1 Lake\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze\",\"Tapioca Dextrin\",\"Salt.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Cocoa Powder, Dark Chocolate (Sugar, Chocolate Liquor, Cocoa Butter), Natural & Artificial Flavors, Color Added, Yellow 5 Lake, Blue 1 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze, Tapioca Dextrin, Salt." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 53,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Blueberry Juice From Puree\",\"Contains 2% Or Less Of The Following:\",\"Natural \\u0026 Artificial Flavors\",\"Color Added\",\"Red 40\",\"Red 40 Lake\",\"Blue 1\",\"Blue 2 Lake\",\"Yellow 5 Lake\",\"Citric Acid\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Blueberry Juice From Puree, Contains 2% Or Less Of The Following:, Natural & Artificial Flavors, Color Added, Red 40, Red 40 Lake, Blue 1, Blue 2 Lake, Yellow 5 Lake, Citric Acid, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 54,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Lemon Puree\",\"Lime Juice Concentrate\",\"Peach Puree Concentrate\",\"Pomegranate Juice Concentrate\",\"Strawberry Puree\",\"Coconut\",\"Natural \\u0026 Artificial Flavors\",\"Citric Acid\",\"Sodium Lactate\",\"Sodium Citrate\",\"Color Added\",\"Red 40 Lake\",\"Red 40\",\"Yellow 5 \\u0026 6\",\"Yellow 5 \\u0026 6 Lake\",\"Blue 1\",\"Blue 1 Lake\",\"Grape Skin Extract (Color)\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze\",\"Tapioca Dextrin.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Lemon Puree, Lime Juice Concentrate, Peach Puree Concentrate, Pomegranate Juice Concentrate, Strawberry Puree, Coconut, Natural & Artificial Flavors, Citric Acid, Sodium Lactate, Sodium Citrate, Color Added, Red 40 Lake, Red 40, Yellow 5 & 6, Yellow 5 & 6 Lake, Blue 1, Blue 1 Lake, Grape Skin Extract (Color), Beeswax, Carnauba Wax, Confectioner'S Glaze, Tapioca Dextrin." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 55,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Natural \\u0026 Artificial Flavors\",\"Citric Acid\",\"Color Added\",\"Yellow 5\",\"Red 40\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Natural & Artificial Flavors, Citric Acid, Color Added, Yellow 5, Red 40, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 56,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Acacia Gum\",\"Citric Acid\",\"Sodium Lactate\",\"Natural \\u0026 Artificial Flavor\",\"Color Added\",\"Yellow 5 \\u0026 6\",\"Red 40\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze\",\"Salt.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Acacia Gum, Citric Acid, Sodium Lactate, Natural & Artificial Flavor, Color Added, Yellow 5 & 6, Red 40, Beeswax, Carnauba Wax, Confectioner'S Glaze, Salt." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 57,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Orange Juice From Puree\",\"Contains 2% Or Less Of The Following:\",\"Citric Acid\",\"Natural And Artificial Flavors\",\"Color Added\",\"Yellow 6 Lake\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Orange Juice From Puree, Contains 2% Or Less Of The Following:, Citric Acid, Natural And Artificial Flavors, Color Added, Yellow 6 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 58,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Apple Juice Concentrate\",\"Citric Acid\",\"Cocoa Powder\",\"Natural \\u0026 Artificial Flavors\",\"Color Added\",\"Red 40 Lake\",\"Yellow 5 \\u0026 6 Lake\",\"Blue 1 \\u0026 2 Lake\",\"Red 40\",\"Vegetable And Fruit Juice (Color)\",\"Tapioca Dextrin\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze\",\"Ground Cinnamon\",\"Salt.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Apple Juice Concentrate, Citric Acid, Cocoa Powder, Natural & Artificial Flavors, Color Added, Red 40 Lake, Yellow 5 & 6 Lake, Blue 1 & 2 Lake, Red 40, Vegetable And Fruit Juice (Color), Tapioca Dextrin, Beeswax, Carnauba Wax, Confectioner'S Glaze, Ground Cinnamon, Salt." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 59,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Strawberry Puree\",\"Chocolate Liquor\",\"Cocoa Butter\",\"Cocoa Powder\",\"Citric Acid\",\"Ground Cinnamon\",\"Tapioca Dextrin\",\"Natural And Artificial Flavor\",\"Color Added\",\"Red 40 Lake\",\"Yellow 5 \\u0026 6 Lake\",\"Red 40\",\"Blue 1 \\u0026 2 Lake\",\"Blue 1\",\"Yellow 5\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze\",\"Salt.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Strawberry Puree, Chocolate Liquor, Cocoa Butter, Cocoa Powder, Citric Acid, Ground Cinnamon, Tapioca Dextrin, Natural And Artificial Flavor, Color Added, Red 40 Lake, Yellow 5 & 6 Lake, Red 40, Blue 1 & 2 Lake, Blue 1, Yellow 5, Beeswax, Carnauba Wax, Confectioner'S Glaze, Salt." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 60,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Peach Juice From Puree Concentrate\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Citric Acid\",\"Sodium Citrate\",\"Natural And Artificial Flavor\",\"Color Added\",\"Yellow 5\",\"Yellow 5 Lake\",\"Red 40 Lake\",\"Red 40\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Peach Juice From Puree Concentrate, Modified Food Starch, Contains 2% Or Less Of The Following:, Citric Acid, Sodium Citrate, Natural And Artificial Flavor, Color Added, Yellow 5, Yellow 5 Lake, Red 40 Lake, Red 40, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 61,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Glucose Syrup\",\"Modified Cornstarch\",\"Pear Juice Concentrate\",\"Flavourings\",\"Colours (E100\",\"E171)\",\"Acidity Regulator (E330)\",\"Glazing Agents (E901\",\"E903\",\"E904)\",\"Vegetable Concentrate (Spirulina).\"]", "Sugar, Glucose Syrup, Modified Cornstarch, Pear Juice Concentrate, Flavourings, Colours (E100, E171), Acidity Regulator (E330), Glazing Agents (E901, E903, E904), Vegetable Concentrate (Spirulina)." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 62,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Cranberry Puree\",\"Raspberry Puree\",\"Grape Juice Concentrate\",\"Mango Juice Concentrate\",\"Strawberry Juice Concentrate\",\"Kiwi Juice Concentrate\",\"Lemon Puree\",\"Cherry Juice Concentrate\",\"Cranberry Juice Concentrate\",\"Natural Flavors\",\"Citric Acid\",\"Color Added\",\"Grape Concentrate (Color)\",\"Turmeric (Color)\",\"Apple (Color)\",\"Hibiscus (Color)\",\"Black Currant (Color)\",\"Carrot (Color)\",\"Confectioner\\u0027S Glaze\",\"Beeswax\",\"Carnauba Wax.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Cranberry Puree, Raspberry Puree, Grape Juice Concentrate, Mango Juice Concentrate, Strawberry Juice Concentrate, Kiwi Juice Concentrate, Lemon Puree, Cherry Juice Concentrate, Cranberry Juice Concentrate, Natural Flavors, Citric Acid, Color Added, Grape Concentrate (Color), Turmeric (Color), Apple (Color), Hibiscus (Color), Black Currant (Color), Carrot (Color), Confectioner'S Glaze, Beeswax, Carnauba Wax." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 63,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Coconut\",\"Citric Acid\",\"Artificial Flavors\",\"Color Added\",\"Yellow 5\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Coconut, Citric Acid, Artificial Flavors, Color Added, Yellow 5, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 64,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Plum Juice From Concentrate\",\"Contains 2% Or Less Of The Following:\",\"Natural And Artificial Flavors\",\"Citric Acid\",\"Sodium Citrate\",\"Color Added\",\"Red 40 Lake\",\"Blue 1 \\u0026 2 Lake\",\"Yellow 6 Lake\",\"Red 40\",\"Yellow 5\",\"Blue 1\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Plum Juice From Concentrate, Contains 2% Or Less Of The Following:, Natural And Artificial Flavors, Citric Acid, Sodium Citrate, Color Added, Red 40 Lake, Blue 1 & 2 Lake, Yellow 6 Lake, Red 40, Yellow 5, Blue 1, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 65,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Pomegranate Juice Concentrate\",\"Natural \\u0026 Artificial Flavor\",\"Citric Acid\",\"Sodium Lactate\",\"Sodium Citrate\",\"Color Added\",\"Red 40\",\"Red 40 Lake\",\"Blue 2 Lake\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Pomegranate Juice Concentrate, Natural & Artificial Flavor, Citric Acid, Sodium Lactate, Sodium Citrate, Color Added, Red 40, Red 40 Lake, Blue 2 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 66,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Lemon Puree\",\"Lime Juice Concentrate\",\"Peach Puree Concentrate\",\"Pomegranate Juice Concentrate\",\"Strawberry Puree\",\"Coconut\",\"Natural \\u0026 Artificial Flavors\",\"Citric Acid\",\"Sodium Lactate\",\"Sodium Citrate\",\"Color Added\",\"Red 40 Lake\",\"Red 40\",\"Yellow 5 \\u0026 6\",\"Yellow 5 \\u0026 6 Lake\",\"Blue 1\",\"Blue 1 Lake\",\"Grape Skin Extract (Color)\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze\",\"Tapioca Dextrin.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Lemon Puree, Lime Juice Concentrate, Peach Puree Concentrate, Pomegranate Juice Concentrate, Strawberry Puree, Coconut, Natural & Artificial Flavors, Citric Acid, Sodium Lactate, Sodium Citrate, Color Added, Red 40 Lake, Red 40, Yellow 5 & 6, Yellow 5 & 6 Lake, Blue 1, Blue 1 Lake, Grape Skin Extract (Color), Beeswax, Carnauba Wax, Confectioner'S Glaze, Tapioca Dextrin." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 67,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Raspberry Juice From Puree\",\"Contains 2% Or Less Of The Following:\",\"Citric Acid\",\"Artificial Flavor\",\"Color Added\",\"Yellow 6\",\"Red 40 Lake\",\"Red 40\",\"Yellow 5 \\u0026 6 Lake\",\"Blue 2 Lake\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Raspberry Juice From Puree, Contains 2% Or Less Of The Following:, Citric Acid, Artificial Flavor, Color Added, Yellow 6, Red 40 Lake, Red 40, Yellow 5 & 6 Lake, Blue 2 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 68,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Apple Juice From Concentrate\",\"Contains 2% Or Less Of The Following:\",\"Lactic Acid\",\"Citric Acid\",\"Fumaric Acid\",\"Natural And Artificial Flavor\",\"Color Added\",\"Red 40\",\"Yellow 6\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Apple Juice From Concentrate, Contains 2% Or Less Of The Following:, Lactic Acid, Citric Acid, Fumaric Acid, Natural And Artificial Flavor, Color Added, Red 40, Yellow 6, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 69,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Natural \\u0026 Artificial Flavors\",\"Citric Acid\",\"Color Added\",\"Red 40\",\"Red 3\",\"Blue 2 Lake\",\"Red 40 Lake\",\"Maltodextrin\",\"Confectioner\\u0027S Glaze\",\"Beeswax\",\"Carnauba Wax.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Natural & Artificial Flavors, Citric Acid, Color Added, Red 40, Red 3, Blue 2 Lake, Red 40 Lake, Maltodextrin, Confectioner'S Glaze, Beeswax, Carnauba Wax." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 70,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Natural And Artificial Flavor\",\"Color Added\",\"Vegetable And Fruit Juice (Color)\",\"Yellow 5 \\u0026 6 Lake\",\"Blue 2 Lake\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze\",\"Salt.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Natural And Artificial Flavor, Color Added, Vegetable And Fruit Juice (Color), Yellow 5 & 6 Lake, Blue 2 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze, Salt." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 71,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Artificial Flavor\",\"Color Added\",\"Red 40 Lake\",\"Yellow 5 Lake\",\"Yellow 5\",\"Red 40\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Artificial Flavor, Color Added, Red 40 Lake, Yellow 5 Lake, Yellow 5, Red 40, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 72,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Cherry Juice From Concentrate\",\"Contains 2% Or Less Of The Following:\",\"Citric Acid\",\"Fumaric Acid\",\"Sodium Lactate\",\"Sodium Citrate\",\"Artificial Flavor\",\"Color Added\",\"Red 40 Lake\",\"Turmeric (Color)\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Cherry Juice From Concentrate, Contains 2% Or Less Of The Following:, Citric Acid, Fumaric Acid, Sodium Lactate, Sodium Citrate, Artificial Flavor, Color Added, Red 40 Lake, Turmeric (Color), Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 73,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Citric Acid\",\"Sodium Lactate\",\"Tartaric Acid\",\"Grape Juice Concentrate\",\"Gum Arabic\",\"Natural \\u0026 Artificial Flavor\",\"Vegetable \\u0026 Fruit Juice (Color)\",\"Color Added\",\"Red 40\",\"Blue 1\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Citric Acid, Sodium Lactate, Tartaric Acid, Grape Juice Concentrate, Gum Arabic, Natural & Artificial Flavor, Vegetable & Fruit Juice (Color), Color Added, Red 40, Blue 1, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 74,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Lemon Juice From Puree\",\"Contains 2% Or Less Of The Following:\",\"Citric Acid\",\"Fumaric Acid\",\"Sodium Lactate\",\"Sodium Citrate\",\"Natural Flavor\",\"Color Added\",\"Yellow 5\",\"Yellow 5 Lake\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Lemon Juice From Puree, Contains 2% Or Less Of The Following:, Citric Acid, Fumaric Acid, Sodium Lactate, Sodium Citrate, Natural Flavor, Color Added, Yellow 5, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 75,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Apple Juice Concentrate\",\"Grape Juice Concentrate\",\"Lemon Puree\",\"Cherry Juice Concentrate\",\"Orange Puree\",\"Citric Acid\",\"Fumaric Acid\",\"Sodium Citrate\",\"Sodium Lactate\",\"Natural And Artificial Flavors\",\"Color Added\",\"Red 40 Lake\",\"Blue 1 \\u0026 2\",\"Blue 1 \\u0026 2 Lake\",\"Yellow 5 \\u0026 6 Lake\",\"Yellow 5\",\"Turmeric (Color)\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Apple Juice Concentrate, Grape Juice Concentrate, Lemon Puree, Cherry Juice Concentrate, Orange Puree, Citric Acid, Fumaric Acid, Sodium Citrate, Sodium Lactate, Natural And Artificial Flavors, Color Added, Red 40 Lake, Blue 1 & 2, Blue 1 & 2 Lake, Yellow 5 & 6 Lake, Yellow 5, Turmeric (Color), Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 76,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Pomegranate Juice Concentrate\",\"Peach Puree Concentrate\",\"Banana Puree\",\"Pear Juice Concentrate\",\"Natural And Artificial Flavors\",\"Citric Acid\",\"Sodium Lactate\",\"Sodium Citrate\",\"Color Added\",\"Red 40\",\"Yellow 5 \\u0026 6\",\"Yellow 5 \\u0026 6 Lake\",\"Blue 1 \\u0026 2 Lake\",\"Red 40 Lake\",\"Blue 1\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze\",\"Salt\",\"Coffee\",\"Tapioca Dextrin.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Pomegranate Juice Concentrate, Peach Puree Concentrate, Banana Puree, Pear Juice Concentrate, Natural And Artificial Flavors, Citric Acid, Sodium Lactate, Sodium Citrate, Color Added, Red 40, Yellow 5 & 6, Yellow 5 & 6 Lake, Blue 1 & 2 Lake, Red 40 Lake, Blue 1, Beeswax, Carnauba Wax, Confectioner'S Glaze, Salt, Coffee, Tapioca Dextrin." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 77,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Strawberry Juice From Puree\",\"Contains 2% Or Less Of The Following:\",\"Citric Acid\",\"Natural And Artificial Flavors\",\"Color Added\",\"Red 40 Lake\",\"Red 40\",\"Yellow 5 Lake\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Strawberry Juice From Puree, Contains 2% Or Less Of The Following:, Citric Acid, Natural And Artificial Flavors, Color Added, Red 40 Lake, Red 40, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 78,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Strawberry Juice From Puree\",\"Contains 2% Or Less Of The Following:\",\"Citric Acid\",\"Natural And Artificial Flavors\",\"Color Added\",\"Red 40 Lake\",\"Yellow 6\",\"Red 40\",\"Yellow 5 \\u0026 6 Lake\",\"Tapioca Dextrin\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Strawberry Juice From Puree, Contains 2% Or Less Of The Following:, Citric Acid, Natural And Artificial Flavors, Color Added, Red 40 Lake, Yellow 6, Red 40, Yellow 5 & 6 Lake, Tapioca Dextrin, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 79,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Apple Juice Concentrate\",\"Citric Acid\",\"Cocoa Powder\",\"Natural \\u0026 Artificial Flavors\",\"Color Added\",\"Red 40 Lake\",\"Yellow 5 \\u0026 6 Lake\",\"Blue 1 \\u0026 2 Lake\",\"Red 40\",\"Vegetable And Fruit Juice (Color)\",\"Tapioca Dextrin\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze\",\"Ground Cinnamon\",\"Salt.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Apple Juice Concentrate, Citric Acid, Cocoa Powder, Natural & Artificial Flavors, Color Added, Red 40 Lake, Yellow 5 & 6 Lake, Blue 1 & 2 Lake, Red 40, Vegetable And Fruit Juice (Color), Tapioca Dextrin, Beeswax, Carnauba Wax, Confectioner'S Glaze, Ground Cinnamon, Salt." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 80,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Strawberry Juice From Concentrate\",\"Contains 2% Or Less Of The Following:\",\"Citric Acid\",\"Artificial Flavors\",\"Color Added\",\"Red 40 Lake\",\"Yellow 6\",\"Red 40\",\"Blue 2 Lake\",\"Yellow 5 \\u0026 6 Lake\",\"Tapioca Dextrin\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Strawberry Juice From Concentrate, Contains 2% Or Less Of The Following:, Citric Acid, Artificial Flavors, Color Added, Red 40 Lake, Yellow 6, Red 40, Blue 2 Lake, Yellow 5 & 6 Lake, Tapioca Dextrin, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 81,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Citric Acid\",\"Confectioner\\u0027S Glaze\",\"Beeswax\",\"Carnauba Wax\",\"Natural And Artificial Flavors\",\"Salt\",\"Color Added\",\"Red 40\",\"Yellow 6 Lake.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Citric Acid, Confectioner'S Glaze, Beeswax, Carnauba Wax, Natural And Artificial Flavors, Salt, Color Added, Red 40, Yellow 6 Lake." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 82,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Lemon Juice From Puree\",\"2% Or Less Of The Following:\",\"Sodium Lactate\",\"Citric Acid\",\"Natural Flavor\",\"Color Added\",\"Yellow 5\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Lemon Juice From Puree, 2% Or Less Of The Following:, Sodium Lactate, Citric Acid, Natural Flavor, Color Added, Yellow 5, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 83,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Lime Juice From Concentrate\",\"2% Or Less Of The Following:\",\"Sodium Lactate\",\"Citric Acid\",\"Natural Flavor\",\"Color Added\",\"Yellow 5\",\"Blue 1\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Lime Juice From Concentrate, 2% Or Less Of The Following:, Sodium Lactate, Citric Acid, Natural Flavor, Color Added, Yellow 5, Blue 1, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 84,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Orange Juice From Orange Puree\",\"2% Or Less Of The Following:\",\"Citric Acid\",\"Sodium Lactate\",\"Natural Flavor\",\"Color Added\",\"Yellow 6\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Orange Juice From Orange Puree, 2% Or Less Of The Following:, Citric Acid, Sodium Lactate, Natural Flavor, Color Added, Yellow 6, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 85,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Grapefruit Juice From Concentrate\",\"2% Or Less Of The Following:\",\"Citric Acid\",\"Sodium Lactate\",\"Natural Flavor\",\"Color Added\",\"Yellow 5 \\u0026 6 Lake\",\"Red 40\",\"Blue 2 Lake\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Grapefruit Juice From Concentrate, 2% Or Less Of The Following:, Citric Acid, Sodium Lactate, Natural Flavor, Color Added, Yellow 5 & 6 Lake, Red 40, Blue 2 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 86,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Tangerine Juice From Concentrate\",\"2% Or Less Of The Following:\",\"Citric Acid\",\"Sodium Lactate\",\"Natural Flavor\",\"Color Added\",\"Yellow 6\",\"Red 40\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Tangerine Juice From Concentrate, 2% Or Less Of The Following:, Citric Acid, Sodium Lactate, Natural Flavor, Color Added, Yellow 6, Red 40, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 87,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Confectioner\\u0027S Glaze\",\"Beeswax\",\"Carnauba Wax\",\"Natural And Artificial Flavors\",\"Salt\",\"Color Added\",\"Red 40\",\"Blue 1Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Confectioner\\u0027S Glaze\",\"Beeswax\",\"Carnauba Wax\",\"Natural And Artificial Flavors\",\"Salt\",\"Color Added\",\"Red 40\",\"Blue 1.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Confectioner'S Glaze, Beeswax, Carnauba Wax, Natural And Artificial Flavors, Salt, Color Added, Red 40, Blue 1Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Confectioner'S Glaze, Beeswax, Carnauba Wax, Natural And Artificial Flavors, Salt, Color Added, Red 40, Blue 1." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 88,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Confectioner\\u0027S Glaze\",\"Beeswax\",\"Carnauba Wax\",\"Natural And Artificial Flavors\",\"Salt\",\"Color Added\",\"Yellow 6 Lake\",\"Yellow 5.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Confectioner'S Glaze, Beeswax, Carnauba Wax, Natural And Artificial Flavors, Salt, Color Added, Yellow 6 Lake, Yellow 5." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 89,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Watermelon Juice From Concentrate\",\"Contains 2% Or Less Of The Following:\",\"Artificial Flavor\",\"Citric Acid\",\"Color Added\",\"Red 40 Lake\",\"Yellow 5\",\"Blue 1\",\"Red 40\",\"Yellow 5 Lake\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Watermelon Juice From Concentrate, Contains 2% Or Less Of The Following:, Artificial Flavor, Citric Acid, Color Added, Red 40 Lake, Yellow 5, Blue 1, Red 40, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 90,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Watermelon Juice From Concentrate\",\"Contains 2% Or Less Of The Following:\",\"Artificial Flavor\",\"Citric Acid\",\"Color Added\",\"Red 40 Lake\",\"Yellow 5\",\"Blue 1\",\"Red 40\",\"Yellow 5 Lake\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Watermelon Juice From Concentrate, Contains 2% Or Less Of The Following:, Artificial Flavor, Citric Acid, Color Added, Red 40 Lake, Yellow 5, Blue 1, Red 40, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 91,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Natural \\u0026 Artificial Flavor\",\"Color Added\",\"Red 40 Lake\",\"Yellow 5 Lake\",\"Red 40\",\"Blue 1 Lake\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Natural & Artificial Flavor, Color Added, Red 40 Lake, Yellow 5 Lake, Red 40, Blue 1 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 92,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Cherry Juice From Concentrate\",\"Contains 2% Or Less Of The Following:\",\"Citric Acid\",\"Artificial Flavor\",\"Color Added\",\"Red 40\",\"Red 40 Lake\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Cherry Juice From Concentrate, Contains 2% Or Less Of The Following:, Citric Acid, Artificial Flavor, Color Added, Red 40, Red 40 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 93,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Watermelon Juice From Concentrate\",\"Contains 2% Or Less Of The Following:\",\"Artificial Flavor\",\"Citric Acid\",\"Color Added\",\"Red 40 Lake\",\"Yellow 5\",\"Blue 1\",\"Red 40\",\"Yellow 5 Lake\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Watermelon Juice From Concentrate, Contains 2% Or Less Of The Following:, Artificial Flavor, Citric Acid, Color Added, Red 40 Lake, Yellow 5, Blue 1, Red 40, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 94,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Blackberry Juice From Puree\",\"Contains 2% Or Less Of The Following:\",\"Citric Acid\",\"Natural \\u0026 Artificial Flavor\",\"Sodium Lactate\",\"Sodium Citrate\",\"Color Added\",\"Blue 2 Lake\",\"Red 40 Lake\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Blackberry Juice From Puree, Contains 2% Or Less Of The Following:, Citric Acid, Natural & Artificial Flavor, Sodium Lactate, Sodium Citrate, Color Added, Blue 2 Lake, Red 40 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 95,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Lemon Juice From Lemon Puree\",\"Contains 2% Or Less Of The Following:\",\"Citric Acid\",\"Natural And Artificial Flavors\",\"Color Added\",\"Yellow 5\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Lemon Juice From Lemon Puree, Contains 2% Or Less Of The Following:, Citric Acid, Natural And Artificial Flavors, Color Added, Yellow 5, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 96,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Lime Juice From Concentrate\",\"Lemon Juice From Lemon Puree\",\"Contains 2% Or Less Of The Following:\",\"Citric Acid\",\"Sodium Lactate\",\"Natural Flavors\",\"Color Added\",\"Yellow 5\",\"Blue 1\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Lime Juice From Concentrate, Lemon Juice From Lemon Puree, Contains 2% Or Less Of The Following:, Citric Acid, Sodium Lactate, Natural Flavors, Color Added, Yellow 5, Blue 1, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 97,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Lemon Puree\",\"Citric Acid\",\"Natural \\u0026 Artificial Flavor\",\"Color Added\",\"Vegetable And Fruit Juice (Color)\",\"Yellow 5 \\u0026 6 Lake\",\"Blue 2 Lake\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze\",\"Salt.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Lemon Puree, Citric Acid, Natural & Artificial Flavor, Color Added, Vegetable And Fruit Juice (Color), Yellow 5 & 6 Lake, Blue 2 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze, Salt." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 98,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Natural And Artificial Flavors\",\"Color Added\",\"Blue 2 Lake\",\"Yellow 6 Lake\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Natural And Artificial Flavors, Color Added, Blue 2 Lake, Yellow 6 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 99,
                columns: new[] { "ImageUrl", "Ingredients", "IngredientsSerialized" },
                values: new object[] { "https://cdn-tp1.mozu.com/9046-m1/cms/files/2da22c8a-8fd0-458f-90a8-8df36e790112", "[\"Sugar\",\"Glucose Syrup\",\"Modified Cornstarch\",\"Passion Fruit Juice Concentrate\",\"Flavourings\",\"Acidity Regulator (E330)\",\"Colours (E100\",\"E171)\",\"Glazing Agents (E901\",\"E903\",\"E904)\",\"Fruit And Vegetable Concentrates (Purple Carrot\",\"Carrot\",\"Black Currant).\"]", "Sugar, Glucose Syrup, Modified Cornstarch, Passion Fruit Juice Concentrate, Flavourings, Acidity Regulator (E330), Colours (E100, E171), Glazing Agents (E901, E903, E904), Fruit And Vegetable Concentrates (Purple Carrot, Carrot, Black Currant)." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 100,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Citric Acid\",\"Natural And Artificial Flavor\",\"Color Added\",\"Sodium Citrate\",\"Blue 1 Lake\",\"Blue 1\",\"Confectioner\\u0027S Glaze\",\"Beeswax\",\"Carnauba Wax.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Citric Acid, Natural And Artificial Flavor, Color Added, Sodium Citrate, Blue 1 Lake, Blue 1, Confectioner'S Glaze, Beeswax, Carnauba Wax." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 101,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Natural \\u0026 Artificial Flavors\",\"Tapioca Dextrin\",\"Color Added\",\"Yellow 5 \\u0026 6 Lake\",\"Red 40 Lake\",\"Red 40\",\"Blue 1 \\u0026 2 Lake\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze\",\"Salt.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Natural & Artificial Flavors, Tapioca Dextrin, Color Added, Yellow 5 & 6 Lake, Red 40 Lake, Red 40, Blue 1 & 2 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze, Salt." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 102,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Natural \\u0026 Artificial Flavors\",\"Tapioca Dextrin\",\"Color Added\",\"Yellow 5 \\u0026 6 Lake\",\"Red 40 Lake\",\"Red 40\",\"Blue 1 \\u0026 2 Lake\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze\",\"Salt.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Natural & Artificial Flavors, Tapioca Dextrin, Color Added, Yellow 5 & 6 Lake, Red 40 Lake, Red 40, Blue 1 & 2 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze, Salt." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 103,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Apple Juice From Concentrate\",\"Contains 2% Or Less Of The Following:\",\"Citric Acid\",\"Fumaric Acid\",\"Sodium Lactate\",\"Sodium Citrate\",\"Artificial Flavor\",\"Color Added\",\"Yellow 5\",\"Yellow 5 Lake\",\"Blue 1\",\"Blue 1 Lake\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Apple Juice From Concentrate, Contains 2% Or Less Of The Following:, Citric Acid, Fumaric Acid, Sodium Lactate, Sodium Citrate, Artificial Flavor, Color Added, Yellow 5, Yellow 5 Lake, Blue 1, Blue 1 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze." });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 104,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[]", "" });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 105,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[]", "" });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 106,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[]", "" });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 107,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[]", "" });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 108,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[]", "" });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 109,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[]", "" });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 110,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[]", "" });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 111,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[]", "" });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 112,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[]", "" });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 113,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[]", "" });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 114,
                columns: new[] { "Ingredients", "IngredientsSerialized" },
                values: new object[] { "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% Or Less Of The Following:\",\"Citric Acid\",\"Natural \\u0026 Artificial Flavor\",\"Color Added\",\"Blue 1\",\"Beeswax\",\"Carnauba Wax\",\"Confectioner\\u0027S Glaze.\"]", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following:, Citric Acid, Natural & Artificial Flavor, Color Added, Blue 1, Beeswax, Carnauba Wax, Confectioner'S Glaze." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IngredientsSerialized",
                table: "Beans");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 1,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Citric Acid, Sodium Lactate, Natural \\u0026 Artificial Flavor, Color Added, Yellow 5, Blue 1, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 2,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural And Artificial Flavors, Color Added, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 3,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural \\u0026 Artificial Flavors, Color Added, Vegetable \\u0026 Fruit Juice (Color), Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 4,
                column: "Ingredients",
                value: "[\"Cane Sugar, Tapioca Syrup, Modified Food Starch, Sour Cherry Juice From Concentrate, Blueberry Juice From Blueberry Puree, Pomegranate Juice From Concentrate, Acai Puree, Natural Flavors, Acerola (Barbados) Cherry Juice, Cranberry Puree, Citric Acid, Apple (Color), Confectioner\\u0027S Glaze, Beeswax, Grape Concentrate (Color), Carrot (Color), Carnauba Wax, Black Currant (Color), Hibiscus (Color), Color Added.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 5,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Strawberry Puree, Chocolate Liquor, Cocoa Butter, Cocoa Powder, Citric Acid, Ground Cinnamon, Tapioca Dextrin, Natural And Artificial Flavor, Color Added, Red 40 Lake, Yellow 5 \\u0026 6 Lake, Red 40, Blue 1 \\u0026 2 Lake, Blue 1, Yellow 5, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Salt.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 6,
                column: "Ingredients",
                value: "[\"Cane Sugar, Tapioca Syrup, Modified Food Starch, Sour Cherry Juice From Concentrate, Blueberry Juice From Blueberry Puree, Pomegranate Juice From Concentrate, Acai Puree, Natural Flavors, Acerola (Barbados) Cherry Juice, Cranberry Puree, Citric Acid, Apple (Color), Confectioner\\u0027S Glaze, Beeswax, Grape Concentrate (Color), Carrot (Color), Carnauba Wax, Black Currant (Color), Hibiscus (Color), Color Added.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 7,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Blueberry Juice From Puree, Contains 2% Or Less Of The Following: Citric Acid, Natural \\u0026 Artificial Flavor, Color Added, Blue 1 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 8,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Artificial Flavor, Color Added, Red 40 Lake, Red 40, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 9,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural And Artificial Flavors, Color Added, Yellow 5, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Salt.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 10,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Cantaloupe Juice From Cantaloupe Powder, Contains 2% Or Less Of The Following: Natural And Artificial Flavors, Color Added, Yellow 6 Lake, Yellow 6, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 11,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural And Artificial Flavors, Coffee, Color Added, Vegetable And Fruit Juice (Color), Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 12,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural And Artificial Flavors, Color Added, Yellow 6, Yellow 5 \\u0026 6 Lake, Blue 2 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Salt.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 13,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Blueberry Juice From Puree, Contains 2% Or Less Of The Following: Citric Acid, Natural \\u0026 Artificial Flavor, Color Added, Blue 1 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 14,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Strawberry Puree, Chocolate Liquor, Cocoa Butter, Cocoa Powder, Citric Acid, Ground Cinnamon, Tapioca Dextrin, Natural And Artificial Flavor, Color Added, Red 40 Lake, Yellow 5 \\u0026 6 Lake, Red 40, Blue 1 \\u0026 2 Lake, Blue 1, Yellow 5, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Salt.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 15,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Cocoa Powder, Chocolate Liquor, Cocoa Butter, Natural And Artificial Flavor, Color Added, Red 40 Lake, Yellow 5 Lake, Blue 2 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 16,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Artificial Flavor, Color Added, Red 40, Red 40 Lake, Turmeric (Color), Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 17,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Apple Juice Concentrate, Citric Acid, Cocoa Powder, Natural \\u0026 Artificial Flavors, Color Added, Red 40 Lake, Yellow 5 \\u0026 6 Lake, Blue 1 \\u0026 2 Lake, Red 40, Vegetable And Fruit Juice (Color), Tapioca Dextrin, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Ground Cinnamon, Salt.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 18,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Coconut, Artificial Flavor, Color Added, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 19,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Citric Acid, Natural And Artificial Flavor, Color Added, Red 40, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 20,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Cranberry Puree, Natural Flavor, Color Added, Red 40 Lake, Blue 2 Lake, Turmeric (Color), Citric Acid, Confectioner\\u0027S Glaze, Beeswax, Carnauba Wax.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 21,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Cranberry Puree, Raspberry Puree, Grape Juice Concentrate, Mango Juice Concentrate, Strawberry Juice Concentrate, Kiwi Juice Concentrate, Lemon Puree, Cherry Juice Concentrate, Cranberry Juice Concentrate, Natural Flavors, Citric Acid, Color Added, Grape Concentrate (Color), Turmeric (Color), Apple (Color), Hibiscus (Color), Black Currant (Color), Carrot (Color), Confectioner\\u0027S Glaze, Beeswax, Carnauba Wax.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 22,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Pineapple Juice From Concentrate, Contains 2% Or Less Of The Following: Citric Acid, Artificial Flavor, Color Added, Yellow 5, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 23,
                column: "Ingredients",
                value: "[\"Ingredients: Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Sodium Citrate, Phosphoric Acid, Natural And Artificial Flavor, Color Added, Red 40 Lake, Blue 2 Lake, Red 40, Yellow 5 Lake, Vegetable \\u0026 Fruit Juice (Color), Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Caffeine.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 24,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Vanilla Beans, Natural And Artificial Flavors, Color Added, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 25,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural \\u0026 Artificial Flavors, Color Added, Blue 1 Lake, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Tapioca Dextrin.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 26,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Apple Juice Concentrate, Citric Acid, Cocoa Powder, Natural \\u0026 Artificial Flavors, Color Added, Red 40 Lake, Yellow 5 \\u0026 6 Lake, Blue 1 \\u0026 2 Lake, Red 40, Vegetable And Fruit Juice (Color), Tapioca Dextrin, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Ground Cinnamon, Salt.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 27,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Citric Acid, Sodium Lactate, Tartaric Acid, Grape Juice Concentrate, Acacia Gum, Natural \\u0026 Artificial Flavor, Color Added, Red 40, Blue 1, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 28,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Apple Juice From Concentrate, Contains 2% Or Less Of The Following: Citric Acid, Artificial Flavor, Color Added, Yellow 5, Blue 1, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 29,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Passion Fruit Juice From Concentrate, Contains 2% Or Less Of The Following: Citric Acid, Natural \\u0026 Artificial Flavor, Color Added, Blue 1 \\u0026 2 Lake, Blue 1 \\u0026 2, Red 40 Lake, Red 40, Yellow 5 Lake, Yellow 5, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 30,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Citric Acid, Natural \\u0026 Artificial Flavor, Color Added, Blue 1, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 31,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Blueberry Juice From Puree, Contains 2% Or Less Of The Following: Citric Acid, Natural \\u0026 Artificial Flavor, Color Added, Blue 1 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 32,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Artificial Flavor, Color Added, Red 40 Lake, Red 40, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 33,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural \\u0026 Artificial Flavors, Citric Acid, Color Added, Maltodextrin, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 34,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural And Artificial Flavors, Color Added, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 35,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural And Artificial Flavors, Citric Acid, Color Added, Yellow 5, Red 40, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 36,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Citric Acid, Sodium Lactate, Tartaric Acid, Grape Juice Concentrate, Gum Arabic, Natural \\u0026 Artificial Flavor, Vegetable \\u0026 Fruit Juice (Color), Color Added, Red 40, Blue 1, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 37,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Orange Juice From Orange Puree, 2% Or Less Of The Following: Citric Acid, Sodium Lactate, Natural Flavor, Color Added, Yellow 6, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 38,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Apple Juice From Concentrate, Contains 2% Or Less Of The Following: Citric Acid, Fumaric Acid, Sodium Lactate, Sodium Citrate, Artificial Flavor, Color Added, Yellow 5, Yellow 5 Lake, Blue 1, Blue 1 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 39,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Lemon Juice From Puree, Contains 2% Or Less Of The Following: Citric Acid, Fumaric Acid, Sodium Lactate, Sodium Citrate, Natural Flavor, Color Added, Yellow 5, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 40,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Cherry Juice From Concentrate, Contains 2% Or Less Of The Following: Citric Acid, Artificial Flavor, Color Added, Red 40, Red 40 Lake, Turmeric (Color), Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 41,
                column: "Ingredients",
                value: "[\"Sugar, Glucose Syrup, Modified Cornstarch, Pear Juice Concentrate, Flavouring, Acidity Regulator (E330), Glazing Agents (E901, E903, E904), Colours (E100, E171), Fruit And Vegetable Concentrates (Carrot, Pumpkin, Spirulina, Apple, Hibiscus), Tapioca Dextrin.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 42,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Kiwi Juice From Concentrate, Contains 2% Or Less Of The Following: Natural And Artificial Flavor, Color Added, Yellow 5, Blue 1, Citric Acid, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 43,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Cranberry Puree, Raspberry Puree, Grape Juice Concentrate, Mango Juice Concentrate, Strawberry Juice Concentrate, Kiwi Juice Concentrate, Lemon Puree, Cherry Juice Concentrate, Cranberry Juice Concentrate, Natural Flavors, Citric Acid, Color Added, Grape Concentrate (Color), Turmeric (Color), Apple (Color), Hibiscus (Color), Black Currant (Color), Carrot (Color), Confectioner\\u0027S Glaze, Beeswax, Carnauba Wax.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 44,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Lemon Juice From Puree, 2% Or Less Of The Following: Sodium Lactate, Citric Acid, Natural Flavor, Color Added, Yellow 5, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 45,
                column: "Ingredients",
                value: "[\"Sugars (Sugar, Corn Syrup, Orange Puree), Modified Corn Starch, Citric Acid, Flavors, Titanium Dioxide, Shellac, Sodium Citrate, Beeswax, Carnauba Wax, Tartrazine, Sunset Yellow Fcf, Allura Red.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 46,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Mango Juice From Puree, Mango Juice From Concentrate, Contains 2% Or Less Of The Following: Citric Acid, Sodium Lactate, Sodium Citrate, Natural \\u0026 Artificial Flavor, Color Added, Yellow 5 Lake, Yellow 5, Blue 1 Lake, Blue 1, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 47,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Cranberry Puree, Raspberry Puree, Grape Juice Concentrate, Mango Juice Concentrate, Strawberry Juice Concentrate, Kiwi Juice Concentrate, Lemon Puree, Cherry Juice Concentrate, Cranberry Juice Concentrate, Natural Flavors, Citric Acid, Color Added, Grape Concentrate (Color), Turmeric (Color), Apple (Color), Hibiscus (Color), Black Currant (Color), Carrot (Color), Confectioner\\u0027S Glaze, Beeswax, Carnauba Wax.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 48,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Fruit And Vegetable Juice (Color), Citric Acid, Confectioner\\u0027S Glaze, Beeswax, Carnauba Wax, Natural And Artificial Flavors, Salt, Color Added, Yellow 5 Lake.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 49,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Lemon Juice From Puree, Contains 2% Or Less Of The Following: Natural And Artificial Flavors, Citric Acid, Sodium Citrate, Color Added, Yellow 5, Blue 1, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 50,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Spirulina Extract (Color), Turmeric (Color), Confectioner\\u0027S Glaze, Beeswax, Carnauba Wax, Natural And Artificial Flavors, Salt, Color Added.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 51,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Orange Puree, Natural \\u0026 Artificial Flavors, Citric Acid, Sodium Lactate, Color Added, Yellow 6, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 52,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Cocoa Powder, Dark Chocolate (Sugar, Chocolate Liquor, Cocoa Butter), Natural \\u0026 Artificial Flavors, Color Added, Yellow 5 Lake, Blue 1 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Tapioca Dextrin, Salt.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 53,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Blueberry Juice From Puree, Contains 2% Or Less Of The Following: Natural \\u0026 Artificial Flavors, Color Added, Red 40, Red 40 Lake, Blue 1, Blue 2 Lake, Yellow 5 Lake, Citric Acid, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 54,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Lemon Puree, Lime Juice Concentrate, Peach Puree Concentrate, Pomegranate Juice Concentrate, Strawberry Puree, Coconut, Natural \\u0026 Artificial Flavors, Citric Acid, Sodium Lactate, Sodium Citrate, Color Added, Red 40 Lake, Red 40, Yellow 5 \\u0026 6, Yellow 5 \\u0026 6 Lake, Blue 1, Blue 1 Lake, Grape Skin Extract (Color), Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Tapioca Dextrin.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 55,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural \\u0026 Artificial Flavors, Citric Acid, Color Added, Yellow 5, Red 40, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 56,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Acacia Gum, Citric Acid, Sodium Lactate, Natural \\u0026 Artificial Flavor, Color Added, Yellow 5 \\u0026 6, Red 40, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Salt.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 57,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Orange Juice From Puree, Contains 2% Or Less Of The Following: Citric Acid, Natural And Artificial Flavors, Color Added, Yellow 6 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 58,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Apple Juice Concentrate, Citric Acid, Cocoa Powder, Natural \\u0026 Artificial Flavors, Color Added, Red 40 Lake, Yellow 5 \\u0026 6 Lake, Blue 1 \\u0026 2 Lake, Red 40, Vegetable And Fruit Juice (Color), Tapioca Dextrin, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Ground Cinnamon, Salt.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 59,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Strawberry Puree, Chocolate Liquor, Cocoa Butter, Cocoa Powder, Citric Acid, Ground Cinnamon, Tapioca Dextrin, Natural And Artificial Flavor, Color Added, Red 40 Lake, Yellow 5 \\u0026 6 Lake, Red 40, Blue 1 \\u0026 2 Lake, Blue 1, Yellow 5, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Salt.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 60,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Peach Juice From Puree Concentrate, Modified Food Starch, Contains 2% Or Less Of The Following: Citric Acid, Sodium Citrate, Natural And Artificial Flavor, Color Added, Yellow 5, Yellow 5 Lake, Red 40 Lake, Red 40, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 61,
                column: "Ingredients",
                value: "[\"Sugar, Glucose Syrup, Modified Cornstarch, Pear Juice Concentrate, Flavourings, Colours (E100, E171), Acidity Regulator (E330), Glazing Agents (E901, E903, E904), Vegetable Concentrate (Spirulina).\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 62,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Cranberry Puree, Raspberry Puree, Grape Juice Concentrate, Mango Juice Concentrate, Strawberry Juice Concentrate, Kiwi Juice Concentrate, Lemon Puree, Cherry Juice Concentrate, Cranberry Juice Concentrate, Natural Flavors, Citric Acid, Color Added, Grape Concentrate (Color), Turmeric (Color), Apple (Color), Hibiscus (Color), Black Currant (Color), Carrot (Color), Confectioner\\u0027S Glaze, Beeswax, Carnauba Wax.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 63,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Coconut, Citric Acid, Artificial Flavors, Color Added, Yellow 5, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 64,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Plum Juice From Concentrate, Contains 2% Or Less Of The Following: Natural And Artificial Flavors, Citric Acid, Sodium Citrate, Color Added, Red 40 Lake, Blue 1 \\u0026 2 Lake, Yellow 6 Lake, Red 40, Yellow 5, Blue 1, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 65,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Pomegranate Juice Concentrate, Natural \\u0026 Artificial Flavor, Citric Acid, Sodium Lactate, Sodium Citrate, Color Added, Red 40, Red 40 Lake, Blue 2 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 66,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Lemon Puree, Lime Juice Concentrate, Peach Puree Concentrate, Pomegranate Juice Concentrate, Strawberry Puree, Coconut, Natural \\u0026 Artificial Flavors, Citric Acid, Sodium Lactate, Sodium Citrate, Color Added, Red 40 Lake, Red 40, Yellow 5 \\u0026 6, Yellow 5 \\u0026 6 Lake, Blue 1, Blue 1 Lake, Grape Skin Extract (Color), Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Tapioca Dextrin.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 67,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Raspberry Juice From Puree, Contains 2% Or Less Of The Following: Citric Acid, Artificial Flavor, Color Added, Yellow 6, Red 40 Lake, Red 40, Yellow 5 \\u0026 6 Lake, Blue 2 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 68,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Apple Juice From Concentrate, Contains 2% Or Less Of The Following: Lactic Acid, Citric Acid, Fumaric Acid, Natural And Artificial Flavor, Color Added, Red 40, Yellow 6, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 69,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural \\u0026 Artificial Flavors, Citric Acid, Color Added, Red 40, Red 3, Blue 2 Lake, Red 40 Lake, Maltodextrin, Confectioner\\u0027S Glaze, Beeswax, Carnauba Wax.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 70,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural And Artificial Flavor, Color Added, Vegetable And Fruit Juice (Color), Yellow 5 \\u0026 6 Lake, Blue 2 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Salt.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 71,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Artificial Flavor, Color Added, Red 40 Lake, Yellow 5 Lake, Yellow 5, Red 40, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 72,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Cherry Juice From Concentrate, Contains 2% Or Less Of The Following: Citric Acid, Fumaric Acid, Sodium Lactate, Sodium Citrate, Artificial Flavor, Color Added, Red 40 Lake, Turmeric (Color), Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 73,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Citric Acid, Sodium Lactate, Tartaric Acid, Grape Juice Concentrate, Gum Arabic, Natural \\u0026 Artificial Flavor, Vegetable \\u0026 Fruit Juice (Color), Color Added, Red 40, Blue 1, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 74,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Lemon Juice From Puree, Contains 2% Or Less Of The Following: Citric Acid, Fumaric Acid, Sodium Lactate, Sodium Citrate, Natural Flavor, Color Added, Yellow 5, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 75,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Apple Juice Concentrate, Grape Juice Concentrate, Lemon Puree, Cherry Juice Concentrate, Orange Puree, Citric Acid, Fumaric Acid, Sodium Citrate, Sodium Lactate, Natural And Artificial Flavors, Color Added, Red 40 Lake, Blue 1 \\u0026 2, Blue 1 \\u0026 2 Lake, Yellow 5 \\u0026 6 Lake, Yellow 5, Turmeric (Color), Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 76,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Pomegranate Juice Concentrate, Peach Puree Concentrate, Banana Puree, Pear Juice Concentrate, Natural And Artificial Flavors, Citric Acid, Sodium Lactate, Sodium Citrate, Color Added, Red 40, Yellow 5 \\u0026 6, Yellow 5 \\u0026 6 Lake, Blue 1 \\u0026 2 Lake, Red 40 Lake, Blue 1, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Salt, Coffee, Tapioca Dextrin.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 77,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Strawberry Juice From Puree, Contains 2% Or Less Of The Following: Citric Acid, Natural And Artificial Flavors, Color Added, Red 40 Lake, Red 40, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 78,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Strawberry Juice From Puree, Contains 2% Or Less Of The Following: Citric Acid, Natural And Artificial Flavors, Color Added, Red 40 Lake, Yellow 6, Red 40, Yellow 5 \\u0026 6 Lake, Tapioca Dextrin, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 79,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Apple Juice Concentrate, Citric Acid, Cocoa Powder, Natural \\u0026 Artificial Flavors, Color Added, Red 40 Lake, Yellow 5 \\u0026 6 Lake, Blue 1 \\u0026 2 Lake, Red 40, Vegetable And Fruit Juice (Color), Tapioca Dextrin, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Ground Cinnamon, Salt.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 80,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Strawberry Juice From Concentrate, Contains 2% Or Less Of The Following: Citric Acid, Artificial Flavors, Color Added, Red 40 Lake, Yellow 6, Red 40, Blue 2 Lake, Yellow 5 \\u0026 6 Lake, Tapioca Dextrin, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 81,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Citric Acid, Confectioner\\u0027S Glaze, Beeswax, Carnauba Wax, Natural And Artificial Flavors, Salt, Color Added, Red 40, Yellow 6 Lake.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 82,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Lemon Juice From Puree, 2% Or Less Of The Following: Sodium Lactate, Citric Acid, Natural Flavor, Color Added, Yellow 5, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 83,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Lime Juice From Concentrate, 2% Or Less Of The Following: Sodium Lactate, Citric Acid, Natural Flavor, Color Added, Yellow 5, Blue 1, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 84,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Orange Juice From Orange Puree, 2% Or Less Of The Following: Citric Acid, Sodium Lactate, Natural Flavor, Color Added, Yellow 6, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 85,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Grapefruit Juice From Concentrate, 2% Or Less Of The Following: Citric Acid, Sodium Lactate, Natural Flavor, Color Added, Yellow 5 \\u0026 6 Lake, Red 40, Blue 2 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 86,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Tangerine Juice From Concentrate, 2% Or Less Of The Following: Citric Acid, Sodium Lactate, Natural Flavor, Color Added, Yellow 6, Red 40, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 87,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Confectioner\\u0027S Glaze, Beeswax, Carnauba Wax, Natural And Artificial Flavors, Salt, Color Added, Red 40, Blue 1Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Confectioner\\u0027S Glaze, Beeswax, Carnauba Wax, Natural And Artificial Flavors, Salt, Color Added, Red 40, Blue 1.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 88,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Confectioner\\u0027S Glaze, Beeswax, Carnauba Wax, Natural And Artificial Flavors, Salt, Color Added, Yellow 6 Lake, Yellow 5.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 89,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Watermelon Juice From Concentrate, Contains 2% Or Less Of The Following: Artificial Flavor, Citric Acid, Color Added, Red 40 Lake, Yellow 5, Blue 1, Red 40, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 90,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Watermelon Juice From Concentrate, Contains 2% Or Less Of The Following: Artificial Flavor, Citric Acid, Color Added, Red 40 Lake, Yellow 5, Blue 1, Red 40, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 91,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural \\u0026 Artificial Flavor, Color Added, Red 40 Lake, Yellow 5 Lake, Red 40, Blue 1 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 92,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Cherry Juice From Concentrate, Contains 2% Or Less Of The Following: Citric Acid, Artificial Flavor, Color Added, Red 40, Red 40 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 93,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Watermelon Juice From Concentrate, Contains 2% Or Less Of The Following: Artificial Flavor, Citric Acid, Color Added, Red 40 Lake, Yellow 5, Blue 1, Red 40, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 94,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Blackberry Juice From Puree, Contains 2% Or Less Of The Following: Citric Acid, Natural \\u0026 Artificial Flavor, Sodium Lactate, Sodium Citrate, Color Added, Blue 2 Lake, Red 40 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 95,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Lemon Juice From Lemon Puree, Contains 2% Or Less Of The Following: Citric Acid, Natural And Artificial Flavors, Color Added, Yellow 5, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 96,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Lime Juice From Concentrate, Lemon Juice From Lemon Puree, Contains 2% Or Less Of The Following: Citric Acid, Sodium Lactate, Natural Flavors, Color Added, Yellow 5, Blue 1, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 97,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Lemon Puree, Citric Acid, Natural \\u0026 Artificial Flavor, Color Added, Vegetable And Fruit Juice (Color), Yellow 5 \\u0026 6 Lake, Blue 2 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Salt.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 98,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural And Artificial Flavors, Color Added, Blue 2 Lake, Yellow 6 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 99,
                columns: new[] { "ImageUrl", "Ingredients" },
                values: new object[] { "", "[\"Sugar, Glucose Syrup, Modified Cornstarch, Passion Fruit Juice Concentrate, Flavourings, Acidity Regulator (E330), Colours (E100, E171), Glazing Agents (E901, E903, E904), Fruit And Vegetable Concentrates (Purple Carrot, Carrot, Black Currant).\"]" });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 100,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Citric Acid, Natural And Artificial Flavor, Color Added, Sodium Citrate, Blue 1 Lake, Blue 1, Confectioner\\u0027S Glaze, Beeswax, Carnauba Wax.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 101,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural \\u0026 Artificial Flavors, Tapioca Dextrin, Color Added, Yellow 5 \\u0026 6 Lake, Red 40 Lake, Red 40, Blue 1 \\u0026 2 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Salt.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 102,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural \\u0026 Artificial Flavors, Tapioca Dextrin, Color Added, Yellow 5 \\u0026 6 Lake, Red 40 Lake, Red 40, Blue 1 \\u0026 2 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Salt.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 103,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Apple Juice From Concentrate, Contains 2% Or Less Of The Following: Citric Acid, Fumaric Acid, Sodium Lactate, Sodium Citrate, Artificial Flavor, Color Added, Yellow 5, Yellow 5 Lake, Blue 1, Blue 1 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 104,
                column: "Ingredients",
                value: "[\"\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 105,
                column: "Ingredients",
                value: "[\"\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 106,
                column: "Ingredients",
                value: "[\"\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 107,
                column: "Ingredients",
                value: "[\"\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 108,
                column: "Ingredients",
                value: "[\"\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 109,
                column: "Ingredients",
                value: "[\"\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 110,
                column: "Ingredients",
                value: "[\"\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 111,
                column: "Ingredients",
                value: "[\"\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 112,
                column: "Ingredients",
                value: "[\"\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 113,
                column: "Ingredients",
                value: "[\"\"]");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 114,
                column: "Ingredients",
                value: "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Citric Acid, Natural \\u0026 Artificial Flavor, Color Added, Blue 1, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]");
        }
    }
}
