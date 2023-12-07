﻿// <auto-generated />
using JellyBellyWikiApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JellyBellyWikiApi.Migrations
{
    [DbContext(typeof(JellyBellyWikiApiContext))]
    [Migration("20231201231501_SeedMockData")]
    partial class SeedMockData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Mixes")
                        .HasColumnType("longtext");

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
                            Ingredients = "Sugar, Corn Syrup, Modified Food Starch, Contains 2% or less of the following: Natural and Artificial Flavors, Color Added, Beeswax, Carnauba Wax, Confectioner's Glaze.",
                            Kosher = true,
                            Mixes = "",
                            Seasonal = false,
                            Sku = 1001,
                            SugarFree = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}