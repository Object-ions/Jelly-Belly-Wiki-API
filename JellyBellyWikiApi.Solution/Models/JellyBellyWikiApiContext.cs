using Microsoft.EntityFrameworkCore;

namespace JellyBellyWikiApi.Models
{
  public class JellyBellyWikiApiContext : DbContext
  {
    public DbSet<Bean> Beans { get; set; }

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
            Mixes = "",
            ColorGroup = "White",
            BackgroundColor = "#E1DFE1",
            ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/75fea694-ed38-4e84-a86e-182e31ea5a7b",
            GlutenFree = false,
            SugarFree = false,
            Seasonal = false,
            Kosher = true
          }
        );
    }
  }
}