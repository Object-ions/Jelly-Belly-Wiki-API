using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JellyBellyWikiApi.Migrations
{
    public partial class UpdateModelsAndMockData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sku",
                table: "Beans");

            migrationBuilder.RenameColumn(
                name: "GroupName",
                table: "Beans",
                newName: "GroupNameSerialized");

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 1,
                column: "GroupNameSerialized",
                value: "Jelly Belly Official Flavors, Most Popular Flavors");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GroupNameSerialized",
                table: "Beans",
                newName: "GroupName");

            migrationBuilder.AddColumn<int>(
                name: "Sku",
                table: "Beans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 1,
                columns: new[] { "GroupName", "Sku" },
                values: new object[] { "Jelly Belly Official Flavors", 1001 });

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 2,
                column: "Sku",
                value: 1002);

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 3,
                column: "Sku",
                value: 1003);

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 4,
                column: "Sku",
                value: 1004);

            migrationBuilder.UpdateData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 5,
                column: "Sku",
                value: 1005);
        }
    }
}
