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
