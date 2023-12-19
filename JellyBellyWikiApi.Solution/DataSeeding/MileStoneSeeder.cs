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
        Description = "At age 24, Gustav Goelitz opens a candy business in Belleville, Illinois, and sets the family on its sweet destiny."
      },

      new MileStone
      {
        MileStoneId = 2,
        Year = 1894,
        Description = "Gustav's sons continue the family candy making tradition."
      },

      new MileStone
      {
        MileStoneId = 3,
        Year = 1898,
        Description = "The second generation of the Goelitz candy-making family specializes in a new type of candy, mellocremes (also called butter creams), which include candy corn."
      },

      new MileStone
      {
        MileStoneId = 4,
        Year = 1940,
        Description = "In the midst of sugar rationing during World War II, which limited candy production, the company introduces Mint Wafers."
      },

      new MileStone
      {
        MileStoneId = 5,
        Year = 1960,
        Description = "The third- and fourth-generation descendants of Gustav Goelitz cook candies such as tangerine slices, spice drops, and jelly beans."
      },

      new MileStone
      {
        MileStoneId = 6,
        Year = 1965,
        Description = "A flavor breakthrough is made when the Goelitz Mini Jelly Beans are infused with flavor in the center as well as the shell."
      },
      new MileStone
      {
        MileStoneId = 8,
        Year = 1972,
        Description = "Chocolate Dutch Mints® debut. A creamy mint center is covered in dark chocolate and finished with a crisp, candy shell. It's a classic now and still one of the most popular confections we make."
      },

      new MileStone
      {
        MileStoneId = 9,
        Year = 1976,
        Description = "Building upon the flavor innovation of the Goelitz Mini Jelly Beans, the first eight flavors of Jelly Belly jelly beans, Root Beer, Green Apple, Licorice, Cream Soda, Lemon, Tangerine, Very Cherry, and Grape, are introduced."
      },

      new MileStone
      {
        MileStoneId = 10,
        Year = 1980,
        Description = "The world discovers President Ronald Reagan eats Jelly Belly jelly beans, and a star is born."
      },

      new MileStone
      {
        MileStoneId = 11,
        Year = 1981,
        Description = "About 3.5 tons of Jelly Belly jelly beans are shipped to Washington D.C. for President Ronald Reagan's inauguration celebrations."
      },

      new MileStone
      {
        MileStoneId = 12,
        Year = 1982,
        Description = "Though shipping across the Northern border to Canada since 1977, Jelly Belly jelly beans make their first trip overseas to the UK in 1982."
      },

      new MileStone
      {
        MileStoneId = 13,
        Year = 1983,
        Description = "Mr. Jelly Belly, a lovable candy character, makes his first public appearance - and it is love at first sight."
      },

      new MileStone
      {
        MileStoneId = 14,
        Year = 1983,
        Description = "Sent by President Ronald Reagan, Jelly Belly jelly beans become the first jelly beans in space!"
      },

      new MileStone
      {
        MileStoneId = 15,
        Year = 1986,
        Description = "New company headquarters are built in Fairfield, California, and factory tours begin soon after."
      },

      new MileStone
      {
        MileStoneId = 16,
        Year = 1989,
        Description = "The Buttered Popcorn flavor is introduced as the world's first 'savory' jelly bean flavor. It is now among the most popular flavors."
      },

      new MileStone
      {
        MileStoneId = 17,
        Year = 1993,
        Description = "Jelly Belly Sours are introduced, a novelty at the time that has since become an enduring favorite."
      },

      new MileStone
      {
        MileStoneId = 18,
        Year = 1996,
        Description = "The ultimate sign of good taste - The Jelly Belly name is stamped on every jelly bean."
      },

      new MileStone
      {
        MileStoneId = 19,
        Year = 2000,
        Description = "Bertie Bott's Every Flavor Beans®, inspired by the Harry Potter series, are brought to life by the company's candy makers in wild flavors like Black Pepper, Dirt, and Earwax."
      },

      new MileStone
      {
        MileStoneId = 20,
        Year = 2001,
        Description = "The Company, known for four generations by the family name Goelitz, is renamed Jelly Belly Candy Company, and continues to make more than 100 fine confections."
      },

      new MileStone
      {
        MileStoneId = 21,
        Year = 2005,
        Description = "Sport Beans® debut. A sports performance jelly bean that provides carb replenishment for athletes."
      },

      new MileStone
      {
        MileStoneId = 22,
        Year = 2008,
        Description = "Offering a flavor experience with wild and wacky flavors, Jelly Belly debuted BeanBoozled jelly beans in 2008 with ten lookalike pairs. Will it be Juicy Pear or Booger? Buttered Popcorn or Rotten Egg? There's only one way to find out!"
      },

      new MileStone
      {
        MileStoneId = 23,
        Year = 2013,
        Description = "Jelly Belly Jewel Collection, featuring Jelly Belly jelly beans with an iridescent sheen, is unveiled."
      },

      new MileStone
      {
        MileStoneId = 24,
        Year = 2020,
        Description = "Jelly Belly heats things with the introduction of the Fiery Five jelly beans."
      }
      );
    }
  }
}