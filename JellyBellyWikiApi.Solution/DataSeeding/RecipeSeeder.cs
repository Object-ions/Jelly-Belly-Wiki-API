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
          Combination =  new[] {"Green Apple + Green Apple + Cinnamon + Apple Pie"}
        },
        new Recipe
        { 
          RecipeId = 3,
          Name = "Banana Bread",
          Combination =  new[] {"Top Banana + Top Banana + Buttered Popcorn + Banana Bread"}
        },
        new Recipe
        { 
          RecipeId = 4,
          Name = "Banana Cream Pie",
          Combination =  new[] {"Top Banana + Cream Soda + Coconut + Banana Cream Pie"}
        },
        new Recipe
        { 
          RecipeId = 5,
          Name = "Berry Lemonade",
          Combination =  new[] {"Berry Blu + Sunkist Lemon + Berry Lemonade"}
        }
      );
    }
  }
}