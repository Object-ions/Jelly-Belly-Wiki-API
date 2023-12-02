using JellyBellyWikiApi.Models;
using Microsoft.EntityFrameworkCore;

namespace JellyBellyWikiApi.DataSeeding
{
  public static class FactSeeder
  {
    public static void Seed(ModelBuilder builder)
    {
      builder.Entity<Fact>().HasData(
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
    }
  }
}