﻿// <auto-generated />
using JellyBellyWikiApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JellyBellyWikiApi.Migrations
{
    [DbContext(typeof(JellyBellyWikiApiContext))]
    partial class JellyBellyWikiApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("JellyBellyWikiApi.Models.Bean", b =>
                {
                    b.Property<int>("BeanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BackgroundColor")
                        .HasColumnType("longtext");

                    b.Property<string>("ColorGroup")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("FlavorName")
                        .HasColumnType("longtext");

                    b.Property<bool>("GlutenFree")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("GroupName")
                        .HasColumnType("longtext");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("Ingredients")
                        .HasColumnType("longtext");

                    b.Property<bool>("Kosher")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Seasonal")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Sku")
                        .HasColumnType("int");

                    b.Property<bool>("SugarFree")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("BeanId");

                    b.ToTable("Beans");

                    b.HasData(
                        new
                        {
                            BeanId = 1,
                            BackgroundColor = "#E1DFE1",
                            ColorGroup = "White",
                            Description = "Experience the delicious taste of buttered popcorn in a bite-sized jelly bean.",
                            FlavorName = "Buttered Popcorn",
                            GlutenFree = false,
                            GroupName = "Jelly Belly Official Flavors",
                            ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/75fea694-ed38-4e84-a86e-182e31ea5a7b",
                            Ingredients = "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% or less of the following: Natural and Artificial Flavors, Color Added, Vegetable and Fruit Juice (Color), Beeswax, Carnauba Wax, Confectioner\\u0027s Glaze.\"]",
                            Kosher = true,
                            Seasonal = false,
                            Sku = 1001,
                            SugarFree = false
                        },
                        new
                        {
                            BeanId = 2,
                            BackgroundColor = "#792E27",
                            ColorGroup = "Brown",
                            Description = "Say 'cheers' with the flavor of this all-American classic drink.",
                            FlavorName = "A&W® Root Beer",
                            GlutenFree = false,
                            GroupName = "Jelly Belly Official Flavors",
                            ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/63b9e71d-9866-4044-9af7-7a64a52b0e0e",
                            Ingredients = "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% or less of the following: Natural and Artificial Flavors, Color Added, Vegetable and Fruit Juice (Color), Beeswax, Carnauba Wax, Confectioner\\u0027s Glaze.\"]",
                            Kosher = false,
                            Seasonal = false,
                            Sku = 1002,
                            SugarFree = false
                        },
                        new
                        {
                            BeanId = 3,
                            BackgroundColor = "#0A9882",
                            ColorGroup = "Blue",
                            Description = "A delicious medley of raspberry, blueberry and strawberry flavors.",
                            FlavorName = "Berry Blue",
                            GlutenFree = false,
                            GroupName = "Jelly Belly Official Flavors",
                            ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/4e65d579-9595-4620-b6c4-a9606df99f3d",
                            Ingredients = "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% or less of the following: Citric Acid. Natural and Artificial Flavor. Color Added. Blue 1, Beeswax. Carnauba Wax. Confectioner\\u0027s Glaze.\"]",
                            Kosher = false,
                            Seasonal = false,
                            Sku = 1003,
                            SugarFree = false
                        },
                        new
                        {
                            BeanId = 4,
                            BackgroundColor = "#3A7195",
                            ColorGroup = "Blue",
                            Description = "Enjoy the taste of fresh-picked blueberries. Deliciously flavored with real blueberry puree.",
                            FlavorName = "Blueberry",
                            GlutenFree = false,
                            GroupName = "Jelly Belly Official Flavors",
                            ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/a8f085b5-b4ff-4aca-8650-43ad54c80fe4",
                            Ingredients = "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Blueberry Juice From Puree\",\"Contains 2% or less of the following: Citric Acid. Natural and Artificial Flavor. Color Added. Blue 1 Lake. Beeswax. Carnauba Wax. Confectioner\\u0027s Glaze.\"]",
                            Kosher = false,
                            Seasonal = false,
                            Sku = 1004,
                            SugarFree = false
                        },
                        new
                        {
                            BeanId = 5,
                            BackgroundColor = "#E3ACBD",
                            ColorGroup = "Pink",
                            Description = " ",
                            FlavorName = "Bubble Gum",
                            GlutenFree = false,
                            GroupName = "Jelly Belly Official Flavors",
                            ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/51474130-73e9-40b7-a8ba-c9eac7be7de4",
                            Ingredients = "[\"Sugar\",\"Corn Syrup\",\"Modified Food Starch\",\"Contains 2% or less of the following: Artificial Flavor. Color Added. Red 40 Lake. Red 40. Yellow 5 Lake. Beeswax. Carnauba Wax. Confectioner\\u0027s Glaze.\"]",
                            Kosher = false,
                            Seasonal = false,
                            Sku = 1005,
                            SugarFree = false
                        });
                });

            modelBuilder.Entity("JellyBellyWikiApi.Models.Fact", b =>
                {
                    b.Property<int>("FactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.HasKey("FactId");

                    b.ToTable("Facts");

                    b.HasData(
                        new
                        {
                            FactId = 1,
                            Description = "Jelly Belly beans gained national attention when they were featured in the White House during the 1980s. President Ronald Reagan was a big fan of Jelly Belly beans, and they became known as the 'President's candy.'.",
                            Title = "Presidential Favorite"
                        },
                        new
                        {
                            FactId = 2,
                            Description = "Jelly Belly is known for its extensive flavor selection, with over 100 different flavors available. Some of the more unusual flavors include Buttered Popcorn, Dr. Pepper, and even Harry Potter-themed flavors like Bertie Bott's Every Flavor Beans.",
                            Title = "Over 100 Flavors"
                        },
                        new
                        {
                            FactId = 3,
                            Description = "Jelly Belly beans have been used to create intricate pieces of art. Artists and enthusiasts have used the beans to make mosaics, portraits, and sculptures.",
                            Title = "Bean Art"
                        },
                        new
                        {
                            FactId = 4,
                            Description = "The Very Cherry flavor was one of the first flavors created by Jelly Belly, and it remains one of the most popular to this day.",
                            Title = "First Flavor"
                        },
                        new
                        {
                            FactId = 5,
                            Description = "Making Jelly Belly beans is a complex process. It involves several stages, including creating the flavor centers, adding the candy shell, and polishing the beans to achieve their signature shine.",
                            Title = "Behind the Scenes"
                        });
                });

            modelBuilder.Entity("JellyBellyWikiApi.Models.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Combination")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("RecipeId");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            RecipeId = 1,
                            Combination = "[\"Very Cherry \\u002B Very Cherry \\u002B Coconut \\u002B Buttered Popcorn \\u002B Cherry Turnover\"]",
                            Name = "Cherry Turnover"
                        },
                        new
                        {
                            RecipeId = 2,
                            Combination = "[\"Green Apple \\u002B Green Apple \\u002B Cinnamon \\u002B Apple Pie\"]",
                            Name = "Apple Pie"
                        },
                        new
                        {
                            RecipeId = 3,
                            Combination = "[\"Top Banana \\u002B Top Banana \\u002B Buttered Popcorn \\u002B Banana Bread\"]",
                            Name = "Banana Bread"
                        },
                        new
                        {
                            RecipeId = 4,
                            Combination = "[\"Top Banana \\u002B Cream Soda \\u002B Coconut \\u002B Banana Cream Pie\"]",
                            Name = "Banana Cream Pie"
                        },
                        new
                        {
                            RecipeId = 5,
                            Combination = "[\"Berry Blu \\u002B Sunkist Lemon \\u002B Berry Lemonade\"]",
                            Name = "Berry Lemonade"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
