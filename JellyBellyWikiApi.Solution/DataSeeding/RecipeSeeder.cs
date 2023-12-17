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
          Name = "BAKED VALENTINE'S DAY DONUTS",
          Description = "Your special someone will L-O-V-E this delicious treat topped with their favorites from the Jelly Belly® Valentine Mix!",
          PrepTime = "5 minutes",
          CookTime = "10 minutes",
          TotalTime = "35 minutes",
          MakingAmount = "6 Donuts",
          Img = "",
          Ingredients = new[] {"3/4 cup all-purpose flour, 1/2 cup granulated sugar, 3/4 tsp baking powder, 1/4 tsp baking soda, 1/4 tsp salt, 1/3 cup buttermilk, 1 egg, 1/4 cup melted unsalted butter, 1/2 tsp vanilla extract"},
          Additions1 = new[] {"GLAZE, 2 cups icing sugar, 1/4 cup milk, approx., 1 tsp vanilla extract, 1/2 cup Jelly Belly Valentine Mix:, Bubble Gum, Coconut, Cotton Candy, Strawberry Cheesecake and Very Cherry"},
          Additions2 = new[] {""},
          Additions3 = new[] {""},
          Directions = new[] {"Preheat oven to 375°F. Grease one standard donut pan well with butter or cooking spray., In a large bowl, sift together flour, sugar, baking powder, baking soda and salt., In separate bowl, whisk together buttermilk, egg, melted butter and vanilla., Stir the dry ingredients into the liquid ingredients until combined., Spoon the batter into the pan, filling each mold three-quarters full., Bake for 9 to 10 minutes or until tops spring back when pressed and a toothpick inserted into the donuts comes out clean., Let cool in pan for 5 minutes. Remove from pan and cool on rack. Reinforce donut holes with handle of wooden spoon, if necessary., Glaze: In a small bowl, whisk together icing sugar and milk, adding more milk a teaspoon at a time until icing is thin enough for donuts to be dipped into., Dip donuts into glaze, turning to coat top completely. Return to rack to set. Dip a second time to create a solid white finish. Arrange Jelly Belly® jelly beans on top, sprinkling or placing as you wish."},
          Tips = new[] {"Tint icing sugar with red food coloring for a red or pink finish."},
        },
      );
    }
  }
}