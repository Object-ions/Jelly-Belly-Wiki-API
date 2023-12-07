using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JellyBellyWikiApi.Migrations
{
    public partial class TempRemoveSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 1);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Beans",
                columns: new[] { "BeanId", "BackgroundColor", "ColorGroup", "Description", "FlavorName", "GlutenFree", "GroupNameSerialized", "ImageUrl", "Ingredients", "Kosher", "Seasonal", "SugarFree" },
                values: new object[,]
                {
                    { 1, "#E1DFE1", "White", "Experience the delicious taste of buttered popcorn in a bite-sized jelly bean.", "Buttered Popcorn", false, "Jelly Belly Official Flavors, Most Popular Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/75fea694-ed38-4e84-a86e-182e31ea5a7b", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% or less of the following: Natural and Artificial Flavors, Color Added, Vegetable and Fruit Juice (Color), Beeswax, Carnauba Wax, Confectioner\\u0027s Glaze.\"]", true, false, false },
                    { 2, "#792E27", "Brown", "Say 'cheers' with the flavor of this all-American classic drink.", "A&W® Root Beer", false, "Jelly Belly Official Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/63b9e71d-9866-4044-9af7-7a64a52b0e0e", "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% or less of the following: Natural and Artificial Flavors, Color Added, Vegetable and Fruit Juice (Color), Beeswax, Carnauba Wax, Confectioner\\u0027s Glaze.\"]", false, false, false },
                    { 3, "#0A9882", "Blue", "A delicious medley of raspberry, blueberry and strawberry flavors.", "Berry Blue", false, "Jelly Belly Official Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/4e65d579-9595-4620-b6c4-a9606df99f3d", "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% or less of the following: Citric Acid. Natural and Artificial Flavor. Color Added. Blue 1, Beeswax. Carnauba Wax. Confectioner\\u0027s Glaze.\"]", false, false, false },
                    { 4, "#3A7195", "Blue", "Enjoy the taste of fresh-picked blueberries. Deliciously flavored with real blueberry puree.", "Blueberry", false, "Jelly Belly Official Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/a8f085b5-b4ff-4aca-8650-43ad54c80fe4", "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Blueberry Juice From Puree\",\"Contains 2% or less of the following: Citric Acid. Natural and Artificial Flavor. Color Added. Blue 1 Lake. Beeswax. Carnauba Wax. Confectioner\\u0027s Glaze.\"]", false, false, false },
                    { 5, "#E3ACBD", "Pink", " ", "Bubble Gum", false, "Jelly Belly Official Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/51474130-73e9-40b7-a8ba-c9eac7be7de4", "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% or less of the following: Artificial Flavor. Color Added. Red 40 Lake. Red 40. Yellow 5 Lake. Beeswax. Carnauba Wax. Confectioner\\u0027s Glaze.\"]", false, false, false }
                });
        }
    }
}
