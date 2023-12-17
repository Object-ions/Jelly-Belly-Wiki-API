using Microsoft.EntityFrameworkCore;
using JellyBellyWikiApi.DataSeeding;
using System.Text.Json;

namespace JellyBellyWikiApi.Models
{
  public class JellyBellyWikiApiContext : DbContext
  {
    public DbSet<Bean> Beans { get; set; }
    public DbSet<Fact> Facts { get; set; }
    public DbSet<MileStone> MileStones { get; set; }
    public DbSet<Combination> Combinations { get; set; }

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

            builder.Entity<Combination>()
                .Property(r => r.Tag)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                    v => JsonSerializer.Deserialize<string[]>(v, (JsonSerializerOptions)null));

            BeanSeeder.Seed(builder);
            FactSeeder.Seed(builder);
            MileStoneSeeder.Seed(builder);
            CombinationSeeder.Seed(builder);
    }
  }
}