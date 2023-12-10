using JellyBellyWikiApi.Models;
using Microsoft.EntityFrameworkCore;

namespace JellyBellyWikiApi.DataSeeding
{
  public static class FactSeeder
  {
    public static void Seed(ModelBuilder builder)
    {
      builder.Entity<Fact>().HasData(
        new Fact
      {
        FactId = 1,
        Title = "Popularity of Flavors",
        Description = "Very Cherry has been the most popular Jelly Belly flavor for many years, only briefly surpassed by Buttered Popcorn in 1998."
      },

      new Fact
      {
        FactId = 2,
        Title = "Caloric Content",
        Description = "Each bean contains only 4 calories, meaning that a handful of 25 beans amounts to 100 calories."
      },

      new Fact
      {
        FactId = 3,
        Title = "Company Origins",
        Description = "The company, initially known for producing candy corn, was established around 1898 as the Goelitz Confectionery Company."
      },

      new Fact
      {
        FactId = 4,
        Title = "Production Time",
        Description = "It takes 7 to 21 days to make a single jelly bean, involving a complex and multi-step process."
      },

      new Fact
      {
        FactId = 5,
        Title = "Early Connections",
        Description = "The founder of Jelly Belly, David Klein, was also notable for creating a new type of jelly bean with flavored insides and outer shells, using unconventional flavors like watermelon, licorice, and root beer."
      },

      new Fact
      {
        FactId = 6,
        Title = "Inspiration",
        Description = "The origin of jelly beans may be traced back to Turkish Delights from Turkey."
      },

      new Fact
      {
        FactId = 7,
        Title = "Unique Features",
        Description = "Jelly Belly beans are known for their flavored centers and shells, smaller size, more intense flavor, and exotic flavors."
      },

      new Fact
      {
        FactId = 8,
        Title = "Astronaut Snack",
        Description = "Jelly Belly beans were the first jelly beans in space, sent on the 1983 Challenger mission as a surprise for astronauts by President Reagan."
      },

      new Fact
      {
        FactId = 9,
        Title = "Historical Slang",
        Description = "The term 'jelly-bean' was used in the 1910s and 1920s as slang for a stylish but otherwise unremarkable man."
      },

      new Fact
      {
        FactId = 10,
        Title = "Flavor Evolution",
        Description = "The company has evolved from its original eight flavors in 1976 to more than 100 over the years. Current popular flavors include Buttered Popcorn, Very Cherry, Cotton Candy, Watermelon, and Green Apple."
      },

      new Fact
      {
        FactId = 11,
        Title = "Company Name Change",
        Description = "In 2001, the company officially became the Jelly Belly Candy Company, reflecting its most popular product."
      },

      new Fact
      {
        FactId = 12,
        Title = "Controversy",
        Description = "The chairman of Jelly Belly came under fire in 2013 for donating to an anti-transgender rights fund."
      },

      new Fact
      {
        FactId = 13,
        Title = "Sport Beans",
        Description = "Jelly Belly introduced Sport Beans for athletes, filled with carbohydrates, electrolytes, and vitamins. However, they faced a lawsuit over labeling sugar as 'evaporated cane juice'."
      },

      new Fact
      {
        FactId = 14,
        Title = "Beer-Flavored Beans",
        Description = "In 2014, Jelly Belly released beer-flavored beans, which sparked controversy among parents concerned about encouraging underage drinking."
      },

      new Fact
      {
        FactId = 15,
        Title = "Recipe Combinations",
        Description = "The company offers official jelly bean 'recipes,' combining different flavors to create new tastes like tres leches cake or a tequila sunrise."
      },

      new Fact
      {
        FactId = 16,
        Title = "Willy Wonka-Esque Treasure Hunt",
        Description = "In 2020, the original Mr. Jelly Belly started a treasure hunt similar to Willy Wonka, offering a chance to win a candy factory."
      },

      new Fact
      {
        FactId = 17,
        Title = "Air Fresheners",
        Description = "Jelly Belly also produces a line of custom air fresheners in various jelly bean scents."
      },

      new Fact
      {
        FactId = 18,
        Title = "Shelf Life",
        Description = "Jelly Belly beans have a shelf life of one year."
      },

      new Fact
      {
        FactId = 19,
        Title = "BeanBoozled Challenge",
        Description = "The BeanBoozled line features pairs of jelly beans with one delicious and one disgusting flavor, challenging consumers to distinguish between them."
      },

      new Fact
      {
        FactId = 20,
        Title = "Cost-Effective Option",
        Description = "'Belly Flops,' imperfectly shaped jelly beans, are sold at a lower price but taste the same as regular beans."
      },

      new Fact
      {
        FactId = 21,
        Title = "Production Time",
        Description = "It takes 7 to 14 days to make a Jelly Belly bean."
      },

      new Fact
      {
        FactId = 22,
        Title = "Visitor Numbers",
        Description = "Jelly Belly's California and Wisconsin locations attract about 600,000 visitors each year for tours."
      },

      new Fact
      {
        FactId = 23,
        Title = "Tour Locations",
        Description = "Public tours are available at two locations: Fairfield, California (factory tour) and Pleasant Prairie, Wisconsin (warehouse tour and train ride)."
      },

      new Fact
      {
        FactId = 24,
        Title = "Total Number of Flavors",
        Description = "Jelly Belly offers 50 official flavors and 66 additional flavors, including rookie, sour, sugar-free, and unique options."
      },

      new Fact
      {
        FactId = 25,
        Title = "Other Products",
        Description = "In addition to jelly beans, Jelly Belly Candy Company produces 74 other gourmet confections."
      },

      new Fact
      {
        FactId = 26,
        Title = "BeanBoozled Line",
        Description = "The BeanBoozled line features 20 flavors - 10 pleasant and 10 gag-inducing."
      },

      new Fact
      {
        FactId = 27,
        Title = "Global Consumption",
        Description = "Jelly Belly beans eaten in a year could circle the earth five times."
      },

      new Fact
      {
        FactId = 28,
        Title = "Space Adventure",
        Description = "Jelly Belly beans were sent on the 1983 space shuttle Challenger mission, making them the first jelly beans in space."
      },

      new Fact
      {
        FactId = 29,
        Title = "Easter Sales",
        Description = "Around 5 billion Jelly Belly beans are sold during Easter."
      },

      new Fact
      {
        FactId = 30,
        Title = "Caloric Content",
        Description = "Each Jelly Belly bean contains 4 calories."
      },

      new Fact
      {
        FactId = 31,
        Title = "Double Flavoring",
        Description = "Jelly Belly was the first company to add flavors to both the shell and the center of the bean, leading to their signature gourmet blends."
      },

      new Fact
      {
        FactId = 32,
        Title = "Basic Ingredients",
        Description = "The main ingredients are sugar, corn syrup, corn starch, and confectioner's glaze, with natural flavors incorporated when possible."
      },

      new Fact
      {
        FactId = 33,
        Title = "Candy Corn Origins",
        Description = "Jelly Belly's roots began with candy corn production by the Goelitz Confectionery Company, founded in 1869."
      },

      new Fact
      {
        FactId = 34,
        Title = "Original Eight Flavors",
        Description = "The initial Jelly Belly flavors included root beer, green apple, licorice, cream soda, lemon, tangerine, very cherry, and grape."
      },

      new Fact
      {
        FactId = 35,
        Title = "Novelty Flavors",
        Description = "Jelly Belly is known for introducing unique flavors, including the BeanBoozled Fiery Five Challenge with varying levels of spiciness."
      },

      new Fact
      {
        FactId = 36,
        Title = "Discontinued Flavors",
        Description = "Over the years, some flavors have been discontinued, including caramel apple, grape jelly, and peanut butter."
      },

      new Fact
      {
        FactId = 37,
        Title = "Seasonal Offerings",
        Description = "Jelly Belly provides seasonal assortments, like the spring mix for Easter and Monster Mash blend for Halloween."
      },

      new Fact
      {
        FactId = 38,
        Title = "Brand Collaborations",
        Description = "They have collaborated with brands like Dr. Pepper, A&W Root Beer, Snapple, Tabasco, Krispy Kreme, and Coldstone Creamery."
      },

      new Fact
      {
        FactId = 39,
        Title = "Dietary Information",
        Description = "Jelly Belly beans are vegetarian but not vegan, as they contain beeswax and shellac. They are also dairy-free, gluten-free, and OU Kosher certified."
      },

      new Fact
      {
        FactId = 40,
        Title = "Cost-Effective Options",
        Description = "'Belly Flops' are imperfectly shaped beans sold at a lower price, and the company also offers a bargain outlet for out-of-season products."
      },

      new Fact
      {
        FactId = 41,
        Title = "Signature Design",
        Description = "Every Jelly Belly bean is marked with the world-famous Jelly Belly logo and has a distinctive shape."
      },
      new Fact
      {
        FactId = 42,
        Title = "Flavor Distribution",
        Description = "The flavor in Jelly Belly beans is packed into both the chewy center and the polished shell."
      },

      new Fact
      {
        FactId = 43,
        Title = "Guinness World Record",
        Description = "In 2010, Jelly Belly set the Guinness World Record for the Largest Candy Art. The art piece made in China was 39 feet long and used approximately 617,000 Jelly Belly beans."
      },

      new Fact
      {
        FactId = 44,
        Title = "Stop-Motion Animation",
        Description = "Jelly Belly donated 288,000 beans in 47 flavors for the world’s first jelly bean stop-motion animation music video 'In Your Arms' by Kina Grannis, released in November 2011."
      },

      new Fact
      {
        FactId = 45,
        Title = "Presidential Favorite",
        Description = "President Ronald Reagan was a well-known fan of Jelly Belly, often snacking on them during cabinet meetings."
      },

      new Fact
      {
        FactId = 46,
        Title = "Reagan's Favorite Flavor",
        Description = "Reagan's favorite Jelly Belly flavor was licorice, which may have been influenced by his attempt to quit pipe-smoking."
      },

      new Fact
      {
        FactId = 47,
        Title = "Candy Corn Legacy",
        Description = "Despite its focus on jelly beans, Jelly Belly still produces candy corn, a nod to its historical roots."
      },

      new Fact
      {
        FactId = 48,
        Title = "Diverse Product Range",
        Description = "Jelly Belly offers a variety of other candies, including chewy fish, gummi bears, gumdrops, Jordan almonds, and even hot chocolate bombs."
      },

      new Fact
      {
        FactId = 49,
        Title = "Themed Celebrations",
        Description = "Jelly Belly beans are used to enhance themed celebrations, such as weddings, baby showers, New Year's Eve, and federal holidays with specially curated assortments."
      },
      new Fact
      {
        FactId = 50,
        Title = "Holiday Themes",
        Description = "Jelly Belly offers special flavors and blends for various holidays, including Christmas, Valentine's Day, and Halloween."
      },

      new Fact
      {
        FactId = 51,
        Title = "Famous Fan",
        Description = "Ronald Reagan famously used Jelly Belly beans to quit smoking and even had a portrait made from Jelly Belly beans at the Reagan Presidential Library."
      },

      new Fact
      {
        FactId = 52,
        Title = "Confection Variety",
        Description = "Jelly Belly's range extends beyond jelly beans, including chewy fish, gummi bears, gumdrops, Jordan almonds, and hot chocolate bombs."
      },

      new Fact
      {
        FactId = 53,
        Title = "Factory Art Gallery",
        Description = "The Jelly Belly Factory features an art gallery with jelly bean mosaics of famous artworks and celebrities."
      },

      new Fact
      {
        FactId = 54,
        Title = "Required Factory Tour Attire",
        Description = "Visitors on the Jelly Belly factory tour must wear silly sailor cap hats with the Jelly Belly logo."
      },

      new Fact
      {
        FactId = 55,
        Title = "Candy Art Record",
        Description = "Jelly Belly holds the Guinness World Record for the largest candy art, a 59-foot long piece made with over 600,000 beans."
      },

      new Fact
      {
        FactId = 56,
        Title = "Innovative Recipes",
        Description = "Jelly Belly pioneered the concept of combining bean flavors to create new tastes, like Lemon + Cotton Candy = Pink Lemonade."
      },

      new Fact
      {
        FactId = 57,
        Title = "Easter Popularity",
        Description = "Easter is the biggest season for Jelly Belly consumption, followed by Christmas."
      },

      new Fact
      {
        FactId = 58,
        Title = "Calorie Count",
        Description = "Each Jelly Belly jelly bean has only 4 calories."
      },

      new Fact
      {
        FactId = 59,
        Title = "Tour Days",
        Description = "Jelly Belly gives tours on 722 days combined at their two locations."
      },

      new Fact
      {
        FactId = 60,
        Title = "BeanBoozled Variations",
        Description = "The BeanBoozled line features flavors like sriracha, jalapeño, cayenne, habañero, and Carolina Reaper."
      },

      new Fact
      {
        FactId = 61,
        Title = "Collaborative Flavors",
        Description = "Collaborations include Krispy Kreme, Fruit Loop, and 'unicorn mix' flavors."
      },

      new Fact
      {
        FactId = 62,
        Title = "Sport Beans",
        Description = "Jelly Belly offers vitamin, electrolyte, and carbohydrate-infused Sports Beans, even with caffeine."
      },

      new Fact
      {
        FactId = 63,
        Title = "Discontinued Flavors",
        Description = "Flavors like caramel apple, grape jelly, and peanut butter have been discontinued."
      },

      new Fact
      {
        FactId = 64,
        Title = "Dietary Information",
        Description = "The beans are vegetarian, dairy-free, gluten-free, and OU Kosher, but not vegan."
      },

      new Fact
      {
        FactId = 65,
        Title = "Cost Savings",
        Description = "‘Belly Flops’ are irregular beans sold at a discount, and bulk buys are available at places like Costco."
      },

      new Fact
      {
        FactId = 66,
        Title = "Presidential Affection",
        Description = "Reagan's fixation with Jelly Belly began as a way to overcome his pipe-smoking habit."
      },

      new Fact
      {
        FactId = 67,
        Title = "Candy Corn Production",
        Description = "Despite its jelly bean focus, Jelly Belly still produces candy corn."
      },

      new Fact
      {
        FactId = 68,
        Title = "Themed Party Enhancements",
        Description = "Jelly Belly beans can be used for themed parties and events, offering a wide array of colors and flavors."
      },

      new Fact
      {
        FactId = 69,
        Title = "Visitor Sampling",
        Description = "Guests on factory tours can sample Jelly Belly jelly beans during their visit."
      },

      new Fact
      {
        FactId = 70,
        Title = "Candy Technology Advancements",
        Description = "Since the 1800s, candy technology has evolved significantly, with Jelly Belly at the forefront of innovation in jelly bean production."
      },

      new Fact
      {
        FactId = 71,
        Title = "Global Popularity",
        Description = "People consume enough Jelly Belly beans annually to circle the globe more than five times."
      },

      new Fact
      {
        FactId = 72,
        Title = "Historical Slang Term",
        Description = "In the early 20th century, 'jelly-bean' was slang for a stylish but superficial man."
      },

      new Fact
      {
        FactId = 73,
        Title = "Presidential Treat",
        Description = "Jelly Belly beans were a staple in the Reagan White House, and a blueberry flavor was created specifically for his 1980 inauguration."
      },

      new Fact
      {
        FactId = 74,
        Title = "Flavor Expansion",
        Description = "Jelly Belly expanded from eight original flavors in 1976 to over 100, including partnerships with brands for unique flavors."
      },

      new Fact
      {
        FactId = 75,
        Title = "Company Renaming",
        Description = "In 2001, the Goelitz family companies merged to form the Jelly Belly Candy Company."
      },

      new Fact
      {
        FactId = 76,
        Title = "Controversy",
        Description = "Jelly Belly's chairman faced backlash for donating to an anti-transgender rights fund in 2013."
      },

      new Fact
      {
        FactId = 77,
        Title = "Sport Beans Lawsuit",
        Description = "Jelly Belly faced a lawsuit over the marketing of Sport Beans, which are infused with vitamins and electrolytes."
      },

      new Fact
      {
        FactId = 78,
        Title = "Jelly Belly in Space",
        Description = "The beans were sent to space on the 1983 Challenger mission, becoming the first jelly beans in space."
      },

      new Fact
      {
        FactId = 79,
        Title = "Beer-Flavored Beans",
        Description = "In 2014, Jelly Belly released beer-flavored beans, sparking controversy among parents."
      },

      new Fact
      {
        FactId = 80,
        Title = "Recipe Mix Line",
        Description = "The company created a line called Recipe Mix, combining two flavors in one bean."
      },

      new Fact
      {
        FactId = 81,
        Title = "Variety in Gift Boxes",
        Description = "Jelly Belly offers holiday-themed gift boxes with flavors like eggnog, candy cane, and pumpkin pie."
      },

      new Fact
      {
        FactId = 82,
        Title = "Clothing and Fashion Collaborations",
        Description = "Jelly Belly has collaborated with clothing and fashion brands to create unique promotional items."
      },

      new Fact
      {
        FactId = 83,
        Title = "Sneaker and Nail Polish Collaborations",
        Description = "The company has even partnered with Reebok for sneakers and Sally Hansen for candy-coated nail polish."
      },

      new Fact
      {
        FactId = 84,
        Title = "Celebrity and Artistic Mosaics",
        Description = "Jelly Belly Factory hosts an art gallery with jelly bean mosaics of celebrities and famous artworks."
      },

      new Fact
      {
        FactId = 85,
        Title = "Unique Factory Tour Features",
        Description = "The factory tour includes a requirement to wear Jelly Belly logo hats and offers fun photo opportunities."
      },

      new Fact
      {
        FactId = 86,
        Title = "Animal Product Use",
        Description = "Jelly Belly beans do not use gelatin but include beeswax and shellac, making them non-vegan."
      },

      new Fact
      {
        FactId = 87,
        Title = "Caffeinated Sports Beans",
        Description = "The brand offers Extreme Sports Beans containing caffeine for an energy boost."
      },

      new Fact
      {
        FactId = 88,
        Title = "Limited Time Flavors",
        Description = "Some BeanBoozled flavors, like toothpaste and liver and onions, are available for a limited time."
      },

      new Fact
      {
        FactId = 89,
        Title = "Shelf Life and Storage",
        Description = "Jelly Belly beans have a shelf life of one year, and consumers are advised to use their senses to determine if they have spoiled."
      },

      new Fact
      {
        FactId = 90,
        Title = "Presidential Portrait",
        Description = "A portrait of Ronald Reagan made entirely out of Jelly Belly beans is displayed at the Reagan Presidential Library."
      },

      new Fact
      {
        FactId = 91,
        Title = "Air Force One Candy Dish",
        Description = "Visitors to the Reagan Library can also see a vintage candy dish from Air Force One, typically filled with Jelly Belly beans."
      },

      new Fact
      {
        FactId = 92,
        Title = "Variety in Beverages",
        Description = "Jelly Belly offers sugar-free, zero-calorie sparkling water in fun flavors like orange sherbet."
      },

      new Fact
      {
        FactId = 93,
        Title = "Event-Themed Beans",
        Description = "For weddings, Jelly Belly offers a white and glamorous blend of flavors like cream soda, vanilla, and coconut."
      },

      new Fact
      {
        FactId = 94,
        Title = "Cake and Cupcake Toppers",
        Description = "Jelly Belly beans are used as decorative and flavorful toppers for cakes and cupcakes on special occasions."
      },

      new Fact
      {
        FactId = 95,
        Title = "Holiday Blend Assortments",
        Description = "Special assortments like the spring mix for Easter and Monster Mash blend for Halloween are offered seasonally."
      },

      new Fact
      {
        FactId = 96,
        Title = "Guinness World Record for Candy Art",
        Description = "The company's 39-foot long candy art piece, created with over 600,000 beans, holds a world record."
      },

      new Fact
      {
        FactId = 97,
        Title = "Stop-Motion Animation Involvement",
        Description = "Jelly Belly contributed to the creation of a pioneering stop-motion animation music video using their beans."
      },

      new Fact
      {
        FactId = 98,
        Title = "Factory Tour Samples",
        Description = "Visitors on Jelly Belly factory tours have the opportunity to sample various flavors during their visit."
      },
      new Fact
      {
        FactId = 99,
        Title = "Factory Tours",
        Description = "The Jelly Belly Factory in Fairfield, California, offers tours where visitors can see the production process, view jelly bean mosaics, and purchase Jelly Belly products in the gift shop."
      }
      );
    }
  }
}