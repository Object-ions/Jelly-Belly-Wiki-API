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
          Tag =  new[] {"Very Cherry + Very Cherry + Coconut + Buttered Popcorn + Cherry Turnover"}
      },

      new Combination
      {
          CombinationId = 2,
          Name = "Apple Pie",
          Tag = new[] {"Green Apple + Green Apple + Cinnamon"}
      },

      new Combination
      {
          CombinationId = 3,
          Name = "Banana Bread",
          Tag = new[] {"Top Banana + Top Banana + Buttered Popcorn"}
      },

      new Combination
      {
          CombinationId = 4,
          Name = "Banana Cream Pie",
          Tag = new[] {"Top Banana + A&W® Cream Soda + Coconut"}
      },

      new Combination
      {
          CombinationId = 5,
          Name = "Banana Split",
          Tag = new[] {"Top Banana + Chocolate Pudding + Crushed Pineapple + Strawberry Jam + Very Cherry + French Vanilla"}
      },

      new Combination
      {
          CombinationId = 6,
          Name = "Bananas Foster",
          Tag = new[] {"Top Banana + Top Banana + Top Banana + Buttered Popcorn + French Vanilla"}
      },

      new Combination
      {
          CombinationId = 7,
          Name = "Berry Lemonade",
          Tag = new[] {"Berry Blu + SUNKIST® Lemon"}
      },

      new Combination
      {
          CombinationId = 8,
          Name = "Blueberry Cheesecake",
          Tag = new[] {"Blueberry + Strawberry Cheesecake + French Vanilla + A&W® Cream Soda"}
      },

      new Combination
      {
          CombinationId = 9,
          Name = "Blueberry Muffin",
          Tag = new[] {"Blueberry + Blueberry + Buttered Popcorn"}
      },

      new Combination
      {
          CombinationId = 10,
          Name = "Blueberry Pancakes",
          Tag = new[] {"Blueberry + Caramel Corn + French Vanilla + Toasted Marshmallow + Toasted Marshmallow"}
      },

      new Combination
      {
          CombinationId = 11,
          Name = "Café Mocha",
          Tag = new[] {"Cappuccino + Cappuccino + Chocolate Pudding + French Vanilla"}
      },

      new Combination
      {
          CombinationId = 12,
          Name = "Candy Apple",
          Tag = new[] {"Green Apple + Green Apple + Cinnamon"}
      },

      new Combination
      {
          CombinationId = 13,
          Name = "Cherry Cola",
          Tag = new[] {"Very Cherry + Very Cherry + Dr Pepper®"}
      },

      new Combination
      {
          CombinationId = 14,
          Name = "Cherry Turnover",
          Tag = new[] {"Very Cherry + Very Cherry + Coconut + Buttered Popcorn"}
      },

      new Combination
      {
          CombinationId = 15,
          Name = "Chocolate Covered Cherries",
          Tag = new[] {"Very Cherry + Very Cherry + Chocolate Pudding"}
      },

      new Combination
      {
          CombinationId = 16,
          Name = "Chocolate Dipped Banana",
          Tag = new[] {"Top Banana + Chocolate Pudding"}
      },

      new Combination
      {
          CombinationId = 17,
          Name = "Chocolate Dipped Strawberries",
          Tag = new[] {"Strawberry Daiquiri + Strawberry Daiquiri + Chocolate Pudding"}
      },

      new Combination
      {
          CombinationId = 18,
          Name = "Chocolate Macaroons",
          Tag = new[] {"Chocolate Pudding + Coconut"}
      },

      new Combination
      {
          CombinationId = 19,
          Name = "Chocolate Popcorn",
          Tag = new[] {"Chocolate Pudding + Buttered Popcorn"}
      },

      new Combination
      {
          CombinationId = 20,
          Name = "Cinnamon Bubble Gum",
          Tag = new[] {"Cinnamon + Bubble Gum"}
      },

      new Combination
      {
          CombinationId = 21,
          Name = "Cinnamon Popcorn",
          Tag = new[] {"Buttered Popcorn + Buttered Popcorn + Sizzling Cinnamon"}
      },

      new Combination
      {
          CombinationId = 22,
          Name = "Coffee Cake",
          Tag = new[] {"Cappuccino + Buttered Popcorn + French Vanilla"}
      },

      new Combination
      {
          CombinationId = 23,
          Name = "Cola",
          Tag = new[] {"Lime + Cinnamon"}
      },

      new Combination
      {
          CombinationId = 24,
          Name = "Fruit Punch",
          Tag = new[] {"Island Punch + SUNKIST® Orange + Very Cherry"}
      },

      new Combination
      {
          CombinationId = 25,
          Name = "Fruit Salad",
          Tag = new[] {"Kiwi + Strawberry Jam + Blueberry + Cantaloupe"}
      },

      new Combination
      {
          CombinationId = 26,
          Name = "Ginger Beer",
          Tag = new[] {"Draft Beer + Draft Beer + Ginger Ale"}
      },

      new Combination
      {
          CombinationId = 27,
          Name = "Green Apple Bubble Gum",
          Tag = new[] {"Green Apple + Bubble Gum + Bubble Gum"}
      },

      new Combination
      {
          CombinationId = 28,
          Name = "Hot Apple Cider",
          Tag = new[] {"Red Apple + Red Apple + Cinnamon"}
      },

      new Combination
      {
          CombinationId = 29,
          Name = "Hot Chocolate",
          Tag = new[] {"Toasted Marshmallow + Chocolate Pudding"}
      },

      new Combination
      {
          CombinationId = 30,
          Name = "Hot Fudge Sundae",
          Tag = new[] {"French Vanilla + French Vanilla + Chocolate Pudding + A&W® Cream Soda + Very Cherry"}
      },

      new Combination
      {
          CombinationId = 31,
          Name = "Iced Vanilla Latte",
          Tag = new[] {"French Vanilla + Cappuccino"}
      },

      new Combination
      {
          CombinationId = 32,
          Name = "Italian Biscotti",
          Tag = new[] {"Licorice + Buttered Popcorn + Buttered Popcorn"}
      },

      new Combination
      {
          CombinationId = 33,
          Name = "Key Lime Pie",
          Tag = new[] {"Lemon Lime + Toasted Marshmallow"}
      },

      new Combination
      {
          CombinationId = 34,
          Name = "Lemon Squares",
          Tag = new[] {"Lemon + Lemon + Vanilla + Coconut"}
      },

      new Combination
      {
          CombinationId = 35,
          Name = "Mango Pineapple Salsa",
          Tag = new[] {"Mango + Crushed Pineapple + Chili Mango"}
      },

      new Combination
      {
          CombinationId = 36,
          Name = "Mango Tango Salsa",
          Tag = new[] {"Mango + Lemon Lime + Chili Mango"}
      },

      new Combination
      {
          CombinationId = 37,
          Name = "Michelada",
          Tag = new[] {"Draft Beer + Draft Beer + Lemon Lime + Tabasco®"}
      },

      new Combination
      {
          CombinationId = 38,
          Name = "Mud Pie",
          Tag = new[] {"Chocolate Pudding + Chocolate Pudding + Very Cherry"}
      },

      new Combination
      {
          CombinationId = 39,
          Name = "Peach Bellini Drink",
          Tag = new[] {"Orange Sherbet + Orange Sherbet + A&W® Cream Soda"}
      },

      new Combination
      {
          CombinationId = 40,
          Name = "Peaches and Cream",
          Tag = new[] {"Peach + A&W® Cream Soda"}
      },

      new Combination
      {
          CombinationId = 41,
          Name = "Pink Lemonade",
          Tag = new[] {"Cotton Candy + SUNKIST® Lemon"}
      },

      new Combination
      {
          CombinationId = 42,
          Name = "Plum Pudding",
          Tag = new[] {"Plum + Plum + French Vanilla"}
      },

      new Combination
      {
          CombinationId = 43,
          Name = "Plum Sorbet",
          Tag = new[] {"Plum + Plum + SUNKIST® Lemon + Green Apple"}
      },

      new Combination
      {
          CombinationId = 44,
          Name = "Plum Tart",
          Tag = new[] {"Plum + Plum + Cinnamon + A&W® Cream Soda"}
      },

      new Combination
      {
          CombinationId = 45,
          Name = "Pumpkin Spice Latte",
          Tag = new[] {"Pumpkin Pie + Pumpkin Pie + French Vanilla + Cappuccino"}
      },

      new Combination
      {
          CombinationId = 46,
          Name = "Rainbow Sherbet",
          Tag = new[] {"Raspberry + Lemon Lime + Orange Sherbet"}
      },

      new Combination
      {
          CombinationId = 47,
          Name = "Raspberry Crème Brûlée",
          Tag = new[] {"French Vanilla + Raspberry + Toasted Marshmallow"}
      },

      new Combination
      {
          CombinationId = 48,
          Name = "Root Beer Float",
          Tag = new[] {"A&W® Root Beer + A&W® Root Beer + A&W® Cream Soda"}
      },

      new Combination
      {
          CombinationId = 49,
          Name = "S'mores",
          Tag = new[] {"Caramel Corn + Toasted Marshmallow + Toasted Marshmallow + Chocolate Pudding"}
      },

      new Combination
      {
          CombinationId = 50,
          Name = "Strawberry-Kiwi Refresher",
          Tag = new[] {"Kiwi + Strawberry Daiquiri"}
      },

      new Combination
      {
          CombinationId = 51,
          Name = "Strawberry Shortcake",
          Tag = new[] {"Strawberry Jam + French Vanilla"}
      },

      new Combination
      {
          CombinationId = 52,
          Name = "Sweet Fried Bananas",
          Tag = new[] {"Top Banana + Top Banana + Cinnamon + Buttered Popcorn"}
      },
      new Combination
      {
          CombinationId = 53,
          Name = "Tequila Sunrise",
          Tag = new[] {"Margarita + Margarita + SUNKIST® Orange + Very Cherry"}
      },

      new Combination
      {
          CombinationId = 54,
          Name = "Tiramisu",
          Tag = new[] {"Cappuccino + Cappuccino + A&W® Cream Soda + Chocolate Pudding"}
      }
      );
    }
  }
}