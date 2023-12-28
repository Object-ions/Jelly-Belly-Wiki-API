using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JellyBellyWikiApi.Migrations
{
    public partial class UpdateTagSterialized : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TagSerialized",
                table: "Combinations",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 1,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Very Cherry\",\"\\u002B ,Very Cherry\",\"\\u002B ,Coconut\",\"\\u002B ,Buttered Popcorn\"]", "Very Cherry, + ,Very Cherry, + ,Coconut, + ,Buttered Popcorn" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 2,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Green Apple\",\"\\u002B ,Green Apple\",\"\\u002B ,Cinnamon\"]", "Green Apple, + ,Green Apple, + ,Cinnamon" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 3,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Top Banana\",\"\\u002B ,Top Banana\",\"\\u002B ,Buttered Popcorn\"]", "Top Banana, + ,Top Banana, + ,Buttered Popcorn" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 4,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Top Banana\",\"\\u002B ,A\\u0026W\\u00AE Cream Soda\",\"\\u002B ,Coconut\"]", "Top Banana, + ,A&W® Cream Soda, + ,Coconut" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 5,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Top Banana\",\"\\u002B ,Chocolate Pudding\",\"\\u002B ,Crushed Pineapple\",\"\\u002B ,Strawberry Jam\",\"\\u002B ,Very Cherry\",\"\\u002B French Vanilla\"]", "Top Banana, + ,Chocolate Pudding, + ,Crushed Pineapple, + ,Strawberry Jam, + ,Very Cherry, + French Vanilla" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 6,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Top Banana\",\"\\u002B ,Top Banana\",\"\\u002B ,Top Banana\",\"\\u002B ,Buttered Popcorn\",\"\\u002B ,French Vanilla\"]", "Top Banana, + ,Top Banana, + ,Top Banana, + ,Buttered Popcorn, + ,French Vanilla" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 7,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Berry Blu\",\"\\u002B ,SUNKIST\\u00AE Lemon\"]", "Berry Blu, + ,SUNKIST® Lemon" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 8,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Blueberry\",\"\\u002B ,Strawberry Cheesecake\",\"\\u002B ,French Vanilla\",\"\\u002B ,A\\u0026W\\u00AE Cream Soda\"]", "Blueberry, + ,Strawberry Cheesecake, + ,French Vanilla, + ,A&W® Cream Soda" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 9,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Blueberry\",\"\\u002B ,Blueberry\",\"\\u002B ,Buttered Popcorn\"]", "Blueberry, + ,Blueberry, + ,Buttered Popcorn" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 10,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Blueberry\",\"\\u002B ,Caramel Corn\",\"\\u002B ,French Vanilla\",\"\\u002B ,Toasted Marshmallow\",\"\\u002B ,Toasted Marshmallow\"]", "Blueberry, + ,Caramel Corn, + ,French Vanilla, + ,Toasted Marshmallow, + ,Toasted Marshmallow" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 11,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Cappuccino\",\"\\u002B ,Cappuccino\",\"\\u002B ,Chocolate Pudding\",\"\\u002B ,French Vanilla\"]", "Cappuccino, + ,Cappuccino, + ,Chocolate Pudding, + ,French Vanilla" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 12,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Green Apple\",\"\\u002B ,Green Apple\",\"\\u002B ,Cinnamon\"]", "Green Apple, + ,Green Apple, + ,Cinnamon" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 13,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Very Cherry\",\"\\u002B ,Very Cherry\",\"\\u002B ,Dr Pepper\\u00AE\"]", "Very Cherry, + ,Very Cherry, + ,Dr Pepper®" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 14,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Very Cherry\",\"\\u002B ,Very Cherry\",\"\\u002B ,Coconut\",\"\\u002B ,Buttered Popcorn\"]", "Very Cherry, + ,Very Cherry, + ,Coconut, + ,Buttered Popcorn" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 15,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Very Cherry\",\"\\u002B ,Very Cherry\",\"\\u002B ,Chocolate Pudding\"]", "Very Cherry, + ,Very Cherry, + ,Chocolate Pudding" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 16,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Top Banana\",\"\\u002B ,Chocolate Pudding\"]", "Top Banana, + ,Chocolate Pudding" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 17,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Strawberry Daiquiri\",\"\\u002B ,Strawberry Daiquiri\",\"\\u002B ,Chocolate Pudding\"]", "Strawberry Daiquiri, + ,Strawberry Daiquiri, + ,Chocolate Pudding" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 18,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Chocolate Pudding\",\"\\u002B ,Coconut\"]", "Chocolate Pudding, + ,Coconut" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 19,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Chocolate Pudding\",\"\\u002B ,Buttered Popcorn\"]", "Chocolate Pudding, + ,Buttered Popcorn" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 20,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Cinnamon\",\"\\u002B ,Bubble Gum\"]", "Cinnamon, + ,Bubble Gum" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 21,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Buttered Popcorn\",\"\\u002B ,Buttered Popcorn\",\"\\u002B ,Sizzling Cinnamon\"]", "Buttered Popcorn, + ,Buttered Popcorn, + ,Sizzling Cinnamon" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 22,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Cappuccino\",\"\\u002B ,Buttered Popcorn\",\"\\u002B ,French Vanilla\"]", "Cappuccino, + ,Buttered Popcorn, + ,French Vanilla" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 23,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Lime\",\"\\u002B ,Cinnamon\"]", "Lime, + ,Cinnamon" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 24,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Island Punch\",\"\\u002B ,SUNKIST\\u00AE Orange\",\"\\u002B ,Very Cherry\"]", "Island Punch, + ,SUNKIST® Orange, + ,Very Cherry" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 25,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Kiwi\",\"\\u002B ,Strawberry Jam\",\"\\u002B ,Blueberry\",\"\\u002B ,Cantaloupe\"]", "Kiwi, + ,Strawberry Jam, + ,Blueberry, + ,Cantaloupe" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 26,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Draft Beer\",\"\\u002B ,Draft Beer\",\"\\u002B ,Ginger Ale\"]", "Draft Beer, + ,Draft Beer, + ,Ginger Ale" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 27,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Green Apple\",\"\\u002B ,Bubble Gum\",\"\\u002B ,Bubble Gum\"]", "Green Apple, + ,Bubble Gum, + ,Bubble Gum" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 28,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Red Apple\",\"\\u002B ,Red Apple\",\"\\u002B ,Cinnamon\"]", "Red Apple, + ,Red Apple, + ,Cinnamon" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 29,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Toasted Marshmallow\",\"\\u002B ,Chocolate Pudding\"]", "Toasted Marshmallow, + ,Chocolate Pudding" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 30,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"French Vanilla\",\"\\u002B ,French Vanilla\",\"\\u002B ,Chocolate Pudding\",\"\\u002B ,A\\u0026W\\u00AE Cream Soda\",\"\\u002B ,Very Cherry\"]", "French Vanilla, + ,French Vanilla, + ,Chocolate Pudding, + ,A&W® Cream Soda, + ,Very Cherry" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 31,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"French Vanilla\",\"\\u002B ,Cappuccino\"]", "French Vanilla, + ,Cappuccino" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 32,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Licorice\",\"\\u002B ,Buttered Popcorn\",\"\\u002B ,Buttered Popcorn\"]", "Licorice, + ,Buttered Popcorn, + ,Buttered Popcorn" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 33,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Lemon Lime\",\"\\u002B ,Toasted Marshmallow\"]", "Lemon Lime, + ,Toasted Marshmallow" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 34,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Lemon\",\"\\u002B ,Lemon\",\"\\u002B ,Vanilla\",\"\\u002B ,Coconut\"]", "Lemon, + ,Lemon, + ,Vanilla, + ,Coconut" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 35,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Mango\",\"\\u002B ,Crushed Pineapple\",\"\\u002B ,Chili Mango\"]", "Mango, + ,Crushed Pineapple, + ,Chili Mango" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 36,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Mango\",\"\\u002B ,Lemon Lime\",\"\\u002B ,Chili Mango\"]", "Mango, + ,Lemon Lime, + ,Chili Mango" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 37,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Draft Beer\",\"\\u002B ,Draft Beer\",\"\\u002B ,Lemon Lime\",\"\\u002B ,Tabasco\\u00AE\"]", "Draft Beer, + ,Draft Beer, + ,Lemon Lime, + ,Tabasco®" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 38,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Chocolate Pudding\",\"\\u002B ,Chocolate Pudding\",\"\\u002B ,Very Cherry\"]", "Chocolate Pudding, + ,Chocolate Pudding, + ,Very Cherry" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 39,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Orange Sherbet\",\"\\u002B ,Orange Sherbet\",\"\\u002B ,A\\u0026W\\u00AE Cream Soda\"]", "Orange Sherbet, + ,Orange Sherbet, + ,A&W® Cream Soda" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 40,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Peach\",\"\\u002B ,A\\u0026W\\u00AE Cream Soda\"]", "Peach, + ,A&W® Cream Soda" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 41,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Cotton Candy\",\"\\u002B ,SUNKIST\\u00AE Lemon\"]", "Cotton Candy, + ,SUNKIST® Lemon" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 42,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Plum\",\"\\u002B ,Plum\",\"\\u002B ,French Vanilla\"]", "Plum, + ,Plum, + ,French Vanilla" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 43,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Plum\",\"\\u002B ,Plum\",\"\\u002B ,SUNKIST\\u00AE Lemon\",\"\\u002B ,Green Apple\"]", "Plum, + ,Plum, + ,SUNKIST® Lemon, + ,Green Apple" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 44,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Plum\",\"\\u002B ,Plum\",\"\\u002B ,Cinnamon\",\"\\u002B ,A\\u0026W\\u00AE Cream Soda\"]", "Plum, + ,Plum, + ,Cinnamon, + ,A&W® Cream Soda" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 45,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Pumpkin Pie\",\"\\u002B ,Pumpkin Pie\",\"\\u002B ,French Vanilla\",\"\\u002B ,Cappuccino\"]", "Pumpkin Pie, + ,Pumpkin Pie, + ,French Vanilla, + ,Cappuccino" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 46,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Raspberry\",\"\\u002B ,Lemon Lime\",\"\\u002B ,Orange Sherbet\"]", "Raspberry, + ,Lemon Lime, + ,Orange Sherbet" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 47,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"French Vanilla\",\"\\u002B ,Raspberry\",\"\\u002B ,Toasted Marshmallow\"]", "French Vanilla, + ,Raspberry, + ,Toasted Marshmallow" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 48,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"A\\u0026W\\u00AE Root Beer\",\"\\u002B ,A\\u0026W\\u00AE Root Beer\",\"\\u002B ,A\\u0026W\\u00AE Cream Soda\"]", "A&W® Root Beer, + ,A&W® Root Beer, + ,A&W® Cream Soda" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 49,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Caramel Corn\",\"\\u002B ,Toasted Marshmallow\",\"\\u002B ,Toasted Marshmallow\",\"\\u002B ,Chocolate Pudding\"]", "Caramel Corn, + ,Toasted Marshmallow, + ,Toasted Marshmallow, + ,Chocolate Pudding" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 50,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Kiwi\",\"\\u002B ,Strawberry Daiquiri\"]", "Kiwi, + ,Strawberry Daiquiri" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 51,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Strawberry Jam\",\"\\u002B ,French Vanilla\"]", "Strawberry Jam, + ,French Vanilla" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 52,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Top Banana\",\"\\u002B ,Top Banana\",\"\\u002B ,Cinnamon\",\"\\u002B ,Buttered Popcorn\"]", "Top Banana, + ,Top Banana, + ,Cinnamon, + ,Buttered Popcorn" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 53,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Margarita\",\"\\u002B ,Margarita\",\"\\u002B ,SUNKIST\\u00AE Orange\",\"\\u002B ,Very Cherry\"]", "Margarita, + ,Margarita, + ,SUNKIST® Orange, + ,Very Cherry" });

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 54,
                columns: new[] { "Tag", "TagSerialized" },
                values: new object[] { "[\"Cappuccino\",\"\\u002B ,Cappuccino\",\"\\u002B ,A\\u0026W\\u00AE Cream Soda\",\"\\u002B ,Chocolate Pudding\"]", "Cappuccino, + ,Cappuccino, + ,A&W® Cream Soda, + ,Chocolate Pudding" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TagSerialized",
                table: "Combinations");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 1,
                column: "Tag",
                value: "[\"Very Cherry, \\u002B ,Very Cherry, \\u002B ,Coconut, \\u002B ,Buttered Popcorn\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 2,
                column: "Tag",
                value: "[\"Green Apple, \\u002B ,Green Apple, \\u002B ,Cinnamon\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 3,
                column: "Tag",
                value: "[\"Top Banana, \\u002B ,Top Banana, \\u002B ,Buttered Popcorn\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 4,
                column: "Tag",
                value: "[\"Top Banana, \\u002B ,A\\u0026W\\u00AE Cream Soda, \\u002B ,Coconut\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 5,
                column: "Tag",
                value: "[\"Top Banana, \\u002B ,Chocolate Pudding, \\u002B ,Crushed Pineapple, \\u002B ,Strawberry Jam, \\u002B ,Very Cherry, \\u002B ,French Vanilla\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 6,
                column: "Tag",
                value: "[\"Top Banana, \\u002B ,Top Banana, \\u002B ,Top Banana, \\u002B ,Buttered Popcorn, \\u002B ,French Vanilla\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 7,
                column: "Tag",
                value: "[\"Berry Blu, \\u002B ,SUNKIST\\u00AE Lemon\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 8,
                column: "Tag",
                value: "[\"Blueberry, \\u002B ,Strawberry Cheesecake, \\u002B ,French Vanilla, \\u002B ,A\\u0026W\\u00AE Cream Soda\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 9,
                column: "Tag",
                value: "[\"Blueberry, \\u002B ,Blueberry, \\u002B ,Buttered Popcorn\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 10,
                column: "Tag",
                value: "[\"Blueberry, \\u002B ,Caramel Corn, \\u002B ,French Vanilla, \\u002B ,Toasted Marshmallow, \\u002B ,Toasted Marshmallow\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 11,
                column: "Tag",
                value: "[\"Cappuccino, \\u002B ,Cappuccino, \\u002B ,Chocolate Pudding, \\u002B ,French Vanilla\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 12,
                column: "Tag",
                value: "[\"Green Apple, \\u002B ,Green Apple, \\u002B ,Cinnamon\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 13,
                column: "Tag",
                value: "[\"Very Cherry, \\u002B ,Very Cherry, \\u002B ,Dr Pepper\\u00AE\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 14,
                column: "Tag",
                value: "[\"Very Cherry, \\u002B ,Very Cherry, \\u002B ,Coconut, \\u002B ,Buttered Popcorn\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 15,
                column: "Tag",
                value: "[\"Very Cherry, \\u002B ,Very Cherry, \\u002B ,Chocolate Pudding\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 16,
                column: "Tag",
                value: "[\"Top Banana, \\u002B ,Chocolate Pudding\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 17,
                column: "Tag",
                value: "[\"Strawberry Daiquiri, \\u002B ,Strawberry Daiquiri, \\u002B ,Chocolate Pudding\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 18,
                column: "Tag",
                value: "[\"Chocolate Pudding, \\u002B ,Coconut\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 19,
                column: "Tag",
                value: "[\"Chocolate Pudding, \\u002B ,Buttered Popcorn\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 20,
                column: "Tag",
                value: "[\"Cinnamon, \\u002B ,Bubble Gum\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 21,
                column: "Tag",
                value: "[\"Buttered Popcorn, \\u002B ,Buttered Popcorn, \\u002B ,Sizzling Cinnamon\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 22,
                column: "Tag",
                value: "[\"Cappuccino, \\u002B ,Buttered Popcorn, \\u002B ,French Vanilla\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 23,
                column: "Tag",
                value: "[\"Lime, \\u002B ,Cinnamon\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 24,
                column: "Tag",
                value: "[\"Island Punch, \\u002B ,SUNKIST\\u00AE Orange, \\u002B ,Very Cherry\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 25,
                column: "Tag",
                value: "[\"Kiwi, \\u002B ,Strawberry Jam, \\u002B ,Blueberry, \\u002B ,Cantaloupe\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 26,
                column: "Tag",
                value: "[\"Draft Beer, \\u002B ,Draft Beer, \\u002B ,Ginger Ale\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 27,
                column: "Tag",
                value: "[\"Green Apple, \\u002B ,Bubble Gum, \\u002B ,Bubble Gum\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 28,
                column: "Tag",
                value: "[\"Red Apple, \\u002B ,Red Apple, \\u002B ,Cinnamon\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 29,
                column: "Tag",
                value: "[\"Toasted Marshmallow, \\u002B ,Chocolate Pudding\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 30,
                column: "Tag",
                value: "[\"French Vanilla, \\u002B ,French Vanilla, \\u002B ,Chocolate Pudding, \\u002B ,A\\u0026W\\u00AE Cream Soda, \\u002B ,Very Cherry\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 31,
                column: "Tag",
                value: "[\"French Vanilla, \\u002B ,Cappuccino\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 32,
                column: "Tag",
                value: "[\"Licorice, \\u002B ,Buttered Popcorn, \\u002B ,Buttered Popcorn\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 33,
                column: "Tag",
                value: "[\"Lemon Lime, \\u002B ,Toasted Marshmallow\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 34,
                column: "Tag",
                value: "[\"Lemon, \\u002B ,Lemon, \\u002B ,Vanilla, \\u002B ,Coconut\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 35,
                column: "Tag",
                value: "[\"Mango, \\u002B ,Crushed Pineapple, \\u002B ,Chili Mango\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 36,
                column: "Tag",
                value: "[\"Mango, \\u002B ,Lemon Lime, \\u002B ,Chili Mango\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 37,
                column: "Tag",
                value: "[\"Draft Beer, \\u002B ,Draft Beer, \\u002B ,Lemon Lime, \\u002B ,Tabasco\\u00AE\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 38,
                column: "Tag",
                value: "[\"Chocolate Pudding, \\u002B ,Chocolate Pudding, \\u002B ,Very Cherry\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 39,
                column: "Tag",
                value: "[\"Orange Sherbet, \\u002B ,Orange Sherbet, \\u002B ,A\\u0026W\\u00AE Cream Soda\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 40,
                column: "Tag",
                value: "[\"Peach, \\u002B ,A\\u0026W\\u00AE Cream Soda\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 41,
                column: "Tag",
                value: "[\"Cotton Candy, \\u002B ,SUNKIST\\u00AE Lemon\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 42,
                column: "Tag",
                value: "[\"Plum, \\u002B ,Plum, \\u002B ,French Vanilla\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 43,
                column: "Tag",
                value: "[\"Plum, \\u002B ,Plum, \\u002B ,SUNKIST\\u00AE Lemon, \\u002B ,Green Apple\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 44,
                column: "Tag",
                value: "[\"Plum, \\u002B ,Plum, \\u002B ,Cinnamon, \\u002B ,A\\u0026W\\u00AE Cream Soda\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 45,
                column: "Tag",
                value: "[\"Pumpkin Pie, \\u002B ,Pumpkin Pie, \\u002B ,French Vanilla, \\u002B ,Cappuccino\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 46,
                column: "Tag",
                value: "[\"Raspberry, \\u002B ,Lemon Lime, \\u002B ,Orange Sherbet\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 47,
                column: "Tag",
                value: "[\"French Vanilla, \\u002B ,Raspberry, \\u002B ,Toasted Marshmallow\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 48,
                column: "Tag",
                value: "[\"A\\u0026W\\u00AE Root Beer, \\u002B ,A\\u0026W\\u00AE Root Beer, \\u002B ,A\\u0026W\\u00AE Cream Soda\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 49,
                column: "Tag",
                value: "[\"Caramel Corn, \\u002B ,Toasted Marshmallow, \\u002B ,Toasted Marshmallow, \\u002B ,Chocolate Pudding\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 50,
                column: "Tag",
                value: "[\"Kiwi, \\u002B ,Strawberry Daiquiri\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 51,
                column: "Tag",
                value: "[\"Strawberry Jam, \\u002B ,French Vanilla\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 52,
                column: "Tag",
                value: "[\"Top Banana, \\u002B ,Top Banana, \\u002B ,Cinnamon, \\u002B ,Buttered Popcorn\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 53,
                column: "Tag",
                value: "[\"Margarita, \\u002B ,Margarita, \\u002B ,SUNKIST\\u00AE Orange, \\u002B ,Very Cherry\"]");

            migrationBuilder.UpdateData(
                table: "Combinations",
                keyColumn: "CombinationId",
                keyValue: 54,
                column: "Tag",
                value: "[\"Cappuccino, \\u002B ,Cappuccino, \\u002B ,A\\u0026W\\u00AE Cream Soda, \\u002B ,Chocolate Pudding\"]");
        }
    }
}
