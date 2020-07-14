# Building an App with Dotnet Core and React
## Technologies
#### Server
- ASP.NET Core 3.1.x
- Entity Framework Core 3.1.x
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
|\_\_Project.sln

## NuGet packages

- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Sqlite
- third

## Dotnet CLI (Window command):

- dotnet new sln
- dotnet new classlib -n project_name
- dotnet new webapi -n project_name
- dotnet sln add project_name
- dotnet add reference ...
  - Domain: none
  - Application: reference to Domain, Persistence
  - Persistence: reference to Domain
  - API: reference to Application
- dotnet ef migrations add Initial -p .\Persistence\ -s .\API\
