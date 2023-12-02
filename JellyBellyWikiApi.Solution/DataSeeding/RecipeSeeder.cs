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
          Combination = new string[] { "Very Cherry", "Very Cherry", "Coconut", "Buttered Popcorn", "Cherry Turnover" }
        },
        new Recipe
        { 
          RecipeId = 2,
          Name = "Apple Pie",
          Combination = new string[] { "Green Apple", "Green Apple", "Cinnamon", "Apple Pie" }
        },
        new Recipe
        { 
          RecipeId = 3,
          Name = "Banana Bread",
          Combination = new string[] { "Top Banana", "Top Banana", "Buttered Popcorn", "Banana Bread" }
        },
        new Recipe
        { 
          RecipeId = 4,
          Name = "Banana Cream Pie",
          Combination = new string[] { "Top Banana", "Cream Soda", "Coconut", "Banana Cream Pie" }
        },
        new Recipe
        { 
          RecipeId = 5,
          Name = "Berry Lemonade",
          Combination = new string[] { "Berry Blu", "Sunkist Lemon", "Berry Lemonade" }
        }
      );
    }
  }
}