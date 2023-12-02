using Microsoft.EntityFrameworkCore;

namespace JellyBellyWikiApi.Models
{
  public class JellyBellyWikiApiContext : DbContext
  {
    public DbSet<Bean> Beans { get; set; }
    public DbSet<Fact> Facts { get; set; }
    public DbSet<Recipe> Recipes { get; set; }

    public JellyBellyWikiApiContext(DbContextOptions<JellyBellyWikiApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Bean>()
      .HasData(
        new Bean
        { 
          BeanId = 1,
          Sku = 1001,
          GroupName = "Jelly Belly Official Flavors",
          FlavorName = "Buttered Popcorn",
          Description = "Experience the delicious taste of buttered popcorn in a bite-sized jelly bean.",
          Ingredients = "Sugar, Corn Syrup, Modified Food Starch, Contains 2% or less of the following: Natural and Artificial Flavors, Color Added, Beeswax, Carnauba Wax, Confectioner's Glaze.",
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
          Sku = 1002,
          GroupName = "Jelly Belly Official Flavors",
          FlavorName = "A&W® Root Beer",
          BackgroundColor = "#792E27",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/63b9e71d-9866-4044-9af7-7a64a52b0e0e",
          Description = "Say 'cheers' with the flavor of this all-American classic drink.",
          Ingredients = "Sugar, Corn Syrup, Modified Food Starch, Contains 2% or less of the following: Natural and Artificial Flavors, Color Added, Vegetable and Fruit Juice (Color), Beeswax, Carnauba Wax, Confectioner's Glaze.",
          ColorGroup = "Brown",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = false
        },
        new Bean
        {
          BeanId = 3,
          Sku = 1003,
          GroupName = "Jelly Belly Official Flavors",
          FlavorName = "Berry Blue",
          BackgroundColor = "#0A9882",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/4e65d579-9595-4620-b6c4-a9606df99f3d",
          Description = "A delicious medley of raspberry, blueberry and strawberry flavors.",
          Ingredients = "Sugar, Corn Syrup, Modified Food Starch, Contains 2% or less of the following: Citric Acid, Natural and Artificial Flavor, Color Added, Blue 1, Beeswax, Carnauba Wax, Confectioner's Glaze.",
          ColorGroup = "Blue",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = false
        },
        new Bean
        {
          BeanId = 4,
          Sku = 1004,
          GroupName = "Jelly Belly Official Flavors",
          FlavorName = "Blueberry",
          BackgroundColor = "#3A7195",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/a8f085b5-b4ff-4aca-8650-43ad54c80fe4",
          Description = "Enjoy the taste of fresh-picked blueberries. Deliciously flavored with real blueberry puree.",
          Ingredients = "Sugar, Corn Syrup, Modified Food Starch, Blueberry Juice From Puree, Contains 2% or less of the following: Citric Acid, Natural and Artificial Flavor, Color Added, Blue 1 Lake, Beeswax, Carnauba Wax, Confectioner's Glaze.",
          ColorGroup = "Blue",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = false
        },
        new Bean
        {
          BeanId = 5,
          Sku = 1005,
          GroupName = "Jelly Belly Official Flavors",
          FlavorName = "Bubble Gum",
          BackgroundColor = "#E3ACBD",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/51474130-73e9-40b7-a8ba-c9eac7be7de4",
          Description = " ",
          Ingredients = "Sugar, Corn Syrup, Modified Food Starch, Contains 2% or less of the following: Artificial Flavor, Color Added, Red 40 Lake, Red 40, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner's Glaze.",
          ColorGroup = "Pink",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = false
        }
      );

      builder.Entity<Fact>()
      .HasData(
        new Fact
        {
          FactId = 1,
          Title = "Presidential Favorite",
          Description = "Jelly Belly beans gained national attention when they were featured in the White House during the 1980s. President Ronald Reagan was a big fan of Jelly Belly beans, and they became known as the 'President's candy.'."
        },

        new Fact
        {
          FactId = 2,
          Title = "Over 100 Flavors",
          Description = "Jelly Belly is known for its extensive flavor selection, with over 100 different flavors available. Some of the more unusual flavors include Buttered Popcorn, Dr. Pepper, and even Harry Potter-themed flavors like Bertie Bott's Every Flavor Beans."
        },

        new Fact
        {
          FactId = 3,
          Title = "Bean Art",
          Description = "Jelly Belly beans have been used to create intricate pieces of art. Artists and enthusiasts have used the beans to make mosaics, portraits, and sculptures."
        },

        new Fact
        {
          FactId = 4,
          Title = "First Flavor",
          Description = "The Very Cherry flavor was one of the first flavors created by Jelly Belly, and it remains one of the most popular to this day."
        },

        new Fact
        {
          FactId = 5,
          Title = "Behind the Scenes",
          Description = "Making Jelly Belly beans is a complex process. It involves several stages, including creating the flavor centers, adding the candy shell, and polishing the beans to achieve their signature shine."
        }
      );

      builder.Entity<Recipe>()
      .HasData(
        new Recipe
        { 
          RecipeId = 1,
          Name = "Cherry Turnover",
          Combination = "Very Cherry + Very Cherry + Coconut + Buttered Popcorn = Cherry Turnover"
        },
        new Recipe
        { 
          RecipeId = 2,
          Name = "Apple Pie",
          Combination = "Green Apple + Green Apple + Cinnamon = Apple Pie"
        },
        new Recipe
        { 
          RecipeId = 3,
          Name = "Banana Bread",
          Combination = "Top Banana + Top Banana + Buttered Popcorn = Banana Bread"
        },
        new Recipe
        { 
          RecipeId = 4,
          Name = "Banana Cream Pie",
          Combination = "Top Banana + Cream Soda + Coconut = Banana Cream Pie"
        },
        new Recipe
        { 
          RecipeId = 5,
          Name = "Berry Lemonade",
          Combination = "Berry Blu + Sunkist Lemon = Berry Lemonade"
        }
      );
    }
  }
}