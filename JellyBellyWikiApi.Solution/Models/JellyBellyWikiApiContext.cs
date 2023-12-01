using Microsoft.EntityFrameworkCore;

namespace JellyBellyWikiApi.Models
{
  public class JellyBellyWikiApiContext : DbContext
  {
    public DbSet<Bean> Beans { get; set; }

    public JellyBellyWikiApiContext(DbContextOptions<JellyBellyWikiApiContext> options) : base(options)
    {
    }
  }
}