using JellyBellyWikiApi.Models;
using Microsoft.EntityFrameworkCore;

namespace JellyBellyWikiApi.DataSeeding
{
  public static class CombinationSeeder
  {
    public static void Seed(ModelBuilder builder)
    {
      builder.Entity<Combination>().HasData(
        new Combination
      { 
          CombinationId = 1,
          Name = "Cherry Turnover",
          TagSerialized =  "Very Cherry, + ,Very Cherry, + ,Coconut, + ,Buttered Popcorn"
      },

      new Combination
      {
          CombinationId = 2,
          Name = "Apple Pie",
          TagSerialized = "Green Apple, + ,Green Apple, + ,Cinnamon"
      },

      new Combination
      {
          CombinationId = 3,
          Name = "Banana Bread",
          TagSerialized = "Top Banana, + ,Top Banana, + ,Buttered Popcorn"
      },

      new Combination
      {
          CombinationId = 4,
          Name = "Banana Cream Pie",
          TagSerialized = "Top Banana, + ,A&W® Cream Soda, + ,Coconut"
      },

      new Combination
      {
          CombinationId = 5,
          Name = "Banana Split",
          TagSerialized = "Top Banana, + ,Chocolate Pudding, + ,Crushed Pineapple, + ,Strawberry Jam, + ,Very Cherry, + French Vanilla"
      },

      new Combination
      {
          CombinationId = 6,
          Name = "Bananas Foster",
          TagSerialized = "Top Banana, + ,Top Banana, + ,Top Banana, + ,Buttered Popcorn, + ,French Vanilla"
      },

      new Combination
      {
          CombinationId = 7,
          Name = "Berry Lemonade",
          TagSerialized = "Berry Blu, + ,SUNKIST® Lemon"
      },

      new Combination
      {
          CombinationId = 8,
          Name = "Blueberry Cheesecake",
          TagSerialized = "Blueberry, + ,Strawberry Cheesecake, + ,French Vanilla, + ,A&W® Cream Soda"
      },

      new Combination
      {
          CombinationId = 9,
          Name = "Blueberry Muffin",
          TagSerialized = "Blueberry, + ,Blueberry, + ,Buttered Popcorn"
      },

      new Combination
      {
          CombinationId = 10,
          Name = "Blueberry Pancakes",
          TagSerialized = "Blueberry, + ,Caramel Corn, + ,French Vanilla, + ,Toasted Marshmallow, + ,Toasted Marshmallow"
      },

      new Combination
      {
          CombinationId = 11,
          Name = "Café Mocha",
          TagSerialized = "Cappuccino, + ,Cappuccino, + ,Chocolate Pudding, + ,French Vanilla"
      },

      new Combination
      {
          CombinationId = 12,
          Name = "Candy Apple",
          TagSerialized = "Green Apple, + ,Green Apple, + ,Cinnamon"
      },

      new Combination
      {
          CombinationId = 13,
          Name = "Cherry Cola",
          TagSerialized = "Very Cherry, + ,Very Cherry, + ,Dr Pepper®"
      },

      new Combination
      {
          CombinationId = 14,
          Name = "Cherry Turnover",
          TagSerialized = "Very Cherry, + ,Very Cherry, + ,Coconut, + ,Buttered Popcorn"
      },

      new Combination
      {
          CombinationId = 15,
          Name = "Chocolate Covered Cherries",
          TagSerialized = "Very Cherry, + ,Very Cherry, + ,Chocolate Pudding"
      },

      new Combination
      {
          CombinationId = 16,
          Name = "Chocolate Dipped Banana",
          TagSerialized = "Top Banana, + ,Chocolate Pudding"
      },

      new Combination
      {
          CombinationId = 17,
          Name = "Chocolate Dipped Strawberries",
          TagSerialized = "Strawberry Daiquiri, + ,Strawberry Daiquiri, + ,Chocolate Pudding"
      },

      new Combination
      {
          CombinationId = 18,
          Name = "Chocolate Macaroons",
          TagSerialized = "Chocolate Pudding, + ,Coconut"
      },

      new Combination
      {
          CombinationId = 19,
          Name = "Chocolate Popcorn",
          TagSerialized = "Chocolate Pudding, + ,Buttered Popcorn"
      },

      new Combination
      {
          CombinationId = 20,
          Name = "Cinnamon Bubble Gum",
          TagSerialized = "Cinnamon, + ,Bubble Gum"
      },

      new Combination
      {
          CombinationId = 21,
          Name = "Cinnamon Popcorn",
          TagSerialized = "Buttered Popcorn, + ,Buttered Popcorn, + ,Sizzling Cinnamon"
      },

      new Combination
      {
          CombinationId = 22,
          Name = "Coffee Cake",
          TagSerialized = "Cappuccino, + ,Buttered Popcorn, + ,French Vanilla"
      },

      new Combination
      {
          CombinationId = 23,
          Name = "Cola",
          TagSerialized = "Lime, + ,Cinnamon"
      },

      new Combination
      {
          CombinationId = 24,
          Name = "Fruit Punch",
          TagSerialized = "Island Punch, + ,SUNKIST® Orange, + ,Very Cherry"
      },

      new Combination
      {
          CombinationId = 25,
          Name = "Fruit Salad",
          TagSerialized = "Kiwi, + ,Strawberry Jam, + ,Blueberry, + ,Cantaloupe"
      },

      new Combination
      {
          CombinationId = 26,
          Name = "Ginger Beer",
          TagSerialized = "Draft Beer, + ,Draft Beer, + ,Ginger Ale"
      },

      new Combination
      {
          CombinationId = 27,
          Name = "Green Apple Bubble Gum",
          TagSerialized = "Green Apple, + ,Bubble Gum, + ,Bubble Gum"
      },

      new Combination
      {
          CombinationId = 28,
          Name = "Hot Apple Cider",
          TagSerialized = "Red Apple, + ,Red Apple, + ,Cinnamon"
      },

      new Combination
      {
          CombinationId = 29,
          Name = "Hot Chocolate",
          TagSerialized = "Toasted Marshmallow, + ,Chocolate Pudding"
      },

      new Combination
      {
          CombinationId = 30,
          Name = "Hot Fudge Sundae",
          TagSerialized = "French Vanilla, + ,French Vanilla, + ,Chocolate Pudding, + ,A&W® Cream Soda, + ,Very Cherry"
      },

      new Combination
      {
          CombinationId = 31,
          Name = "Iced Vanilla Latte",
          TagSerialized = "French Vanilla, + ,Cappuccino"
      },

      new Combination
      {
          CombinationId = 32,
          Name = "Italian Biscotti",
          TagSerialized = "Licorice, + ,Buttered Popcorn, + ,Buttered Popcorn"
      },

      new Combination
      {
          CombinationId = 33,
          Name = "Key Lime Pie",
          TagSerialized = "Lemon Lime, + ,Toasted Marshmallow"
      },

      new Combination
      {
          CombinationId = 34,
          Name = "Lemon Squares",
          TagSerialized = "Lemon, + ,Lemon, + ,Vanilla, + ,Coconut"
      },

      new Combination
      {
          CombinationId = 35,
          Name = "Mango Pineapple Salsa",
          TagSerialized = "Mango, + ,Crushed Pineapple, + ,Chili Mango"
      },

      new Combination
      {
          CombinationId = 36,
          Name = "Mango Tango Salsa",
          TagSerialized = "Mango, + ,Lemon Lime, + ,Chili Mango"
      },

      new Combination
      {
          CombinationId = 37,
          Name = "Michelada",
          TagSerialized = "Draft Beer, + ,Draft Beer, + ,Lemon Lime, + ,Tabasco®"
      },

      new Combination
      {
          CombinationId = 38,
          Name = "Mud Pie",
          TagSerialized = "Chocolate Pudding, + ,Chocolate Pudding, + ,Very Cherry"
      },

      new Combination
      {
          CombinationId = 39,
          Name = "Peach Bellini Drink",
          TagSerialized = "Orange Sherbet, + ,Orange Sherbet, + ,A&W® Cream Soda"
      },

      new Combination
      {
          CombinationId = 40,
          Name = "Peaches and Cream",
          TagSerialized = "Peach, + ,A&W® Cream Soda"
      },

      new Combination
      {
          CombinationId = 41,
          Name = "Pink Lemonade",
          TagSerialized = "Cotton Candy, + ,SUNKIST® Lemon"
      },

      new Combination
      {
          CombinationId = 42,
          Name = "Plum Pudding",
          TagSerialized = "Plum, + ,Plum, + ,French Vanilla"
      },

      new Combination
      {
          CombinationId = 43,
          Name = "Plum Sorbet",
          TagSerialized = "Plum, + ,Plum, + ,SUNKIST® Lemon, + ,Green Apple"
      },

      new Combination
      {
          CombinationId = 44,
          Name = "Plum Tart",
          TagSerialized = "Plum, + ,Plum, + ,Cinnamon, + ,A&W® Cream Soda"
      },

      new Combination
      {
          CombinationId = 45,
          Name = "Pumpkin Spice Latte",
          TagSerialized = "Pumpkin Pie, + ,Pumpkin Pie, + ,French Vanilla, + ,Cappuccino"
      },

      new Combination
      {
          CombinationId = 46,
          Name = "Rainbow Sherbet",
          TagSerialized = "Raspberry, + ,Lemon Lime, + ,Orange Sherbet"
      },

      new Combination
      {
          CombinationId = 47,
          Name = "Raspberry Crème Brûlée",
          TagSerialized = "French Vanilla, + ,Raspberry, + ,Toasted Marshmallow"
      },

      new Combination
      {
          CombinationId = 48,
          Name = "Root Beer Float",
          TagSerialized = "A&W® Root Beer, + ,A&W® Root Beer, + ,A&W® Cream Soda"
      },

      new Combination
      {
          CombinationId = 49,
          Name = "S'mores",
          TagSerialized = "Caramel Corn, + ,Toasted Marshmallow, + ,Toasted Marshmallow, + ,Chocolate Pudding"
      },

      new Combination
      {
          CombinationId = 50,
          Name = "Strawberry-Kiwi Refresher",
          TagSerialized = "Kiwi, + ,Strawberry Daiquiri"
      },

      new Combination
      {
          CombinationId = 51,
          Name = "Strawberry Shortcake",
          TagSerialized = "Strawberry Jam, + ,French Vanilla"
      },

      new Combination
      {
          CombinationId = 52,
          Name = "Sweet Fried Bananas",
          TagSerialized = "Top Banana, + ,Top Banana, + ,Cinnamon, + ,Buttered Popcorn"
      },
      new Combination
      {
          CombinationId = 53,
          Name = "Tequila Sunrise",
          TagSerialized = "Margarita, + ,Margarita, + ,SUNKIST® Orange, + ,Very Cherry"
      },

      new Combination
      {
          CombinationId = 54,
          Name = "Tiramisu",
          TagSerialized = "Cappuccino, + ,Cappuccino, + ,A&W® Cream Soda, + ,Chocolate Pudding"
      }
      );
    }
  }
}