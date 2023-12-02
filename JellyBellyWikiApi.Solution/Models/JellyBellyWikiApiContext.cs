using Microsoft.EntityFrameworkCore;
using JellyBellyWikiApi.DataSeeding;

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
      .Property(b => b.Ingredients)
      .HasConversion(
        v => string.Join(",", v), 
        v => v.Split(',', StringSplitOptions.RemoveEmptyEntries));

      // Seeding data using separate seeder classes
      BeanSeeder.Seed(builder);
      FactSeeder.Seed(builder);
      RecipeSeeder.Seed(builder);
    }
  }
}