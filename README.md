# Jelly Belly Wiki API

### By Moses Atia Poston.

## Description

This API provides detailed information about Jelly Belly beans, including facts, milestones, recipes, and bean details. It is designed to be a comprehensive resource for Jelly Belly enthusiasts and researchers.

<!-- This project is a part of a bigger project that includes the UI and the webscrape -->
<!-- link for 2 other repos -->
<!-- links for live site -->

## Features

- Detailed information on Jelly Belly beans
- Historical milestones related to Jelly Belly
- Recipes involving Jelly Belly beans
- Fun facts about Jelly Belly

## Technologies Used

- C#
- ASP.NET Core
- Entity Framework Core
- MySQL
- LINQ
- Postman
- Swagger

## Setup/Installation Requirements

### Required Technology

1. Follow the instructions on this <a href="https://old.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql">page</a> for installing and configuring MySQL.
2. Installing dotnet-ef:

   > ```bash
   > $ dotnet tool install --global dotnet-ef --version 6.0.0
   > ```

3. Install Postman
   (Optional) [Download and install Postman](https://www.postman.com/downloads/).

#### Cloning the Repo:

1. Open Terminal.
2. Change your directory to where you would want the cloned directory.
3. Input the following command into your terminal:
   > ```bash
   > $ git clone https://github.com/Object-ions/Jelly-Belly-Wiki-API
   > ```

#### Set up a Connection String to Database

4. Using the terminal, navigate to the production directory- `JellyBellyWikiApi.Solution` and create a new file called `appsettings.json`

5. Add the following code snippet while also replacing the following values with your own values as shown below the code snippet:

- [YOUR-USERNAME-HERE] with your username
- [YOUR-PASSWORD-HERE] with your password
- [YOUR-DATABASE-NAME-HERE] with the name of your database

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DATABASE-NAME-HERE];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```

#### Create the Database

6. In your terminal, under the project's production directory `JellyBellyWikiApi.Solution`, run this command to create the database.

> ```bash
> $ dotnet ef database update
> ```

However, if update does not work, run this command in your terminal:

> ```bash
> $ dotnet ef migrations add Initial
> $ dotnet ef database update
> ```

## Launching the API

In the command line in the project's production directory `JellyBellyWikiApi.Solution`, enter the command `dotnet watch run`. This will compile and execute the application.

> ```bash
> $ dotnet watch run
> ```

## Using API

To access the API endpoints, utilize tools like a browser, Postman, or Swagger.

(If working with Swagger, go to either https://localhost:5001/swagger/index.html or http://localhost:5000/swagger/index.html.)

#### Pagination Info

The API supports pagination for listing endpoints. Pagination allows you to retrieve a subset of records, making it efficient for large datasets.

- pageIndex: Indicates the current page number. Starts at 1.
- pageSize: Defines the number of records per page.

Example: To retrieve the second page of beans with 10 beans per page, use:
`GET /api/beans?pageIndex=1&pageSize=10`

If pagination is not defined in the request, default values will be used.

## Endpoints

#### HTTP Request Structure

"Beans"

| Request Type |       Path        | Description                          | Parameters                                                                                                                                             |
| :----------: | :---------------: | ------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------ |
|     GET      |   /api/{beans}    | Retrieves a list of beans.           | groupName, flavorName, colorGroup, backgroundColor, imageUrl, ingredients, glutenFree, sugarFree, seasonal, kosher, pageIndex, pageSize (all optional) |
|     GET      | /api/{beans}/{id} | Retrieves a specific bean by its ID. | None                                                                                                                                                   |

"Facts"

| Request Type |       Path        | Description                          | Parameters                                |
| :----------: | :---------------: | ------------------------------------ | ----------------------------------------- |
|     GET      |   /api/{facts}    | Retrieves a list of facts.           | title, pageIndex, pageSize (all optional) |
|     GET      | /api/{facts}/{id} | Retrieves a specific fact by its ID. | None                                      |

"Recipes"

| Request Type |        Path         | Description                            | Parameters                               |
| :----------: | :-----------------: | -------------------------------------- | ---------------------------------------- |
|     GET      |   /api/{recipes}    | Retrieves a list of recipes.           | name, pageIndex, pageSize (all optional) |
|     GET      | /api/{recipes}/{id} | Retrieves a specific recipe by its ID. | None                                     |

"MileStones"

| Request Type |          Path          | Description                               | Parameters                               |
| :----------: | :--------------------: | ----------------------------------------- | ---------------------------------------- |
|     GET      |   /api/{mileStones}    | Retrieves a list of mileStones.           | year, pageIndex, pageSize (all optional) |
|     GET      | /api/{mileStones}/{id} | Retrieves a specific mileStone by its ID. | None                                     |

## Examples

#### Example Queries

The following query will return beans with ID of 6 to 10 from the dataset (page number 2, with 5 beans on each page).

```
'https://localhost:5001/api/Beans?pageIndex=2&pageSize=5'
```

#### Sample JSON Response from the above query

```json
{
  "totalCount": 114,
  "pageSize": 5,
  "currentPage": 2,
  "totalPages": 23,
  "items": [
    {
      "beanId": 6,
      "groupName": ["Superfruit Flavors"],
      "groupNameSerialized": "Superfruit Flavors",
      "flavorName": "Barbados Cherry",
      "description": "A Sweet Cherry Flavor With Just A Hint Of Tartness.",
      "colorGroup": "lightpink",
      "backgroundColor": "#E798AB",
      "imageUrl": "https://cdn-tp1.mozu.com/9046-m1/cms/files/168244d0-b3ba-4725-a2d9-5083b362d10a",
      "ingredients": [
        "Cane Sugar, Tapioca Syrup, Modified Food Starch, Sour Cherry Juice From Concentrate, Blueberry Juice From Blueberry Puree, Pomegranate Juice From Concentrate, Acai Puree, Natural Flavors, Acerola (Barbados) Cherry Juice, Cranberry Puree, Citric Acid, Apple (Color), Confectioner'S Glaze, Beeswax, Grape Concentrate (Color), Carrot (Color), Carnauba Wax, Black Currant (Color), Hibiscus (Color), Color Added."
      ],
      "glutenFree": false,
      "sugarFree": false,
      "seasonal": false,
      "kosher": true
    },
    {
      "beanId": 7,
      "groupName": ["Jelly Belly Official Flavors"],
      "groupNameSerialized": "Jelly Belly Official Flavors",
      "flavorName": "Blueberry",
      "description": "Enjoy The Taste Of Fresh-Picked Blueberries. Deliciously Flavored With Real Blueberry Puree.",
      "colorGroup": "steelblue",
      "backgroundColor": "#3A7195",
      "imageUrl": "https://cdn-tp1.mozu.com/9046-m1/cms/files/a8f085b5-b4ff-4aca-8650-43ad54c80fe4",
      "ingredients": [
        "Sugar, Corn Syrup, Modified Food Starch, Blueberry Juice From Puree, Contains 2% Or Less Of The Following: Citric Acid, Natural & Artificial Flavor, Color Added, Blue 1 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze."
      ],
      "glutenFree": false,
      "sugarFree": false,
      "seasonal": false,
      "kosher": true
    },
    {
      "beanId": 8,
      "groupName": ["Jelly Belly Official Flavors", "Kids Mix Flavors"],
      "groupNameSerialized": "Jelly Belly Official Flavors, Kids Mix Flavors",
      "flavorName": "Bubble Gum",
      "description": "This Bean Has Everything But The Bubble! Taking A Trip Down Memory Lane Has Never Tasted So Good.",
      "colorGroup": "lightpink",
      "backgroundColor": "#E3ACBD",
      "imageUrl": "https://cdn-tp1.mozu.com/9046-m1/cms/files/51474130-73e9-40b7-a8ba-c9eac7be7de4",
      "ingredients": [
        "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Artificial Flavor, Color Added, Red 40 Lake, Red 40, Yellow 5 Lake, Beeswax, Carnauba Wax, Confectioner'S Glaze."
      ],
      "glutenFree": false,
      "sugarFree": false,
      "seasonal": false,
      "kosher": true
    },
    {
      "beanId": 9,
      "groupName": ["Jelly Belly Official Flavors", "Kids Mix Flavors"],
      "groupNameSerialized": "Jelly Belly Official Flavors, Kids Mix Flavors",
      "flavorName": "Buttered Popcorn",
      "description": "Now You Can Enjoy Buttery Perfection Without Having To Go To The Movies.",
      "colorGroup": "gold",
      "backgroundColor": "#F6D334",
      "imageUrl": "https://cdn-tp1.mozu.com/9046-m1/cms/files/61207309-fffb-443a-b735-b9a5a6374c8d",
      "ingredients": [
        "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Natural And Artificial Flavors, Color Added, Yellow 5, Beeswax, Carnauba Wax, Confectioner'S Glaze, Salt."
      ],
      "glutenFree": false,
      "sugarFree": false,
      "seasonal": false,
      "kosher": true
    },
    {
      "beanId": 10,
      "groupName": ["Jelly Belly Official Flavors", "Tropical Mix Flavors"],
      "groupNameSerialized": "Jelly Belly Official Flavors, Tropical Mix Flavors",
      "flavorName": "Cantaloupe",
      "description": "This Sweet Summertime Favorite Is Always In Season.",
      "colorGroup": "goldenrod",
      "backgroundColor": "#FAA538",
      "imageUrl": "https://cdn-tp1.mozu.com/9046-m1/cms/files/45d0972c-e554-4374-8b21-ac50ff450d3e",
      "ingredients": [
        "Sugar, Corn Syrup, Modified Food Starch, Cantaloupe Juice From Cantaloupe Powder, Contains 2% Or Less Of The Following: Natural And Artificial Flavors, Color Added, Yellow 6 Lake, Yellow 6, Beeswax, Carnauba Wax, Confectioner'S Glaze."
      ],
      "glutenFree": false,
      "sugarFree": false,
      "seasonal": false,
      "kosher": true
    }
  ]
}
```

The following query will return facts with ID of 1 and 2 from the dataset (page number 1, with 2 facts on each page).

```
'https://localhost:5001/api/Facts?pageIndex=1&pageSize=2'
```

#### Sample JSON Response from the above query

```json
{
  "totalCount": 99,
  "pageSize": 2,
  "currentPage": 1,
  "totalPages": 50,
  "items": [
    {
      "factId": 1,
      "title": "Popularity of Flavors",
      "description": "Very Cherry has been the most popular Jelly Belly flavor for many years, only briefly surpassed by Buttered Popcorn in 1998."
    },
    {
      "factId": 2,
      "title": "Caloric Content",
      "description": "Each bean contains only 4 calories, meaning that a handful of 25 beans amounts to 100 calories."
    }
  ]
}
```

## Known Bugs

- No known bugs.

## License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2023 Moshe Atia Poston.

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

- If you detect any bug in the program, please reach out to me at [moshikoatia@gmail.com](mailto:moshikoatia@gmail.com).
