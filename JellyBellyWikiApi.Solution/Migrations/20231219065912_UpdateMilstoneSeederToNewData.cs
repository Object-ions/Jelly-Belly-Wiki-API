using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JellyBellyWikiApi.Migrations
{
    public partial class UpdateMilstoneSeederToNewData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MileStones",
                keyColumn: "MileStoneId",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "MileStones",
                keyColumn: "MileStoneId",
                keyValue: 1,
                column: "Description",
                value: "At age 24, Gustav Goelitz opens a candy business in Belleville, Illinois, and sets the family on its sweet destiny.");

            migrationBuilder.UpdateData(
                table: "MileStones",
                keyColumn: "MileStoneId",
                keyValue: 2,
                columns: new[] { "Description", "Year" },
                values: new object[] { "Gustav's sons continue the family candy making tradition.", 1894 });

            migrationBuilder.UpdateData(
                table: "MileStones",
                keyColumn: "MileStoneId",
                keyValue: 3,
                columns: new[] { "Description", "Year" },
                values: new object[] { "The second generation of the Goelitz candy-making family specializes in a new type of candy, mellocremes (also called butter creams), which include candy corn.", 1898 });

            migrationBuilder.UpdateData(
                table: "MileStones",
                keyColumn: "MileStoneId",
                keyValue: 4,
                columns: new[] { "Description", "Year" },
                values: new object[] { "In the midst of sugar rationing during World War II, which limited candy production, the company introduces Mint Wafers.", 1940 });

            migrationBuilder.UpdateData(
                table: "MileStones",
                keyColumn: "MileStoneId",
                keyValue: 5,
                columns: new[] { "Description", "Year" },
                values: new object[] { "The third- and fourth-generation descendants of Gustav Goelitz cook candies such as tangerine slices, spice drops, and jelly beans.", 1960 });

            migrationBuilder.UpdateData(
                table: "MileStones",
                keyColumn: "MileStoneId",
                keyValue: 6,
                columns: new[] { "Description", "Year" },
                values: new object[] { "A flavor breakthrough is made when the Goelitz Mini Jelly Beans are infused with flavor in the center as well as the shell.", 1965 });

            migrationBuilder.UpdateData(
                table: "MileStones",
                keyColumn: "MileStoneId",
                keyValue: 8,
                columns: new[] { "Description", "Year" },
                values: new object[] { "Chocolate Dutch Mints® debut. A creamy mint center is covered in dark chocolate and finished with a crisp, candy shell. It's a classic now and still one of the most popular confections we make.", 1972 });

            migrationBuilder.UpdateData(
                table: "MileStones",
                keyColumn: "MileStoneId",
                keyValue: 9,
                columns: new[] { "Description", "Year" },
                values: new object[] { "Building upon the flavor innovation of the Goelitz Mini Jelly Beans, the first eight flavors of Jelly Belly jelly beans, Root Beer, Green Apple, Licorice, Cream Soda, Lemon, Tangerine, Very Cherry, and Grape, are introduced.", 1976 });

            migrationBuilder.UpdateData(
                table: "MileStones",
                keyColumn: "MileStoneId",
                keyValue: 10,
                columns: new[] { "Description", "Year" },
                values: new object[] { "The world discovers President Ronald Reagan eats Jelly Belly jelly beans, and a star is born.", 1980 });

            migrationBuilder.UpdateData(
                table: "MileStones",
                keyColumn: "MileStoneId",
                keyValue: 11,
                columns: new[] { "Description", "Year" },
                values: new object[] { "About 3.5 tons of Jelly Belly jelly beans are shipped to Washington D.C. for President Ronald Reagan's inauguration celebrations.", 1981 });

            migrationBuilder.UpdateData(
                table: "MileStones",
                keyColumn: "MileStoneId",
                keyValue: 12,
                columns: new[] { "Description", "Year" },
                values: new object[] { "Though shipping across the Northern border to Canada since 1977, Jelly Belly jelly beans make their first trip overseas to the UK in 1982.", 1982 });

            migrationBuilder.UpdateData(
                table: "MileStones",
                keyColumn: "MileStoneId",
                keyValue: 13,
                columns: new[] { "Description", "Year" },
                values: new object[] { "Mr. Jelly Belly, a lovable candy character, makes his first public appearance - and it is love at first sight.", 1983 });

            migrationBuilder.InsertData(
                table: "MileStones",
                columns: new[] { "MileStoneId", "Description", "Year" },
                values: new object[,]
                {
                    { 14, "Sent by President Ronald Reagan, Jelly Belly jelly beans become the first jelly beans in space!", 1983 },
                    { 15, "New company headquarters are built in Fairfield, California, and factory tours begin soon after.", 1986 },
                    { 16, "The Buttered Popcorn flavor is introduced as the world's first 'savory' jelly bean flavor. It is now among the most popular flavors.", 1989 },
                    { 17, "Jelly Belly Sours are introduced, a novelty at the time that has since become an enduring favorite.", 1993 },
                    { 18, "The ultimate sign of good taste - The Jelly Belly name is stamped on every jelly bean.", 1996 },
                    { 19, "Bertie Bott's Every Flavor Beans®, inspired by the Harry Potter series, are brought to life by the company's candy makers in wild flavors like Black Pepper, Dirt, and Earwax.", 2000 },
                    { 20, "The Company, known for four generations by the family name Goelitz, is renamed Jelly Belly Candy Company, and continues to make more than 100 fine confections.", 2001 },
                    { 21, "Sport Beans® debut. A sports performance jelly bean that provides carb replenishment for athletes.", 2005 },
                    { 22, "Offering a flavor experience with wild and wacky flavors, Jelly Belly debuted BeanBoozled jelly beans in 2008 with ten lookalike pairs. Will it be Juicy Pear or Booger? Buttered Popcorn or Rotten Egg? There's only one way to find out!", 2008 },
                    { 23, "Jelly Belly Jewel Collection, featuring Jelly Belly jelly beans with an iridescent sheen, is unveiled.", 2013 },
                    { 24, "Jelly Belly heats things with the introduction of the Fiery Five jelly beans.", 2020 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MileStones",
                keyColumn: "MileStoneId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MileStones",
                keyColumn: "MileStoneId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "MileStones",
                keyColumn: "MileStoneId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "MileStones",
                keyColumn: "MileStoneId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "MileStones",
                keyColumn: "MileStoneId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "MileStones",
                keyColumn: "MileStoneId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "MileStones",
                keyColumn: "MileStoneId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "MileStones",
                keyColumn: "MileStoneId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "MileStones",
                keyColumn: "MileStoneId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "MileStones",
                keyColumn: "MileStoneId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "MileStones",
                keyColumn: "MileStoneId",
                keyValue: 24);

            migrationBuilder.UpdateData(
                table: "MileStones",
                keyColumn: "MileStoneId",
                keyValue: 1,
                column: "Description",
                value: "Gustav Goelitz opens a candy business in Belleville, Illinois, laying the foundation for the company's future.");

            migrationBuilder.UpdateData(
                table: "MileStones",
                keyColumn: "MileStoneId",
                keyValue: 2,
                columns: new[] { "Description", "Year" },
                values: new object[] { "The Goelitz family specializes in mellocremes, including candy corn.", 1898 });

            migrationBuilder.UpdateData(
                table: "MileStones",
                keyColumn: "MileStoneId",
                keyValue: 3,
                columns: new[] { "Description", "Year" },
                values: new object[] { "During World War II, amidst sugar rationing, the company introduces Mint Wafers.", 1940 });

            migrationBuilder.UpdateData(
                table: "MileStones",
                keyColumn: "MileStoneId",
                keyValue: 4,
                columns: new[] { "Description", "Year" },
                values: new object[] { "A significant breakthrough with the Goelitz Mini Jelly Beans, infused with flavor in both the center and the shell.", 1965 });

            migrationBuilder.UpdateData(
                table: "MileStones",
                keyColumn: "MileStoneId",
                keyValue: 5,
                columns: new[] { "Description", "Year" },
                values: new object[] { "The first Jelly Belly jelly beans are introduced with flavors like Root Beer, Green Apple, Licorice, Cream Soda, Lemon, Tangerine, Very Cherry, and Grape.", 1976 });

            migrationBuilder.UpdateData(
                table: "MileStones",
                keyColumn: "MileStoneId",
                keyValue: 6,
                columns: new[] { "Description", "Year" },
                values: new object[] { "The brand gains significant popularity, notably with President Ronald Reagan as a fan.", 1980 });

            migrationBuilder.UpdateData(
                table: "MileStones",
                keyColumn: "MileStoneId",
                keyValue: 8,
                columns: new[] { "Description", "Year" },
                values: new object[] { "The company is renamed to Jelly Belly Candy Company.", 2001 });

            migrationBuilder.UpdateData(
                table: "MileStones",
                keyColumn: "MileStoneId",
                keyValue: 9,
                columns: new[] { "Description", "Year" },
                values: new object[] { "Introduction of Bertie Bott's Every Flavor Beans from the Harry Potter series.", 2002 });

            migrationBuilder.UpdateData(
                table: "MileStones",
                keyColumn: "MileStoneId",
                keyValue: 10,
                columns: new[] { "Description", "Year" },
                values: new object[] { "Sales reach $125 million, indicating substantial growth.", 2004 });

            migrationBuilder.UpdateData(
                table: "MileStones",
                keyColumn: "MileStoneId",
                keyValue: 11,
                columns: new[] { "Description", "Year" },
                values: new object[] { "BeanBoozled jelly beans are introduced, featuring wild and wacky flavors.", 2008 });

            migrationBuilder.UpdateData(
                table: "MileStones",
                keyColumn: "MileStoneId",
                keyValue: 12,
                columns: new[] { "Description", "Year" },
                values: new object[] { "Draft Beer flavor, inspired by Hefeweizen ale, is introduced.", 2014 });

            migrationBuilder.UpdateData(
                table: "MileStones",
                keyColumn: "MileStoneId",
                keyValue: 13,
                columns: new[] { "Description", "Year" },
                values: new object[] { "Ferrara Candy Company announces an agreement to acquire Jelly Belly Candy Company.", 2023 });

            migrationBuilder.InsertData(
                table: "MileStones",
                columns: new[] { "MileStoneId", "Description", "Year" },
                values: new object[] { 7, "The company begins printing the Jelly Belly name on every bean.", 1996 });
        }
    }
}
