using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JellyBellyWikiApi.Migrations
{
    public partial class SeedFactsDataTo100 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 1,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Very Cherry has been the most popular Jelly Belly flavor for many years, only briefly surpassed by Buttered Popcorn in 1998.", "Popularity of Flavors" });

            migrationBuilder.UpdateData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 2,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Each bean contains only 4 calories, meaning that a handful of 25 beans amounts to 100 calories.", "Caloric Content" });

            migrationBuilder.UpdateData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 3,
                columns: new[] { "Description", "Title" },
                values: new object[] { "The company, initially known for producing candy corn, was established around 1898 as the Goelitz Confectionery Company.", "Company Origins" });

            migrationBuilder.UpdateData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 4,
                columns: new[] { "Description", "Title" },
                values: new object[] { "It takes 7 to 21 days to make a single jelly bean, involving a complex and multi-step process.", "Production Time" });

            migrationBuilder.UpdateData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 5,
                columns: new[] { "Description", "Title" },
                values: new object[] { "The founder of Jelly Belly, David Klein, was also notable for creating a new type of jelly bean with flavored insides and outer shells, using unconventional flavors like watermelon, licorice, and root beer.", "Early Connections" });

            migrationBuilder.InsertData(
                table: "Facts",
                columns: new[] { "FactId", "Description", "Title" },
                values: new object[,]
                {
                    { 6, "The origin of jelly beans may be traced back to Turkish Delights from Turkey.", "Inspiration" },
                    { 7, "Jelly Belly beans are known for their flavored centers and shells, smaller size, more intense flavor, and exotic flavors.", "Unique Features" },
                    { 8, "Jelly Belly beans were the first jelly beans in space, sent on the 1983 Challenger mission as a surprise for astronauts by President Reagan.", "Astronaut Snack" },
                    { 9, "The term 'jelly-bean' was used in the 1910s and 1920s as slang for a stylish but otherwise unremarkable man.", "Historical Slang" },
                    { 10, "The company has evolved from its original eight flavors in 1976 to more than 100 over the years. Current popular flavors include Buttered Popcorn, Very Cherry, Cotton Candy, Watermelon, and Green Apple.", "Flavor Evolution" },
                    { 11, "In 2001, the company officially became the Jelly Belly Candy Company, reflecting its most popular product.", "Company Name Change" },
                    { 12, "The chairman of Jelly Belly came under fire in 2013 for donating to an anti-transgender rights fund.", "Controversy" },
                    { 13, "Jelly Belly introduced Sport Beans for athletes, filled with carbohydrates, electrolytes, and vitamins. However, they faced a lawsuit over labeling sugar as 'evaporated cane juice'.", "Sport Beans" },
                    { 14, "In 2014, Jelly Belly released beer-flavored beans, which sparked controversy among parents concerned about encouraging underage drinking.", "Beer-Flavored Beans" },
                    { 15, "The company offers official jelly bean 'recipes,' combining different flavors to create new tastes like tres leches cake or a tequila sunrise.", "Recipe Combinations" },
                    { 16, "In 2020, the original Mr. Jelly Belly started a treasure hunt similar to Willy Wonka, offering a chance to win a candy factory.", "Willy Wonka-Esque Treasure Hunt" },
                    { 17, "Jelly Belly also produces a line of custom air fresheners in various jelly bean scents.", "Air Fresheners" },
                    { 18, "Jelly Belly beans have a shelf life of one year.", "Shelf Life" },
                    { 19, "The BeanBoozled line features pairs of jelly beans with one delicious and one disgusting flavor, challenging consumers to distinguish between them.", "BeanBoozled Challenge" },
                    { 20, "'Belly Flops,' imperfectly shaped jelly beans, are sold at a lower price but taste the same as regular beans.", "Cost-Effective Option" },
                    { 21, "It takes 7 to 14 days to make a Jelly Belly bean.", "Production Time" },
                    { 22, "Jelly Belly's California and Wisconsin locations attract about 600,000 visitors each year for tours.", "Visitor Numbers" },
                    { 23, "Public tours are available at two locations: Fairfield, California (factory tour) and Pleasant Prairie, Wisconsin (warehouse tour and train ride).", "Tour Locations" },
                    { 24, "Jelly Belly offers 50 official flavors and 66 additional flavors, including rookie, sour, sugar-free, and unique options.", "Total Number of Flavors" },
                    { 25, "In addition to jelly beans, Jelly Belly Candy Company produces 74 other gourmet confections.", "Other Products" },
                    { 26, "The BeanBoozled line features 20 flavors - 10 pleasant and 10 gag-inducing.", "BeanBoozled Line" },
                    { 27, "Jelly Belly beans eaten in a year could circle the earth five times.", "Global Consumption" },
                    { 28, "Jelly Belly beans were sent on the 1983 space shuttle Challenger mission, making them the first jelly beans in space.", "Space Adventure" },
                    { 29, "Around 5 billion Jelly Belly beans are sold during Easter.", "Easter Sales" },
                    { 30, "Each Jelly Belly bean contains 4 calories.", "Caloric Content" },
                    { 31, "Jelly Belly was the first company to add flavors to both the shell and the center of the bean, leading to their signature gourmet blends.", "Double Flavoring" },
                    { 32, "The main ingredients are sugar, corn syrup, corn starch, and confectioner's glaze, with natural flavors incorporated when possible.", "Basic Ingredients" },
                    { 33, "Jelly Belly's roots began with candy corn production by the Goelitz Confectionery Company, founded in 1869.", "Candy Corn Origins" },
                    { 34, "The initial Jelly Belly flavors included root beer, green apple, licorice, cream soda, lemon, tangerine, very cherry, and grape.", "Original Eight Flavors" },
                    { 35, "Jelly Belly is known for introducing unique flavors, including the BeanBoozled Fiery Five Challenge with varying levels of spiciness.", "Novelty Flavors" },
                    { 36, "Over the years, some flavors have been discontinued, including caramel apple, grape jelly, and peanut butter.", "Discontinued Flavors" },
                    { 37, "Jelly Belly provides seasonal assortments, like the spring mix for Easter and Monster Mash blend for Halloween.", "Seasonal Offerings" },
                    { 38, "They have collaborated with brands like Dr. Pepper, A&W Root Beer, Snapple, Tabasco, Krispy Kreme, and Coldstone Creamery.", "Brand Collaborations" },
                    { 39, "Jelly Belly beans are vegetarian but not vegan, as they contain beeswax and shellac. They are also dairy-free, gluten-free, and OU Kosher certified.", "Dietary Information" },
                    { 40, "'Belly Flops' are imperfectly shaped beans sold at a lower price, and the company also offers a bargain outlet for out-of-season products.", "Cost-Effective Options" },
                    { 41, "Every Jelly Belly bean is marked with the world-famous Jelly Belly logo and has a distinctive shape.", "Signature Design" },
                    { 42, "The flavor in Jelly Belly beans is packed into both the chewy center and the polished shell.", "Flavor Distribution" },
                    { 43, "In 2010, Jelly Belly set the Guinness World Record for the Largest Candy Art. The art piece made in China was 39 feet long and used approximately 617,000 Jelly Belly beans.", "Guinness World Record" },
                    { 44, "Jelly Belly donated 288,000 beans in 47 flavors for the world’s first jelly bean stop-motion animation music video 'In Your Arms' by Kina Grannis, released in November 2011.", "Stop-Motion Animation" },
                    { 45, "President Ronald Reagan was a well-known fan of Jelly Belly, often snacking on them during cabinet meetings.", "Presidential Favorite" },
                    { 46, "Reagan's favorite Jelly Belly flavor was licorice, which may have been influenced by his attempt to quit pipe-smoking.", "Reagan's Favorite Flavor" },
                    { 47, "Despite its focus on jelly beans, Jelly Belly still produces candy corn, a nod to its historical roots.", "Candy Corn Legacy" },
                    { 48, "Jelly Belly offers a variety of other candies, including chewy fish, gummi bears, gumdrops, Jordan almonds, and even hot chocolate bombs.", "Diverse Product Range" },
                    { 49, "Jelly Belly beans are used to enhance themed celebrations, such as weddings, baby showers, New Year's Eve, and federal holidays with specially curated assortments.", "Themed Celebrations" },
                    { 50, "Jelly Belly offers special flavors and blends for various holidays, including Christmas, Valentine's Day, and Halloween.", "Holiday Themes" },
                    { 51, "Ronald Reagan famously used Jelly Belly beans to quit smoking and even had a portrait made from Jelly Belly beans at the Reagan Presidential Library.", "Famous Fan" },
                    { 52, "Jelly Belly's range extends beyond jelly beans, including chewy fish, gummi bears, gumdrops, Jordan almonds, and hot chocolate bombs.", "Confection Variety" },
                    { 53, "The Jelly Belly Factory features an art gallery with jelly bean mosaics of famous artworks and celebrities.", "Factory Art Gallery" },
                    { 54, "Visitors on the Jelly Belly factory tour must wear silly sailor cap hats with the Jelly Belly logo.", "Required Factory Tour Attire" },
                    { 55, "Jelly Belly holds the Guinness World Record for the largest candy art, a 59-foot long piece made with over 600,000 beans.", "Candy Art Record" },
                    { 56, "Jelly Belly pioneered the concept of combining bean flavors to create new tastes, like Lemon + Cotton Candy = Pink Lemonade.", "Innovative Recipes" },
                    { 57, "Easter is the biggest season for Jelly Belly consumption, followed by Christmas.", "Easter Popularity" },
                    { 58, "Each Jelly Belly jelly bean has only 4 calories.", "Calorie Count" },
                    { 59, "Jelly Belly gives tours on 722 days combined at their two locations.", "Tour Days" },
                    { 60, "The BeanBoozled line features flavors like sriracha, jalapeño, cayenne, habañero, and Carolina Reaper.", "BeanBoozled Variations" },
                    { 61, "Collaborations include Krispy Kreme, Fruit Loop, and 'unicorn mix' flavors.", "Collaborative Flavors" },
                    { 62, "Jelly Belly offers vitamin, electrolyte, and carbohydrate-infused Sports Beans, even with caffeine.", "Sport Beans" },
                    { 63, "Flavors like caramel apple, grape jelly, and peanut butter have been discontinued.", "Discontinued Flavors" },
                    { 64, "The beans are vegetarian, dairy-free, gluten-free, and OU Kosher, but not vegan.", "Dietary Information" },
                    { 65, "‘Belly Flops’ are irregular beans sold at a discount, and bulk buys are available at places like Costco.", "Cost Savings" },
                    { 66, "Reagan's fixation with Jelly Belly began as a way to overcome his pipe-smoking habit.", "Presidential Affection" },
                    { 67, "Despite its jelly bean focus, Jelly Belly still produces candy corn.", "Candy Corn Production" },
                    { 68, "Jelly Belly beans can be used for themed parties and events, offering a wide array of colors and flavors.", "Themed Party Enhancements" },
                    { 69, "Guests on factory tours can sample Jelly Belly jelly beans during their visit.", "Visitor Sampling" },
                    { 70, "Since the 1800s, candy technology has evolved significantly, with Jelly Belly at the forefront of innovation in jelly bean production.", "Candy Technology Advancements" },
                    { 71, "People consume enough Jelly Belly beans annually to circle the globe more than five times.", "Global Popularity" },
                    { 72, "In the early 20th century, 'jelly-bean' was slang for a stylish but superficial man.", "Historical Slang Term" },
                    { 73, "Jelly Belly beans were a staple in the Reagan White House, and a blueberry flavor was created specifically for his 1980 inauguration.", "Presidential Treat" },
                    { 74, "Jelly Belly expanded from eight original flavors in 1976 to over 100, including partnerships with brands for unique flavors.", "Flavor Expansion" },
                    { 75, "In 2001, the Goelitz family companies merged to form the Jelly Belly Candy Company.", "Company Renaming" },
                    { 76, "Jelly Belly's chairman faced backlash for donating to an anti-transgender rights fund in 2013.", "Controversy" },
                    { 77, "Jelly Belly faced a lawsuit over the marketing of Sport Beans, which are infused with vitamins and electrolytes.", "Sport Beans Lawsuit" },
                    { 78, "The beans were sent to space on the 1983 Challenger mission, becoming the first jelly beans in space.", "Jelly Belly in Space" },
                    { 79, "In 2014, Jelly Belly released beer-flavored beans, sparking controversy among parents.", "Beer-Flavored Beans" },
                    { 80, "The company created a line called Recipe Mix, combining two flavors in one bean.", "Recipe Mix Line" },
                    { 81, "Jelly Belly offers holiday-themed gift boxes with flavors like eggnog, candy cane, and pumpkin pie.", "Variety in Gift Boxes" },
                    { 82, "Jelly Belly has collaborated with clothing and fashion brands to create unique promotional items.", "Clothing and Fashion Collaborations" },
                    { 83, "The company has even partnered with Reebok for sneakers and Sally Hansen for candy-coated nail polish.", "Sneaker and Nail Polish Collaborations" },
                    { 84, "Jelly Belly Factory hosts an art gallery with jelly bean mosaics of celebrities and famous artworks.", "Celebrity and Artistic Mosaics" },
                    { 85, "The factory tour includes a requirement to wear Jelly Belly logo hats and offers fun photo opportunities.", "Unique Factory Tour Features" },
                    { 86, "Jelly Belly beans do not use gelatin but include beeswax and shellac, making them non-vegan.", "Animal Product Use" },
                    { 87, "The brand offers Extreme Sports Beans containing caffeine for an energy boost.", "Caffeinated Sports Beans" },
                    { 88, "Some BeanBoozled flavors, like toothpaste and liver and onions, are available for a limited time.", "Limited Time Flavors" },
                    { 89, "Jelly Belly beans have a shelf life of one year, and consumers are advised to use their senses to determine if they have spoiled.", "Shelf Life and Storage" },
                    { 90, "A portrait of Ronald Reagan made entirely out of Jelly Belly beans is displayed at the Reagan Presidential Library.", "Presidential Portrait" },
                    { 91, "Visitors to the Reagan Library can also see a vintage candy dish from Air Force One, typically filled with Jelly Belly beans.", "Air Force One Candy Dish" },
                    { 92, "Jelly Belly offers sugar-free, zero-calorie sparkling water in fun flavors like orange sherbet.", "Variety in Beverages" },
                    { 93, "For weddings, Jelly Belly offers a white and glamorous blend of flavors like cream soda, vanilla, and coconut.", "Event-Themed Beans" },
                    { 94, "Jelly Belly beans are used as decorative and flavorful toppers for cakes and cupcakes on special occasions.", "Cake and Cupcake Toppers" },
                    { 95, "Special assortments like the spring mix for Easter and Monster Mash blend for Halloween are offered seasonally.", "Holiday Blend Assortments" },
                    { 96, "The company's 39-foot long candy art piece, created with over 600,000 beans, holds a world record.", "Guinness World Record for Candy Art" },
                    { 97, "Jelly Belly contributed to the creation of a pioneering stop-motion animation music video using their beans.", "Stop-Motion Animation Involvement" },
                    { 98, "Visitors on Jelly Belly factory tours have the opportunity to sample various flavors during their visit.", "Factory Tour Samples" },
                    { 99, "The Jelly Belly Factory in Fairfield, California, offers tours where visitors can see the production process, view jelly bean mosaics, and purchase Jelly Belly products in the gift shop.", "Factory Tours" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 99);

            migrationBuilder.UpdateData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 1,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Jelly Belly beans gained national attention when they were featured in the White House during the 1980s. President Ronald Reagan was a big fan of Jelly Belly beans, and they became known as the 'President's candy.'.", "Presidential Favorite" });

            migrationBuilder.UpdateData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 2,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Jelly Belly is known for its extensive flavor selection, with over 100 different flavors available. Some of the more unusual flavors include Buttered Popcorn, Dr. Pepper, and even Harry Potter-themed flavors like Bertie Bott's Every Flavor Beans.", "Over 100 Flavors" });

            migrationBuilder.UpdateData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 3,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Jelly Belly beans have been used to create intricate pieces of art. Artists and enthusiasts have used the beans to make mosaics, portraits, and sculptures.", "Bean Art" });

            migrationBuilder.UpdateData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 4,
                columns: new[] { "Description", "Title" },
                values: new object[] { "The Very Cherry flavor was one of the first flavors created by Jelly Belly, and it remains one of the most popular to this day.", "First Flavor" });

            migrationBuilder.UpdateData(
                table: "Facts",
                keyColumn: "FactId",
                keyValue: 5,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Making Jelly Belly beans is a complex process. It involves several stages, including creating the flavor centers, adding the candy shell, and polishing the beans to achieve their signature shine.", "Behind the Scenes" });
        }
    }
}
