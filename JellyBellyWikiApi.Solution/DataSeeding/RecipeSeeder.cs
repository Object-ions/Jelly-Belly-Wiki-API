using JellyBellyWikiApi.Models;
using Microsoft.EntityFrameworkCore;

namespace JellyBellyWikiApi.DataSeeding
{
  public static class RecipeSeeder
  {
    public static void Seed(ModelBuilder builder)
    {
      builder.Entity<Recipe>().HasData(
        new Recipe
      { 
          RecipeId = 1,
          Name = "Cherry Turnover",
          Combination =  new[] {"Very Cherry + Very Cherry + Coconut + Buttered Popcorn + Cherry Turnover"}
      },

      new Recipe
      {
          RecipeId = 2,
          Name = "Apple Pie",
          Combination = new[] {"Green Apple + Green Apple + Cinnamon"}
      },

      new Recipe
      {
          RecipeId = 3,
          Name = "Banana Bread",
          Combination = new[] {"Top Banana + Top Banana + Buttered Popcorn"}
      },

      new Recipe
      {
          RecipeId = 4,
          Name = "Banana Cream Pie",
          Combination = new[] {"Top Banana + A&W® Cream Soda + Coconut"}
      },

      new Recipe
      {
          RecipeId = 5,
          Name = "Banana Split",
          Combination = new[] {"Top Banana + Chocolate Pudding + Crushed Pineapple + Strawberry Jam + Very Cherry + French Vanilla"}
      },

      new Recipe
      {
          RecipeId = 6,
          Name = "Bananas Foster",
          Combination = new[] {"Top Banana + Top Banana + Top Banana + Buttered Popcorn + French Vanilla"}
      },

      new Recipe
      {
          RecipeId = 7,
          Name = "Berry Lemonade",
          Combination = new[] {"Berry Blu + SUNKIST® Lemon"}
      },

      new Recipe
      {
          RecipeId = 8,
          Name = "Blueberry Cheesecake",
          Combination = new[] {"Blueberry + Strawberry Cheesecake + French Vanilla + A&W® Cream Soda"}
      },

      new Recipe
      {
          RecipeId = 9,
          Name = "Blueberry Muffin",
          Combination = new[] {"Blueberry + Blueberry + Buttered Popcorn"}
      },

      new Recipe
      {
          RecipeId = 10,
          Name = "Blueberry Pancakes",
          Combination = new[] {"Blueberry + Caramel Corn + French Vanilla + Toasted Marshmallow + Toasted Marshmallow"}
      },

      new Recipe
      {
          RecipeId = 11,
          Name = "Café Mocha",
          Combination = new[] {"Cappuccino + Cappuccino + Chocolate Pudding + French Vanilla"}
      },

      new Recipe
      {
          RecipeId = 12,
          Name = "Candy Apple",
          Combination = new[] {"Green Apple + Green Apple + Cinnamon"}
      },

      new Recipe
      {
          RecipeId = 13,
          Name = "Cherry Cola",
          Combination = new[] {"Very Cherry + Very Cherry + Dr Pepper®"}
      },

      new Recipe
      {
          RecipeId = 14,
          Name = "Cherry Turnover",
          Combination = new[] {"Very Cherry + Very Cherry + Coconut + Buttered Popcorn"}
      },

      new Recipe
      {
          RecipeId = 15,
          Name = "Chocolate Covered Cherries",
          Combination = new[] {"Very Cherry + Very Cherry + Chocolate Pudding"}
      },

      new Recipe
      {
          RecipeId = 16,
          Name = "Chocolate Dipped Banana",
          Combination = new[] {"Top Banana + Chocolate Pudding"}
      },

      new Recipe
      {
          RecipeId = 17,
          Name = "Chocolate Dipped Strawberries",
          Combination = new[] {"Strawberry Daiquiri + Strawberry Daiquiri + Chocolate Pudding"}
      },

      new Recipe
      {
          RecipeId = 18,
          Name = "Chocolate Macaroons",
          Combination = new[] {"Chocolate Pudding + Coconut"}
      },

      new Recipe
      {
          RecipeId = 19,
          Name = "Chocolate Popcorn",
          Combination = new[] {"Chocolate Pudding + Buttered Popcorn"}
      },

      new Recipe
      {
          RecipeId = 20,
          Name = "Cinnamon Bubble Gum",
          Combination = new[] {"Cinnamon + Bubble Gum"}
      },

      new Recipe
      {
          RecipeId = 21,
          Name = "Cinnamon Popcorn",
          Combination = new[] {"Buttered Popcorn + Buttered Popcorn + Sizzling Cinnamon"}
      },

      new Recipe
      {
          RecipeId = 22,
          Name = "Coffee Cake",
          Combination = new[] {"Cappuccino + Buttered Popcorn + French Vanilla"}
      },

      new Recipe
      {
          RecipeId = 23,
          Name = "Cola",
          Combination = new[] {"Lime + Cinnamon"}
      },

      new Recipe
      {
          RecipeId = 24,
          Name = "Fruit Punch",
          Combination = new[] {"Island Punch + SUNKIST® Orange + Very Cherry"}
      },

      new Recipe
      {
          RecipeId = 25,
          Name = "Fruit Salad",
          Combination = new[] {"Kiwi + Strawberry Jam + Blueberry + Cantaloupe"}
      },

      new Recipe
      {
          RecipeId = 26,
          Name = "Ginger Beer",
          Combination = new[] {"Draft Beer + Draft Beer + Ginger Ale"}
      },

      new Recipe
      {
          RecipeId = 27,
          Name = "Green Apple Bubble Gum",
          Combination = new[] {"Green Apple + Bubble Gum + Bubble Gum"}
      },

      new Recipe
      {
          RecipeId = 28,
          Name = "Hot Apple Cider",
          Combination = new[] {"Red Apple + Red Apple + Cinnamon"}
      },

      new Recipe
      {
          RecipeId = 29,
          Name = "Hot Chocolate",
          Combination = new[] {"Toasted Marshmallow + Chocolate Pudding"}
      },

      new Recipe
      {
          RecipeId = 30,
          Name = "Hot Fudge Sundae",
          Combination = new[] {"French Vanilla + French Vanilla + Chocolate Pudding + A&W® Cream Soda + Very Cherry"}
      },

      new Recipe
      {
          RecipeId = 31,
          Name = "Iced Vanilla Latte",
          Combination = new[] {"French Vanilla + Cappuccino"}
      },

      new Recipe
      {
          RecipeId = 32,
          Name = "Italian Biscotti",
          Combination = new[] {"Licorice + Buttered Popcorn + Buttered Popcorn"}
      },

      new Recipe
      {
          RecipeId = 33,
          Name = "Key Lime Pie",
          Combination = new[] {"Lemon Lime + Toasted Marshmallow"}
      },

      new Recipe
      {
          RecipeId = 34,
          Name = "Lemon Squares",
          Combination = new[] {"Lemon + Lemon + Vanilla + Coconut"}
      },

      new Recipe
      {
          RecipeId = 35,
          Name = "Mango Pineapple Salsa",
          Combination = new[] {"Mango + Crushed Pineapple + Chili Mango"}
      },

      new Recipe
      {
          RecipeId = 36,
          Name = "Mango Tango Salsa",
          Combination = new[] {"Mango + Lemon Lime + Chili Mango"}
      },

      new Recipe
      {
          RecipeId = 37,
          Name = "Michelada",
          Combination = new[] {"Draft Beer + Draft Beer + Lemon Lime + Tabasco®"}
      },

      new Recipe
      {
          RecipeId = 38,
          Name = "Mud Pie",
          Combination = new[] {"Chocolate Pudding + Chocolate Pudding + Very Cherry"}
      },

      new Recipe
      {
          RecipeId = 39,
          Name = "Peach Bellini Drink",
          Combination = new[] {"Orange Sherbet + Orange Sherbet + A&W® Cream Soda"}
      },

      new Recipe
      {
          RecipeId = 40,
          Name = "Peaches and Cream",
          Combination = new[] {"Peach + A&W® Cream Soda"}
      },

      new Recipe
      {
          RecipeId = 41,
          Name = "Pink Lemonade",
          Combination = new[] {"Cotton Candy + SUNKIST® Lemon"}
      },

      new Recipe
      {
          RecipeId = 42,
          Name = "Plum Pudding",
          Combination = new[] {"Plum + Plum + French Vanilla"}
      },

      new Recipe
      {
          RecipeId = 43,
          Name = "Plum Sorbet",
          Combination = new[] {"Plum + Plum + SUNKIST® Lemon + Green Apple"}
      },

      new Recipe
      {
          RecipeId = 44,
          Name = "Plum Tart",
          Combination = new[] {"Plum + Plum + Cinnamon + A&W® Cream Soda"}
      },

      new Recipe
      {
          RecipeId = 45,
          Name = "Pumpkin Spice Latte",
          Combination = new[] {"Pumpkin Pie + Pumpkin Pie + French Vanilla + Cappuccino"}
      },

      new Recipe
      {
          RecipeId = 46,
          Name = "Rainbow Sherbet",
          Combination = new[] {"Raspberry + Lemon Lime + Orange Sherbet"}
      },

      new Recipe
      {
          RecipeId = 47,
          Name = "Raspberry Crème Brûlée",
          Combination = new[] {"French Vanilla + Raspberry + Toasted Marshmallow"}
      },

      new Recipe
      {
          RecipeId = 48,
          Name = "Root Beer Float",
          Combination = new[] {"A&W® Root Beer + A&W® Root Beer + A&W® Cream Soda"}
      },

      new Recipe
      {
          RecipeId = 49,
          Name = "S'mores",
          Combination = new[] {"Caramel Corn + Toasted Marshmallow + Toasted Marshmallow + Chocolate Pudding"}
      },

      new Recipe
      {
          RecipeId = 50,
          Name = "Strawberry-Kiwi Refresher",
          Combination = new[] {"Kiwi + Strawberry Daiquiri"}
      },

      new Recipe
      {
          RecipeId = 51,
          Name = "Strawberry Shortcake",
          Combination = new[] {"Strawberry Jam + French Vanilla"}
      },

      new Recipe
      {
          RecipeId = 52,
          Name = "Sweet Fried Bananas",
          Combination = new[] {"Top Banana + Top Banana + Cinnamon + Buttered Popcorn"}
      },
      new Recipe
      {
          RecipeId = 53,
          Name = "Tequila Sunrise",
          Combination = new[] {"Margarita + Margarita + SUNKIST® Orange + Very Cherry"}
      },

      new Recipe
      {
          RecipeId = 54,
          Name = "Tiramisu",
          Combination = new[] {"Cappuccino + Cappuccino + A&W® Cream Soda + Chocolate Pudding"}
      }
      );
    }
  }
}