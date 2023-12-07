using JellyBellyWikiApi.Models;
using Microsoft.EntityFrameworkCore;

namespace JellyBellyWikiApi.DataSeeding
{
  public static class BeanSeeder
  {
    public static void Seed(ModelBuilder builder)
    {
      builder.Entity<Bean>().HasData(
        new Bean
        {
          BeanId = 1,
          GroupNameSerialized = "Jelly Belly Official Flavors, Soda Pop Shoppe® Flavors",
          FlavorName = "7Up",
          Description = "The Refreshing And Crisp Flavor Of Lemon Lime Soda.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Citric Acid, Sodium Lactate, Natural & Artificial Flavor, Color Added, Yellow 5, Blue 1, Beeswax, Carnauba Wax, Confectioner'S Glaze"},
          ColorGroup = "khaki",
          BackgroundColor = "#CEDC91",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/ab692677-5471-4863-91a8-659363ae4cc4",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 2,
          GroupNameSerialized = "Jelly Belly Official Flavors, Soda Pop Shoppe® Flavors",
          FlavorName = "A&W® Cream Soda",
          Description = "A Deliciously Creamy Take On The Classic Vanilla Flavor.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural And Artificial Flavors, Color Added, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "gainsboro",
          BackgroundColor = "#E1DFE1",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/75fea694-ed38-4e84-a86e-182e31ea5a7b",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 3,
          GroupNameSerialized = "Jelly Belly Official Flavors, Soda Pop Shoppe® Flavors",
          FlavorName = "A&W® Root Beer",
          Description = "Say 'Cheers' With The Flavor Of This All-American Classic Drink.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural & Artificial Flavors, Color Added, Vegetable & Fruit Juice (Color), Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "saddlebrown",
          BackgroundColor = "#792E27",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/63b9e71d-9866-4044-9af7-7a64a52b0e0e",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 4,
          GroupNameSerialized = "Superfruit Flavors",
          FlavorName = "Acai Berry",
          Description = "Hard To Pronounce But A Delight To Enjoy. A Super Sweet And Rich Berry Taste Unlike Any Other.",
          Ingredients = new [] {"Cane Sugar, Tapioca Syrup, Modified Food Starch, Sour Cherry Juice From Concentrate, Blueberry Juice From Blueberry Puree, Pomegranate Juice From Concentrate, Acai Puree, Natural Flavors, Acerola (Barbados) Cherry Juice, Cranberry Puree, Citric Acid, Apple (Color), Confectioner'S Glaze, Beeswax, Grape Concentrate (Color), Carrot (Color), Carnauba Wax, Black Currant (Color), Hibiscus (Color), Color Added."},
          ColorGroup = "darkslategray",
          BackgroundColor = "#5B3640",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/6f0c6164-71c8-47f6-a55f-893f5fd58fa0",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 5,
          GroupNameSerialized = "Cold Stone® Flavors",
          FlavorName = "Apple Pie A La Cold Stone®",
          Description = "A Creamy Combination Of French Vanilla, Apple Pie, And Caramel Flavors Adds A Sweet Twist To The Classic American Dessert.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Strawberry Puree, Chocolate Liquor, Cocoa Butter, Cocoa Powder, Citric Acid, Ground Cinnamon, Tapioca Dextrin, Natural And Artificial Flavor, Color Added, Red 40 Lake, Yellow 5 & 6 Lake, Red 40, Blue 1 & 2 Lake, Blue 1, Yellow 5, Beeswax, Carnauba Wax, Confectioner'S Glaze, Salt."},
          ColorGroup = "burlywood",
          BackgroundColor = "#F0C57F",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/81f5ecb8-250b-403f-a1bf-89fb6e47dd0d",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 6,
          GroupNameSerialized = "Superfruit Flavors",
          FlavorName = "Barbados Cherry",
          Description = "A Sweet Cherry Flavor With Just A Hint Of Tartness.",
          Ingredients = new [] {"Cane Sugar, Tapioca Syrup, Modified Food Starch, Sour Cherry Juice From Concentrate, Blueberry Juice From Blueberry Puree, Pomegranate Juice From Concentrate, Acai Puree, Natural Flavors, Acerola (Barbados) Cherry Juice, Cranberry Puree, Citric Acid, Apple (Color), Confectioner'S Glaze, Beeswax, Grape Concentrate (Color), Carrot (Color), Carnauba Wax, Black Currant (Color), Hibiscus (Color), Color Added."},
          ColorGroup = "lightpink",
          BackgroundColor = "#E798AB",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/168244d0-b3ba-4725-a2d9-5083b362d10a",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 7,
          GroupNameSerialized = "Jelly Belly Official Flavors",
          FlavorName = "Blueberry",
          Description = "Enjoy The Taste Of Fresh-Picked Blueberries. Deliciously Flavored With Real Blueberry Puree.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Blueberry Juice From Puree, Contains 2% Or Less Of The Following: Citric Acid, Natural & Artificial Flavor, Color Added, Blue 1 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "steelblue",
          BackgroundColor = "#3A7195",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/a8f085b5-b4ff-4aca-8650-43ad54c80fe4",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 8,
          GroupNameSerialized = "Jelly Belly Official Flavors, Kids Mix Flavors",
          FlavorName = "Bubble Gum",
          Description = "This Bean Has Everything But The Bubble! Taking A Trip Down Memory Lane Has Never Tasted So Good.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Artificial Flavor, Color Added, Red 40 Lake, Red 40, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "lightpink",
          BackgroundColor = "#E3ACBD",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/51474130-73e9-40b7-a8ba-c9eac7be7de4",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 9,
          GroupNameSerialized = "Jelly Belly Official Flavors, Kids Mix Flavors",
          FlavorName = "Buttered Popcorn",
          Description = "Now You Can Enjoy Buttery Perfection Without Having To Go To The Movies.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural And Artificial Flavors, Color Added, Yellow 5, Beeswax, Carnauba Wax, Confectioner'S Glaze, Salt."},
          ColorGroup = "gold",
          BackgroundColor = "#F6D334",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/61207309-fffb-443a-b735-b9a5a6374c8d",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 10,
          GroupNameSerialized = "Jelly Belly Official Flavors, Tropical Mix Flavors",
          FlavorName = "Cantaloupe",
          Description = "This Sweet Summertime Favorite Is Always In Season.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Cantaloupe Juice From Cantaloupe Powder, Contains 2% Or Less Of The Following: Natural And Artificial Flavors, Color Added, Yellow 6 Lake, Yellow 6, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "goldenrod",
          BackgroundColor = "#FAA538",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/45d0972c-e554-4374-8b21-ac50ff450d3e",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 11,
          GroupNameSerialized = "Jelly Belly Official Flavors",
          FlavorName = "Cappuccino",
          Description = "The Rich And Creamy Taste Of Cappuccino. So 'Delicioso' Because Each Is Flavored With Real Coffee.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural And Artificial Flavors, Coffee, Color Added, Vegetable And Fruit Juice (Color), Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "saddlebrown",
          BackgroundColor = "#5A262A",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/ca2fe8be-4c41-4e83-81df-cf3b093f5a42",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 12,
          GroupNameSerialized = "Jelly Belly Official Flavors",
          FlavorName = "Caramel Corn",
          Description = "A Partnership Made In Heaven. Sweet Caramel And Buttery Popcorn.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural And Artificial Flavors, Color Added, Yellow 6, Yellow 5 & 6 Lake, Blue 2 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze, Salt."},
          ColorGroup = "burlywood",
          BackgroundColor = "#F0C57F",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/aff9adae-5dde-4e5b-b718-a68d7ed8edf2",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 13,
          GroupNameSerialized = "Superfruit Flavors, Kids Mix Flavors",
          FlavorName = "Blueberry",
          Description = "Enjoy The Taste Of Fresh-Picked Blueberries. Deliciously Flavored With Real Blueberry Puree.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Blueberry Juice From Puree, Contains 2% Or Less Of The Following: Citric Acid, Natural & Artificial Flavor, Color Added, Blue 1 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "steelblue",
          BackgroundColor = "#3A7195",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/4ee93e6c-c132-47ab-a748-b9663251b14e",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 14,
          GroupNameSerialized = "Cold Stone® Flavors",
          FlavorName = "Chocolate Devotion®",
          Description = "Rich Chocolate Taste That Will Bring You To Your Happy Place. Flavored With Real Cocoa Powder For An Indulgent Treat.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Strawberry Puree, Chocolate Liquor, Cocoa Butter, Cocoa Powder, Citric Acid, Ground Cinnamon, Tapioca Dextrin, Natural And Artificial Flavor, Color Added, Red 40 Lake, Yellow 5 & 6 Lake, Red 40, Blue 1 & 2 Lake, Blue 1, Yellow 5, Beeswax, Carnauba Wax, Confectioner'S Glaze, Salt."},
          ColorGroup = "saddlebrown",
          BackgroundColor = "#792E27",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/f7cc6aee-9e70-466f-8d5a-a173b4a42275",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 15,
          GroupNameSerialized = "Jelly Belly Official Flavors",
          FlavorName = "Chocolate Pudding",
          Description = "A Creamy, Chocolatey Tasting Delight Flavored With Real Cocoa Powder. No Spoon Required.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Cocoa Powder, Chocolate Liquor, Cocoa Butter, Natural And Artificial Flavor, Color Added, Red 40 Lake, Yellow 5 Lake, Blue 2 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "darkslategray",
          BackgroundColor = "#402427",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/63b9e71d-9866-4044-9af7-7a64a52b0e0e",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 16,
          GroupNameSerialized = "Jelly Belly Official Flavors",
          FlavorName = "Cinnamon",
          Description = "The Perfect Combination Of Sugar And Spice. These Beans Have Just The Right Amount Of Cinnamon To Make Them A Sweet Treat For All.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Artificial Flavor, Color Added, Red 40, Red 40 Lake, Turmeric (Color), Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "indianred",
          BackgroundColor = "#DD4B62",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/18e50750-75eb-4f26-b8ed-1c01db69f3d3",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 17,
          GroupNameSerialized = "Krispy Kreme® Doughnuts Flavors",
          FlavorName = "Cinnamon Apple Filled",
          Description = "The Perfect Combination Of A Classic Glazed Donut And Sweet Apple Filling. Flavored With Real Apple Juice.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Apple Juice Concentrate, Citric Acid, Cocoa Powder, Natural & Artificial Flavors, Color Added, Red 40 Lake, Yellow 5 & 6 Lake, Blue 1 & 2 Lake, Red 40, Vegetable And Fruit Juice (Color), Tapioca Dextrin, Beeswax, Carnauba Wax, Confectioner'S Glaze, Ground Cinnamon, Salt."},
          ColorGroup = "peru",
          BackgroundColor = "#ba815c",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/1477c8aa-1320-45a1-b5a0-2fe90bdcc7f3",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 18,
          GroupNameSerialized = "Jelly Belly Official Flavors, Tropical Mix Flavors",
          FlavorName = "Coconut",
          Description = "Take A Quick Trip To The Tropics With The Taste Of Real Coconut.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Coconut, Artificial Flavor, Color Added, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "gainsboro",
          BackgroundColor = "#E1DFE1",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/ad4638c8-b778-4248-afca-7c3051c8f92f",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 19,
          GroupNameSerialized = "Jelly Belly Official Flavors, Kids Mix Flavors",
          FlavorName = "Cotton Candy",
          Description = "A Sweet Taste From Your Childhood That Will Bring A Smile To Your Face.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Citric Acid, Natural And Artificial Flavor, Color Added, Red 40, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "tan",
          BackgroundColor = "#E19E9F",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/0066a0a9-88cc-4b1f-bacc-5db4fffdbc38",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 20,
          GroupNameSerialized = "Superfruit Flavors",
          FlavorName = "Cranberry",
          Description = "Not Too Tart And Not Too Sweet. This Berry Flavor Definitely Has The Perfect Balance.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Cranberry Puree, Natural Flavor, Color Added, Red 40 Lake, Blue 2 Lake, Turmeric (Color), Citric Acid, Confectioner'S Glaze, Beeswax, Carnauba Wax."},
          ColorGroup = "brown",
          BackgroundColor = "#871922",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/c2909d75-8d0c-4629-b086-8ad2b43b3ac7",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 21,
          GroupNameSerialized = "Snapple® Mix Flavors",
          FlavorName = "Cranberry Raspberry",
          Description = "This Delicious Berry Flavor From Snapple® Packed Into A Jelly Bean For A Sweet Treat.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Cranberry Puree, Raspberry Puree, Grape Juice Concentrate, Mango Juice Concentrate, Strawberry Juice Concentrate, Kiwi Juice Concentrate, Lemon Puree, Cherry Juice Concentrate, Cranberry Juice Concentrate, Natural Flavors, Citric Acid, Color Added, Grape Concentrate (Color), Turmeric (Color), Apple (Color), Hibiscus (Color), Black Currant (Color), Carrot (Color), Confectioner'S Glaze, Beeswax, Carnauba Wax."},
          ColorGroup = "indianred",
          BackgroundColor = "#DD4B62",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/3100bc6f-a543-4795-8acb-0d1bfe76a188",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 22,
          GroupNameSerialized = "Jelly Belly Official Flavors, Tropical Mix Flavors",
          FlavorName = "Crushed Pineapple",
          Description = "Like A Private Island For Your Taste Buds. Flavored With Real Pineapple Juice For Sweet Tropical Goodness.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Pineapple Juice From Concentrate, Contains 2% Or Less Of The Following: Citric Acid, Artificial Flavor, Color Added, Yellow 5, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "khaki",
          BackgroundColor = "#FADF50",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/f8683af4-2326-4d12-a477-1d6f2afd6652",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 23,
          GroupNameSerialized = "Jelly Belly Official Flavors, Soda Pop Shoppe® Flavors",
          FlavorName = "Dr Pepper®",
          Description = "There'S Nothing Like A Dr Pepper. The Soda With A Signature Blend Of 23 Flavors Packed Into A Jelly Bean.",
          Ingredients = new [] {"Ingredients: Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Sodium Citrate, Phosphoric Acid, Natural And Artificial Flavor, Color Added, Red 40 Lake, Blue 2 Lake, Red 40, Yellow 5 Lake, Vegetable & Fruit Juice (Color), Beeswax, Carnauba Wax, Confectioner'S Glaze, Caffeine."},
          ColorGroup = "darkslategray",
          BackgroundColor = "#5B3640",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/cea8f58e-5cd9-4aa7-aa30-9f24c6360508",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 24,
          GroupNameSerialized = "Jelly Belly Official Flavors",
          FlavorName = "French Vanilla",
          Description = "A Jelly Bean That Tastes Just Like A Vanilla Bean.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Vanilla Beans, Natural And Artificial Flavors, Color Added, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "lightgray",
          BackgroundColor = "#D2D0CE",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/3e8e01cb-f2a8-4121-ab59-b0a608ad5a92",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 25,
          GroupNameSerialized = "Cocktail Classics® Flavors",
          FlavorName = "Gin & Tonic",
          Description = "Zesty And Bittersweet With Hints Of Elderberry And Lime.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural & Artificial Flavors, Color Added, Blue 1 Lake, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze, Tapioca Dextrin."},
          ColorGroup = "lightgray",
          BackgroundColor = "#CED8C2",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/43a9c3a6-6f8c-44e4-a80b-df041f725fe4",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 26,
          GroupNameSerialized = "Krispy Kreme® Doughnuts Flavors",
          FlavorName = "Glazed Blueberry Cake",
          Description = "Enjoy The Oven-Baked Like Taste Of Blueberry Cake Without The Crumbs!",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Apple Juice Concentrate, Citric Acid, Cocoa Powder, Natural & Artificial Flavors, Color Added, Red 40 Lake, Yellow 5 & 6 Lake, Blue 1 & 2 Lake, Red 40, Vegetable And Fruit Juice (Color), Tapioca Dextrin, Beeswax, Carnauba Wax, Confectioner'S Glaze, Ground Cinnamon, Salt."},
          ColorGroup = "sienna",
          BackgroundColor = "#91484c",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/e2d439f7-eee7-47b4-8b84-47c3ff8afbc7",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 27,
          GroupNameSerialized = "Soda Pop Shoppe® Flavors",
          FlavorName = "Grape Crush",
          Description = "A Sweet Grape Flavor With An Exciting Rush Of Fun And Flavor In Every Bean.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Citric Acid, Sodium Lactate, Tartaric Acid, Grape Juice Concentrate, Acacia Gum, Natural & Artificial Flavor, Color Added, Red 40, Blue 1, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "darkslategray",
          BackgroundColor = "#553E5C",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/64e1b48e-8989-4ec3-be34-f19a95ffc864",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 28,
          GroupNameSerialized = "Jelly Belly Official Flavors, Kids Mix Flavors, , Tropical Mix Flavors",
          FlavorName = "Green Apple",
          Description = "Tart And Crisp Flavor Made From Real Apple Juice.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Apple Juice From Concentrate, Contains 2% Or Less Of The Following: Citric Acid, Artificial Flavor, Color Added, Yellow 5, Blue 1, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "forestgreen",
          BackgroundColor = "#0E7534",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/5b0694eb-f83b-4bc2-a78e-0b48d5bfcd0e",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 29,
          GroupNameSerialized = "Jelly Belly Official Flavors, Tropical Mix Flavors",
          FlavorName = "Island Punch",
          Description = "Take Your Taste Buds To A Tropical Island Paradise. Expertly Flavored With A Blend Of Juices From Real Fruits.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Passion Fruit Juice From Concentrate, Contains 2% Or Less Of The Following: Citric Acid, Natural & Artificial Flavor, Color Added, Blue 1 & 2 Lake, Blue 1 & 2, Red 40 Lake, Red 40, Yellow 5 Lake, Yellow 5, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "dimgray",
          BackgroundColor = "#4F657C",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/2b66c2e0-5c3d-47da-bf51-acebb5e41d96",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 30,
          GroupNameSerialized = "Jelly Belly Official Flavors ,Tropical Mix Flavors, Kids Mix Flavors",
          FlavorName = "Berry Blue",
          Description = "A Delicious Medley Of Raspberry, Blueberry And Strawberry Flavors.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Citric Acid, Natural & Artificial Flavor, Color Added, Blue 1, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "teal",
          BackgroundColor = "#00798B",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/80249b46-c082-4de5-b654-64c904d7ea31",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 31,
          GroupNameSerialized = "Jewel Jelly Beans Flavors",
          FlavorName = "Jewel Blueberry",
          Description = "A Beautifully Sparkling Bean Flavored With Real Blueberry Puree For A Taste That Bursts With Flavor.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Blueberry Juice From Puree, Contains 2% Or Less Of The Following: Citric Acid, Natural & Artificial Flavor, Color Added, Blue 1 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "darkslategray",
          BackgroundColor = "#293656",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/cdd532da-3ece-4bd6-a3f7-14b543756939",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 32,
          GroupNameSerialized = "Jewel Jelly Beans Flavors",
          FlavorName = "Jewel Bubble Gum",
          Description = "This Sparkly Bean Has Everything But The Bubble! Taking A Trip Down Memory Lane Has Never Tasted So Good.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Artificial Flavor, Color Added, Red 40 Lake, Red 40, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "rosybrown",
          BackgroundColor = "#CD8784",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/03fdb902-86ed-43fa-9f8b-0e5a30ceb975",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 33,
          GroupNameSerialized = "Jewel Jelly Beans Flavors",
          FlavorName = "Jewel Champagne",
          Description = "Ready To Toast To Any Occasion With A Classy Irridescent Finish, This Bean Contains All The Flavour Of A Glass Of Bubbly Without Any Of The Alcohol.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural & Artificial Flavors, Citric Acid, Color Added, Maltodextrin, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "wheat",
          BackgroundColor = "#E9CCAD",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/e2145438-c107-4b94-a76d-6ba1e047c414",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 34,
          GroupNameSerialized = "Jewel Jelly Beans Flavors",
          FlavorName = "Jewel Cream Soda",
          Description = "Creamy And Smooth Taste With A Special Sparkle That Makes This Bean Shine.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural And Artificial Flavors, Color Added, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "gainsboro",
          BackgroundColor = "#E5DCD5",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/c7d4188a-d542-445d-b1a8-a40fd64a9c82",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 35,
          GroupNameSerialized = "Jewel Jelly Beans Flavors",
          FlavorName = "Jewel Ginger Ale",
          Description = "Includes A Fizzy Sensation With Just The Right Blend Of Flavours. Perfect To Enjoy On Its Own Or Mixed With Other Flavours.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural And Artificial Flavors, Citric Acid, Color Added, Yellow 5, Red 40, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "saddlebrown",
          BackgroundColor = "#602825",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/48c985a0-b84a-4c10-932f-0851cab8c803",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 36,
          GroupNameSerialized = "Jewel Jelly Beans Flavors",
          FlavorName = "Jewel Grape Soda",
          Description = "You Just Picked A Winner! Flavourings Of Real Grape Juice Give It A Fresh From The Vine Taste.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Citric Acid, Sodium Lactate, Tartaric Acid, Grape Juice Concentrate, Gum Arabic, Natural & Artificial Flavor, Vegetable & Fruit Juice (Color), Color Added, Red 40, Blue 1, Beeswax, Carnauba Wax, Confectioner'S Glaze"},
          ColorGroup = "steelblue",
          BackgroundColor = "#3D7889",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/b0d69aca-6114-46ab-80a1-0c9ad46187ed",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 37,
          GroupNameSerialized = "Jewel Jelly Beans Flavors",
          FlavorName = "Jewel Orange",
          Description = "A Beautifully Sparkling Citrus Treat Flavored With Real Orange Puree.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Orange Juice From Orange Puree, 2% Or Less Of The Following: Citric Acid, Sodium Lactate, Natural Flavor, Color Added, Yellow 6, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "sandybrown",
          BackgroundColor = "#FCB76C",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/079a2eb5-6c13-456c-8d7e-9d4fe7b2c85b",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 38,
          GroupNameSerialized = "Jewel Jelly Beans Flavors, Sours Flavors",
          FlavorName = "Jewel Sour Apple",
          Description = "So Shiny, So Tart. Flavored With Real Apple Juice.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Apple Juice From Concentrate, Contains 2% Or Less Of The Following: Citric Acid, Fumaric Acid, Sodium Lactate, Sodium Citrate, Artificial Flavor, Color Added, Yellow 5, Yellow 5 Lake, Blue 1, Blue 1 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "forestgreen",
          BackgroundColor = "#2B9B39",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/7fcbe714-3501-415c-af4f-9d815bcf09f9",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 39,
          GroupNameSerialized = "Jewel Jelly Beans Flavors, Sours Flavors",
          FlavorName = "Jewel Sour Lemon",
          Description = "A Shiny Bean That Packs Some Serious Pucker Power. Flavored With Real Lemon Puree To Deliver A Tasty Tartness.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Lemon Juice From Puree, Contains 2% Or Less Of The Following: Citric Acid, Fumaric Acid, Sodium Lactate, Sodium Citrate, Natural Flavor, Color Added, Yellow 5, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "goldenrod",
          BackgroundColor = "#D6BA03",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/4bfae66c-e08a-4f33-a6c8-6e126927c6e9",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 40,
          GroupNameSerialized = "Jewel Jelly Beans Flavors",
          FlavorName = "Jewel Very Cherry",
          Description = "This Bean Sparkles Like A Ruby And Is Made With Real Cherry Juice To Burst With Flavor.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Cherry Juice From Concentrate, Contains 2% Or Less Of The Following: Citric Acid, Artificial Flavor, Color Added, Red 40, Red 40 Lake, Turmeric (Color), Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "indianred",
          BackgroundColor = "#9C4B6F",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/92cdbdb8-d760-4cb0-8c52-c99f3c46573c",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 41,
          GroupNameSerialized = "Jelly Belly Official Flavors",
          FlavorName = "Juicy Pear",
          Description = "With Just One Bite, It'S Easy To See Why It'S Called Juicy Pear. The Fresh Sweet Taste Comes From Flavorings Of Real Pear.",
          Ingredients = new [] {"Sugar, Glucose Syrup, Modified Cornstarch, Pear Juice Concentrate, Flavouring, Acidity Regulator (E330), Glazing Agents (E901, E903, E904), Colours (E100, E171), Fruit And Vegetable Concentrates (Carrot, Pumpkin, Spirulina, Apple, Hibiscus), Tapioca Dextrin."},
          ColorGroup = "yellowgreen",
          BackgroundColor = "#AAAE45",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/40f80743-d4a1-4350-84db-c7b6d2e21217",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 42,
          GroupNameSerialized = "Jelly Belly Official Flavors, Tropical Mix Flavors",
          FlavorName = "Kiwi",
          Description = "A Sweet And Exotic Taste Made With Flavorings Of Real Kiwifruit.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Kiwi Juice From Concentrate, Contains 2% Or Less Of The Following: Natural And Artificial Flavor, Color Added, Yellow 5, Blue 1, Citric Acid, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "yellowgreen",
          BackgroundColor = "#8EBF14",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/652b2681-d41e-4ca3-907d-3020935e7a3c",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 43,
          GroupNameSerialized = "Snapple® Mix Flavors",
          FlavorName = "Kiwi Strawberry",
          Description = "The Iconic Blend Of Tangy Kiwi And Sweet Strawberry Made Famous By Snapple® In The Form Of A Jelly Bean.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Cranberry Puree, Raspberry Puree, Grape Juice Concentrate, Mango Juice Concentrate, Strawberry Juice Concentrate, Kiwi Juice Concentrate, Lemon Puree, Cherry Juice Concentrate, Cranberry Juice Concentrate, Natural Flavors, Citric Acid, Color Added, Grape Concentrate (Color), Turmeric (Color), Apple (Color), Hibiscus (Color), Black Currant (Color), Carrot (Color), Confectioner'S Glaze, Beeswax, Carnauba Wax."},
          ColorGroup = "indianred",
          BackgroundColor = "#DD4B62",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/6fc6faa5-8377-44c5-a889-da4c567a2fde",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 44,
          GroupNameSerialized = "Jelly Belly Official Flavors, Kids Mix Flavors, Sunkist® Citrus Mix Flavors, Tropical Mix Flavors",
          FlavorName = "Sunkist® Lemon",
          Description = "The Perfect Amount Of Pucker. Real Lemon Flavorings Give These Beans Their Tasty Tartness.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Lemon Juice From Puree, 2% Or Less Of The Following: Sodium Lactate, Citric Acid, Natural Flavor, Color Added, Yellow 5, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "indianred",
          BackgroundColor = "#DD4B62",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/93aa8039-d6f6-4d33-8562-4d250bc60ad3",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 45,
          GroupNameSerialized = "Jelly Belly Official Flavors",
          FlavorName = "Mandarin Orange Mango Smoothie",
          Description = "Mix It Up With This Citrusy Sweet Blend. Flavored With Real Orange Puree.",
          Ingredients = new [] {"Sugars (Sugar, Corn Syrup, Orange Puree), Modified Corn Starch, Citric Acid, Flavors, Titanium Dioxide, Shellac, Sodium Citrate, Beeswax, Carnauba Wax, Tartrazine, Sunset Yellow Fcf, Allura Red."},
          ColorGroup = "indianred",
          BackgroundColor = "#DD4B62",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/5f0240a3-f7ee-401f-8d52-06e04b81cd29",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 46,
          GroupNameSerialized = "Jelly Belly Official Flavors, Tropical Mix Flavors",
          FlavorName = "Mango",
          Description = "Fresh And Sweet. Tropical Island Goodness Flavored With Real Mango Puree.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Mango Juice From Puree, Mango Juice From Concentrate, Contains 2% Or Less Of The Following: Citric Acid, Sodium Lactate, Sodium Citrate, Natural & Artificial Flavor, Color Added, Yellow 5 Lake, Yellow 5, Blue 1 Lake, Blue 1, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "goldenrod",
          BackgroundColor = "#D1CA3D",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/f885e029-ed2f-4828-a861-a2ca203fda3d",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 47,
          GroupNameSerialized = "Snapple® Mix Flavors",
          FlavorName = "Mango Madness",
          Description = "Go Mad For This Sweet, Fruity, And Delicious Mango Flavor From Snapple®.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Cranberry Puree, Raspberry Puree, Grape Juice Concentrate, Mango Juice Concentrate, Strawberry Juice Concentrate, Kiwi Juice Concentrate, Lemon Puree, Cherry Juice Concentrate, Cranberry Juice Concentrate, Natural Flavors, Citric Acid, Color Added, Grape Concentrate (Color), Turmeric (Color), Apple (Color), Hibiscus (Color), Black Currant (Color), Carrot (Color), Confectioner'S Glaze, Beeswax, Carnauba Wax."},
          ColorGroup = "goldenrod",
          BackgroundColor = "#F99B25",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/26cd4116-6409-41aa-87bc-fa60c1e4712f",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 48,
          GroupNameSerialized = "Boba Milk Tea Flavors",
          FlavorName = "Mango Milk Tea",
          Description = "A Tropical Treat With A Bubbly Twist. This Fruity Delight Tastes Just Like Your Favorite Boba Milk Tea Drink.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Fruit And Vegetable Juice (Color), Citric Acid, Confectioner'S Glaze, Beeswax, Carnauba Wax, Natural And Artificial Flavors, Salt, Color Added, Yellow 5 Lake."},
          ColorGroup = "burlywood",
          BackgroundColor = "#EBC669",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/e3183e7b-32e2-4912-b439-e3070b00354b",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 49,
          GroupNameSerialized = "Jelly Belly Official Flavors, Cocktail Classics® Flavors",
          FlavorName = "Margarita",
          Description = "No Tequila Required. Made With A Twist Of Lime Juice.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Lemon Juice From Puree, Contains 2% Or Less Of The Following: Natural And Artificial Flavors, Citric Acid, Sodium Citrate, Color Added, Yellow 5, Blue 1, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "yellowgreen",
          BackgroundColor = "#7EB159",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/de15af51-3c70-4ecc-aa08-0421d2f8b9a6",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 50,
          GroupNameSerialized = "Boba Milk Tea Flavors",
          FlavorName = "Matcha Milk Tea",
          Description = "Savor The Perfect Blend Of Matcha Milk Tea And Tapioca Pearls In Every Bite.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Spirulina Extract (Color), Turmeric (Color), Confectioner'S Glaze, Beeswax, Carnauba Wax, Natural And Artificial Flavors, Salt, Color Added."},
          ColorGroup = "khaki",
          BackgroundColor = "#C2E189",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/bb22db94-1576-444c-9d5c-5654760b63dc",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 51,
          GroupNameSerialized = "Cocktail Classics® Flavors",
          FlavorName = "Mimosa",
          Description = "A Sophisticated Combination Of Champagne And Orange Juice. There'S No Bubbly, But Each Is Deliciously Flavored With Real Orange Puree.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Orange Puree, Natural & Artificial Flavors, Citric Acid, Sodium Lactate, Color Added, Yellow 6, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "peru",
          BackgroundColor = "#D48840",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/62223645-ae3e-4235-ae61-49ccfb736a20",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 52,
          GroupNameSerialized = "Cold Stone® Flavors",
          FlavorName = "Mint Chocolate Chip®",
          Description = "A Delicious Combination Of Chocolate And Mint Flavor In Every Bean.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Cocoa Powder, Dark Chocolate (Sugar, Chocolate Liquor, Cocoa Butter), Natural & Artificial Flavors, Color Added, Yellow 5 Lake, Blue 1 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze, Tapioca Dextrin, Salt."},
          ColorGroup = "darkseagreen",
          BackgroundColor = "#83AD5C",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/47c39487-4faa-4dc1-8b58-3b18e2de6a43",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 53,
          GroupNameSerialized = "Jelly Belly Official Flavors",
          FlavorName = "Mixed Berry Smoothie",
          Description = "A Delightful Mix Of Creamy Berry Flavors. No Blender Required.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Blueberry Juice From Puree, Contains 2% Or Less Of The Following: Natural & Artificial Flavors, Color Added, Red 40, Red 40 Lake, Blue 1, Blue 2 Lake, Yellow 5 Lake, Citric Acid, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "darkgray",
          BackgroundColor = "#B598AF",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/6671ca61-29e4-4c6c-9a5a-f0b161e8cabd",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 54,
          GroupNameSerialized = "Cocktail Classics® Flavors",
          FlavorName = "Mojito",
          Description = "Sit Back And Enjoy The Refreshing Taste Of Mint And Lime Without Any Of The Alcohol.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Lemon Puree, Lime Juice Concentrate, Peach Puree Concentrate, Pomegranate Juice Concentrate, Strawberry Puree, Coconut, Natural & Artificial Flavors, Citric Acid, Sodium Lactate, Sodium Citrate, Color Added, Red 40 Lake, Red 40, Yellow 5 & 6, Yellow 5 & 6 Lake, Blue 1, Blue 1 Lake, Grape Skin Extract (Color), Beeswax, Carnauba Wax, Confectioner'S Glaze, Tapioca Dextrin."},
          ColorGroup = "seagreen",
          BackgroundColor = "#03ad50",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/ae599b54-6174-4fc2-bc8c-4fd4be9575da",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 55,
          GroupNameSerialized = "Cocktail Classics® Flavors",
          FlavorName = "Moscow Mule",
          Description = "Complete With A Copper Finish, This Bean Tastes Like The Iconic Cocktail Without The Distilled Spirit.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural & Artificial Flavors, Citric Acid, Color Added, Yellow 5, Red 40, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "peru",
          BackgroundColor = "#AD7E47",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/d2511937-9cf5-4f2a-918e-e793fe314a43",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 56,
          GroupNameSerialized = "Soda Pop Shoppe® Flavors",
          FlavorName = "Orange Crush",
          Description = "The Iconic Orange Soda Flavor That Offers A Refreshingly Sweet Escape On A Warm Afternoon.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Acacia Gum, Citric Acid, Sodium Lactate, Natural & Artificial Flavor, Color Added, Yellow 5 & 6, Red 40, Beeswax, Carnauba Wax, Confectioner'S Glaze, Salt."},
          ColorGroup = "sandybrown",
          BackgroundColor = "#F6A763",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/01716593-31a1-42ae-b31e-fb9bee03aefa",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 57,
          GroupNameSerialized = "Jelly Belly Official Flavors, Kids Mix Flavors",
          FlavorName = "Orange Sherbet",
          Description = "The Light And Refreshing Combination Of Sweet Orange And Smooth Cream Flavors. Made Possible With Real Orange Puree. No Freezer Required.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Orange Juice From Puree, Contains 2% Or Less Of The Following: Citric Acid, Natural And Artificial Flavors, Color Added, Yellow 6 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "lightsalmon",
          BackgroundColor = "#F79C72",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/4c7cc562-717a-4633-885a-d02c71cd0f4f",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 58,
          GroupNameSerialized = "Krispy Kreme® Doughnuts Flavors",
          FlavorName = "Original Glazed®",
          Description = "The Perfectly Sweet Flavor Everyone Loves To Wake Up To.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Apple Juice Concentrate, Citric Acid, Cocoa Powder, Natural & Artificial Flavors, Color Added, Red 40 Lake, Yellow 5 & 6 Lake, Blue 1 & 2 Lake, Red 40, Vegetable And Fruit Juice (Color), Tapioca Dextrin, Beeswax, Carnauba Wax, Confectioner'S Glaze, Ground Cinnamon, Salt."},
          ColorGroup = "peru",
          BackgroundColor = "#c2864b",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/c826460c-e441-48b1-9582-19bfe677265d",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 59,
          GroupNameSerialized = "Cold Stone® Flavors",
          FlavorName = "Our Strawberry Blonde®",
          Description = "Enjoy A Scoop Of Everyone'S Summertime Favorite. Flavored With Real Strawberry Puree For A Fresh Fruit Taste.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Strawberry Puree, Chocolate Liquor, Cocoa Butter, Cocoa Powder, Citric Acid, Ground Cinnamon, Tapioca Dextrin, Natural And Artificial Flavor, Color Added, Red 40 Lake, Yellow 5 & 6 Lake, Red 40, Blue 1 & 2 Lake, Blue 1, Yellow 5, Beeswax, Carnauba Wax, Confectioner'S Glaze, Salt."},
          ColorGroup = "crimson",
          BackgroundColor = "#c4293e",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/54f01786-0de0-4b6b-b2ac-daa2116c7ffb",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 60,
          GroupNameSerialized = "Jelly Belly Official Flavors, Kids Mix Flavors, Tropical Mix Flavors",
          FlavorName = "Peach",
          Description = "The Luscious And Ripe Taste Of Summer. Flavored With Real Peach Puree.",
          Ingredients = new [] {"Sugar, Corn Syrup, Peach Juice From Puree Concentrate, Modified Food Starch, Contains 2% Or Less Of The Following: Citric Acid, Sodium Citrate, Natural And Artificial Flavor, Color Added, Yellow 5, Yellow 5 Lake, Red 40 Lake, Red 40, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "peru",
          BackgroundColor = "#EB8435",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/c75fe96b-333c-420d-869b-6fba2486a914",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 61,
          GroupNameSerialized = "",
          FlavorName = "Pineapple Pear Smoothie",
          Description = "Smooth & Creamy With Just A Hint Of Tartness. Flavoured With Real Pear And Pineapple Juices.",
          Ingredients = new [] {"Sugar, Glucose Syrup, Modified Cornstarch, Pear Juice Concentrate, Flavourings, Colours (E100, E171), Acidity Regulator (E330), Glazing Agents (E901, E903, E904), Vegetable Concentrate (Spirulina)."},
          ColorGroup = "khaki",
          BackgroundColor = "#EFE393",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/cb895cb6-1fa4-4327-97fe-0d2c043788d7",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 62,
          GroupNameSerialized = "Snapple® Mix Flavors",
          FlavorName = "Pink Lemonade",
          Description = "All Pink With A Flavor That Is Tart, Tangy, And Lemony.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Cranberry Puree, Raspberry Puree, Grape Juice Concentrate, Mango Juice Concentrate, Strawberry Juice Concentrate, Kiwi Juice Concentrate, Lemon Puree, Cherry Juice Concentrate, Cranberry Juice Concentrate, Natural Flavors, Citric Acid, Color Added, Grape Concentrate (Color), Turmeric (Color), Apple (Color), Hibiscus (Color), Black Currant (Color), Carrot (Color), Confectioner'S Glaze, Beeswax, Carnauba Wax."},
          ColorGroup = "indianred",
          BackgroundColor = "#da566a",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/64c8a21f-56d6-4e15-ada5-73530ca410f4",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 63,
          GroupNameSerialized = "Cocktail Classics® Flavors, Tropical Mix Flavors",
          FlavorName = "Piñ1A Colada",
          Description = "Smooth & Creamy With Just A Hint Of Tartness. Flavored With Real Pear And Pineapple Juices.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Coconut, Citric Acid, Artificial Flavors, Color Added, Yellow 5, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "yellowgreen",
          BackgroundColor = "#7EB159",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/653fa358-460d-4883-8aab-5b8ca7d67cf0",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 64,
          GroupNameSerialized = "Jelly Belly Official Flavors",
          FlavorName = "Plum",
          Description = "Sweet And Ripe. Flavoured With Real Plum Juice To Give It A Freshly Picked Taste.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Plum Juice From Concentrate, Contains 2% Or Less Of The Following: Natural And Artificial Flavors, Citric Acid, Sodium Citrate, Color Added, Red 40 Lake, Blue 1 & 2 Lake, Yellow 6 Lake, Red 40, Yellow 5, Blue 1, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "darkslategray",
          BackgroundColor = "#293656",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/6a268368-578b-4118-b664-48df18dfe32b",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 65,
          GroupNameSerialized = "Jelly Belly Official Flavors, Superfruit Flavors",
          FlavorName = "Pomegranate",
          Description = "Perfectly Tart And Sweet But Without The Seeds. Flavored With Real Pomegranate Juice.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Pomegranate Juice Concentrate, Natural & Artificial Flavor, Citric Acid, Sodium Lactate, Sodium Citrate, Color Added, Red 40, Red 40 Lake, Blue 2 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "indianred",
          BackgroundColor = "#DD4B62",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/6cef85fd-9273-4490-bf69-6448d361adc7",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 66,
          GroupNameSerialized = "",
          FlavorName = "Pomegranate Cosmo",
          Description = "The Ultimate In Chic Drinks. Contains The Same Robust And Refreshing Taste As The Classic Cocktail Without Any Of The Alcohol.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Lemon Puree, Lime Juice Concentrate, Peach Puree Concentrate, Pomegranate Juice Concentrate, Strawberry Puree, Coconut, Natural & Artificial Flavors, Citric Acid, Sodium Lactate, Sodium Citrate, Color Added, Red 40 Lake, Red 40, Yellow 5 & 6, Yellow 5 & 6 Lake, Blue 1, Blue 1 Lake, Grape Skin Extract (Color), Beeswax, Carnauba Wax, Confectioner'S Glaze, Tapioca Dextrin."},
          ColorGroup = "brown",
          BackgroundColor = "#972C3F",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/7d3a9d0f-b6b0-4a15-8304-b62c2422331e",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 67,
          GroupNameSerialized = "Jelly Belly Official Flavors, Kids Mix Flavors",
          FlavorName = "Raspberry",
          Description = "Enjoy The Fresh-Picked Taste Of Real Raspberry Puree.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Raspberry Juice From Puree, Contains 2% Or Less Of The Following: Citric Acid, Artificial Flavor, Color Added, Yellow 6, Red 40 Lake, Red 40, Yellow 5 & 6 Lake, Blue 2 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "firebrick",
          BackgroundColor = "#B11F29",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/0ad95037-f351-452b-b81e-62d07357ec35",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 68,
          GroupNameSerialized = "Jelly Belly Official Flavors, Kids Mix Flavors",
          FlavorName = "Red Apple",
          Description = "Crisp, Delicious And Sweet. A Classic Taste That Only Comes From Including Real Apple Juice.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Apple Juice From Concentrate, Contains 2% Or Less Of The Following: Lactic Acid, Citric Acid, Fumaric Acid, Natural And Artificial Flavor, Color Added, Red 40, Yellow 6, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "brown",
          BackgroundColor = "#972C3F",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/488e9a3f-c4d2-4330-ab8e-bfc41205566a",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 69,
          GroupNameSerialized = "Jelly Belly Official Flavors",
          FlavorName = "Rose",
          Description = "The Delicious Flavour Of A Glass Of Bubbly That Makes Every Occasion Extra Rosy.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural & Artificial Flavors, Citric Acid, Color Added, Red 40, Red 3, Blue 2 Lake, Red 40 Lake, Maltodextrin, Confectioner'S Glaze, Beeswax, Carnauba Wax."},
          ColorGroup = "lightpink",
          BackgroundColor = "#FF9BB3",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/0162eacd-3d45-4dae-b44f-262987ec1100",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },
        new Bean
        {
          BeanId = 70,
          GroupNameSerialized = "Jelly Belly Official Flavors",
          FlavorName = "S'Mores",
          Description = "The Perfect Taste Combination Of Marshmallow, Graham Cracker And Chocolate. No Campfire Required.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural And Artificial Flavor, Color Added, Vegetable And Fruit Juice (Color), Yellow 5 & 6 Lake, Blue 2 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze, Salt."},
          ColorGroup = "wheat",
          BackgroundColor = "#E9CCAD",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/41f3ac58-a03d-4b75-b566-fc1ff9d1b336",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 71,
          GroupNameSerialized = "Jelly Belly Official Flavors",
          FlavorName = "Sizzling Cinnamon",
          Description = "We Turned Up The Heat. This Bean'S Fiery Cinnamon Flavor Bites Back With A Delectable Spice That'S Just Right.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Artificial Flavor, Color Added, Red 40 Lake, Yellow 5 Lake, Yellow 5, Red 40, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "brown",
          BackgroundColor = "#871922",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/4473a98d-1f4e-4242-aefa-6882472cc211",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 72,
          GroupNameSerialized = "Jelly Belly Official Flavors, Kids Mix Flavors, Sours Flavors",
          FlavorName = "Sour Cherry",
          Description = "A Sour Twist To One Of Our Most Popular Flavors. Made To Perfection With Real Cherry Juice For A Delicious Fresh-Picked Flavor.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Cherry Juice From Concentrate, Contains 2% Or Less Of The Following: Citric Acid, Fumaric Acid, Sodium Lactate, Sodium Citrate, Artificial Flavor, Color Added, Red 40 Lake, Turmeric (Color), Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "brown",
          BackgroundColor = "#9E222C",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/a0ed8075-fc86-4fe9-ad34-64f70a250b46",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },
        new Bean
        {
          BeanId = 73,
          GroupNameSerialized = "Sours Flavors",
          FlavorName = "Sour Grape",
          Description = "So Sour. So Good. Flavorings Of Real Grape Juice Produces A Fresh From The Vine Taste.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Citric Acid, Sodium Lactate, Tartaric Acid, Grape Juice Concentrate, Gum Arabic, Natural & Artificial Flavor, Vegetable & Fruit Juice (Color), Color Added, Red 40, Blue 1, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "steelblue",
          BackgroundColor = "#3a7295",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/b03ee77c-fb40-485d-9457-00b685295329",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 74,
          GroupNameSerialized = "Sours Flavors",
          FlavorName = "Sour Lemon",
          Description = "This Bean Packs Extra Pucker Power. Real Lemon Puree' Delivers Its Special Tasty Tartness.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Lemon Juice From Puree, Contains 2% Or Less Of The Following: Citric Acid, Fumaric Acid, Sodium Lactate, Sodium Citrate, Natural Flavor, Color Added, Yellow 5, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "gold",
          BackgroundColor = "#F9D501",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/93aa8039-d6f6-4d33-8562-4d250bc60ad3",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 75,
          GroupNameSerialized = "Sours Flavors",
          FlavorName = "Sour Orange",
          Description = "Pucker Up! Flavored With Real Orange Puree.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Apple Juice Concentrate, Grape Juice Concentrate, Lemon Puree, Cherry Juice Concentrate, Orange Puree, Citric Acid, Fumaric Acid, Sodium Citrate, Sodium Lactate, Natural And Artificial Flavors, Color Added, Red 40 Lake, Blue 1 & 2, Blue 1 & 2 Lake, Yellow 5 & 6 Lake, Yellow 5, Turmeric (Color), Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "goldenrod",
          BackgroundColor = "#F99B25",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/2c756f64-6b9e-413f-a0b6-54f9f033d4ed",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 76,
          GroupNameSerialized = "Jelly Belly Official Flavors",
          FlavorName = "Strawberry Banana Smoothie",
          Description = "Go Ahead. Mix It Up! A Delicious Combo Flavored With Real Strawberry And Banana Purees.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Pomegranate Juice Concentrate, Peach Puree Concentrate, Banana Puree, Pear Juice Concentrate, Natural And Artificial Flavors, Citric Acid, Sodium Lactate, Sodium Citrate, Color Added, Red 40, Yellow 5 & 6, Yellow 5 & 6 Lake, Blue 1 & 2 Lake, Red 40 Lake, Blue 1, Beeswax, Carnauba Wax, Confectioner'S Glaze, Salt, Coffee, Tapioca Dextrin."},
          ColorGroup = "goldenrod",
          BackgroundColor = "#E5932E",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/bc9729ec-1e40-4504-b41e-6cd0805fe599",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 77,
          GroupNameSerialized = "Jelly Belly Official Flavors",
          FlavorName = "Strawberry Cheesecake",
          Description = "A Dessert Lover'S Dream! There Is A Reason Why It'S One Of Our Most Popular Flavors. Go Ahead, Treat Yourself.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Strawberry Juice From Puree, Contains 2% Or Less Of The Following: Citric Acid, Natural And Artificial Flavors, Color Added, Red 40 Lake, Red 40, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "lightpink",
          BackgroundColor = "#E798AB",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/ebf62896-5b77-411b-ac14-f28a70555e27",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 78,
          GroupNameSerialized = "Jelly Belly Official Flavors, Cocktail Classics® Flavors, Tropical Mix Flavors",
          FlavorName = "Strawberry Daiquiri",
          Description = "You'Ll Feel Like You Are Poolside As You Enjoy The Fresh Fruity Taste. We Flavor Each Bean With Real Strawberry Puree.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Strawberry Juice From Puree, Contains 2% Or Less Of The Following: Citric Acid, Natural And Artificial Flavors, Color Added, Red 40 Lake, Yellow 6, Red 40, Yellow 5 & 6 Lake, Tapioca Dextrin, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "indianred",
          BackgroundColor = "#B95A66",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/cce90e1d-7ced-4e18-a05b-734c36287baf",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 79,
          GroupNameSerialized = "Krispy Kreme® Doughnuts Flavors",
          FlavorName = "Strawberry Iced",
          Description = "Classic Glazed Donut Flavors With The Added Indulgence Of Strawberry Icing.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Apple Juice Concentrate, Citric Acid, Cocoa Powder, Natural & Artificial Flavors, Color Added, Red 40 Lake, Yellow 5 & 6 Lake, Blue 1 & 2 Lake, Red 40, Vegetable And Fruit Juice (Color), Tapioca Dextrin, Beeswax, Carnauba Wax, Confectioner'S Glaze, Ground Cinnamon, Salt."},
          ColorGroup = "lightpink",
          BackgroundColor = "#E798AB",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/af61cc87-48ba-4364-9417-5aa6767dc7c3",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 80,
          GroupNameSerialized = "Jelly Belly Official Flavors, Kids Mix Flavors",
          FlavorName = "Strawberry Jam",
          Description = "The Perfect Sweet Topping. Flavoured With Real Strawberry Juice For A Fresh From The Jar Taste.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Strawberry Juice From Concentrate, Contains 2% Or Less Of The Following: Citric Acid, Artificial Flavors, Color Added, Red 40 Lake, Yellow 6, Red 40, Blue 2 Lake, Yellow 5 & 6 Lake, Tapioca Dextrin, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "firebrick",
          BackgroundColor = "#C02032",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-11441/cms/files/d3de2b1e-08ce-495e-9b6c-021d9fbc1601",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 81,
          GroupNameSerialized = "Boba Milk Tea Flavors",
          FlavorName = "Strawberry Milk Tea",
          Description = "Refreshing And Sweet. Sweet Strawberries, Milk Tea, And Tapioca Pearls Combine For A Delightful Treat.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Citric Acid, Confectioner'S Glaze, Beeswax, Carnauba Wax, Natural And Artificial Flavors, Salt, Color Added, Red 40, Yellow 6 Lake."},
          ColorGroup = "pink",
          BackgroundColor = "#F9CAC8",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/0172a080-8a8f-4e2d-802c-d9b596708950",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 82,
          GroupNameSerialized = "Jelly Belly Official Flavors",
          FlavorName = "Lemon",
          Description = "The Perfect Amount Of Pucker. Real Lemon Flavorings Give These Beans Their Tasty Tartness.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Lemon Juice From Puree, 2% Or Less Of The Following: Sodium Lactate, Citric Acid, Natural Flavor, Color Added, Yellow 5, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "gold",
          BackgroundColor = "#F9D501",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/93aa8039-d6f6-4d33-8562-4d250bc60ad3",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 83,
          GroupNameSerialized = "Jelly Belly Official Flavors, Sunkist® Citrus Mix Flavors",
          FlavorName = "Sunkist® Lime",
          Description = "Sweet, Tart, And Zesty. Flavored With Real Lime Juice For That Fresh-Picked Taste.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Lime Juice From Concentrate, 2% Or Less Of The Following: Sodium Lactate, Citric Acid, Natural Flavor, Color Added, Yellow 5, Blue 1, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "darkkhaki",
          BackgroundColor = "#D5DC55",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/c12f270c-e207-41a6-9a09-4df3024ea08a",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 84,
          GroupNameSerialized = "Jelly Belly Official Flavors, Sunkist® Citrus Mix Flavors",
          FlavorName = "Sunkist® Orange",
          Description = "The Perfect Way To Wake Up Your Taste Buds. Each Flavored With Real Orange Puree For A Sweet Citrus Treat.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Orange Juice From Orange Puree, 2% Or Less Of The Following: Citric Acid, Sodium Lactate, Natural Flavor, Color Added, Yellow 6, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "goldenrod",
          BackgroundColor = "#F99B25",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/447dd4bc-23dd-4736-8343-18af394a1d4d",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 85,
          GroupNameSerialized = "Jelly Belly Official Flavors, Sunkist® Citrus Mix Flavors, Tropical Mix Flavors",
          FlavorName = "Sunkist® Pink Grapefruit",
          Description = "It Tastes So Fresh Squeezed Because It'S Flavored With Real Grapefruit Juice.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Grapefruit Juice From Concentrate, 2% Or Less Of The Following: Citric Acid, Sodium Lactate, Natural Flavor, Color Added, Yellow 5 & 6 Lake, Red 40, Blue 2 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "darksalmon",
          BackgroundColor = "#E6986B",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/3827a360-1573-4ed7-bf95-b80a4d4f610c",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 86,
          GroupNameSerialized = "Jelly Belly Official Flavors, Sunkist® Citrus Mix Flavors, Tropical Mix Flavors",
          FlavorName = "Sunkist® Tangerine",
          Description = "Get Ready For A Sweet And Tart Taste That'S Flavored With Real Tangerine Juice For A Burst Of Flavor.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Tangerine Juice From Concentrate, 2% Or Less Of The Following: Citric Acid, Sodium Lactate, Natural Flavor, Color Added, Yellow 6, Red 40, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "coral",
          BackgroundColor = "#EE734A",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/7b266567-cd0b-4c08-956a-734395bf7aed",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 87,
          GroupNameSerialized = "Boba Milk Tea Flavors",
          FlavorName = "Taro Milk Tea",
          Description = "Take Your Taste Buds On A Journey With This Internationally-Inspired Flavor. The Perfect Blend Of Taro Milk Tea And Tapioca Pearls Make Up This Truly Unique Bean.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Confectioner'S Glaze, Beeswax, Carnauba Wax, Natural And Artificial Flavors, Salt, Color Added, Red 40, Blue 1Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Confectioner'S Glaze, Beeswax, Carnauba Wax, Natural And Artificial Flavors, Salt, Color Added, Red 40, Blue 1."},
          ColorGroup = "silver",
          BackgroundColor = "#CCB7C3",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/a0773550-2984-4533-b198-fe2552500342",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 88,
          GroupNameSerialized = "Boba Milk Tea Flavors",
          FlavorName = "Thai Milk Tea",
          Description = "Experience The Rich And Aromatic Blend Of Thai Milk Tea And Tapioca Pearls In Every Bite.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Confectioner'S Glaze, Beeswax, Carnauba Wax, Natural And Artificial Flavors, Salt, Color Added, Yellow 6 Lake, Yellow 5."},
          ColorGroup = "sandybrown",
          BackgroundColor = "#EBAC4A",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/0c679fc3-78fc-4fac-9ec9-878b8ce6f057",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 89,
          GroupNameSerialized = "Jelly Belly Official Flavors, Kids Mix Flavors",
          FlavorName = "Toasted Marshmallow",
          Description = "Bring Back Memories Of Sitting Around The Campfire. No Stick Required.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Watermelon Juice From Concentrate, Contains 2% Or Less Of The Following: Artificial Flavor, Citric Acid, Color Added, Red 40 Lake, Yellow 5, Blue 1, Red 40, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "silver",
          BackgroundColor = "#D8C6AB",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/bc97e1a9-0e2b-4dc6-8fde-d469d4c05ef3",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 90,
          GroupNameSerialized = "Jelly Belly Official Flavors, Tropical Mix Flavors",
          FlavorName = "Top Banana",
          Description = "So Delicious, You'Ll Want To Eat A Bunch. Flavored With Real Banana Puree.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Watermelon Juice From Concentrate, Contains 2% Or Less Of The Following: Artificial Flavor, Citric Acid, Color Added, Red 40 Lake, Yellow 5, Blue 1, Red 40, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "goldenrod",
          BackgroundColor = "#CCA42C",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/5e604eb2-d339-4166-ac6b-24a66dd984e7",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 91,
          GroupNameSerialized = "Jelly Belly Official Flavors, Kids Mix Flavors",
          FlavorName = "Tutti-Fruitti",
          Description = "This Beloved Bean Is A Unique And Delicious Combination Of Fruity Flavors.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural & Artificial Flavor, Color Added, Red 40 Lake, Yellow 5 Lake, Red 40, Blue 1 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "lightpink",
          BackgroundColor = "#EFB3CB",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/e7fafb0e-9dc4-4c9c-93bc-485d306ac31d",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 92,
          GroupNameSerialized = "Jelly Belly Official Flavors, Kids Mix Flavors",
          FlavorName = "Very Cherry",
          Description = "Our Most Popular Flavor Is Created With Real Cherry Juice To Seem Like It Came Right From A Tree.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Cherry Juice From Concentrate, Contains 2% Or Less Of The Following: Citric Acid, Artificial Flavor, Color Added, Red 40, Red 40 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "brown",
          BackgroundColor = "#AD1E34",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/d9051ec6-2970-4c88-8227-7f7e2fe1c76d",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 93,
          GroupNameSerialized = "Jelly Belly Official Flavors, Kids Mix Flavors",
          FlavorName = "Watermelon",
          Description = "A Sweet Sensation That'S Green On The Outside And Red On The Inside. Flavored With Real Watermelon Juice To Be Delicious Inside And Out.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Watermelon Juice From Concentrate, Contains 2% Or Less Of The Following: Artificial Flavor, Citric Acid, Color Added, Red 40 Lake, Yellow 5, Blue 1, Red 40, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "darkgreen",
          BackgroundColor = "#264D16",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/559e929f-9e78-4f9b-a7e3-178efc226ba9",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 94,
          GroupNameSerialized = "Jelly Belly Official Flavors",
          FlavorName = "Wild Blackberry",
          Description = "Deep And Fruity Flavor That Tastes Like It Came Right From The Bush. Flavored With Real Blackberry Puree.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Blackberry Juice From Puree, Contains 2% Or Less Of The Following: Citric Acid, Natural & Artificial Flavor, Sodium Lactate, Sodium Citrate, Color Added, Blue 2 Lake, Red 40 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "dimgray",
          BackgroundColor = "#655277",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/8567bee8-e66d-4217-96a5-7d9e931916d5",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 95,
          GroupNameSerialized = "Jelly Belly Official Flavors",
          FlavorName = "Lemon Drop",
          Description = "The Classic Candy That Is Sweet With Just A Hint Of Sour. Flavoured With Real Lemon Puree.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Lemon Juice From Lemon Puree, Contains 2% Or Less Of The Following: Citric Acid, Natural And Artificial Flavors, Color Added, Yellow 5, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "gold",
          BackgroundColor = "#FFE92D",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/0946ef12-a22e-4f5f-b82b-704024380c59",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 96,
          GroupNameSerialized = "Jelly Belly Official Flavors, Kids Mix Flavors, Tropical Mix Flavors",
          FlavorName = "Lemon Lime",
          Description = "The Citrus Match Made In Heaven And Made With Real Lime Juice Concentrate.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Lime Juice From Concentrate, Lemon Juice From Lemon Puree, Contains 2% Or Less Of The Following: Citric Acid, Sodium Lactate, Natural Flavors, Color Added, Yellow 5, Blue 1, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "darkkhaki",
          BackgroundColor = "#D5DC55",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/e1300522-2a05-429c-82b8-3c4f46754c5c",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 97,
          GroupNameSerialized = "Jelly Belly Official Flavors",
          FlavorName = "Lemon Meringue Pie",
          Description = "A Tart And Sweet Taste You'Ll Swear Was Topped With Meringue. Flavored With Real Lemon Puree.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Lemon Puree, Citric Acid, Natural & Artificial Flavor, Color Added, Vegetable And Fruit Juice (Color), Yellow 5 & 6 Lake, Blue 2 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze, Salt."},
          ColorGroup = "gold",
          BackgroundColor = "#F1C720",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/1896002b-1acf-44de-b540-1fb48c780d0e",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 98,
          GroupNameSerialized = "Jelly Belly Official Flavors",
          FlavorName = "Licorice",
          Description = "Indulge In The Unmistakable Flavor That Balances Sweet With Spice. Our Traditional Taste Comes From Real Black Licorice.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural And Artificial Flavors, Color Added, Blue 2 Lake, Yellow 6 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "darkslategray",
          BackgroundColor = "#022F34",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/d06c24dd-24c3-4059-ab3f-bcc80f78df86",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 99,
          GroupNameSerialized = "Jelly Belly Official Flavors",
          FlavorName = "Cherry Passion Fruit Smoothie",
          Description = "The Sweet And Fruity Flavors Of Cherry And Passion Fruit Are Blended To Perfection In This Unique Smoothie Flavor.",
          Ingredients = new [] {"Sugar, Glucose Syrup, Modified Cornstarch, Passion Fruit Juice Concentrate, Flavourings, Acidity Regulator (E330), Colours (E100, E171), Glazing Agents (E901, E903, E904), Fruit And Vegetable Concentrates (Purple Carrot, Carrot, Black Currant)."},
          ColorGroup = "black",
          BackgroundColor = "#",
          ImageUrl = "",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 100,
          GroupNameSerialized = "Jelly Belly Official Flavors",
          FlavorName = "Blue Raspberry",
          Description = "Enjoy The Taste Of A Fresh-Picked Raspberry In A Beautiful Blue Hue.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Citric Acid, Natural And Artificial Flavor, Color Added, Sodium Citrate, Blue 1 Lake, Blue 1, Confectioner'S Glaze, Beeswax, Carnauba Wax."},
          ColorGroup = "teal",
          BackgroundColor = "#03698B",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/95aa0f7d-e369-4438-984c-f6dd1300664d",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 101,
          GroupNameSerialized = "Cold Stone® Flavors",
          FlavorName = "Birthday Cake Remix®",
          Description = "Party All The Time With This Unique Ice Cream Flavor.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural & Artificial Flavors, Tapioca Dextrin, Color Added, Yellow 5 & 6 Lake, Red 40 Lake, Red 40, Blue 1 & 2 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze, Salt."},
          ColorGroup = "antiquewhite",
          BackgroundColor = "#EEE7D8",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/76c3b0f3-ef88-4cee-9cf9-d75eb51622aa",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 102,
          GroupNameSerialized = "Jelly Belly Official Flavors",
          FlavorName = "Birthday Cake",
          Description = "Make Everyday Taste Like Your Birthday.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural & Artificial Flavors, Tapioca Dextrin, Color Added, Yellow 5 & 6 Lake, Red 40 Lake, Red 40, Blue 1 & 2 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze, Salt."},
          ColorGroup = "antiquewhite",
          BackgroundColor = "#EEE7D8",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/76c3b0f3-ef88-4cee-9cf9-d75eb51622aa",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 103,
          GroupNameSerialized = "Jelly Belly Official Flavors, Kids Mix Flavors",
          FlavorName = "Sour Apple",
          Description = "Fresh From The Tree Sweetness With A Sour Twist. Flavored With Real Apple Juice.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Apple Juice From Concentrate, Contains 2% Or Less Of The Following: Citric Acid, Fumaric Acid, Sodium Lactate, Sodium Citrate, Artificial Flavor, Color Added, Yellow 5, Yellow 5 Lake, Blue 1, Blue 1 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "forestgreen",
          BackgroundColor = "#3C812A",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/c2ec3236-f34b-4685-a50b-1f013144dc52",
          GlutenFree = false,
          SugarFree = false,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 104,
          GroupNameSerialized = "Sugar-Free Assorted Flavors",
          FlavorName = "Sugar-Free Cherry",
          Description = "",
          Ingredients = new [] {""},
          ColorGroup = "firebrick",
          BackgroundColor = "#C02032",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-11441/cms/files/dom-sugar-free-cherry-shadow-new.webp",
          GlutenFree = false,
          SugarFree = true,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 105,
          GroupNameSerialized = "Sugar-Free Assorted Flavors",
          FlavorName = "Sugar-Free Sizzling Cinnamon",
          Description = "",
          Ingredients = new [] {""},
          ColorGroup = "indianred",
          BackgroundColor = "#DD4B62",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-11441/cms/files/dom-sugar-free-sizzling-cinnamon-shadow.webp",
          GlutenFree = false,
          SugarFree = true,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 106,
          GroupNameSerialized = "Sugar-Free Assorted Flavors",
          FlavorName = "Sugar-Free Green Apple",
          Description = "",
          Ingredients = new [] {""},
          ColorGroup = "forestgreen",
          BackgroundColor = "#2B9B39",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-11441/cms/files/dom-sugar-free-green-apple-shadow.webp",
          GlutenFree = false,
          SugarFree = true,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 107,
          GroupNameSerialized = "Sugar-Free Assorted Flavors",
          FlavorName = "Sugar-Free Juicy Pear",
          Description = "",
          Ingredients = new [] {""},
          ColorGroup = "darkkhaki",
          BackgroundColor = "#c8cf65",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-11441/cms/files/dom-sugar-free-juicy-pear-shadow-new.webp",
          GlutenFree = false,
          SugarFree = true,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 108,
          GroupNameSerialized = "Sugar-Free Assorted Flavors",
          FlavorName = "Sugar-Free Lemon",
          Description = "",
          Ingredients = new [] {""},
          ColorGroup = "sandybrown",
          BackgroundColor = "#e9d443",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-11441/cms/files/dom-sugar-free-lemon-shadow-new.webp",
          GlutenFree = false,
          SugarFree = true,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 109,
          GroupNameSerialized = "Sugar-Free Assorted Flavors",
          FlavorName = "Sugar-Free Licorice",
          Description = "",
          Ingredients = new [] {""},
          ColorGroup = "darkslategray",
          BackgroundColor = "#022F34",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-11441/cms/files/dom-sugar-free-licorice-shadow.webp",
          GlutenFree = false,
          SugarFree = true,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 110,
          GroupNameSerialized = "Sugar-Free Assorted Flavors",
          FlavorName = "Sugar-Free Pineapple",
          Description = "",
          Ingredients = new [] {""},
          ColorGroup = "khaki",
          BackgroundColor = "#FADF50",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-11441/cms/files/dom-sugar-free-pineapple-shadow.webp",
          GlutenFree = false,
          SugarFree = true,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 111,
          GroupNameSerialized = "Sugar-Free Assorted Flavors",
          FlavorName = "Sugar-Free Buttered Popcorn",
          Description = "",
          Ingredients = new [] {""},
          ColorGroup = "khaki",
          BackgroundColor = "#FDE96C",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-11441/cms/files/dom-sugar-free-buttered-popcorn-shadow.webp",
          GlutenFree = false,
          SugarFree = true,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 112,
          GroupNameSerialized = "Sugar-Free Assorted Flavors",
          FlavorName = "Sugar-Free Strawberry",
          Description = "",
          Ingredients = new [] {""},
          ColorGroup = "lightpink",
          BackgroundColor = "#EFB3CB",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-11441/cms/files/dom-sugar-free-strawberry-shadow.webp",
          GlutenFree = false,
          SugarFree = true,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 113,
          GroupNameSerialized = "Sugar-Free Assorted Flavors",
          FlavorName = "Sugar-Free Tangerine",
          Description = "",
          Ingredients = new [] {""},
          ColorGroup = "goldenrod",
          BackgroundColor = "#f99b24",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-11441/cms/files/dom-sugar-free-tangerine-shadow-new.webp",
          GlutenFree = false,
          SugarFree = true,
          Seasonal = false,
          Kosher = true
        },

        new Bean
        {
          BeanId = 114,
          GroupNameSerialized = "Sugar-Free Assorted Flavors",
          FlavorName = "Jewel Berry Blue",
          Description = "A Combination Of Fruits To Give Your Taste Buds The Royal Treatment.",
          Ingredients = new [] {"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Citric Acid, Natural & Artificial Flavor, Color Added, Blue 1, Beeswax, Carnauba Wax, Confectioner'S Glaze."},
          ColorGroup = "teal",
          BackgroundColor = "#085881",
          ImageUrl = "https://cdn-tp1.mozu.com/9046-m1/cms/files/1ba610ca-1701-47ec-a982-7e1bde8e79bd",
          GlutenFree = false,
          SugarFree = true,
          Seasonal = false,
          Kosher = true
        }
      );
    }
  }
}