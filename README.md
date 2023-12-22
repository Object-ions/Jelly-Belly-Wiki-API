# Jelly Belly Wiki API

### By Moses Atia Poston.

## Description

This API provides detailed information about Jelly Belly beans, including facts, milestones, recipes, and bean details. It is designed to be a comprehensive resource for Jelly Belly enthusiasts and researchers.

This project is divided into three main parts, each with its own repository:

1. **Web Scraper Repository (GitHub Repo)**: This repository contains scripts and supporting files for data collection using Python, BeautifulSoup, and ChromeDriver. It details the methodology used for creatively gathering data step by step until it was ready to be seeded into the C# API.
2. **API Repository (GitHub Repo)**: The heart of the project, this repository holds the C# and EF Core .Net API with MySql migrations. It serves as the core database of the project. Detailed instructions on how to use this API are available in the repository, similar to the API Documentation provided in the UI.
3. **UI Repository (GitHub Repo)**: The User Interface makes full use of the API's database, showcasing one approach to design by utilizing all the endpoints and their various options.

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

1. **MySQL Installation and Configuration**:

   - Follow the instructions on [this page](https://dev.mysql.com/doc/mysql-installation-excerpt/5.7/en/) for installing and configuring MySQL if you don't already have it installed.

2. **Installing dotnet-ef**:

   - Run the following command in your terminal:
     ```
     $ dotnet tool install --global dotnet-ef --version 6.0.0
     ```

3. **Install Postman (Optional)**:

   - Download and install [Postman](https://www.postman.com/downloads/). This is recommended if you wish to conduct API testing and data retrieval independently, without immediate application integration.

4. **Cloning the Repo**:
   - Open your Terminal.
   - Change your directory to where you want the cloned directory.
   - Input the following command:
     ```
     $ git clone https://github.com/Object-ions/Jelly-Belly-Wiki-API
     ```

### Set up a Connection String to Database

1. **Create `appsettings.json`**:

   - Using the terminal, navigate to the `JellyBellyWikiApi.Solution` production directory.
   - Create a new file named `appsettings.json`.

2. **Configure `appsettings.json`**:

   - Add the following code snippet to the `appsettings.json` file. Be sure to replace `[YOUR-USERNAME-HERE]`, `[YOUR-PASSWORD-HERE]`, and `[YOUR-DATABASE-NAME-HERE]` with your actual MySQL username, password, and database name:

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
         "DefaultConnection": "Server=localhost;Port=3306;
         database=[YOUR-DATABASE-NAME-HERE];
         uid=[YOUR-USERNAME-HERE];
         pwd=[YOUR-PASSWORD-HERE];"
       }
     }
     ```

### Create the Database

6. **Create Database**:
   - In your terminal, navigate to the project's production directory `JellyBellyWikiApi.Solution`.
   - Run the following command to create the database:
     ```
     $ dotnet ef database update
     ```
   - If the update command does not work, run these commands instead:
     ```
     $ dotnet ef migrations add Initial
     $ dotnet ef database update
     ```

### Launching the API

7. **Start the API**:

   - In the command line, under the directory `JellyBellyWikiApi.Solution`, enter the command:
     ```
     $ dotnet watch run
     ```
   - This will compile and execute the application and open 'Swagger' on `localhost:5001`.

   - If 'Swagger' does not open automatically, you can access it using this link in your browser:
     [Swagger UI](https://localhost:5001/swagger/index.html)

### Using API

To access the API endpoints and see the data, you can utilize tools like a browser, Postman, or Swagger. This allows you to interact with the API and explore its capabilities.

For guidance on integrating this API into your application, refer to the section "How to Utilize This API" for detailed instructions and examples.

## Endpoints

### List of Endpoints:

- Beans
- Facts
- Recipes
- Combinations
- History

### HTTP Request Structure

#### "Beans"

| Endpoint          | Request Type | Path              | Description                                           | Parameters                                                                                      |
| ----------------- | ------------ | ----------------- | ----------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| 1. Get Beans      | GET          | `/api/beans`      | Retrieves a paginated list of beans.                  | groupName, flavorName, colorGroup, glutenFree, sugarFree, seasonal, kosher, pageIndex, pageSize |
| 2. Get Bean by ID | GET          | `/api/beans/{id}` | Retrieves detailed information about a specific bean. | id                                                                                              |

### Parameter Details

- `groupName` (string, optional): Filters beans by group name. To see a list of group names, refer to the file: 'list_of_properties_to_query.md'.
- `flavorName` (string, optional): Filters beans by flavor name. To see a list of flavor names, refer to the file: 'list_of_properties_to_query.md'.
- `colorGroup` (string, optional): Filters beans by color group. To see a list of color groups, refer to the file: 'list_of_properties_to_query.md'.
- `glutenFree` (boolean, optional): Filters beans by gluten-free status.
- `sugarFree` (boolean, optional): Filters beans by sugar-free status.
- `seasonal` (boolean, optional): Filters beans by seasonal availability.
- `kosher` (boolean, optional): Filters beans by kosher status.
- `pageIndex` (int, default=1): Specifies the page index for pagination.
- `pageSize` (int, default=10): Specifies the number of records per page for pagination.

### Additional Information

- **Response Format**: JSON
- **Authentication**: No authentication required for these endpoints.
- **Rate Limit**: Not specified (consider providing details if applicable).
- **Error Codes**: Standard HTTP status codes (e.g., 404 for Not Found).

### Example Request

- To retrieve information about the bean with ID 1:

```
https://localhost:5001/api/Beans/1
```

\*\* For more example requests, check out the 'Query' section.

## API Endpoints with Query Options and Examples

To find detailed information about the parameters such as `groupName`, `flavorName`, `colorGroup`, and more, please refer to the "Endpoints" section of the documentation. There, you can find links to tables that provide comprehensive attribute lists.

### Beans

**Base URL**: `https://localhost:5001/api/beans`

- `groupName`: [https://localhost:5001/api/beans?groupName=Jelly Belly Official Flavors](https://localhost:5001/api/beans?groupName=Jelly Belly Official Flavors)
- `flavorName`: [https://localhost:5001/api/beans?flavorName=7Up](https://localhost:5001/api/beans?flavorName=7Up)
- `colorGroup`: [https://localhost:5001/api/beans?colorGroup=khaki](https://localhost:5001/api/beans?colorGroup=khaki)
- `glutenFree`: [https://localhost:5001/api/beans?glutenFree=true](https://localhost:5001/api/beans?glutenFree=true)
- `sugarFree`: [https://localhost:5001/api/beans?sugarFree=false](https://localhost:5001/api/beans?sugarFree=false)
- `seasonal`: [https://localhost:5001/api/beans?seasonal=true](https://localhost:5001/api/beans?seasonal=true)
- `kosher`: [https://localhost:5001/api/beans?kosher=true](https://localhost:5001/api/beans?kosher=true)
- `pageIndex` and `pageSize`: [https://localhost:5001/api/beans?pageIndex=1&pageSize=10](https://localhost:5001/api/beans?pageIndex=1&pageSize=10)

### Facts

**Base URL**: `https://localhost:5001/api/facts`

- `title`: [https://localhost:5001/api/facts?title=Popularity of Flavors](https://localhost:5001/api/facts?title=Popularity of Flavors)

### Combinations

**Base URL**: `https://localhost:5001/api/combinations`

- `name`: [https://localhost:5001/api/combinations?name=Cherry Turnover](https://localhost:5001/api/combinations?name=Cherry Turnover)

### Recipes

**Base URL**: `https://localhost:5001/api/recipes`

- `name`: [https://localhost:5001/api/recipes?name=OMBRÉ CAKE](https://localhost:5001/api/recipes?name=OMBRÉ CAKE)

### Milestones

**Base URL**: `https://localhost:5001/api/mileStones`

- `year`: [https://localhost:5001/api/mileStones?year=1869](https://localhost:5001/api/mileStones?year=1869)

**Note**: When searching with phrases that include spaces, the URL will automatically replace spaces with "%20". You can search with spaces between words.

## Request URL and Server Response

Click on an option to see the requested URL with the response body:

- [Response for query on Beans by flavorName](#response-for-query-on-beans-by-flavorname)
- [Response for query on Beans by ID](#response-for-query-on-beans-by-id)
- [Response for query on Beans by paging](#response-for-query-on-beans-by-paging)

### Response for Query on Beans by FlavorName

The following query will return beans with the flavor name "7UP":

```
https://localhost:5001/api/Beans?flavorName=7up
```

#### Server Response

- **Code**: `200`
- **Response Body**:

  ```json
  {
    "totalCount": 1,
    "pageSize": 10,
    "currentPage": 1,
    "totalPages": 1,
    "items": [
      {
        "beanId": 1,
        "groupName": [
          "Jelly Belly Official Flavors",
          "Soda Pop Shoppe® Flavors"
        ],
        "groupNameSerialized": "Jelly Belly Official Flavors, Soda Pop Shoppe® Flavors",
        "flavorName": "7Up",
        "description": "The Refreshing And Crisp Flavor Of Lemon Lime Soda.",
        "colorGroup": "khaki",
        "backgroundColor": "#CEDC91",
        "imageUrl": "https://cdn-tp1.mozu.com/9046-m1/cms/files/ab692677-5471-4863-91a8-659363ae4cc4",
        "ingredients": [
          "Sugar, Corn Syrup, Modified Food Starch, Contains 2% Or Less Of The Following: Citric Acid, Sodium Lactate, Natural & Artificial Flavor, Color Added, Yellow 5, Blue 1, Beeswax, Carnauba Wax, Confectioner'S Glaze"
        ],
        "glutenFree": false,
        "sugarFree": false,
        "seasonal": false,
        "kosher": true
      }
    ]
  }
  ```

## Pagination Info

The API supports pagination for listing endpoints. Pagination is an efficient way to handle large datasets by retrieving a subset of records at a time.

### Pagination Parameters

- `pageIndex`: Indicates the current page number. It starts at 1.
- `pageSize`: Defines the number of records per page.

### Example Usage

To retrieve the second page of beans with 10 beans per page, use the following request:

```
 https://localhost:5001/api/beans?pageIndex=2&pageSize=10
```

**Note**: If pagination parameters are not defined in the request, default values will be applied.

## Known Bugs

### Description:

Currently, there is a notable bug in the API concerning the structure of arrays. The expected behavior is to receive an array of strings. However, the API is returning an array containing a single element (at index 0) where the items are concatenated into a single string, separated by commas (,).

### Temporary Workaround:

In the user interface (UI), we have implemented a JavaScript-based solution to address this issue. This script manipulates the data received from the API to transform it back into the intended format, which is an array of individual strings. This approach ensures that the data is displayed correctly in the UI, despite the existing bug in the API.

## Ongoing Development

Please note that this project is not in its final form. Future updates will include enhanced descriptions, text improvements, and refined styling to improve user experience and interface aesthetics. Additionally, significant portions of the codebase are slated for refactoring to optimize performance and maintainability.

This project is very much a work in progress, and regular updates are planned to address these aspects. Your patience and understanding are greatly appreciated as these improvements are made.

## Copyright and Data Accuracy Disclaimer

### Content Origin

Please be aware that all data and information presented in this application, including the UI and the database, are derived from the official Jelly Belly website. This project does not claim originality of the content and acknowledges that all information is borrowed from publicly available sources.

### Disclaimer

While every effort has been made to ensure the accuracy of the information, there may be instances of errors, typos, or inaccuracies. Therefore, this resource should not be solely relied upon, especially for health-related decisions. I do not assume responsibility for the content's accuracy.

### Consumer Advice

Before consuming any Jelly Belly products, it is strongly advised to consult the official Jelly Belly website or product packaging to verify ingredients, calorie content, and other nutritional information. This step is crucial for those with dietary restrictions or allergies.

## License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2023 Moshe Atia Poston.

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

- If you detect any bug in the program, please reach out to me at [moshikoatia@gmail.com](mailto:moshikoatia@gmail.com).
