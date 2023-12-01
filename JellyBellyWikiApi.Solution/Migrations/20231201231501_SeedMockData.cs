using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JellyBellyWikiApi.Migrations
{
    public partial class SeedMockData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Beans",
                columns: new[] { "BeanId", "BackgroundColor", "ColorGroup", "Description", "FlavorName", "GlutenFree", "GroupName", "ImageUrl", "Ingredients", "Kosher", "Mixes", "Seasonal", "Sku", "SugarFree" },
                values: new object[] { 1, "#E1DFE1", "White", "Experience the delicious taste of buttered popcorn in a bite-sized jelly bean.", "Buttered Popcorn", false, "Jelly Belly Official Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/75fea694-ed38-4e84-a86e-182e31ea5a7b", "Sugar, Corn Syrup, Modified Food Starch, Contains 2% or less of the following: Natural and Artificial Flavors, Color Added, Beeswax, Carnauba Wax, Confectioner's Glaze.", true, "", false, 1001, false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 1);
        }
    }
}
