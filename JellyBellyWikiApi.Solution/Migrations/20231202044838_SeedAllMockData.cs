using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JellyBellyWikiApi.Migrations
{
    public partial class SeedAllMockData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Beans",
                columns: new[] { "BeanId", "BackgroundColor", "ColorGroup", "Description", "FlavorName", "GlutenFree", "GroupName", "ImageUrl", "Ingredients", "Kosher", "Seasonal", "Sku", "SugarFree" },
                values: new object[,]
                {
                    { 2, "#792E27", "Brown", "Say 'cheers' with the flavor of this all-American classic drink.", "A&W® Root Beer", false, "Jelly Belly Official Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/63b9e71d-9866-4044-9af7-7a64a52b0e0e", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% or less of the following: Natural and Artificial Flavors, Color Added, Vegetable and Fruit Juice (Color), Beeswax, Carnauba Wax, Confectioner's Glaze.", false, false, 1002, false },
                    { 3, "#0A9882", "Blue", "A delicious medley of raspberry, blueberry and strawberry flavors.", "Berry Blue", false, "Jelly Belly Official Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/4e65d579-9595-4620-b6c4-a9606df99f3d", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% or less of the following: Citric Acid, Natural and Artificial Flavor, Color Added, Blue 1, Beeswax, Carnauba Wax, Confectioner's Glaze.", false, false, 1003, false },
                    { 4, "#3A7195", "Blue", "Enjoy the taste of fresh-picked blueberries. Deliciously flavored with real blueberry puree.", "Blueberry", false, "Jelly Belly Official Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/a8f085b5-b4ff-4aca-8650-43ad54c80fe4", "Sugar, Corn Syrup, Modified Food Starch, Blueberry Juice From Puree, Contains 2% or less of the following: Citric Acid, Natural and Artificial Flavor, Color Added, Blue 1 Lake, Beeswax, Carnauba Wax, Confectioner's Glaze.", false, false, 1004, false },
                    { 5, "#E3ACBD", "Pink", " ", "Bubble Gum", false, "Jelly Belly Official Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/51474130-73e9-40b7-a8ba-c9eac7be7de4", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% or less of the following: Artificial Flavor, Color Added, Red 40 Lake, Red 40, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner's Glaze.", false, false, 1005, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 5);
        }
    }
}
