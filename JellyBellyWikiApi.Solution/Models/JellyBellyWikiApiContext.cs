using Microsoft.EntityFrameworkCore;
using JellyBellyWikiApi.DataSeeding;
using System.Text.Json;
using JellyBellyWikiApi.Models;

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
            v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
            v => JsonSerializer.Deserialize<string[]>(v, (JsonSerializerOptions)null));

      builder.Entity<Recipe>()
          .Property(r => r.Combination)
          .HasConversion(
              v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
              v => JsonSerializer.Deserialize<string[]>(v, (JsonSerializerOptions)null));


      // Seeding data using separate seeder classes
      BeanSeeder.Seed(builder);
      FactSeeder.Seed(builder);
      RecipeSeeder.Seed(builder);
    }
  }
}