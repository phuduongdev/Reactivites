# Building an App with Dotnet Core and React
## Technologies
#### Server
- ASP.NET Core 3.1.x
- Entity Framework Core 3.1.x
- MediatR

#### Client
- axios
- Semantic UI React

## Clean Architecture

                 API
                  |
                  v
              Application
             /    |
            /     v
           /    Domain
          /     ^
         v     /
    Persistence

## Project Structure

Project
|**Domain : library, contains the bussiness entities
|**Application : library, process the bussiness logics
|**Persistence : library, access to the database
|**API : Web Api App, recive HTTP requests and respond to them
|**client-app: using create-react-app, semantic ui, axios
|\_\_Project.sln

## NuGet packages

- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Sqlite
- 