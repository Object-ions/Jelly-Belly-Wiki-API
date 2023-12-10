using JellyBellyWikiApi.Models;
using Microsoft.EntityFrameworkCore;

namespace JellyBellyWikiApi.DataSeeding
{
  public static class MileStoneSeeder
  {
    public static void Seed(ModelBuilder builder)
    {
      builder.Entity<MileStone>().HasData(
        new MileStone
        {
          MileStoneId = 1,
          Year = 1869,
          Description = "Gustav Goelitz opens a candy business in Belleville, Illinois, laying the foundation for the company's future."
        },

        new MileStone
        {
          MileStoneId = 2,
          Year = 1898,
          Description = "The Goelitz family specializes in mellocremes, including candy corn."
        },

        new MileStone
        {
          MileStoneId = 3,
          Year = 1940,
          Description = "During World War II, amidst sugar rationing, the company introduces Mint Wafers."
        },

        new MileStone
        {
          MileStoneId = 4,
          Year = 1965,
          Description = "A significant breakthrough with the Goelitz Mini Jelly Beans, infused with flavor in both the center and the shell."
        },

        new MileStone
        {
          MileStoneId = 5,
          Year = 1976,
          Description = "The first Jelly Belly jelly beans are introduced with flavors like Root Beer, Green Apple, Licorice, Cream Soda, Lemon, Tangerine, Very Cherry, and Grape."
        },

        new MileStone
        {
          MileStoneId = 6,
          Year = 1980,
          Description = "The brand gains significant popularity, notably with President Ronald Reagan as a fan."
        },

        new MileStone
        {
          MileStoneId = 7,
          Year = 1996,
          Description = "The company begins printing the Jelly Belly name on every bean."
        },

        new MileStone
        {
          MileStoneId = 8,
          Year = 2001,
          Description = "The company is renamed to Jelly Belly Candy Company."
        },

        new MileStone
        {
          MileStoneId = 9,
          Year = 2002,
          Description = "Introduction of Bertie Bott's Every Flavor Beans from the Harry Potter series."
        },

        new MileStone
        {
          MileStoneId = 10,
          Year = 2004,
          Description = "Sales reach $125 million, indicating substantial growth."
        },

        new MileStone
        {
          MileStoneId = 11,
          Year = 2008,
          Description = "BeanBoozled jelly beans are introduced, featuring wild and wacky flavors."
        },

        new MileStone
        {
          MileStoneId = 12,
          Year = 2014,
          Description = "Draft Beer flavor, inspired by Hefeweizen ale, is introduced."
        },

        new MileStone
        {
          MileStoneId = 13,
          Year = 2023,
          Description = "Ferrara Candy Company announces an agreement to acquire Jelly Belly Candy Company."
        }
      );
    }
  }
}