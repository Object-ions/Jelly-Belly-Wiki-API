using JellyBellyWikiApi.Models;
using Microsoft.EntityFrameworkCore;

namespace JellyBellyWikiApi.DataSeeding
{
  public static class RecipeSeeder
  {
    public static void Seed(ModelBuilder builder)
    {
      builder.Entity<Recipe>().HasData(
        new Recipe
        {
          RecipeId = 1,
          Name = "BAKED VALENTINE'S DAY DONUTS",
          Description = "Your special someone will L-O-V-E this delicious treat topped with their favorites from the Jelly Belly® Valentine Mix!",
          PrepTime = "5 minutes",
          CookTime = "10 minutes",
          TotalTime = "35 minutes",
          MakingAmount = "6 Donuts",
          Img = "https://cdn-tp1.mozu.com/9046-m1/cms/files/fdb32456-5901-4745-8297-1d92035ab382",
          Ingredients = new[] {"3/4 cup all-purpose flour, 1/2 cup granulated sugar, 3/4 tsp baking powder, 1/4 tsp baking soda, 1/4 tsp salt, 1/3 cup buttermilk, 1 egg, 1/4 cup melted unsalted butter, 1/2 tsp vanilla extract"},
          Additions1 = new[] {"GLAZE, 2 cups icing sugar, 1/4 cup milk, approx., 1 tsp vanilla extract, 1/2 cup Jelly Belly Valentine Mix:, Bubble Gum, Coconut, Cotton Candy, Strawberry Cheesecake and Very Cherry"},
          Additions2 = new[] {""},
          Additions3 = new[] {""},
          Directions = new[] {"Preheat oven to 375°F. Grease one standard donut pan well with butter or cooking spray., In a large bowl, sift together flour, sugar, baking powder, baking soda and salt., In separate bowl, whisk together buttermilk, egg, melted butter and vanilla., Stir the dry ingredients into the liquid ingredients until combined., Spoon the batter into the pan, filling each mold three-quarters full., Bake for 9 to 10 minutes or until tops spring back when pressed and a toothpick inserted into the donuts comes out clean., Let cool in pan for 5 minutes. Remove from pan and cool on rack. Reinforce donut holes with handle of wooden spoon, if necessary., Glaze: In a small bowl, whisk together icing sugar and milk, adding more milk a teaspoon at a time until icing is thin enough for donuts to be dipped into., Dip donuts into glaze, turning to coat top completely. Return to rack to set. Dip a second time to create a solid white finish. Arrange Jelly Belly® jelly beans on top, sprinkling or placing as you wish."},
          Tips = new[] {"Tint icing sugar with red food coloring for a red or pink finish."},
        },
        new Recipe
        {
          RecipeId = 2,
          Name = "JELLY BELLY HUGS AND KISSES BROWNIES",
          Description = "Your favorite brownie recipe or mix is transformed into a love-inspired treat. Decorate with Jelly Belly beans and send X's and O's to someone special.",
          PrepTime = "",
          CookTime = "",
          TotalTime = "",
          MakingAmount = "12 brownies",
          Img = "https://cdn-tp1.mozu.com/9046-m1/cms/files/8e657035-f26b-4661-80ca-d90368548c07",
          Ingredients = new[] { "1 box (18.75 ounces) brownie mix, 1 can (16 ounces) milk chocolate frosting, 1 cup Jelly Belly Valentine's Mix (That's Jewel Bubble Gum, Jewel Cream Soda and Jewel Very Cherry)" },
          Additions1 = new[] {""},
          Additions2 = new[] {""},
          Additions3 = new[] {""},
          Directions = new[] { "Preheat oven to 325°F. Line a 9 inch square baking pan with foil and coat with vegetable cooking spray., Prepare brownie mix according to package directions. Spread the batter into the prepared pan and make smooth. Bake until a toothpick inserted in center comes out clean, 38 to 43 minutes. Transfer to a wire rack and cool completely., Invert the brownie from the pan and remove the foil. Spread the top of the brownie with the chocolate frosting. Refrigerate frosted brownie until firm, about 1 hour., Cut brownie into 2 inch squares, making sure to clean the knife after each cut. Or use a 2 1/2 inch heart shaped cookie cutter and to cut out heart shapes, as close together as possible, making sure to clean the cutter after every heart., Use the red Jelly Belly beans to make X's and the white Jelly Belly beans to make O's on top of the square brownies. Cover the heart brownies with the pink Jelly Belly beans." },
          Tips = new[] {""},
        },
        new Recipe
        {
          RecipeId = 3,
          Name = "JELLY BELLY LOVE BUGS",
          Description = "These cute cupcakes are anything but pests! Express your love with these inspiring desserts, and charm your way into hearts everywhere.",
          PrepTime = "",
          CookTime = "",
          TotalTime = "",
          MakingAmount = "24 cupcakes",
          Img = "https://cdn-tp1.mozu.com/9046-m1/cms/files/ea0613fb-a4a9-4334-92dd-d691cadb6428",
          Ingredients = new[] { "1 box (16.5 ounces) strawberry supreme cake mix, 3 large eggs, 1 cup buttermilk, 1/3 cup vegetable oil, 1 cup Very Cherry Jelly Belly® jelly beans, 24 round butter cookies, 2 1/2 inch round, 1 bag (10 ounces) pink candy melting wafers, 1 tablespoon vegetable shortening, 1 can (16 ounces) chocolate frosting, 24 mini chocolate sandwich cookies, 1 tube (4.25 ounces each) red, white and black decorating icing, 1/2 cup dark cocoa candy melts, 48 Licorice Pastels (your choice of color, shown in black)" },
          Additions1 = new[] {""},
          Additions2 = new[] {""},
          Additions3 = new[] {""},
          Directions = new[] { "Preheat the oven to 350°F. Place paper cupcake liners in 24 cupcake cups. Prepare the cake mix according to package directions substituting the buttermilk for the water called for on the box. Divide the batter between the prepared cupcake liners, about 2/3 full. Bake until a toothpick inserted in center comes out clean, about 15 to 19 minutes. Transfer to a wire rack and cool completely., Use a serrated knife to cut the cookies in half crosswise to make the wings. Cut the jelly beans in half crosswise with a small paring knife to make the spots for the wings. Place the pink melting wafers and the vegetable shortening in a microwaveable bowl. Microwave, stirring frequently, until smooth, about 1 minute. Working on 1 cookie at a time, grasp the pointed end of a cookie half and dip it in the melted candy to coat. (Don't worry if this leaves a fingerprint in one end of the coated cookie.) Allow the candy to drip off and scrape the bottom of the cookie against the bowl to remove any excess. Transfer the coated cookie to a sheet of wax paper. Repeat with the other cookie half, grasping it by the same end as the first half. While the candy is still wet, add 4 cut jelly bean pieces, cut side down, to each wing as the spots. Repeat with the remaining cookies, candy and jelly beans. Refrigerate the wings for a few minutes to harden the candy., Spread the top of a cupcake with some chocolate frosting and make smooth. Place a pair of cookie wings on top of the cupcake, placing them so the ends with the fingerprints are touching. Repeat with the remaining cupcakes and wings., Place the mini sandwich cookies on a sheet of wax paper. Melt the dark cocoa candy melts in the microwave until smooth, about 30 seconds. Spoon the candy into a ziplock bag. Snip a small corner from the bag. Pipe 2 dots of melted candy near one edge of a cookie. Add a black licorice pastel to each dot of melted candy to make the antennae. Repeat with the remaining cookies and licorice pastels. Refrigerate until set, about 5 minutes., Pipe a dot of the cocoa candy melts on top of the wings where they meet (the fingerprints) and attach the cookie head. Pipe eyes with the white and black icing and a red mouth." },
          Tips = new[] {""},
        },
        new Recipe
        {
          RecipeId = 4,
          Name = "JELLY BELLY PETIT FOURS",
          Description = "Small cakes packed with delicious flavor! Make these for birthday parties, brunches, showers, and other celebrations. Decorate with your favorite Jelly Belly jelly beans on top!",
          PrepTime = "",
          CookTime = "",
          TotalTime = "",
          MakingAmount = "80 pieces",
          Img = "https://cdn-tp1.mozu.com/9046-m1/cms/files/e3b09054-b486-43dc-b782-d2390438acca",
          Ingredients = new[] { "1 box (16.5 ounces) French vanilla cake mix, 3 large eggs, 1 cup buttermilk, 1/3 cup vegetable oil, Neon pink food coloring, 1 can (16 ounces) plus 1 cup vanilla frosting, 1/2 cup low sugar strawberry jam, strained, 1 cup Jelly Belly Jewel Valentine Mix (That's Jewel Bubble Gum, Jewel Cream Soda and Jewel Very Cherry), Pink mini paper liners" },
          Additions1 = new[] {""},
          Additions2 = new[] {""},
          Additions3 = new[] {""},
          Directions = new[] { "Preheat oven to 350°F. Line a jelly roll pan (11 1/2 by 17 1/2 inches) with wax paper. Coat the pan and wax paper with vegetable cooking spray. Prepare the cake mix according to package directions, substituting the buttermilk for the water in the recipe. Add 6 drops of the neon pink food coloring to the batter and stir until blended. Pour the batter into the prepared pan and smooth top. Bake until a toothpick inserted in center comes out clean, 17 to 20 minutes. Transfer to a wire rack to cool 10 minutes. Invert the cake onto the rack and cool completely., Tint 1/2 cup of the vanilla frosting pink with the food coloring and spoon it into a ziplock bag. Spoon 1 cup of the vanilla frosting into a glass measuring cup and cover with plastic wrap to prevent drying., Cut the cake in half crosswise to make two 8 3/4 by 11 1/2-inch rectangles. Line a cookie sheet with wax paper. Transfer one cake layer to the wax paper. Spread a thin layer of the strained strawberry jam on top of the cake. Spread the remaining vanilla frosting on top of the jam. Place the other cake layer on top, pressing down to secure. Place a sheet of wax paper on top of the cake. Place another cookie sheet on top of the wax paper covered cake. Place several filled food cans evenly spaced on top of the cookie sheet to help weigh down the cake and press the layers together. Transfer the assembly to the refrigerator to set, at least 3 hours or overnight., Remove the cookie sheet, wax paper and cans from the pressed cake. Place the cake on a wire rack set over a wax paper lined cookie sheet. Heat the vanilla frosting in the microwave, stirring every 5 seconds until the texture of slightly whipped cream, about 20 seconds. Pour the frosting over the pressed cake to completely cover the top. Return to the refrigerator for 15 minutes for the frosting to set., Trim edges to make even. Cut the cake crosswise into 1 inch wide strips making sure to clean the knife after each cut. Cut each strip crosswise into 1 inch pieces, keeping the knife clean after each cut. Transfer each 1-inch square piece to a paper liner. Snip a very small corner from the bag with the pink frosting. Using a back and forth motion, pipe zig zag lines on top of each petit four. Arrange 1 to 3 Jelly Belly beans on top of each piece." },
          Tips = new[] {""},
        },
        new Recipe
        {
          RecipeId = 5,
          Name = "EASTER BUNNY COOKIES",
          Description = "Gather the family and hop to making Easter memories when everyone joins in to decorate Easter Bunny Cookies. Any seasonally shaped cookie will work here – chicks, eggs, carrots, lambs, etc. Have fun with our Easter Bunny Cookies. They're the perfect Easter treat to share with your family. There's no doubt your kids will love them!",
          PrepTime = "",
          CookTime = "",
          TotalTime = "",
          MakingAmount = "8 cookies",
          Img = "https://cdn-tp1.mozu.com/9046-m1/cms/files/0502f6e2-1175-482b-bb02-b33786a75702",
          Ingredients = new[] { "Royal Icing, Rose pink and lemon or golden-yellow gel paste food coloring, 8 sugar cookie cutouts, White sanding sugar, Kids Mix Jelly Belly jelly beans" },
          Additions1 = new[] {""},
          Additions2 = new[] {""},
          Additions3 = new[] {""},
          Directions = new[] { "Mix together some royal icing with pink food coloring until desired shade is reached. Transfer to a small squirt bottle with a thick tip. Leaving a ¼-inch border, outline bunny portion of a cookie and draw a jagged edge where the bunny meets the egg. Draw several zigzags across entire surface of outlined area. Use a spatula to spread evenly, and then shake cookie gently to settle icing. If there are any air bubbles, use a toothpick to pop them., Using a sharp paring knife, cut one blue Jelly Belly jelly bean in half crosswise. Place the halves, cut side down, on cookie to resemble eyes. Add a pink one to resemble a nose. While the icing is still wet, transfer cookie to a paper plate and sprinkle bunny generously with sanding sugar. Working over the paper plate, shake off any excess sugar and reserve for remaining cookies. Using a toothpick, remove any remaining grains of sugar along the edge where bunny meets egg. Let dry at least 15 minutes before proceeding., Mix together some royal icing with yellow food coloring until desired shade is reached. Transfer to a small squirt bottle with a thick tip. Leaving a ¼-inch border, outline egg portion. Draw several zigzags across entire surface of outlined area. Use a spatula to spread evenly, and then shake cookie gently to settle icing. If there are any air bubbles, use a toothpick to pop them., Following shape of egg, use tweezers to add Jelly Belly jelly beans closely together to fill, forming a mosaic pattern. You'll want to work fairly quickly, as the icing will begin to dry. Repeat process with remaining cookies. Let cookies dry completely before packaging, about 8 hours." },
          Tips = new[] {""},
        },
        new Recipe
        {
          RecipeId = 6,
          Name = "JELLY BELLY BUNNY CUPCAKES",
          Description = "Dazzle your friends and family with these charming Bunny Cupcakes!",
          PrepTime = "",
          CookTime = "",
          TotalTime = "",
          MakingAmount = "24 Cupcakes",
          Img = "https://cdn-tp1.mozu.com/9046-m1/cms/files/5f52ad3f-bb2b-4ad7-ba59-4d72bfbfd859",
          Ingredients = new[] { "1 box (16.5 ounces) vanilla cake mix, 3 large eggs, 1 cup buttermilk, 1/3 cup vegetable oil, 1/4 tsp coconut extract, 1 can (16 ounces) vanilla frosting, 1 1/4 cups desiccated coconut or finely chopped shredded coconut, 1 1/2 cup Jewel Spring Mix Jelly Belly® jelly beans, 1/2 cup white chocolate melting wafers, 3 tbsps each bright pink, light pink, orange, green and light blue decorating sugar, 48 marshmallows, 24 thin pretzel sticks, 1 tube (4.25 ounces) chocolate decorating icing" },
          Additions1 = new[] {""},
          Additions2 = new[] {""},
          Additions3 = new[] {""},
          Directions = new[] { "Preheat the oven to 350°F. Line 24 muffin cups with white paper liners. Prepare cake mix according to package directions, substituting the buttermilk for the water in the recipe. Divide the batter between the prepared cups, about 2/3 full, and bake until golden about 15 to 18 minutes. Transfer to a wire rack and cool completely. Refrigerate cupcakes until ready to decorate., To make the bunny ears, cut 1/4 inch from each short end of a marshmallow and dip the cut sides of the end pieces into the desired sugar color to coat. (When you cut, discard the small remaining piece in the center of each marshmallow.) Repeat with 23 marshmallows and the sugars to make 24 pairs of colored bunny ears. For the head, insert a pretzel stick into a rounded side of a whole marshmallow., Line a cookie sheet with wax paper. Arrange 2 like colored sugared marshmallow ears, lengthwise, side by side, and the head marshmallow, on its side below the ears (The pretzel stick will be at the bottom, on the opposite side from the ears)., Place the white candy melts in a recloseable bag. Microwave the bag, stopping to massage every 5 seconds, until smooth, about 1 minute. Snip a small corner from the bag. Pipe two dots of melted candy on the top side of the marshmallow head to attach the sugar coated mini marshmallow ears. For the nose, pipe a small dot of candy to the front side of the marshmallow head and attach a Jelly Belly bean that matches the ear color. For the tail, pipe a dot of melted candy on the wax paper and arrange 4 Jelly Belly beans of the same color together on the dot. Refrigerate until set, about 5 minutes., Place the coconut in a medium bowl. Spread the top of a chilled cupcake with a mound of vanilla frosting and make smooth. Roll the top of the cupcake in the coconut to coat. Repeat with the remaining cupcakes., To assemble, insert the pretzel end of the head close to one edge of the frosted cupcake. Pipe eyes with the chocolate icing. Add the tail with a dot of frosting to secure. Press 4 Jelly Belly beans into the side of the cupcake as the feet using matching colored beans. Repeat with the remaining cupcakes and candies." },
          Tips = new[] {""},
        },
        new Recipe
        {
          RecipeId = 7,
          Name = "JELLY BELLY EASTER PETIT FOURS",
          Description = "Use egg-shaped cookie cutters to create these festive Easter egg petit fours.",
          PrepTime = "20 minutes plus 2 hours freezing time",
          CookTime = "15 minutes",
          TotalTime = "2 hours, 40 minutes",
          MakingAmount = "16 Petit fours",
          Img = "https://cdn-tp1.mozu.com/9046-m1/cms/files/0458d976-32df-4ef9-8c82-1e10873aea9f",
          Ingredients = new[] { "3 eggs, 1 cup granulated sugar, 1 tsp vanilla, 3/4 cup all-purpose flour, sifted, 1 tsp baking powder, 1/4 tsp salt, 1/2 cup seedless raspberry jam, 16 oz. chopped white chocolate, 2 tbsp coconut oil, Food coloring (pastel colors, such as rose, violet and teal), 1 cup Jelly Belly® Spring Mix jelly beans" },
          Additions1 = new[] {""},
          Additions2 = new[] {""},
          Additions3 = new[] {""},
          Directions = new[] { "Preheat oven to 375°F. Line 15- x 10-inch baking pan with parchment paper. Spray with cooking spray., Using electric mixer, beat eggs on high speed for 2 to 3 minutes or until thickened and pale yellow; gradually beat in sugar. Add 1/3 cup water and vanilla; beat on low speed for 1 minute., Gradually add flour, baking powder and salt, beating until batter is smooth, scraping down sides of bowl., Spread batter evenly in prepared baking pan. Bake for 12 to 15 minutes or until toothpick inserted into center comes out clean. Let cool in pan for 10 minutes. Transfer to rack; let cool completely., Cut cake in half to create two thin layers. Place one layer on waxed paper-lined baking sheet and spread jam evenly over top; place second layer on top, trimming edges if necessary. Freeze for 2 hours., Using egg-shaped cutter, cut cake into 16 egg shapes. Reserve scraps for another use (such as snacking)., Melt white chocolate and coconut oil in heatproof bowl set over saucepan of barely simmering water. Remove from heat., Arrange petit fours, 2 inches apart, on rack set over parchment paper-lined baking sheet., Divide melted chocolate mixture into three bowls; tint with desired colors of food coloring. Pour each colored chocolate mixture over 5 or 6 petit fours, shaking tray to ensure coating covers petit fours entirely. Refrigerate until firm and set. If necessary, repeating this step can create a smoother layer., Decorate by pressing Jelly Belly® Spring Mix jelly beans into tops of cakes in desired pattern." },
          Tips = new[] {"If desired, use other fillings, such as red currant jelly, prepared lemon curd or buttercream icing between layers., If you don't want to press the Jelly Belly beans into the top of the petit fours, use royal icing to secure them. You can even decorate the sides this way."}
        },
        new Recipe
        {
          RecipeId = 8,
          Name = "CHERRY BLOSSOM CAKE",
          Description = "Celebrate spring with this gorgeous cake, the perfect finishing touch for parties, bridal showers and other festive occasions.",
          PrepTime = "",
          CookTime = "",
          TotalTime = "",
          MakingAmount = "16 servings",
          Img = "https://cdn-tp1.mozu.com/9046-m1/cms/files/de71768b-90e4-45c7-a568-a8aea708bfb2",
          Ingredients = new[] { "1 box (16.5 ounces) strawberry supreme cake mix, 3 large eggs, 1 cup buttermilk, 1/3 cup vegetable oil, 1 can (16 ounces) + 1 cup vanilla frosting, Neon/bright blue food coloring, 1 cup milk chocolate frosting, 3/4 cup Jewel Bubble Gum Jelly Belly jelly beans, 1/4 cup Jewel Cream Soda Jelly Belly jelly beans" },
          Additions1 = new[] {""},
          Additions2 = new[] {""},
          Additions3 = new[] {""},
          Directions = new[] { "Preheat oven to 350°F. Grease and line 9 X 13-inch cake pan with parchment paper. Prepare cake mix according to package directions, substituting buttermilk for water. Pour batter into prepared pan. Bake 24 to 27 minutes or until golden and toothpick inserted in center comes out clean. Transfer to wire rack and cool 10 minutes. Invert and cool completely. When cool, refrigerate cake for at least 1 hour., Spoon 1/4 cup of the vanilla frosting and the chocolate frosting into separate pastry or recloseable bags. Press out the excess air from the bags and set aside. Tint remaining vanilla frosting light blue with food coloring., Place chilled cake on foil-covered piece of cardboard cut to fit, and transfer to a wire rack over a sheet pan. Spread very thin layer of light blue frosting over top and sides of cake to make smooth. Spoon remaining light blue frosting into a microwaveable glass measuring cup. Microwave frosting, stirring every 5 seconds until frosting is the texture of slightly whipped cream, about 20 to 30 seconds. Pour frosting over cake to cover completely, using small spatula to spread frosting evenly on sides of the cake, to cover. Transfer cake to refrigerator to set, about 30 minutes., Snip a small (scant 1/4 inch) corner from bag with the milk chocolate frosting. Place chilled cake onto serving platter. Pipe overlapping lines of milk chocolate frosting, starting from one corner diagonally across cake as main branch. (It may be helpful to use a toothpick to lightly score the branch into the blue frosting first and then pipe the chocolate frosting following the score marks.) Pipe more lines of frosting to thicken the main branch. Next pipe shorter lines of frosting for smaller branches. (Follow your instincts to create a graceful branching pattern.) For flowers, arrange 5 Jewel Bubble Gum Jelly Belly beans so that the short ends are touching in clusters all over the branches on the cake. Using small knife, cut Jewel Cream Soda Jelly Belly beans in half crosswise. Snip small corner from bag with vanilla frosting. Pipe dots of vanilla frosting in center of flower clusters and press half jelly bean, cut side down, into frosting." },
          Tips = new[] {""},
        },
        new Recipe
        {
          RecipeId = 9,
          Name = "JELLY BELLY FLOWER COOKIE POPS",
          Description = "Let your kitchen blossom with flower cookies-on-a-stick. Collect a dozen and make a bouquet centerpiece in a terra cotta pot. These colorful cookies are fun and easy to make, and are topped with some of your favorite Jelly Belly Confections like Jelly Belly Chewy Fish, and of course lots of Jelly Belly jelly beans! Flower Cookie Pops are perfect for spring brunch, Mother’s Day, bridal showers, baby showers and get-well gifts.",
          PrepTime = "",
          CookTime = "",
          TotalTime = "",
          MakingAmount = "",
          Img = "",
          Ingredients = new[] { "1 roll of refrigerated sugar cookie dough, ¾ cup all-purpose flour, 1 ½ cups confectioners' sugar, 1 tablespoon egg white powder, 1 to 2 tablespoons water, Assorted Jelly Belly jelly beans, Green Jelly Belly Chewy Fish" },
          Additions1 = new[] { "Parchment paper, Flower-shaped cookie cutter, Lollipop sticks, Resealable bag, Styrofoam, Terra cotta pot or serving bowl" },
          Additions2 = new[] {""},
          Additions3 = new[] {""},
          Directions = new[] { "Preheat oven to 350°F. Line 2 cookie sheets with parchment paper. Knead the sugar cookie dough with the flour on a work surface until smooth. Divide the dough in half., Roll out half on a lightly floured surface to a scant ¼ inch thickness. Use 2 to 3 inch flower shape cookie cutters and cut out as many shapes as possible. Transfer the shapes to the prepared pans on either long edge. Insert a lollipop stick into the dough about half way into the cut out., Bake until cookies are golden about 10 to 12 minutes. Transfer to a wire rack and cool completely. Repeat with the remaining dough and lollipop sticks., Combine the powdered sugar and egg white powder in a medium bowl. Add 1 tablespoon water and mix well. Add more water, 1 teaspoon at a time, until mixture is thick. Spoon the mixture into a re-sealable bag., Snip a very small corner from the bag, about 1/8 inch. Pipe dots of frosting on cookies and attach the Jelly Belly beans. For the center of the cookies, cut some of the Jelly Belly beans in half crosswise and add, cut side down. Continue with the remaining Jelly Belly beans and cookies. Let cookies dry at least 2 hours., Place a piece of Styrofoam into a clean planter or serving bowl. Fill planter with green Jelly Belly beans. Insert the cookie pops into the planter, pushing the sticks into the Styrofoam to secure at different heights. Add a few green Jelly Belly Chewy Fish as the leaves." },
          Tips = new[] {""},
        },
      );
    }
  }
}