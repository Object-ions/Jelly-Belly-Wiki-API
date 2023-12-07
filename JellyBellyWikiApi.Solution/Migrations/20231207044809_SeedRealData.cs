using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JellyBellyWikiApi.Migrations
{
    public partial class SeedRealData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Beans",
                columns: new[] { "BeanId", "BackgroundColor", "ColorGroup", "Description", "FlavorName", "GlutenFree", "GroupNameSerialized", "ImageUrl", "Ingredients", "Kosher", "Seasonal", "SugarFree" },
                values: new object[,]
                {
                    { 1, "#CEDC91", "White", "The Refreshing And Crisp Flavor Of Lemon Lime Soda.", "7Up", false, "Jelly Belly Official Flavors, Soda Pop Shoppe® Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/ab692677-5471-4863-91a8-659363ae4cc4", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Citric Acid, Sodium Lactate, Natural \\u0026 Artificial Flavor, Color Added, Yellow 5, Blue 1, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze\"]", true, false, false },
                    { 2, "#E1DFE1", "White", "A Deliciously Creamy Take On The Classic Vanilla Flavor.", "A&W® Cream Soda", false, "Jelly Belly Official Flavors, Soda Pop Shoppe® Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/75fea694-ed38-4e84-a86e-182e31ea5a7b", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural And Artificial Flavors, Color Added, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 3, "#792E27", "White", "Say 'Cheers' With The Flavor Of This All-American Classic Drink.", "A&W® Root Beer", false, "Jelly Belly Official Flavors, Soda Pop Shoppe® Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/63b9e71d-9866-4044-9af7-7a64a52b0e0e", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural \\u0026 Artificial Flavors, Color Added, Vegetable \\u0026 Fruit Juice (Color), Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 4, "#5B3640", "White", "Hard To Pronounce But A Delight To Enjoy. A Super Sweet And Rich Berry Taste Unlike Any Other.", "Acai Berry", false, "Superfruit Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/6f0c6164-71c8-47f6-a55f-893f5fd58fa0", "[\"Cane Sugar, Tapioca Syrup, Modified Food Starch, Sour Cherry Juice From Concentrate, Blueberry Juice From Blueberry Puree, Pomegranate Juice From Concentrate, Acai Puree, Natural Flavors, Acerola (Barbados) Cherry Juice, Cranberry Puree, Citric Acid, Apple (Color), Confectioner\\u0027S Glaze, Beeswax, Grape Concentrate (Color), Carrot (Color), Carnauba Wax, Black Currant (Color), Hibiscus (Color), Color Added.\"]", true, false, false },
                    { 5, "#F0C57F", "White", "A Creamy Combination Of French Vanilla, Apple Pie, And Caramel Flavors Adds A Sweet Twist To The Classic American Dessert.", "Apple Pie A La Cold Stone®", false, "Cold Stone® Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/81f5ecb8-250b-403f-a1bf-89fb6e47dd0d", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Strawberry Puree, Chocolate Liquor, Cocoa Butter, Cocoa Powder, Citric Acid, Ground Cinnamon, Tapioca Dextrin, Natural And Artificial Flavor, Color Added, Red 40 Lake, Yellow 5 \\u0026 6 Lake, Red 40, Blue 1 \\u0026 2 Lake, Blue 1, Yellow 5, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Salt.\"]", true, false, false },
                    { 6, "#E798AB", "White", "A Sweet Cherry Flavor With Just A Hint Of Tartness.", "Barbados Cherry", false, "Superfruit Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/168244d0-b3ba-4725-a2d9-5083b362d10a", "[\"Cane Sugar, Tapioca Syrup, Modified Food Starch, Sour Cherry Juice From Concentrate, Blueberry Juice From Blueberry Puree, Pomegranate Juice From Concentrate, Acai Puree, Natural Flavors, Acerola (Barbados) Cherry Juice, Cranberry Puree, Citric Acid, Apple (Color), Confectioner\\u0027S Glaze, Beeswax, Grape Concentrate (Color), Carrot (Color), Carnauba Wax, Black Currant (Color), Hibiscus (Color), Color Added.\"]", true, false, false },
                    { 7, "#3A7195", "White", "Enjoy The Taste Of Fresh-Picked Blueberries. Deliciously Flavored With Real Blueberry Puree.", "Blueberry", false, "Jelly Belly Official Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/a8f085b5-b4ff-4aca-8650-43ad54c80fe4", "[\"Sugar, Corn Syrup, Modified Food Starch, Blueberry Juice From Puree, Contains 2% Or Less Of The Following: Citric Acid, Natural \\u0026 Artificial Flavor, Color Added, Blue 1 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 8, "#E3ACBD", "White", "This Bean Has Everything But The Bubble! Taking A Trip Down Memory Lane Has Never Tasted So Good.", "Bubble Gum", false, "Jelly Belly Official Flavors, Kids Mix Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/51474130-73e9-40b7-a8ba-c9eac7be7de4", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Artificial Flavor, Color Added, Red 40 Lake, Red 40, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 9, "#F6D334", "White", "Now You Can Enjoy Buttery Perfection Without Having To Go To The Movies.", "Buttered Popcorn", false, "Jelly Belly Official Flavors, Kids Mix Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/61207309-fffb-443a-b735-b9a5a6374c8d", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural And Artificial Flavors, Color Added, Yellow 5, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Salt.\"]", true, false, false },
                    { 10, "#FAA538", "White", "This Sweet Summertime Favorite Is Always In Season.", "Cantaloupe", false, "Jelly Belly Official Flavors, Tropical Mix Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/45d0972c-e554-4374-8b21-ac50ff450d3e", "[\"Sugar, Corn Syrup, Modified Food Starch, Cantaloupe Juice From Cantaloupe Powder, Contains 2% Or Less Of The Following: Natural And Artificial Flavors, Color Added, Yellow 6 Lake, Yellow 6, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 11, "#5A262A", "White", "The Rich And Creamy Taste Of Cappuccino. So 'Delicioso' Because Each Is Flavored With Real Coffee.", "Cappuccino", false, "Jelly Belly Official Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/ca2fe8be-4c41-4e83-81df-cf3b093f5a42", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural And Artificial Flavors, Coffee, Color Added, Vegetable And Fruit Juice (Color), Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 12, "#F0C57F", "White", "A Partnership Made In Heaven. Sweet Caramel And Buttery Popcorn.", "Caramel Corn", false, "Jelly Belly Official Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/aff9adae-5dde-4e5b-b718-a68d7ed8edf2", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural And Artificial Flavors, Color Added, Yellow 6, Yellow 5 \\u0026 6 Lake, Blue 2 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Salt.\"]", true, false, false },
                    { 13, "#3A7195", "White", "Enjoy The Taste Of Fresh-Picked Blueberries. Deliciously Flavored With Real Blueberry Puree.", "Blueberry", false, "Superfruit Flavors, Kids Mix Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/4ee93e6c-c132-47ab-a748-b9663251b14e", "[\"Sugar, Corn Syrup, Modified Food Starch, Blueberry Juice From Puree, Contains 2% Or Less Of The Following: Citric Acid, Natural \\u0026 Artificial Flavor, Color Added, Blue 1 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 14, "#792E27", "White", "Rich Chocolate Taste That Will Bring You To Your Happy Place. Flavored With Real Cocoa Powder For An Indulgent Treat.", "Chocolate Devotion®", false, "Cold Stone® Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/f7cc6aee-9e70-466f-8d5a-a173b4a42275", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Strawberry Puree, Chocolate Liquor, Cocoa Butter, Cocoa Powder, Citric Acid, Ground Cinnamon, Tapioca Dextrin, Natural And Artificial Flavor, Color Added, Red 40 Lake, Yellow 5 \\u0026 6 Lake, Red 40, Blue 1 \\u0026 2 Lake, Blue 1, Yellow 5, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Salt.\"]", true, false, false },
                    { 15, "#402427", "White", "A Creamy, Chocolatey Tasting Delight Flavored With Real Cocoa Powder. No Spoon Required.", "Chocolate Pudding", false, "Jelly Belly Official Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/63b9e71d-9866-4044-9af7-7a64a52b0e0e", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Cocoa Powder, Chocolate Liquor, Cocoa Butter, Natural And Artificial Flavor, Color Added, Red 40 Lake, Yellow 5 Lake, Blue 2 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 16, "#DD4B62", "White", "The Perfect Combination Of Sugar And Spice. These Beans Have Just The Right Amount Of Cinnamon To Make Them A Sweet Treat For All.", "Cinnamon", false, "Jelly Belly Official Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/18e50750-75eb-4f26-b8ed-1c01db69f3d3", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Artificial Flavor, Color Added, Red 40, Red 40 Lake, Turmeric (Color), Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 17, "#ba815c", "White", "The Perfect Combination Of A Classic Glazed Donut And Sweet Apple Filling. Flavored With Real Apple Juice.", "Cinnamon Apple Filled", false, "Krispy Kreme® Doughnuts Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/1477c8aa-1320-45a1-b5a0-2fe90bdcc7f3", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Apple Juice Concentrate, Citric Acid, Cocoa Powder, Natural \\u0026 Artificial Flavors, Color Added, Red 40 Lake, Yellow 5 \\u0026 6 Lake, Blue 1 \\u0026 2 Lake, Red 40, Vegetable And Fruit Juice (Color), Tapioca Dextrin, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Ground Cinnamon, Salt.\"]", true, false, false },
                    { 18, "#E1DFE1", "White", "Take A Quick Trip To The Tropics With The Taste Of Real Coconut.", "Coconut", false, "Jelly Belly Official Flavors, Tropical Mix Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/ad4638c8-b778-4248-afca-7c3051c8f92f", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Coconut, Artificial Flavor, Color Added, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 19, "#E19E9F", "White", "A Sweet Taste From Your Childhood That Will Bring A Smile To Your Face.", "Cotton Candy", false, "Jelly Belly Official Flavors, Kids Mix Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/0066a0a9-88cc-4b1f-bacc-5db4fffdbc38", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Citric Acid, Natural And Artificial Flavor, Color Added, Red 40, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 20, "#871922", "White", "Not Too Tart And Not Too Sweet. This Berry Flavor Definitely Has The Perfect Balance.", "Cranberry", false, "Superfruit Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/c2909d75-8d0c-4629-b086-8ad2b43b3ac7", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Cranberry Puree, Natural Flavor, Color Added, Red 40 Lake, Blue 2 Lake, Turmeric (Color), Citric Acid, Confectioner\\u0027S Glaze, Beeswax, Carnauba Wax.\"]", true, false, false },
                    { 21, "#DD4B62", "White", "This Delicious Berry Flavor From Snapple® Packed Into A Jelly Bean For A Sweet Treat.", "Cranberry Raspberry", false, "Snapple® Mix Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/3100bc6f-a543-4795-8acb-0d1bfe76a188", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Cranberry Puree, Raspberry Puree, Grape Juice Concentrate, Mango Juice Concentrate, Strawberry Juice Concentrate, Kiwi Juice Concentrate, Lemon Puree, Cherry Juice Concentrate, Cranberry Juice Concentrate, Natural Flavors, Citric Acid, Color Added, Grape Concentrate (Color), Turmeric (Color), Apple (Color), Hibiscus (Color), Black Currant (Color), Carrot (Color), Confectioner\\u0027S Glaze, Beeswax, Carnauba Wax.\"]", true, false, false },
                    { 22, "#FADF50", "White", "Like A Private Island For Your Taste Buds. Flavored With Real Pineapple Juice For Sweet Tropical Goodness.", "Crushed Pineapple", false, "Jelly Belly Official Flavors, Tropical Mix Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/f8683af4-2326-4d12-a477-1d6f2afd6652", "[\"Sugar, Corn Syrup, Modified Food Starch, Pineapple Juice From Concentrate, Contains 2% Or Less Of The Following: Citric Acid, Artificial Flavor, Color Added, Yellow 5, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 23, "#5B3640", "White", "There'S Nothing Like A Dr Pepper. The Soda With A Signature Blend Of 23 Flavors Packed Into A Jelly Bean.", "Dr Pepper®", false, "Jelly Belly Official Flavors, Soda Pop Shoppe® Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/cea8f58e-5cd9-4aa7-aa30-9f24c6360508", "[\"Ingredients: Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Sodium Citrate, Phosphoric Acid, Natural And Artificial Flavor, Color Added, Red 40 Lake, Blue 2 Lake, Red 40, Yellow 5 Lake, Vegetable \\u0026 Fruit Juice (Color), Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Caffeine.\"]", true, false, false },
                    { 24, "#D2D0CE", "White", "A Jelly Bean That Tastes Just Like A Vanilla Bean.", "French Vanilla", false, "Jelly Belly Official Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/3e8e01cb-f2a8-4121-ab59-b0a608ad5a92", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Vanilla Beans, Natural And Artificial Flavors, Color Added, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 25, "#CED8C2", "White", "Zesty And Bittersweet With Hints Of Elderberry And Lime.", "Gin & Tonic", false, "Cocktail Classics® Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/43a9c3a6-6f8c-44e4-a80b-df041f725fe4", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural \\u0026 Artificial Flavors, Color Added, Blue 1 Lake, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Tapioca Dextrin.\"]", true, false, false },
                    { 26, "#91484c", "White", "Enjoy The Oven-Baked Like Taste Of Blueberry Cake Without The Crumbs!", "Glazed Blueberry Cake", false, "Krispy Kreme® Doughnuts Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/e2d439f7-eee7-47b4-8b84-47c3ff8afbc7", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Apple Juice Concentrate, Citric Acid, Cocoa Powder, Natural \\u0026 Artificial Flavors, Color Added, Red 40 Lake, Yellow 5 \\u0026 6 Lake, Blue 1 \\u0026 2 Lake, Red 40, Vegetable And Fruit Juice (Color), Tapioca Dextrin, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Ground Cinnamon, Salt.\"]", true, false, false },
                    { 27, "#553E5C", "White", "A Sweet Grape Flavor With An Exciting Rush Of Fun And Flavor In Every Bean.", "Grape Crush", false, "Soda Pop Shoppe® Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/64e1b48e-8989-4ec3-be34-f19a95ffc864", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Citric Acid, Sodium Lactate, Tartaric Acid, Grape Juice Concentrate, Acacia Gum, Natural \\u0026 Artificial Flavor, Color Added, Red 40, Blue 1, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 28, "#0E7534", "White", "Tart And Crisp Flavor Made From Real Apple Juice.", "Green Apple", false, "Jelly Belly Official Flavors, Kids Mix Flavors, Tropical Mix Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/5b0694eb-f83b-4bc2-a78e-0b48d5bfcd0e", "[\"Sugar, Corn Syrup, Modified Food Starch, Apple Juice From Concentrate, Contains 2% Or Less Of The Following: Citric Acid, Artificial Flavor, Color Added, Yellow 5, Blue 1, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 29, "#4F657C", "White", "Take Your Taste Buds To A Tropical Island Paradise. Expertly Flavored With A Blend Of Juices From Real Fruits.", "Island Punch", false, "Jelly Belly Official Flavors, Tropical Mix Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/2b66c2e0-5c3d-47da-bf51-acebb5e41d96", "[\"Sugar, Corn Syrup, Modified Food Starch, Passion Fruit Juice From Concentrate, Contains 2% Or Less Of The Following: Citric Acid, Natural \\u0026 Artificial Flavor, Color Added, Blue 1 \\u0026 2 Lake, Blue 1 \\u0026 2, Red 40 Lake, Red 40, Yellow 5 Lake, Yellow 5, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 30, "#00798B", "White", "A Delicious Medley Of Raspberry, Blueberry And Strawberry Flavors.", "Berry Blue", false, "Jelly Belly Official Flavors ,Tropical Mix Flavors, Kids Mix Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/80249b46-c082-4de5-b654-64c904d7ea31", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Citric Acid, Natural \\u0026 Artificial Flavor, Color Added, Blue 1, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 31, "#293656", "White", "A Beautifully Sparkling Bean Flavored With Real Blueberry Puree For A Taste That Bursts With Flavor.", "Jewel Blueberry", false, "Jewel Jelly Beans Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/cdd532da-3ece-4bd6-a3f7-14b543756939", "[\"Sugar, Corn Syrup, Modified Food Starch, Blueberry Juice From Puree, Contains 2% Or Less Of The Following: Citric Acid, Natural \\u0026 Artificial Flavor, Color Added, Blue 1 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 32, "#CD8784", "White", "This Sparkly Bean Has Everything But The Bubble! Taking A Trip Down Memory Lane Has Never Tasted So Good.", "Jewel Bubble Gum", false, "Jewel Jelly Beans Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/03fdb902-86ed-43fa-9f8b-0e5a30ceb975", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Artificial Flavor, Color Added, Red 40 Lake, Red 40, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 33, "#E9CCAD", "White", "Ready To Toast To Any Occasion With A Classy Irridescent Finish, This Bean Contains All The Flavour Of A Glass Of Bubbly Without Any Of The Alcohol.", "Jewel Champagne", false, "Jewel Jelly Beans Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/e2145438-c107-4b94-a76d-6ba1e047c414", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural \\u0026 Artificial Flavors, Citric Acid, Color Added, Maltodextrin, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 34, "#E5DCD5", "White", "Creamy And Smooth Taste With A Special Sparkle That Makes This Bean Shine.", "Jewel Cream Soda", false, "Jewel Jelly Beans Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/c7d4188a-d542-445d-b1a8-a40fd64a9c82", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural And Artificial Flavors, Color Added, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 35, "#602825", "White", "Includes A Fizzy Sensation With Just The Right Blend Of Flavours. Perfect To Enjoy On Its Own Or Mixed With Other Flavours.", "Jewel Ginger Ale", false, "Jewel Jelly Beans Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/48c985a0-b84a-4c10-932f-0851cab8c803", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural And Artificial Flavors, Citric Acid, Color Added, Yellow 5, Red 40, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 36, "#3D7889", "White", "You Just Picked A Winner! Flavourings Of Real Grape Juice Give It A Fresh From The Vine Taste.", "Jewel Grape Soda", false, "Jewel Jelly Beans Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/b0d69aca-6114-46ab-80a1-0c9ad46187ed", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Citric Acid, Sodium Lactate, Tartaric Acid, Grape Juice Concentrate, Gum Arabic, Natural \\u0026 Artificial Flavor, Vegetable \\u0026 Fruit Juice (Color), Color Added, Red 40, Blue 1, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze\"]", true, false, false },
                    { 37, "#FCB76C", "White", "A Beautifully Sparkling Citrus Treat Flavored With Real Orange Puree.", "Jewel Orange", false, "Jewel Jelly Beans Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/079a2eb5-6c13-456c-8d7e-9d4fe7b2c85b", "[\"Sugar, Corn Syrup, Modified Food Starch, Orange Juice From Orange Puree, 2% Or Less Of The Following: Citric Acid, Sodium Lactate, Natural Flavor, Color Added, Yellow 6, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 38, "#2B9B39", "White", "So Shiny, So Tart. Flavored With Real Apple Juice.", "Jewel Sour Apple", false, "Jewel Jelly Beans Flavors, Sours Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/7fcbe714-3501-415c-af4f-9d815bcf09f9", "[\"Sugar, Corn Syrup, Modified Food Starch, Apple Juice From Concentrate, Contains 2% Or Less Of The Following: Citric Acid, Fumaric Acid, Sodium Lactate, Sodium Citrate, Artificial Flavor, Color Added, Yellow 5, Yellow 5 Lake, Blue 1, Blue 1 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 39, "#D6BA03", "White", "A Shiny Bean That Packs Some Serious Pucker Power. Flavored With Real Lemon Puree To Deliver A Tasty Tartness.", "Jewel Sour Lemon", false, "Jewel Jelly Beans Flavors, Sours Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/4bfae66c-e08a-4f33-a6c8-6e126927c6e9", "[\"Sugar, Corn Syrup, Modified Food Starch, Lemon Juice From Puree, Contains 2% Or Less Of The Following: Citric Acid, Fumaric Acid, Sodium Lactate, Sodium Citrate, Natural Flavor, Color Added, Yellow 5, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 40, "#9C4B6F", "White", "This Bean Sparkles Like A Ruby And Is Made With Real Cherry Juice To Burst With Flavor.", "Jewel Very Cherry", false, "Jewel Jelly Beans Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/92cdbdb8-d760-4cb0-8c52-c99f3c46573c", "[\"Sugar, Corn Syrup, Modified Food Starch, Cherry Juice From Concentrate, Contains 2% Or Less Of The Following: Citric Acid, Artificial Flavor, Color Added, Red 40, Red 40 Lake, Turmeric (Color), Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 41, "#AAAE45", "White", "With Just One Bite, It'S Easy To See Why It'S Called Juicy Pear. The Fresh Sweet Taste Comes From Flavorings Of Real Pear.", "Juicy Pear", false, "Jelly Belly Official Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/40f80743-d4a1-4350-84db-c7b6d2e21217", "[\"Sugar, Glucose Syrup, Modified Cornstarch, Pear Juice Concentrate, Flavouring, Acidity Regulator (E330), Glazing Agents (E901, E903, E904), Colours (E100, E171), Fruit And Vegetable Concentrates (Carrot, Pumpkin, Spirulina, Apple, Hibiscus), Tapioca Dextrin.\"]", true, false, false },
                    { 42, "#8EBF14", "White", "A Sweet And Exotic Taste Made With Flavorings Of Real Kiwifruit.", "Kiwi", false, "Jelly Belly Official Flavors, Tropical Mix Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/652b2681-d41e-4ca3-907d-3020935e7a3c", "[\"Sugar, Corn Syrup, Modified Food Starch, Kiwi Juice From Concentrate, Contains 2% Or Less Of The Following: Natural And Artificial Flavor, Color Added, Yellow 5, Blue 1, Citric Acid, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 43, "#DD4B62", "White", "The Iconic Blend Of Tangy Kiwi And Sweet Strawberry Made Famous By Snapple® In The Form Of A Jelly Bean.", "Kiwi Strawberry", false, "Snapple® Mix Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/6fc6faa5-8377-44c5-a889-da4c567a2fde", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Cranberry Puree, Raspberry Puree, Grape Juice Concentrate, Mango Juice Concentrate, Strawberry Juice Concentrate, Kiwi Juice Concentrate, Lemon Puree, Cherry Juice Concentrate, Cranberry Juice Concentrate, Natural Flavors, Citric Acid, Color Added, Grape Concentrate (Color), Turmeric (Color), Apple (Color), Hibiscus (Color), Black Currant (Color), Carrot (Color), Confectioner\\u0027S Glaze, Beeswax, Carnauba Wax.\"]", true, false, false },
                    { 44, "#DD4B62", "White", "The Perfect Amount Of Pucker. Real Lemon Flavorings Give These Beans Their Tasty Tartness.", "Sunkist® Lemon", false, "Jelly Belly Official Flavors, Kids Mix Flavors, Sunkist® Citrus Mix Flavors, Tropical Mix Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/93aa8039-d6f6-4d33-8562-4d250bc60ad3", "[\"Sugar, Corn Syrup, Modified Food Starch, Lemon Juice From Puree, 2% Or Less Of The Following: Sodium Lactate, Citric Acid, Natural Flavor, Color Added, Yellow 5, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 45, "#DD4B62", "White", "Mix It Up With This Citrusy Sweet Blend. Flavored With Real Orange Puree.", "Mandarin Orange Mango Smoothie", false, "Jelly Belly Official Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/5f0240a3-f7ee-401f-8d52-06e04b81cd29", "[\"Sugars (Sugar, Corn Syrup, Orange Puree), Modified Corn Starch, Citric Acid, Flavors, Titanium Dioxide, Shellac, Sodium Citrate, Beeswax, Carnauba Wax, Tartrazine, Sunset Yellow Fcf, Allura Red.\"]", true, false, false },
                    { 46, "#D1CA3D", "White", "Fresh And Sweet. Tropical Island Goodness Flavored With Real Mango Puree.", "Mango", false, "Jelly Belly Official Flavors, Tropical Mix Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/f885e029-ed2f-4828-a861-a2ca203fda3d", "[\"Sugar, Corn Syrup, Modified Food Starch, Mango Juice From Puree, Mango Juice From Concentrate, Contains 2% Or Less Of The Following: Citric Acid, Sodium Lactate, Sodium Citrate, Natural \\u0026 Artificial Flavor, Color Added, Yellow 5 Lake, Yellow 5, Blue 1 Lake, Blue 1, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 47, "#F99B25", "White", "Go Mad For This Sweet, Fruity, And Delicious Mango Flavor From Snapple®.", "Mango Madness", false, "Snapple® Mix Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/26cd4116-6409-41aa-87bc-fa60c1e4712f", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Cranberry Puree, Raspberry Puree, Grape Juice Concentrate, Mango Juice Concentrate, Strawberry Juice Concentrate, Kiwi Juice Concentrate, Lemon Puree, Cherry Juice Concentrate, Cranberry Juice Concentrate, Natural Flavors, Citric Acid, Color Added, Grape Concentrate (Color), Turmeric (Color), Apple (Color), Hibiscus (Color), Black Currant (Color), Carrot (Color), Confectioner\\u0027S Glaze, Beeswax, Carnauba Wax.\"]", true, false, false },
                    { 48, "#EBC669", "White", "A Tropical Treat With A Bubbly Twist. This Fruity Delight Tastes Just Like Your Favorite Boba Milk Tea Drink.", "Mango Milk Tea", false, "Boba Milk Tea Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/e3183e7b-32e2-4912-b439-e3070b00354b", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Fruit And Vegetable Juice (Color), Citric Acid, Confectioner\\u0027S Glaze, Beeswax, Carnauba Wax, Natural And Artificial Flavors, Salt, Color Added, Yellow 5 Lake.\"]", true, false, false },
                    { 49, "#7EB159", "White", "No Tequila Required. Made With A Twist Of Lime Juice.", "Margarita", false, "Jelly Belly Official Flavors, Cocktail Classics® Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/de15af51-3c70-4ecc-aa08-0421d2f8b9a6", "[\"Sugar, Corn Syrup, Modified Food Starch, Lemon Juice From Puree, Contains 2% Or Less Of The Following: Natural And Artificial Flavors, Citric Acid, Sodium Citrate, Color Added, Yellow 5, Blue 1, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 50, "#C2E189", "White", "Savor The Perfect Blend Of Matcha Milk Tea And Tapioca Pearls In Every Bite.", "Matcha Milk Tea", false, "Boba Milk Tea Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/bb22db94-1576-444c-9d5c-5654760b63dc", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Spirulina Extract (Color), Turmeric (Color), Confectioner\\u0027S Glaze, Beeswax, Carnauba Wax, Natural And Artificial Flavors, Salt, Color Added.\"]", true, false, false },
                    { 51, "#D48840", "White", "A Sophisticated Combination Of Champagne And Orange Juice. There'S No Bubbly, But Each Is Deliciously Flavored With Real Orange Puree.", "Mimosa", false, "Cocktail Classics® Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/62223645-ae3e-4235-ae61-49ccfb736a20", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Orange Puree, Natural \\u0026 Artificial Flavors, Citric Acid, Sodium Lactate, Color Added, Yellow 6, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 52, "#83AD5C", "White", "A Delicious Combination Of Chocolate And Mint Flavor In Every Bean.", "Mint Chocolate Chip®", false, "Cold Stone® Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/47c39487-4faa-4dc1-8b58-3b18e2de6a43", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Cocoa Powder, Dark Chocolate (Sugar, Chocolate Liquor, Cocoa Butter), Natural \\u0026 Artificial Flavors, Color Added, Yellow 5 Lake, Blue 1 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Tapioca Dextrin, Salt.\"]", true, false, false },
                    { 53, "#B598AF", "White", "A Delightful Mix Of Creamy Berry Flavors. No Blender Required.", "Mixed Berry Smoothie", false, "Jelly Belly Official Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/6671ca61-29e4-4c6c-9a5a-f0b161e8cabd", "[\"Sugar, Corn Syrup, Modified Food Starch, Blueberry Juice From Puree, Contains 2% Or Less Of The Following: Natural \\u0026 Artificial Flavors, Color Added, Red 40, Red 40 Lake, Blue 1, Blue 2 Lake, Yellow 5 Lake, Citric Acid, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 54, "#03ad50", "White", "Sit Back And Enjoy The Refreshing Taste Of Mint And Lime Without Any Of The Alcohol.", "Mojito", false, "Cocktail Classics® Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/ae599b54-6174-4fc2-bc8c-4fd4be9575da", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Lemon Puree, Lime Juice Concentrate, Peach Puree Concentrate, Pomegranate Juice Concentrate, Strawberry Puree, Coconut, Natural \\u0026 Artificial Flavors, Citric Acid, Sodium Lactate, Sodium Citrate, Color Added, Red 40 Lake, Red 40, Yellow 5 \\u0026 6, Yellow 5 \\u0026 6 Lake, Blue 1, Blue 1 Lake, Grape Skin Extract (Color), Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Tapioca Dextrin.\"]", true, false, false },
                    { 55, "#AD7E47", "White", "Complete With A Copper Finish, This Bean Tastes Like The Iconic Cocktail Without The Distilled Spirit.", "Moscow Mule", false, "Cocktail Classics® Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/d2511937-9cf5-4f2a-918e-e793fe314a43", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural \\u0026 Artificial Flavors, Citric Acid, Color Added, Yellow 5, Red 40, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 56, "#F6A763", "White", "The Iconic Orange Soda Flavor That Offers A Refreshingly Sweet Escape On A Warm Afternoon.", "Orange Crush", false, "Soda Pop Shoppe® Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/01716593-31a1-42ae-b31e-fb9bee03aefa", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Acacia Gum, Citric Acid, Sodium Lactate, Natural \\u0026 Artificial Flavor, Color Added, Yellow 5 \\u0026 6, Red 40, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Salt.\"]", true, false, false },
                    { 57, "#F79C72", "White", "The Light And Refreshing Combination Of Sweet Orange And Smooth Cream Flavors. Made Possible With Real Orange Puree. No Freezer Required.", "Orange Sherbet", false, "Jelly Belly Official Flavors, Kids Mix Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/4c7cc562-717a-4633-885a-d02c71cd0f4f", "[\"Sugar, Corn Syrup, Modified Food Starch, Orange Juice From Puree, Contains 2% Or Less Of The Following: Citric Acid, Natural And Artificial Flavors, Color Added, Yellow 6 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 58, "#c2864b", "White", "The Perfectly Sweet Flavor Everyone Loves To Wake Up To.", "Original Glazed®", false, "Krispy Kreme® Doughnuts Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/c826460c-e441-48b1-9582-19bfe677265d", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Apple Juice Concentrate, Citric Acid, Cocoa Powder, Natural \\u0026 Artificial Flavors, Color Added, Red 40 Lake, Yellow 5 \\u0026 6 Lake, Blue 1 \\u0026 2 Lake, Red 40, Vegetable And Fruit Juice (Color), Tapioca Dextrin, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Ground Cinnamon, Salt.\"]", true, false, false },
                    { 59, "#c4293e", "White", "Enjoy A Scoop Of Everyone'S Summertime Favorite. Flavored With Real Strawberry Puree For A Fresh Fruit Taste.", "Our Strawberry Blonde®", false, "Cold Stone® Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/54f01786-0de0-4b6b-b2ac-daa2116c7ffb", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Strawberry Puree, Chocolate Liquor, Cocoa Butter, Cocoa Powder, Citric Acid, Ground Cinnamon, Tapioca Dextrin, Natural And Artificial Flavor, Color Added, Red 40 Lake, Yellow 5 \\u0026 6 Lake, Red 40, Blue 1 \\u0026 2 Lake, Blue 1, Yellow 5, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Salt.\"]", true, false, false },
                    { 60, "#EB8435", "White", "The Luscious And Ripe Taste Of Summer. Flavored With Real Peach Puree.", "Peach", false, "Jelly Belly Official Flavors, Kids Mix Flavors, Tropical Mix Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/c75fe96b-333c-420d-869b-6fba2486a914", "[\"Sugar, Corn Syrup, Peach Juice From Puree Concentrate, Modified Food Starch, Contains 2% Or Less Of The Following: Citric Acid, Sodium Citrate, Natural And Artificial Flavor, Color Added, Yellow 5, Yellow 5 Lake, Red 40 Lake, Red 40, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 61, "#EFE393", "White", "Smooth & Creamy With Just A Hint Of Tartness. Flavoured With Real Pear And Pineapple Juices.", "Pineapple Pear Smoothie", false, "", "https://cdn-tp1.mozu.com/9046-m1/cms/files/cb895cb6-1fa4-4327-97fe-0d2c043788d7", "[\"Sugar, Glucose Syrup, Modified Cornstarch, Pear Juice Concentrate, Flavourings, Colours (E100, E171), Acidity Regulator (E330), Glazing Agents (E901, E903, E904), Vegetable Concentrate (Spirulina).\"]", true, false, false },
                    { 62, "#da566a", "White", "All Pink With A Flavor That Is Tart, Tangy, And Lemony.", "Pink Lemonade", false, "Snapple® Mix Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/64c8a21f-56d6-4e15-ada5-73530ca410f4", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Cranberry Puree, Raspberry Puree, Grape Juice Concentrate, Mango Juice Concentrate, Strawberry Juice Concentrate, Kiwi Juice Concentrate, Lemon Puree, Cherry Juice Concentrate, Cranberry Juice Concentrate, Natural Flavors, Citric Acid, Color Added, Grape Concentrate (Color), Turmeric (Color), Apple (Color), Hibiscus (Color), Black Currant (Color), Carrot (Color), Confectioner\\u0027S Glaze, Beeswax, Carnauba Wax.\"]", true, false, false },
                    { 63, "#7EB159", "White", "Smooth & Creamy With Just A Hint Of Tartness. Flavored With Real Pear And Pineapple Juices.", "Piñ1A Colada", false, "Cocktail Classics® Flavors, Tropical Mix Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/653fa358-460d-4883-8aab-5b8ca7d67cf0", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Coconut, Citric Acid, Artificial Flavors, Color Added, Yellow 5, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 64, "#293656", "White", "Sweet And Ripe. Flavoured With Real Plum Juice To Give It A Freshly Picked Taste.", "Plum", false, "Jelly Belly Official Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/6a268368-578b-4118-b664-48df18dfe32b", "[\"Sugar, Corn Syrup, Modified Food Starch, Plum Juice From Concentrate, Contains 2% Or Less Of The Following: Natural And Artificial Flavors, Citric Acid, Sodium Citrate, Color Added, Red 40 Lake, Blue 1 \\u0026 2 Lake, Yellow 6 Lake, Red 40, Yellow 5, Blue 1, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 65, "#DD4B62", "White", "Perfectly Tart And Sweet But Without The Seeds. Flavored With Real Pomegranate Juice.", "Pomegranate", false, "Jelly Belly Official Flavors, Superfruit Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/6cef85fd-9273-4490-bf69-6448d361adc7", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Pomegranate Juice Concentrate, Natural \\u0026 Artificial Flavor, Citric Acid, Sodium Lactate, Sodium Citrate, Color Added, Red 40, Red 40 Lake, Blue 2 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 66, "#972C3F", "White", "The Ultimate In Chic Drinks. Contains The Same Robust And Refreshing Taste As The Classic Cocktail Without Any Of The Alcohol.", "Pomegranate Cosmo", false, "", "https://cdn-tp1.mozu.com/9046-m1/cms/files/7d3a9d0f-b6b0-4a15-8304-b62c2422331e", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Lemon Puree, Lime Juice Concentrate, Peach Puree Concentrate, Pomegranate Juice Concentrate, Strawberry Puree, Coconut, Natural \\u0026 Artificial Flavors, Citric Acid, Sodium Lactate, Sodium Citrate, Color Added, Red 40 Lake, Red 40, Yellow 5 \\u0026 6, Yellow 5 \\u0026 6 Lake, Blue 1, Blue 1 Lake, Grape Skin Extract (Color), Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Tapioca Dextrin.\"]", true, false, false },
                    { 67, "#B11F29", "White", "Enjoy The Fresh-Picked Taste Of Real Raspberry Puree.", "Raspberry", false, "Jelly Belly Official Flavors, Kids Mix Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/0ad95037-f351-452b-b81e-62d07357ec35", "[\"Sugar, Corn Syrup, Modified Food Starch, Raspberry Juice From Puree, Contains 2% Or Less Of The Following: Citric Acid, Artificial Flavor, Color Added, Yellow 6, Red 40 Lake, Red 40, Yellow 5 \\u0026 6 Lake, Blue 2 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 68, "#972C3F", "White", "Crisp, Delicious And Sweet. A Classic Taste That Only Comes From Including Real Apple Juice.", "Red Apple", false, "Jelly Belly Official Flavors, Kids Mix Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/488e9a3f-c4d2-4330-ab8e-bfc41205566a", "[\"Sugar, Corn Syrup, Modified Food Starch, Apple Juice From Concentrate, Contains 2% Or Less Of The Following: Lactic Acid, Citric Acid, Fumaric Acid, Natural And Artificial Flavor, Color Added, Red 40, Yellow 6, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 69, "#FF9BB3", "White", "The Delicious Flavour Of A Glass Of Bubbly That Makes Every Occasion Extra Rosy.", "Rose", false, "Jelly Belly Official Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/0162eacd-3d45-4dae-b44f-262987ec1100", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural \\u0026 Artificial Flavors, Citric Acid, Color Added, Red 40, Red 3, Blue 2 Lake, Red 40 Lake, Maltodextrin, Confectioner\\u0027S Glaze, Beeswax, Carnauba Wax.\"]", true, false, false },
                    { 70, "#E9CCAD", "White", "The Perfect Taste Combination Of Marshmallow, Graham Cracker And Chocolate. No Campfire Required.", "S'Mores", false, "Jelly Belly Official Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/41f3ac58-a03d-4b75-b566-fc1ff9d1b336", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural And Artificial Flavor, Color Added, Vegetable And Fruit Juice (Color), Yellow 5 \\u0026 6 Lake, Blue 2 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Salt.\"]", true, false, false },
                    { 71, "#871922", "White", "We Turned Up The Heat. This Bean'S Fiery Cinnamon Flavor Bites Back With A Delectable Spice That'S Just Right.", "Sizzling Cinnamon", false, "Jelly Belly Official Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/4473a98d-1f4e-4242-aefa-6882472cc211", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Artificial Flavor, Color Added, Red 40 Lake, Yellow 5 Lake, Yellow 5, Red 40, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 72, "#9E222C", "White", "A Sour Twist To One Of Our Most Popular Flavors. Made To Perfection With Real Cherry Juice For A Delicious Fresh-Picked Flavor.", "Sour Cherry", false, "Jelly Belly Official Flavors, Kids Mix Flavors, Sours Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/a0ed8075-fc86-4fe9-ad34-64f70a250b46", "[\"Sugar, Corn Syrup, Modified Food Starch, Cherry Juice From Concentrate, Contains 2% Or Less Of The Following: Citric Acid, Fumaric Acid, Sodium Lactate, Sodium Citrate, Artificial Flavor, Color Added, Red 40 Lake, Turmeric (Color), Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 73, "#3a7295", "White", "So Sour. So Good. Flavorings Of Real Grape Juice Produces A Fresh From The Vine Taste.", "Sour Grape", false, "Sours Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/b03ee77c-fb40-485d-9457-00b685295329", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Citric Acid, Sodium Lactate, Tartaric Acid, Grape Juice Concentrate, Gum Arabic, Natural \\u0026 Artificial Flavor, Vegetable \\u0026 Fruit Juice (Color), Color Added, Red 40, Blue 1, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 74, "#F9D501", "White", "This Bean Packs Extra Pucker Power. Real Lemon Puree' Delivers Its Special Tasty Tartness.", "Sour Lemon", false, "Sours Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/93aa8039-d6f6-4d33-8562-4d250bc60ad3", "[\"Sugar, Corn Syrup, Modified Food Starch, Lemon Juice From Puree, Contains 2% Or Less Of The Following: Citric Acid, Fumaric Acid, Sodium Lactate, Sodium Citrate, Natural Flavor, Color Added, Yellow 5, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 75, "#F99B25", "White", "Pucker Up! Flavored With Real Orange Puree.", "Sour Orange", false, "Sours Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/2c756f64-6b9e-413f-a0b6-54f9f033d4ed", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Apple Juice Concentrate, Grape Juice Concentrate, Lemon Puree, Cherry Juice Concentrate, Orange Puree, Citric Acid, Fumaric Acid, Sodium Citrate, Sodium Lactate, Natural And Artificial Flavors, Color Added, Red 40 Lake, Blue 1 \\u0026 2, Blue 1 \\u0026 2 Lake, Yellow 5 \\u0026 6 Lake, Yellow 5, Turmeric (Color), Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 76, "#E5932E", "White", "Go Ahead. Mix It Up! A Delicious Combo Flavored With Real Strawberry And Banana Purees.", "Strawberry Banana Smoothie", false, "Jelly Belly Official Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/bc9729ec-1e40-4504-b41e-6cd0805fe599", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Pomegranate Juice Concentrate, Peach Puree Concentrate, Banana Puree, Pear Juice Concentrate, Natural And Artificial Flavors, Citric Acid, Sodium Lactate, Sodium Citrate, Color Added, Red 40, Yellow 5 \\u0026 6, Yellow 5 \\u0026 6 Lake, Blue 1 \\u0026 2 Lake, Red 40 Lake, Blue 1, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Salt, Coffee, Tapioca Dextrin.\"]", true, false, false },
                    { 77, "#E798AB", "White", "A Dessert Lover'S Dream! There Is A Reason Why It'S One Of Our Most Popular Flavors. Go Ahead, Treat Yourself.", "Strawberry Cheesecake", false, "Jelly Belly Official Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/ebf62896-5b77-411b-ac14-f28a70555e27", "[\"Sugar, Corn Syrup, Modified Food Starch, Strawberry Juice From Puree, Contains 2% Or Less Of The Following: Citric Acid, Natural And Artificial Flavors, Color Added, Red 40 Lake, Red 40, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 78, "#B95A66", "White", "You'Ll Feel Like You Are Poolside As You Enjoy The Fresh Fruity Taste. We Flavor Each Bean With Real Strawberry Puree.", "Strawberry Daiquiri", false, "Jelly Belly Official Flavors, Cocktail Classics® Flavors, Tropical Mix Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/cce90e1d-7ced-4e18-a05b-734c36287baf", "[\"Sugar, Corn Syrup, Modified Food Starch, Strawberry Juice From Puree, Contains 2% Or Less Of The Following: Citric Acid, Natural And Artificial Flavors, Color Added, Red 40 Lake, Yellow 6, Red 40, Yellow 5 \\u0026 6 Lake, Tapioca Dextrin, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 79, "#E798AB", "White", "Classic Glazed Donut Flavors With The Added Indulgence Of Strawberry Icing.", "Strawberry Iced", false, "Krispy Kreme® Doughnuts Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/af61cc87-48ba-4364-9417-5aa6767dc7c3", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Apple Juice Concentrate, Citric Acid, Cocoa Powder, Natural \\u0026 Artificial Flavors, Color Added, Red 40 Lake, Yellow 5 \\u0026 6 Lake, Blue 1 \\u0026 2 Lake, Red 40, Vegetable And Fruit Juice (Color), Tapioca Dextrin, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Ground Cinnamon, Salt.\"]", true, false, false },
                    { 80, "#C02032", "White", "The Perfect Sweet Topping. Flavoured With Real Strawberry Juice For A Fresh From The Jar Taste.", "Strawberry Jam", false, "Jelly Belly Official Flavors, Kids Mix Flavors", "https://cdn-tp1.mozu.com/9046-11441/cms/files/d3de2b1e-08ce-495e-9b6c-021d9fbc1601", "[\"Sugar, Corn Syrup, Modified Food Starch, Strawberry Juice From Concentrate, Contains 2% Or Less Of The Following: Citric Acid, Artificial Flavors, Color Added, Red 40 Lake, Yellow 6, Red 40, Blue 2 Lake, Yellow 5 \\u0026 6 Lake, Tapioca Dextrin, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 81, "#F9CAC8", "White", "Refreshing And Sweet. Sweet Strawberries, Milk Tea, And Tapioca Pearls Combine For A Delightful Treat.", "Strawberry Milk Tea", false, "Boba Milk Tea Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/0172a080-8a8f-4e2d-802c-d9b596708950", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Citric Acid, Confectioner\\u0027S Glaze, Beeswax, Carnauba Wax, Natural And Artificial Flavors, Salt, Color Added, Red 40, Yellow 6 Lake.\"]", true, false, false },
                    { 82, "#F9D501", "White", "The Perfect Amount Of Pucker. Real Lemon Flavorings Give These Beans Their Tasty Tartness.", "Lemon", false, "Jelly Belly Official Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/93aa8039-d6f6-4d33-8562-4d250bc60ad3", "[\"Sugar, Corn Syrup, Modified Food Starch, Lemon Juice From Puree, 2% Or Less Of The Following: Sodium Lactate, Citric Acid, Natural Flavor, Color Added, Yellow 5, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 83, "#D5DC55", "White", "Sweet, Tart, And Zesty. Flavored With Real Lime Juice For That Fresh-Picked Taste.", "Sunkist® Lime", false, "Jelly Belly Official Flavors, Sunkist® Citrus Mix Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/c12f270c-e207-41a6-9a09-4df3024ea08a", "[\"Sugar, Corn Syrup, Modified Food Starch, Lime Juice From Concentrate, 2% Or Less Of The Following: Sodium Lactate, Citric Acid, Natural Flavor, Color Added, Yellow 5, Blue 1, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 84, "#F99B25", "White", "The Perfect Way To Wake Up Your Taste Buds. Each Flavored With Real Orange Puree For A Sweet Citrus Treat.", "Sunkist® Orange", false, "Jelly Belly Official Flavors, Sunkist® Citrus Mix Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/447dd4bc-23dd-4736-8343-18af394a1d4d", "[\"Sugar, Corn Syrup, Modified Food Starch, Orange Juice From Orange Puree, 2% Or Less Of The Following: Citric Acid, Sodium Lactate, Natural Flavor, Color Added, Yellow 6, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 85, "#E6986B", "White", "It Tastes So Fresh Squeezed Because It'S Flavored With Real Grapefruit Juice.", "Sunkist® Pink Grapefruit", false, "Jelly Belly Official Flavors, Sunkist® Citrus Mix Flavors, Tropical Mix Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/3827a360-1573-4ed7-bf95-b80a4d4f610c", "[\"Sugar, Corn Syrup, Modified Food Starch, Grapefruit Juice From Concentrate, 2% Or Less Of The Following: Citric Acid, Sodium Lactate, Natural Flavor, Color Added, Yellow 5 \\u0026 6 Lake, Red 40, Blue 2 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 86, "#EE734A", "White", "Get Ready For A Sweet And Tart Taste That'S Flavored With Real Tangerine Juice For A Burst Of Flavor.", "Sunkist® Tangerine", false, "Jelly Belly Official Flavors, Sunkist® Citrus Mix Flavors, Tropical Mix Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/7b266567-cd0b-4c08-956a-734395bf7aed", "[\"Sugar, Corn Syrup, Modified Food Starch, Tangerine Juice From Concentrate, 2% Or Less Of The Following: Citric Acid, Sodium Lactate, Natural Flavor, Color Added, Yellow 6, Red 40, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 87, "#CCB7C3", "White", "Take Your Taste Buds On A Journey With This Internationally-Inspired Flavor. The Perfect Blend Of Taro Milk Tea And Tapioca Pearls Make Up This Truly Unique Bean.", "Taro Milk Tea", false, "Boba Milk Tea Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/a0773550-2984-4533-b198-fe2552500342", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Confectioner\\u0027S Glaze, Beeswax, Carnauba Wax, Natural And Artificial Flavors, Salt, Color Added, Red 40, Blue 1Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Confectioner\\u0027S Glaze, Beeswax, Carnauba Wax, Natural And Artificial Flavors, Salt, Color Added, Red 40, Blue 1.\"]", true, false, false },
                    { 88, "#EBAC4A", "White", "Experience The Rich And Aromatic Blend Of Thai Milk Tea And Tapioca Pearls In Every Bite.", "Thai Milk Tea", false, "Boba Milk Tea Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/0c679fc3-78fc-4fac-9ec9-878b8ce6f057", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Confectioner\\u0027S Glaze, Beeswax, Carnauba Wax, Natural And Artificial Flavors, Salt, Color Added, Yellow 6 Lake, Yellow 5.\"]", true, false, false },
                    { 89, "#D8C6AB", "White", "Bring Back Memories Of Sitting Around The Campfire. No Stick Required.", "Toasted Marshmallow", false, "Jelly Belly Official Flavors, Kids Mix Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/bc97e1a9-0e2b-4dc6-8fde-d469d4c05ef3", "[\"Sugar, Corn Syrup, Modified Food Starch, Watermelon Juice From Concentrate, Contains 2% Or Less Of The Following: Artificial Flavor, Citric Acid, Color Added, Red 40 Lake, Yellow 5, Blue 1, Red 40, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 90, "#CCA42C", "White", "So Delicious, You'Ll Want To Eat A Bunch. Flavored With Real Banana Puree.", "Top Banana", false, "Jelly Belly Official Flavors, Tropical Mix Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/5e604eb2-d339-4166-ac6b-24a66dd984e7", "[\"Sugar, Corn Syrup, Modified Food Starch, Watermelon Juice From Concentrate, Contains 2% Or Less Of The Following: Artificial Flavor, Citric Acid, Color Added, Red 40 Lake, Yellow 5, Blue 1, Red 40, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 91, "#EFB3CB", "White", "This Beloved Bean Is A Unique And Delicious Combination Of Fruity Flavors.", "Tutti-Fruitti", false, "Jelly Belly Official Flavors, Kids Mix Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/e7fafb0e-9dc4-4c9c-93bc-485d306ac31d", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural \\u0026 Artificial Flavor, Color Added, Red 40 Lake, Yellow 5 Lake, Red 40, Blue 1 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 92, "#AD1E34", "White", "Our Most Popular Flavor Is Created With Real Cherry Juice To Seem Like It Came Right From A Tree.", "Very Cherry", false, "Jelly Belly Official Flavors, Kids Mix Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/d9051ec6-2970-4c88-8227-7f7e2fe1c76d", "[\"Sugar, Corn Syrup, Modified Food Starch, Cherry Juice From Concentrate, Contains 2% Or Less Of The Following: Citric Acid, Artificial Flavor, Color Added, Red 40, Red 40 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 93, "#264D16", "White", "A Sweet Sensation That'S Green On The Outside And Red On The Inside. Flavored With Real Watermelon Juice To Be Delicious Inside And Out.", "Watermelon", false, "Jelly Belly Official Flavors, Kids Mix Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/559e929f-9e78-4f9b-a7e3-178efc226ba9", "[\"Sugar, Corn Syrup, Modified Food Starch, Watermelon Juice From Concentrate, Contains 2% Or Less Of The Following: Artificial Flavor, Citric Acid, Color Added, Red 40 Lake, Yellow 5, Blue 1, Red 40, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 94, "#655277", "White", "Deep And Fruity Flavor That Tastes Like It Came Right From The Bush. Flavored With Real Blackberry Puree.", "Wild Blackberry", false, "Jelly Belly Official Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/8567bee8-e66d-4217-96a5-7d9e931916d5", "[\"Sugar, Corn Syrup, Modified Food Starch, Blackberry Juice From Puree, Contains 2% Or Less Of The Following: Citric Acid, Natural \\u0026 Artificial Flavor, Sodium Lactate, Sodium Citrate, Color Added, Blue 2 Lake, Red 40 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 95, "#FFE92D", "White", "The Classic Candy That Is Sweet With Just A Hint Of Sour. Flavoured With Real Lemon Puree.", "Lemon Drop", false, "Jelly Belly Official Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/0946ef12-a22e-4f5f-b82b-704024380c59", "[\"Sugar, Corn Syrup, Modified Food Starch, Lemon Juice From Lemon Puree, Contains 2% Or Less Of The Following: Citric Acid, Natural And Artificial Flavors, Color Added, Yellow 5, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 96, "#D5DC55", "White", "The Citrus Match Made In Heaven And Made With Real Lime Juice Concentrate.", "Lemon Lime", false, "Jelly Belly Official Flavors, Kids Mix Flavors, Tropical Mix Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/e1300522-2a05-429c-82b8-3c4f46754c5c", "[\"Sugar, Corn Syrup, Modified Food Starch, Lime Juice From Concentrate, Lemon Juice From Lemon Puree, Contains 2% Or Less Of The Following: Citric Acid, Sodium Lactate, Natural Flavors, Color Added, Yellow 5, Blue 1, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 97, "#F1C720", "White", "A Tart And Sweet Taste You'Ll Swear Was Topped With Meringue. Flavored With Real Lemon Puree.", "Lemon Meringue Pie", false, "Jelly Belly Official Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/1896002b-1acf-44de-b540-1fb48c780d0e", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Lemon Puree, Citric Acid, Natural \\u0026 Artificial Flavor, Color Added, Vegetable And Fruit Juice (Color), Yellow 5 \\u0026 6 Lake, Blue 2 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Salt.\"]", true, false, false },
                    { 98, "#022F34", "White", "Indulge In The Unmistakable Flavor That Balances Sweet With Spice. Our Traditional Taste Comes From Real Black Licorice.", "Licorice", false, "Jelly Belly Official Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/d06c24dd-24c3-4059-ab3f-bcc80f78df86", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural And Artificial Flavors, Color Added, Blue 2 Lake, Yellow 6 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 99, "#", "White", "The Sweet And Fruity Flavors Of Cherry And Passion Fruit Are Blended To Perfection In This Unique Smoothie Flavor.", "Cherry Passion Fruit Smoothie", false, "Jelly Belly Official Flavors", "", "[\"Sugar, Glucose Syrup, Modified Cornstarch, Passion Fruit Juice Concentrate, Flavourings, Acidity Regulator (E330), Colours (E100, E171), Glazing Agents (E901, E903, E904), Fruit And Vegetable Concentrates (Purple Carrot, Carrot, Black Currant).\"]", true, false, false },
                    { 100, "#03698B", "White", "Enjoy The Taste Of A Fresh-Picked Raspberry In A Beautiful Blue Hue.", "Blue Raspberry", false, "Jelly Belly Official Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/95aa0f7d-e369-4438-984c-f6dd1300664d", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Citric Acid, Natural And Artificial Flavor, Color Added, Sodium Citrate, Blue 1 Lake, Blue 1, Confectioner\\u0027S Glaze, Beeswax, Carnauba Wax.\"]", true, false, false },
                    { 101, "#EEE7D8", "White", "Party All The Time With This Unique Ice Cream Flavor.", "Birthday Cake Remix®", false, "Cold Stone® Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/76c3b0f3-ef88-4cee-9cf9-d75eb51622aa", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural \\u0026 Artificial Flavors, Tapioca Dextrin, Color Added, Yellow 5 \\u0026 6 Lake, Red 40 Lake, Red 40, Blue 1 \\u0026 2 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Salt.\"]", true, false, false },
                    { 102, "#EEE7D8", "White", "Make Everyday Taste Like Your Birthday.", "Birthday Cake", false, "Jelly Belly Official Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/76c3b0f3-ef88-4cee-9cf9-d75eb51622aa", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural \\u0026 Artificial Flavors, Tapioca Dextrin, Color Added, Yellow 5 \\u0026 6 Lake, Red 40 Lake, Red 40, Blue 1 \\u0026 2 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze, Salt.\"]", true, false, false },
                    { 103, "#3C812A", "White", "Fresh From The Tree Sweetness With A Sour Twist. Flavored With Real Apple Juice.", "Sour Apple", false, "Jelly Belly Official Flavors, Kids Mix Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/c2ec3236-f34b-4685-a50b-1f013144dc52", "[\"Sugar, Corn Syrup, Modified Food Starch, Apple Juice From Concentrate, Contains 2% Or Less Of The Following: Citric Acid, Fumaric Acid, Sodium Lactate, Sodium Citrate, Artificial Flavor, Color Added, Yellow 5, Yellow 5 Lake, Blue 1, Blue 1 Lake, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, false },
                    { 104, "#C02032", "White", "", "Sugar-Free Cherry", false, "Sugar-Free Assorted Flavors", "https://cdn-tp1.mozu.com/9046-11441/cms/files/dom-sugar-free-cherry-shadow-new.webp", "[\"\"]", true, false, true },
                    { 105, "#DD4B62", "White", "", "Sugar-Free Sizzling Cinnamon", false, "Sugar-Free Assorted Flavors", "https://cdn-tp1.mozu.com/9046-11441/cms/files/dom-sugar-free-sizzling-cinnamon-shadow.webp", "[\"\"]", true, false, true },
                    { 106, "#2B9B39", "White", "", "Sugar-Free Green Apple", false, "Sugar-Free Assorted Flavors", "https://cdn-tp1.mozu.com/9046-11441/cms/files/dom-sugar-free-green-apple-shadow.webp", "[\"\"]", true, false, true },
                    { 107, "#c8cf65", "White", "", "Sugar-Free Juicy Pear", false, "Sugar-Free Assorted Flavors", "https://cdn-tp1.mozu.com/9046-11441/cms/files/dom-sugar-free-juicy-pear-shadow-new.webp", "[\"\"]", true, false, true },
                    { 108, "#e9d443", "White", "", "Sugar-Free Lemon", false, "Sugar-Free Assorted Flavors", "https://cdn-tp1.mozu.com/9046-11441/cms/files/dom-sugar-free-lemon-shadow-new.webp", "[\"\"]", true, false, true },
                    { 109, "#022F34", "White", "", "Sugar-Free Licorice", false, "Sugar-Free Assorted Flavors", "https://cdn-tp1.mozu.com/9046-11441/cms/files/dom-sugar-free-licorice-shadow.webp", "[\"\"]", true, false, true },
                    { 110, "#FADF50", "White", "", "Sugar-Free Pineapple", false, "Sugar-Free Assorted Flavors", "https://cdn-tp1.mozu.com/9046-11441/cms/files/dom-sugar-free-pineapple-shadow.webp", "[\"\"]", true, false, true },
                    { 111, "#FDE96C", "White", "", "Sugar-Free Buttered Popcorn", false, "Sugar-Free Assorted Flavors", "https://cdn-tp1.mozu.com/9046-11441/cms/files/dom-sugar-free-buttered-popcorn-shadow.webp", "[\"\"]", true, false, true },
                    { 112, "#EFB3CB", "White", "", "Sugar-Free Strawberry", false, "Sugar-Free Assorted Flavors", "https://cdn-tp1.mozu.com/9046-11441/cms/files/dom-sugar-free-strawberry-shadow.webp", "[\"\"]", true, false, true },
                    { 113, "#f99b24", "White", "", "Sugar-Free Tangerine", false, "Sugar-Free Assorted Flavors", "https://cdn-tp1.mozu.com/9046-11441/cms/files/dom-sugar-free-tangerine-shadow-new.webp", "[\"\"]", true, false, true },
                    { 114, "#085881", "White", "A Combination Of Fruits To Give Your Taste Buds The Royal Treatment.", "Jewel Berry Blue", false, "Sugar-Free Assorted Flavors", "https://cdn-tp1.mozu.com/9046-m1/cms/files/1ba610ca-1701-47ec-a982-7e1bde8e79bd", "[\"Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Citric Acid, Natural \\u0026 Artificial Flavor, Color Added, Blue 1, Beeswax, Carnauba Wax, Confectioner\\u0027S Glaze.\"]", true, false, true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Beans",
                keyColumn: "BeanId",
                keyValue: 114);
        }
    }
}
