using JellyBellyWikiApi.Models;
using Microsoft.EntityFrameworkCore;

namespace JellyBellyWikiApi.DataSeeding
{
  public static class BeanSeeder
  {
    public static void Seed(ModelBuilder builder)
    {
      builder.Entity<Bean>().HasData(
        new Bean
        { 
          BeanId = 1,
           GroupNameSerialized = "Jelly Belly Official Flavors, Most Popular Flavors",
          FlavorName = "Buttered Popcorn",
          Description = "Experience the delicious taste of buttered popcorn in a bite-sized jelly bean.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% or less of the following: Natural and Artificial Flavors, Color Added, Vegetable and Fruit Juice (Color), Beeswax, Carnauba Wax, Confectioner's Glaze."},
          ColorGroup = "White",
          BackgroundColor = "#E1DFE1",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/75fea694-ed38-4e84-a86e-182e31ea5a7b",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },
        new Bean
        {
          BeanId = 2,
           GroupNameSerialized = "Jelly Belly Official Flavors",
          FlavorName = "A&W® Root Beer",
          BackgroundColor = "#792E27",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/63b9e71d-9866-4044-9af7-7a64a52b0e0e",
          Description = "Say 'cheers' with the flavor of this all-American classic drink.",
          Ingredients = new [] {"Sugar", "Corn Syrup", "Modified Food Starch", "Contains 2% or less of the following: Natural and Artificial Flavors, Color Added, Vegetable and Fruit Juice (Color), Beeswax, Carnauba Wax, Confectioner's Glaze."},
          ColorGroup = "Brown",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = false
        },
        new Bean
        {
          BeanId = 3,
           GroupNameSerialized = "Jelly Belly Official Flavors",
          FlavorName = "Berry Blue",
          BackgroundColor = "#0A9882",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/4e65d579-9595-4620-b6c4-a9606df99f3d",
          Description = "A delicious medley of raspberry, blueberry and strawberry flavors.",
          Ingredients = new [] {"Sugar", "Corn Syrup", "Modified Food Starch", "Contains 2% or less of the following: Citric Acid. Natural and Artificial Flavor. Color Added. Blue 1, Beeswax. Carnauba Wax. Confectioner's Glaze."},
          ColorGroup = "Blue",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = false
        },
        new Bean
        {
          BeanId = 4,
           GroupNameSerialized = "Jelly Belly Official Flavors",
          FlavorName = "Blueberry",
          BackgroundColor = "#3A7195",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/a8f085b5-b4ff-4aca-8650-43ad54c80fe4",
          Description = "Enjoy the taste of fresh-picked blueberries. Deliciously flavored with real blueberry puree.",
          Ingredients = new [] {"Sugar", "Corn Syrup", "Modified Food Starch", "Blueberry Juice From Puree", "Contains 2% or less of the following: Citric Acid. Natural and Artificial Flavor. Color Added. Blue 1 Lake. Beeswax. Carnauba Wax. Confectioner's Glaze."},
          ColorGroup = "Blue",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = false
        },
        new Bean
        {
          BeanId = 5,
           GroupNameSerialized = "Jelly Belly Official Flavors",
          FlavorName = "Bubble Gum",
          BackgroundColor = "#E3ACBD",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/51474130-73e9-40b7-a8ba-c9eac7be7de4",
          Description = " ",
          Ingredients = new [] {"Sugar", "Corn Syrup", "Modified Food Starch", "Contains 2% or less of the following: Artificial Flavor. Color Added. Red 40 Lake. Red 40. Yellow 5 Lake. Beeswax. Carnauba Wax. Confectioner's Glaze."},
          ColorGroup = "Pink",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = false
        }
      );
    }
  }
}